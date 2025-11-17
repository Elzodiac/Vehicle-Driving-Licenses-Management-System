using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmShowInternationalLicense : Form
    {
        clsPeople _Person;
        clsInternationalLicense _IntLicense;
        public frmShowInternationalLicense(clsPeople Person, clsInternationalLicense IntLicense)
        {
            _Person = Person;
            _IntLicense = IntLicense;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowInternationalLicense_Load(object sender, EventArgs e)
        {
            lbName.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
            lbIntLicenseID.Text = _IntLicense.InternationalLicenseID.ToString();
            lbLicenseID.Text = _IntLicense.IssuedUsingLocalLicenseID.ToString();
            lbNationalNo.Text = _Person.NationalNo;
            lbGendor.Text = _Person.Gendor == 1 ? "Male" : "Female";
            lbIssueDate.Text = _IntLicense.IssueDate.ToString("d");
            lbApplicationID.Text = _IntLicense.ApplicationID.ToString();
            lbIsActive.Text = _IntLicense.IsActive == true ? "Yes" : "No";
            lbDateOfBirth.Text = _Person.DateOfBirth.ToString("d");
            lbdriverID.Text = _IntLicense.DriverID.ToString();
            lbExpDate.Text = _IntLicense.ExpirationDate.ToString("d");

            if (File.Exists(_Person.ImagePath))
            {
                pbPersonPic.Image = Image.FromFile(_Person.ImagePath);
            }
        }
    }
}
