using System;
using System.Drawing;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmChangePassword : Form
    {
        private clsUser _User;
        private string _Password;
        
        public frmChangePassword(clsUser User)
        {
            _User = User;

            InitializeComponent();
        }

        private void _LoadData()
        {
            this.Size = new Size(870, 580);

            clsPeople Person = clsPeople.Find(_User.PersonID);
            ucShowDetails.FillPersonInfo(Person);

            lbUserID.Text = _User.ID.ToString();
            lbUsername.Text = _User.Username;
            lbIsActive.Text = _User.IsActive ? "Active" : "Inactie";  
        }
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(tbCurrentPass.Text) ||
        string.IsNullOrWhiteSpace(tbNewPass.Text) ||
        string.IsNullOrWhiteSpace(tbConfirmPass.Text)))
            {
                if (tbNewPass.Text != tbConfirmPass.Text)
                {
                    MessageBox.Show("The password and confirmation do not match.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                if (_Password != _User.Password.ToString())
                {
                    MessageBox.Show("Current Password is Wrong!",
                                   "Error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                    return;
                }

            clsUser User = clsUser.Find(int.Parse(lbUserID.Text));
                User.Password = tbConfirmPass.Text;

                if (User.Save())
                    MessageBox.Show("Password Changed Successfully", "Saved",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill in all fields before saving", "warning",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                return;
            }
        }

        private void tbCurrentPass_TextChanged(object sender, EventArgs e)
        {
            string enteredPassword = tbCurrentPass.Text;
            string EncodePassword = clsUser.EncodePassword(enteredPassword);
            _Password = EncodePassword;

            if (EncodePassword != _User.Password.ToString())
                errorProvider1.SetError(tbCurrentPass, "Current Password is Wrong!");
            else
                errorProvider1.Clear();
        }

        private void tbConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (tbNewPass.Text != tbConfirmPass.Text)
                errorProvider1.SetError(tbConfirmPass, "Password must be identical");
            else
                errorProvider1.Clear();
        }
    }
}
