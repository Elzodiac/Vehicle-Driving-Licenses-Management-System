using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void _RefreshUsersList()
        {
            dgvGetUsers.DataSource = clsUser.GetAllUsers();

            int rowCount = dgvGetUsers.Rows.Count;
            lbRecordNum.Text = rowCount.ToString();
        }  //

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();
            cbFilterBy.SelectedIndex = 0;
            cbActiveOrInactive.SelectedIndex = 0;
            tsmiAddNew.Click += btnAddUser_Click;
        } ////

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedItem.ToString() != "None")
            {
                if (cbFilterBy.SelectedItem.ToString() == "Is Active")
                {
                    cbActiveOrInactive.Visible = true;
                }
                else
                {
                    tbFilterBy.Visible = true;
                    tbFilterBy.Focus();
                    tbFilterBy.Text = "";
                }

            }
            else
                tbFilterBy.Visible = false;

            if (cbFilterBy.SelectedIndex == 0)
                _RefreshUsersList();
        }

        private void tbFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cbFilterBy.SelectedIndex)
            {
                case 1:
                case 2:
                    if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                        e.Handled = true;
                    break;
                case 4:
                    if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                        e.Handled = true;
                    break;
                case 5:
                case 3:
                    if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                        e.Handled = true;
                    break;
            }
        }

        private void tbFilterBy_TextChanged(object sender, EventArgs e)
        {
            DataTable dtPeople = clsUser.GetAllUsers();

            if (string.IsNullOrEmpty(tbFilterBy.Text.Trim()))
            {
                _RefreshUsersList();
                return;
            }

            string FilterExpression = "";

            switch (cbFilterBy.SelectedIndex)
            {
                case 1:
                    int UserID = int.Parse(tbFilterBy.Text);
                    FilterExpression = $"UserID = {UserID}";
                    break;
                case 2:
                    int PersonID = int.Parse(tbFilterBy.Text);
                    FilterExpression = $"PersonID = {PersonID}";
                    break;
                case 3:
                    string FullName = tbFilterBy.Text.Trim();
                    FilterExpression = $"FullName = '{FullName}'";
                    break;
                case 4:
                    string UserName = tbFilterBy.Text.Trim();
                    FilterExpression = $"UserName = '{UserName}'";
                    break;
            }

            DataView dv = new DataView(dtPeople);
            dv.RowFilter = FilterExpression;
            dgvGetUsers.DataSource = dv;

            int rowCount = dgvGetUsers.Rows.Count;
            lbRecordNum.Text = rowCount.ToString();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Form frmAddAndEditUsers = new frmAddAndEditUserInfo(-1);
            frmAddAndEditUsers.ShowDialog();
        }

        private void frmManageUsers_Activated(object sender, EventArgs e)
        {
            _RefreshUsersList();
        }

        private void cbActiveOrInactive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterExpression = "";
            bool IsActive = false;

            DataTable dtPeople = clsUser.GetAllUsers();

            switch (cbActiveOrInactive.SelectedIndex)
            {
                case 1:
                    IsActive = true;
                    FilterExpression = $"IsActive = {IsActive}";
                    break;
                case 2:
                    IsActive = false;
                    FilterExpression = $"IsActive = {IsActive}";
                    break;
            }

            DataView dv = new DataView(dtPeople);
            dv.RowFilter = FilterExpression;
            dgvGetUsers.DataSource = dv;
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvGetUsers.CurrentRow.Cells[0].Value;

            Form frmAddAndEdit = new frmAddAndEditUserInfo(UserID);
            frmAddAndEdit.ShowDialog();
            _RefreshUsersList();
        }

        private void tsmiChangePass_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvGetUsers.CurrentRow.Cells[0].Value;
            clsUser User = clsUser.Find(UserID);

            Form frmChangePassword = new frmChangePassword(User);
            frmChangePassword.ShowDialog();
            _RefreshUsersList();
        }

        private void tsmiShowDetails_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvGetUsers.CurrentRow.Cells[0].Value;
            int PersonID = (int)dgvGetUsers.CurrentRow.Cells[1].Value;

            Form frmUserInfo = new frmUserInfo(PersonID, UserID);
            frmUserInfo.ShowDialog();
            _RefreshUsersList();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvGetUsers.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete user [" + UserID + " ]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                if (clsUser.DeleteUser(UserID))
                    MessageBox.Show("The user has been successfully deleted");
                else
                    MessageBox.Show("Failed to delete user", "Failed Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _RefreshUsersList();
            }
        }
    }
}
