using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DVLD_Proj;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmAddAndEditPersonInfo : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        private int _PersonID;
        private clsPeople _Person;
        public frmAddAndEditPersonInfo(int PersonID)
        {
            _PersonID = PersonID;

            if (_PersonID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

            InitializeComponent();
        }

        public frmAddAndEditPersonInfo()
        {
        }

        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            ucAddAndEditPerson.FillCountries(dtCountries);
        }

        private void _SendCountryNameToUpdatePerson()
        {
            string CountryName = clsCountry.Find(_Person.NationalityCountryID).CountryName;

            ucAddAndEditPerson.GetCountryNameById(CountryName);
        }

        private void _LoadData()
        {
            _FillCountriesInComoboBox();

            if (_Mode == enMode.AddNew)
            {
                lbAddEditPerson.Text = "Add New Person";
                _Person = new clsPeople();
                ucAddAndEditPerson.MaxDateTime();
                ucAddAndEditPerson.RemoveVisible();
                return;
            }


            _Person = clsPeople.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("Person is not Found");
                return;
            }


            lbAddEditPerson.Text = "Update Person";
            lbNA.Text = _PersonID.ToString();
            

            _SendCountryNameToUpdatePerson();

            ucAddAndEditPerson.FillPersonFields(_Person);
            ucAddAndEditPerson.MaxDateTime();
            ucAddAndEditPerson.RemoveVisible();

        }

        
        private void frmAddAndEditPersonInfo_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        public delegate void DataBackEventHandler(object sender, clsPeople Person);

        public event DataBackEventHandler DataBack;

        private void ucAddAndEditPerson_OnClose()
        {
            if (Application.OpenForms.OfType<frmAddAndEditUserInfo>().Any())
            {
                DataBack?.Invoke(this, _Person);

                this.Close();
            }

            this.Close();
        }

        private void ucAddAndEditPerson_OnSave(object sender, ctrlAdd_Edit.SaveEventArgs e)
        {

            _Person.FirstName = e.FirstName;
            _Person.SecondName = e.SecondName;
            _Person.ThirdName = e.ThirdName;
            _Person.LastName = e.LastName;
            _Person.NationalNo = e.NationalNo;
            _Person.DateOfBirth = e.DateOfBirth;
            _Person.Gendor = e.Gendor;
            _Person.Phone = e.Phone;
            _Person.Email = e.Email;
            _Person.NationalityCountryID = e.Country;
            _Person.Address = e.Address;
            _Person.ImagePath = e.ImagePath;


            if (_Person.Save())
                MessageBox.Show("Data Saved Successfully.");
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.");

            _Mode = enMode.Update;
            lbAddEditPerson.Text = "Update Person";
            lbNA.Text = _Person.ID.ToString();
        }

    }
}
