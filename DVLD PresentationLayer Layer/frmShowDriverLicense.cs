using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmShowDriverLicense : Form
    {
        private clsLicense _NewLicense;

        public frmShowDriverLicense(clsLicense NewLicense)
        {
            _NewLicense = NewLicense;
            InitializeComponent();
            this.Height += 95;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowDriverLicense_Load(object sender, EventArgs e)
        {

            clsLicense License = _NewLicense; // LicenseID
            lbLicenseID.Text = License.LicenseID.ToString();
            string DrivingClass = clsLicenseClass.Find(License.LicenseClass).LicClassName;
            lbClass.Text = DrivingClass;

            int PersonID = clsApplications.Find(License.ApplicationID).AppPersonID;
            clsPeople Person = clsPeople.Find(PersonID);
            lbNationalNo.Text = Person.NationalNo;
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
            clsDetainedLicense DetinedLicense = clsDetainedLicense.FindByLicenseID(License.LicenseID);

            if(DetinedLicense == null)
                lbIsDetained.Text = "No";
            else
                lbIsDetained.Text = DetinedLicense.ReleasedByUserID == -1 ?
                    "Yes" : "No";

            if (File.Exists(Person.ImagePath))
            {
                pbPersonPic.Image = Image.FromFile(Person.ImagePath);
            }
        }
    }
}
