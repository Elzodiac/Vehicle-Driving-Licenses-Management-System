using System;
using System.Drawing;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmAddAndEditLDLApp : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        private clsLDLApp _LDLApp;
        private clsApplications _Application;
        private int _LDLAppID, _PersonID, _UserID;
        public frmAddAndEditLDLApp(int UserID, int LDLAppID)
        {
            _UserID = UserID;
            _LDLAppID = LDLAppID;
            if (LDLAppID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(860, 520);
        }

        private void _LoadData()
        {

            cbFilterBy.SelectedIndex = 0;
            lbAppDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbAppFees.Text = "15 $";
            lbCreatedBy.Text = clsUser.Find(_UserID).Username;
            cbLicenseClass.SelectedIndex = 0;

            this.Size = new Size(880, 550);

            if (_Mode == enMode.AddNew)
            {
                lbAddEditUser.Text = "Add Local Driving License Application";
                _LDLApp = new clsLDLApp();
                _Application = new clsApplications();
                return;
            }

            _LDLApp = clsLDLApp.Find(_LDLAppID);
            _Application = clsApplications.Find(_LDLApp.AppID);
            _PersonID = _Application.AppPersonID;

            if (_LDLApp == null)
            {
                MessageBox.Show("Local Driving License Application is not Found");
                return;
            }

            lbAddEditUser.Text = "Edit Local Driving License Application";

            clsPeople Person = clsPeople.Find(_PersonID);
            ucShowDetails.FillPersonInfo(Person);
            _PersonID = Person.ID;

            string LicClassName = clsLicenseClass.Find(_LDLApp.LicClassID).LicClassName;

            gbFilter.Enabled = false;
            tbFilterBy.Visible = true;
            cbFilterBy.SelectedIndex = 1;

            lbDLAppID.Text = _LDLApp.AppID.ToString();
            cbLicenseClass.SelectedIndex = cbLicenseClass.FindString(LicClassName);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 0)
                tbFilterBy.Visible = false;
            else
            {
                tbFilterBy.Visible = true;
                tbFilterBy.Text = "";
                tbFilterBy.Focus();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabCAddAndEditUser.SelectedIndex = 1;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddAndEditPersonInfo frmAddAndEdit = new frmAddAndEditPersonInfo(-1);

            frmAddAndEdit.DataBack += frmAddAndEditDataBack;
            frmAddAndEdit.ShowDialog();
        }

        private void frmAddAndEditDataBack(object sender, clsPeople Person)
        {
            ucShowDetails.FillPersonInfo(Person);
            _PersonID = Person.ID;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tabCAddAndEditUser.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string PersonID = ucShowDetails.PersonIDValue;

            if(PersonID == "???")
            {
                MessageBox.Show("Someone must be selected to apply for a local" +
                 " driver's license.", "Error", MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
                return;
            }
             

            if (!clsApplications.isAppExists(int.Parse(PersonID), cbLicenseClass.SelectedIndex + 1))
            {
                if (PersonID != "???")
                    _Application.AppPersonID = int.Parse(PersonID);

                _Application.AppDate = DateTime.Now;
                _Application.AppTypeID = 1;

                if (_Mode == enMode.AddNew)
                {
                    _Application.AppStatusID = 1;
                    _Application.LastStatusDate = DateTime.Now;
                }

                _Application.PaidFees = 15;
                _Application.CreaByUserID = _UserID;

                bool AppSave = _Application.Save();

                _LDLApp.AppID = _Application.AppID;
                _LDLApp.LicClassID = cbLicenseClass.SelectedIndex + 1;

                if (_LDLApp.Save() && AppSave)
                    MessageBox.Show("Data Saved Successfully.");
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.");

                _Mode = enMode.Update;
                lbAddEditUser.Text = "Edit Local Driving License Application";
                lbDLAppID.Text = _LDLApp.ID.ToString();
            }
            else            
                MessageBox.Show("Choose another License Class, the selected Person Already have a license or an active application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void tbFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterBy.SelectedIndex == 1)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
                {
                    e.Handled = true; // stop writting
                }
            }
        }

        private void frmAddAndEditLDLApp_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 1 || cbFilterBy.SelectedIndex == 2)
            {
                if (!string.IsNullOrWhiteSpace(tbFilterBy.Text))
                {
                    clsPeople Person = cbFilterBy.SelectedIndex == 1
                    ? clsPeople.Find(int.Parse(tbFilterBy.Text.Trim()))
                    : clsPeople.Find(tbFilterBy.Text.Trim());

                    if (Person == null)
                    {
                        string criteria = cbFilterBy.SelectedIndex == 1 ? "Person ID" : "National No.";
                        MessageBox.Show($"No Person with {criteria} = {tbFilterBy.Text.Trim()}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    ucShowDetails.FillPersonInfo(Person);
                    _PersonID = Person.ID;
                }
            }
        }

    }
}
