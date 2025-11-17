using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmReplacementForDamagedOrLostLicense : Form
    {
        private clsUser _User;
        private string _NationalNo;
        private int _PersonID;
        private clsLicense _License;
        public frmReplacementForDamagedOrLostLicense(clsUser User)
        {
            _User = User;
            InitializeComponent();
            this.Height += 120;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReplacementForDamagedOrLostLicense_Load(object sender, EventArgs e)
        {
            lbAppDate.Text = DateTime.Now.ToString("d");
            lbCreByUser.Text = _User.Username;
        }

        private void tbLicenseIDSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true; // stop writting
            }
        }

        private void llbShowLicHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmLicensesHistory = new frmLicensesHistory(_NationalNo);
            frmLicensesHistory.ShowDialog();
        }

        private void llbShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmShowLicense = new frmShowDriverLicense(_License);
            frmShowLicense.ShowDialog();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to issue a replacement for the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                clsApplications Application = new clsApplications();

                Application.AppPersonID = _PersonID;
                Application.AppDate = DateTime.Now;
                Application.AppTypeID = rbDamagedLicense.Checked ? 4 : 3;
                Application.AppStatusID = 2;
                Application.LastStatusDate = DateTime.Now;
                Application.PaidFees = rbDamagedLicense.Checked ? 5 : 10;
                Application.CreaByUserID = _User.ID;

                bool IsAppSave = Application.Save();

                clsLicense License = new clsLicense();

                License.ApplicationID = Application.AppID;
                License.DriverID = _License.DriverID;
                License.LicenseClass = _License.LicenseClass;
                License.IssueDate = _License.IssueDate;
                License.ExpDate = _License.ExpDate;
                clsLicenseClass LicenseClass = clsLicenseClass.Find(License.LicenseClass);
                License.PaidFees = LicenseClass.ClassFees;
                License.IsActive = true;
                License.IssueReason = (byte)(rbDamagedLicense.Checked ? 4 : 3);
                License.CreatedByUserID = _User.ID;
                _License.IsActive = false;



                if (IsAppSave && License.Save() && _License.Save())
                {
                    MessageBox.Show("License replaced successfully with ID = " + License.LicenseID,
                    "License replaced", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    gbFilter.Enabled = false;
                    btnIssue.Enabled = false;
                    llbShowLicenseInfo.Enabled = true;
                    lbLRAppID.Text = License.ApplicationID.ToString();
                    lbRepLicenseID.Text = License.LicenseID.ToString();
                    clsLicense License2 = clsLicense.Find(License.LicenseID);
                    _License = License2;
                }
            }
        }

        private void btnSerLicense_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLicenseIDSearch.Text))
            {
                MessageBox.Show("Please enter License ID.",
                    "Invalid entry", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int LicenseID = int.Parse(tbLicenseIDSearch.Text);
            clsLicense Lic = clsLicense.Find(LicenseID);

            if (Lic == null)
            {
                MessageBox.Show("License with ID = " + LicenseID + " is not found",
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (DateTime.Now >= Lic.ExpDate)
            {
                MessageBox.Show("Selected License is Expiared, you need to renew this license",
                    "Invalid license", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (Lic.IsActive != true)
            {
                MessageBox.Show("License with ID = " + LicenseID + " is not Active",
                    "Invalid license", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            clsLicense License = clsLicense.FindByAppID(Lic.ApplicationID); // LicenseID
            lbLicenseID.Text = License.LicenseID.ToString();
            lbOldLocalLicenseID.Text = License.LicenseID.ToString();
            string DrivingClass = clsLicenseClass.Find(License.LicenseClass).LicClassName;
            lbClass.Text = DrivingClass;
            _License = License;

            int PersonID = clsApplications.Find(Lic.ApplicationID).AppPersonID;
            clsPeople Person = clsPeople.Find(PersonID);
            lbNationalNo.Text = Person.NationalNo;
            _NationalNo = Person.NationalNo;
            _PersonID = Person.ID;
            lbGendor.Text = Person.Gendor == 1 ? "Male" : "Female";
            lbDateOfBirth.Text = Person.DateOfBirth.ToString("d");
            lbName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;

            lbIssueDate.Text = License.IssueDate.ToString("d");
            lbIssueReason.Text = License.IssueReason == 1 ? "First Time"
                : License.IssueReason == 2 ? "Renew"
                : License.IssueReason == 3 ? "Rep For Lost"
                : License.IssueReason == 4 ? "Rep For Damaged" : "";
            lbNotes.Text = License.Notes.ToString();
            lbIsActive.Text = License.IsActive == true ? "Yes" : "No";
            lbdriverID.Text = License.DriverID.ToString();
            lbExpDate.Text = License.ExpDate.ToString("d");
            bool IsDetined = clsDetainedLicense.isDetainLicenseByLicIDExists(License.LicenseID);
            lbIsDetained.Text = IsDetined ? "Yes" : "No";


            if (File.Exists(Person.ImagePath))
            {
                pbPersonPic.Image = Image.FromFile(Person.ImagePath);
            }


            btnIssue.Enabled = true;
            llbShowLicHistory.Enabled = true;
        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            lbFees.Text = 5.ToString();
            lbTitle.Text = "Replacement For Damaged License";
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            lbFees.Text = 10.ToString();
            lbTitle.Text = "Replacement For Lost License";
        }

    }
}
