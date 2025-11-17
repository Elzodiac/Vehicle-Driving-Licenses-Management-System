using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmDetainLicense : Form
    {
        private clsUser _User;
        private string _NationalNo;
        private clsLicense _License;
        public frmDetainLicense(clsUser User)
        {
            _User = User;
            InitializeComponent();
            this.Height += 123;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        } // 

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            lbDetainDate.Text = DateTime.Now.ToString("d");
            lbCreByUser.Text = _User.Username;
        } //

        private void tbLicenseIDSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true; // stop writting
            }
        } //

        private void llbShowLicHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmLicensesHistory = new frmLicensesHistory(_NationalNo);
            frmLicensesHistory.ShowDialog();
        } //

        private void llbShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmShowLicense = new frmShowDriverLicense(_License);
            frmShowLicense.ShowDialog();
        } //

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to issue a replacement for the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                clsDetainedLicense DetainLicense = new clsDetainedLicense();

                DetainLicense.LicenseID = int.Parse(lbLicenseID.Text);
                DetainLicense.DetainDate = DateTime.Now;
                DetainLicense.FineFees = decimal.Parse(tbFineFees.Text);
                DetainLicense.CreatedByUserID = _User.ID;
                DetainLicense.IsReleased = false;


                if (DetainLicense.Save())
                {
                    MessageBox.Show("License detained successfully with ID = " + DetainLicense.DetainID,
                    "License replaced", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    gbFilter.Enabled = false;
                    btnDetain.Enabled = false;
                    tbFineFees.Enabled = false;
                    llbShowLicenseInfo.Enabled = true;
                    lbDetainID.Text = DetainLicense.DetainID.ToString();
                    clsLicense License = clsLicense.Find(int.Parse(lbLicenseID.Text));
                    _License = License;
                }
            }
        } //

        private void tbFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true; // stop writting
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
            // 

            clsDetainedLicense DetinedLicense = clsDetainedLicense.FindByLicenseID(LicenseID);

            if (DetinedLicense != null && DetinedLicense.ReleasedByUserID == -1)
            {
                MessageBox.Show("Selected License is detained, choose another one.",
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


            //btnDetain.Enabled = true;
            llbShowLicHistory.Enabled = true;
        } 

        private void tbFineFees_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbFineFees.Text))            
                btnDetain.Enabled = true;            
            else
                btnDetain.Enabled = false;
        }
    }
}
