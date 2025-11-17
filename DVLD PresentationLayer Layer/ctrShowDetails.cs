using System;
using System.IO;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class ctrShowDetails : UserControl
    {
        private int _PesonID;
        private clsPeople _Person;
        public ctrShowDetails()
        {
            InitializeComponent();
        }

        public string PersonIDValue
        {
            get { return lbPersonID.Text; }
            set { lbPersonID.Text = value; }
        }

        public void FillPersonInfo(clsPeople Person)
        {
            _Person = Person;
            _PesonID = Person.ID;

           
                lbPersonID.Text = Person.ID.ToString();
                lbName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
                lbNationalNo.Text = Person.NationalNo.ToString();
                lbGendor.Text = Person.Gendor == 0 ? "Male" : "Female";
                lbEmail.Text = Person.Email.ToString();
                lbAddress.Text = Person.Address.ToString();
                lbDateOfBirth.Text = Person.DateOfBirth.ToString("yyyy-MM-dd");
                lbPhone.Text = Person.Phone.ToString();
               if(Person.NationalityCountryID != -1) 
                lbCountry.Text = clsCountry.Find(Person.NationalityCountryID).CountryName;            
                

                if (!string.IsNullOrEmpty(Person.ImagePath) && Person.ImagePath != "default" && File.Exists(Person.ImagePath))
                    pbPersonPic.Load(Person.ImagePath);
                else
                    pbPersonPic.Image = Properties.Resources.person1;
            

        }


        private void llbEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_Person != null)
            {
                Form frmAddAndEdit = new frmAddAndEditPersonInfo(_PesonID);
                frmAddAndEdit.ShowDialog();
            }
            else
                MessageBox.Show("A person must be selected before editing.", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }


        private void ctrShowDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
