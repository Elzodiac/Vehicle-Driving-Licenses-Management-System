using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmRenewLicenseApplication : Form
    {
        private clsUser _User;
        private clsLicense _License;
        private clsLicense _NewLicense;
        private string _NationalNo;
        private int _PersonID;
        public frmRenewLicenseApplication(clsUser User)
        {
            _User = User;
            InitializeComponent();
            this.Height += 200;
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
            // 
            if (DateTime.Now <= Lic.ExpDate)
            {
                MessageBox.Show("Selected License is not yet Expiared, it will expir on: " + Lic.ExpDate,
                    "Invalid license", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (Lic.IsActive == false)
            {
                MessageBox.Show("this license is inactive.",
                    "Invalid license", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            clsLicense License = clsLicense.FindByAppID(Lic.ApplicationID); // LicenseID
            lbLicenseID.Text = License.LicenseID.ToString();
            lbOldLicenseID.Text = License.LicenseID.ToString();
            string DrivingClass = clsLicenseClass.Find(License.LicenseClass).LicClassName;
            lbClass.Text = DrivingClass;
            lbLicenseFees.Text = License.PaidFees.ToString();
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


            btnRenew.Enabled = true;
            llbShowLicHistory.Enabled = true;
            decimal total = Convert.ToDecimal(lbAppFees.Text) + Convert.ToDecimal(lbLicenseFees.Text);
            lbTotalFees.Text = total.ToString();

            
        }

        private void tbLicenseIDSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true; // stop writting
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llbShowLicHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmLicensesHistory = new frmLicensesHistory(_NationalNo);
            frmLicensesHistory.ShowDialog();
        }

        private void llbShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmShowLicense = new frmShowDriverLicense(_NewLicense);
            frmShowLicense.ShowDialog();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to renew this license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
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

                clsLicense License = new clsLicense();

                License.ApplicationID = Application.AppID;
                License.DriverID = _License.DriverID;
                License.LicenseClass = _License.LicenseClass;
                License.IssueDate = DateTime.Now;
                License.ExpDate = (License.LicenseClass == 1 || License.LicenseClass == 2) ? DateTime.Now.AddYears(5) : DateTime.Now.AddYears(10);
                License.Notes = tbNotes.Text;
                clsLicenseClass LicenseClass = clsLicenseClass.Find(License.LicenseClass);
                License.PaidFees = LicenseClass.ClassFees;
                License.IsActive = true;
                License.IssueReason = 2;
                License.CreatedByUserID = _User.ID;
                _License.IsActive = false;
                


                if (IsAppSave && License.Save() && _License.Save())
                {
                    MessageBox.Show("License renewed successfully with ID = " + License.LicenseID,
                    "License Renewed", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    gbFilter.Enabled = false;
                    btnRenew.Enabled = false;
                    llbShowLicenseInfo.Enabled = true;
                    lbILAppID.Text = License.ApplicationID.ToString();
                    lbRenLicenseID.Text = License.LicenseID.ToString();
                    clsLicense License2 = clsLicense.Find(License.LicenseID);
                    _NewLicense = License2;
                }
            }
        }

        private void frmRenewLicenseApplication_Load(object sender, EventArgs e)
        {
            lbAppDate.Text = DateTime.Now.ToString("d");
            lbIssueDate2.Text = DateTime.Now.ToString("d");
            lbExpDate2.Text = DateTime.Now.AddYears(10).ToString("d");
            lbCreByUser.Text = _User.Username;
        }
    }
}
