using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmReleaseDetainedLicense : Form
    {
        private clsUser _User;
        private string _NationalNo;
        private int _PersonID, _ConMenuStrPersonID = -1;
        private clsLicense _License;
        private clsDetainedLicense _DetainedLicense;
        public frmReleaseDetainedLicense(clsUser User)
        {
            _User = User;
            InitializeComponent();
            this.Height += 134;
        }

        public frmReleaseDetainedLicense(clsUser User, int ConMenuStrPersonID)
        {
            _User = User;
            _ConMenuStrPersonID = ConMenuStrPersonID;
            InitializeComponent();
            this.Height += 134;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

            clsDetainedLicense DetinedLicense = clsDetainedLicense.FindByLicenseID(LicenseID);

            if (DetinedLicense == null || DetinedLicense.ReleasedByUserID != -1)
            {
                MessageBox.Show("Selected License is not detained, choose another one.",
                    "Invalid license", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (Lic.IsActive == false)
            {
                MessageBox.Show("license is inactive choose another one.",
                    "Invalid license", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            clsLicense License = clsLicense.FindByAppID(Lic.ApplicationID); // LicenseID
            lbLicenseID.Text = License.LicenseID.ToString();
            lbDetainLicenseID.Text = License.LicenseID.ToString();
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

            clsDetainedLicense DetainedLicense = clsDetainedLicense.FindByLicenseID(LicenseID);
            lbDetainID.Text = DetainedLicense.DetainID.ToString();
            lbDetainDate.Text = DetainedLicense.DetainDate.ToString("d");
            lbApplicationFees.Text = 15.ToString();
            clsUser User = clsUser.Find(DetainedLicense.CreatedByUserID);
            lbCreByUser.Text = User.Username;
            lbFineFees.Text = DetainedLicense.FineFees.ToString();
            lbTotalFees.Text = (15 + DetainedLicense.FineFees).ToString();
            _DetainedLicense = DetainedLicense;


            if (File.Exists(Person.ImagePath))
            {
                pbPersonPic.Image = Image.FromFile(Person.ImagePath);
            }


            btnRelease.Enabled = true;
            llbShowLicHistory.Enabled = true;
        }

        private void llbShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmShowLicense = new frmShowDriverLicense(_License);
            frmShowLicense.ShowDialog();
        }

        private void llbShowLicHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmLicensesHistory = new frmLicensesHistory(_NationalNo);
            frmLicensesHistory.ShowDialog();
        }

        private void tbLicenseIDSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true; // stop writting
            }
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            if(_ConMenuStrPersonID != -1)
            {
                gbFilter.Enabled = false;
                btnRelease.Enabled = true;
                llbShowLicHistory.Enabled = true;
                llbShowLicenseInfo.Enabled = true;
                tbLicenseIDSearch.Text = _ConMenuStrPersonID.ToString();

                int LicenseID = _ConMenuStrPersonID;
                clsLicense Lic = clsLicense.Find(LicenseID);

                clsLicense License = clsLicense.FindByAppID(Lic.ApplicationID); // LicenseID
                lbLicenseID.Text = License.LicenseID.ToString();
                lbDetainLicenseID.Text = License.LicenseID.ToString();
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

                clsDetainedLicense DetainedLicense = clsDetainedLicense.FindByLicenseID(LicenseID);
                lbDetainID.Text = DetainedLicense.DetainID.ToString();
                lbDetainDate.Text = DetainedLicense.DetainDate.ToString("d");
                lbApplicationFees.Text = 15.ToString();
                clsUser User = clsUser.Find(DetainedLicense.CreatedByUserID);
                lbCreByUser.Text = User.Username;
                lbFineFees.Text = DetainedLicense.FineFees.ToString();
                lbTotalFees.Text = (15 + DetainedLicense.FineFees).ToString();
                _DetainedLicense = DetainedLicense;


                if (File.Exists(Person.ImagePath))
                {
                    pbPersonPic.Image = Image.FromFile(Person.ImagePath);
                }
            }
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release this detained license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                clsApplications Application = new clsApplications();

                Application.AppPersonID = _PersonID;
                Application.AppDate = DateTime.Now;
                Application.AppTypeID = 5;
                Application.AppStatusID = 2;
                Application.LastStatusDate = DateTime.Now;
                Application.PaidFees = 15;
                Application.CreaByUserID = _User.ID;

                bool IsAppSave = Application.Save();

                _DetainedLicense.IsReleased = true;
                _DetainedLicense.ReleaseDate = DateTime.Now;
                _DetainedLicense.ReleasedByUserID = _User.ID;
                _DetainedLicense.ReleaseApplicationID = Application.AppID;

                if (IsAppSave && _DetainedLicense.Save())
                {
                    MessageBox.Show("Detained License released",
                    "License Renewed", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    gbFilter.Enabled = false;
                    btnRelease.Enabled = false;
                    llbShowLicenseInfo.Enabled = true;
                    lbRDLApplicationID.Text = Application.AppID.ToString();
                }
            }
        }
    }
}
