using System;
using System.Drawing;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmAddAndEditUserInfo : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        private clsUser _User;
        private int _UserID, _PersonID;

        public frmAddAndEditUserInfo(int UserID)
        {
            _UserID = UserID;

            if (UserID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

                InitializeComponent();
        }

        private void _LoadData()
        {
            tabCAddAndEditUser.Appearance = TabAppearance.FlatButtons;
            tabCAddAndEditUser.ItemSize = new Size(0, 1);
            tabCAddAndEditUser.SizeMode = TabSizeMode.Fixed;

            cbFilterBy.SelectedIndex = 0;
            this.Size = new Size(880, 550);

            if (_Mode == enMode.AddNew)
            {
                lbAddEditUser.Text = "Add New User";
                _User = new clsUser();
                return;
            }

            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show("User is not Found");
                return;
            }

            lbAddEditUser.Text = "Update User";

            clsPeople Person = clsPeople.Find(_User.PersonID);
            ucShowDetails.FillPersonInfo(Person);
            _PersonID = Person.ID;


            gbFilter.Enabled = false;
            tbFilterBy.Visible = true;
            cbFilterBy.SelectedIndex = 1;

            lbUserID.Text = _User.ID.ToString();
            tbUserName.Text = _User.Username;
            tbPassword.Text = _User.Password;
            tbConfirmPass.Text = _User.Password;
            cbIsActive.Checked = _User.IsActive;

        }

        private void frmAddAndEditUserInfo_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterBy.SelectedIndex == 0)
                tbFilterBy.Visible = false;
            else
            {
                tbFilterBy.Visible = true;
                tbFilterBy.Text = "";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            string PersonID = ucShowDetails.PersonIDValue;

            if(PersonID != "???" && _Mode != enMode.Update)
            {

                bool isExists = clsUser.isUserExistsByPersonID(int.Parse(PersonID));

                if (isExists)
                    MessageBox.Show("Selected Person already has a user, Choose another one.",
                                    "Select another Person",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    tabCAddAndEditUser.SelectedIndex = 1;
            }
            else
                tabCAddAndEditUser.SelectedIndex = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!(string.IsNullOrWhiteSpace(tbUserName.Text) ||
        string.IsNullOrWhiteSpace(tbPassword.Text) ||
        string.IsNullOrWhiteSpace(tbConfirmPass.Text)))
            {
                if (tbPassword.Text != tbConfirmPass.Text)
                {
                    MessageBox.Show("The password and confirmation do not match.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                _User.PersonID = _PersonID;
                _User.Username = tbUserName.Text.Trim();
                _User.Password = tbPassword.Text.Trim();
                _User.IsActive = cbIsActive.Checked;


                if (_User.Save())
                    MessageBox.Show("Data Saved Successfully.");
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.");

                _UserID = _User.ID;
                lbUserID.Text = _UserID.ToString();

                _Mode = enMode.Update;
                lbAddEditUser.Text = "Update Person";
            }
            else
            {
                MessageBox.Show("Please fill in all fields before saving", "warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchUser_Click_1(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 1 || cbFilterBy.SelectedIndex == 2)
            {
                if(!string.IsNullOrWhiteSpace(tbFilterBy.Text))
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

        private void tbConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if(tbPassword.Text != tbConfirmPass.Text)
                epPassword.SetError(tbConfirmPass, "Password must be identical");
            else
                epPassword.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
