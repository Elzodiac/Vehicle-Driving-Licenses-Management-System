using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmInternationalLicenseApplication : Form
    {
        private clsUser _User;
        private clsInternationalLicense _IntLicense;
        private clsPeople _Person;
        private string _NationalNo;
        private int _PersonID, _DriverID;
        public frmInternationalLicenseApplication(clsUser User)
        {
            _User = User;
            InitializeComponent();
            this.Height += 180;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSerLicense_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbLicenseIDSearch.Text))
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

            if(Lic.IsActive != true || DateTime.Now >= Lic.ExpDate)
            {
                MessageBox.Show("License with ID = " + LicenseID + " is not Active",
                    "Invalid license", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if(clsInternationalLicense.IsInterLicenseExists(LicenseID))
            {
                MessageBox.Show("License with ID = " + LicenseID + " is alredy has a International License",
                    "Pre-existing license", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if(Lic.LicenseClass < 3)
            {
                MessageBox.Show("License with ID = " + LicenseID + " It is a type of license that cannot have a International license.",
                    "License type is not eligible", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }


            clsLDLApp LDLApp = clsLDLApp.FindByAppID(Lic.ApplicationID);

            clsLDLApp LDL_App = clsLDLApp.Findvw(LDLApp.ID);
            lbClass.Text = LDL_App.DrivingClass;
            lbName.Text = LDL_App.FullName;
            int ApplicationID = clsLDLApp.Find(LDLApp.ID).AppID;
            clsLicense License = clsLicense.FindByAppID(ApplicationID);
            lbLicenseID.Text = License.LicenseID.ToString();
            lbLocalLicenseID.Text = License.LicenseID.ToString();
            _DriverID = License.DriverID;

            int PersonID = clsApplications.Find(ApplicationID).AppPersonID;
            clsPeople Person = clsPeople.Find(PersonID);
            lbNationalNo.Text = Person.NationalNo;
            _NationalNo = Person.NationalNo;
            _PersonID = Person.ID;
            _Person = Person;
            lbGendor.Text = Person.Gendor == 1 ? "Male" : "Female";
            lbDateOfBirth.Text = Person.DateOfBirth.ToString("d");

            lbIssueDate.Text = License.IssueDate.ToString("d");
            lbIssueReason.Text = License.IssueReason.ToString();
            lbNotes.Text = License.Notes.ToString();
            lbIsActive.Text = License.IsActive == true ? "Yes" : "No";
            lbdriverID.Text = License.DriverID.ToString();
            lbExpDate.Text = License.ExpDate.ToString("d");
            lbIsDetained.Text = "No";


            if (File.Exists(Person.ImagePath))
            {
                pbPersonPic.Image = Image.FromFile(Person.ImagePath);
            }

            btnIssue.Enabled = true;
            llbShowLicHistory.Enabled = true;

        }

        private void tbLicenseIDSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true; // stop writting
            }
        }

        private void frmInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            lbAppDate.Text = DateTime.Now.ToString("d");
            lbIssueDate2.Text = DateTime.Now.ToString("d");
            lbExpDate2.Text = DateTime.Now.AddYears(10).ToString("d");
            lbCreByUser.Text = _User.Username;
        }

        private void llbShowLicHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmLicensesHistory = new frmLicensesHistory(_NationalNo);
            frmLicensesHistory.ShowDialog();
        }

        private void llbShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmShowIntLicense = new frmShowInternationalLicense(_Person, _IntLicense);
            frmShowIntLicense.ShowDialog();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to issue the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                clsApplications Application = new clsApplications();

                Application.AppPersonID = _PersonID;
                Application.AppDate = DateTime.Now;
                Application.AppTypeID = 6;
                Application.AppStatusID = 2;
                Application.LastStatusDate = DateTime.Now;
                Application.PaidFees = 50;
                Application.CreaByUserID = _User.ID;

                bool IsAppSave = Application.Save();

                clsInternationalLicense InterLicense = new clsInternationalLicense();

                InterLicense.ApplicationID = Application.AppID;
                InterLicense.DriverID = _DriverID;
                InterLicense.IssuedUsingLocalLicenseID = int.Parse(lbLicenseID.Text);
                InterLicense.IssueDate = DateTime.Now;
                InterLicense.ExpirationDate = DateTime.Now;
                InterLicense.IsActive = true;
                InterLicense.CreatedByUserID = _User.ID;

                if (IsAppSave && InterLicense.Save())
                {
                    MessageBox.Show("international license issued successfully with ID = " + InterLicense.InternationalLicenseID,
                    "License Issued", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    gbFilter.Enabled = false;
                    btnIssue.Enabled = false;
                    llbShowLicenseInfo.Enabled = true;

                    _IntLicense = InterLicense;
                }

            }
        }
    }
}
