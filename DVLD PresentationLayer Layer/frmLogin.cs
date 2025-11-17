using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string _Username, _Password, _filePath = @"C:\Users\Public\RemMe.txt";
        public static string DecodePassword(string base64)
        {
            byte[] bytes = Convert.FromBase64String(base64);
            string originalPassword = Encoding.UTF8.GetString(bytes);
            return originalPassword;
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

            if (File.Exists(_filePath))
            {
                string[] lines = File.ReadAllLines(_filePath);

                if (lines.Length > 0)
                {
                    foreach (string line in lines)
                    {
                        if(line.StartsWith("Username:"))
                        {
                            _Username = line.Substring("Username: ".Length);
                            tbUsername.Text = line.Substring("Username: ".Length);
                        }
                        else if (line.StartsWith("Password:"))
                        {
                            //string encodePassword = line.Substring("Password: ".Length);
                            //string decodePassword = DecodePassword(encodePassword);
                            //tbPassword.Text = decodePassword;
                            _Password = line.Substring("Password: ".Length);
                            tbPassword.Text = line.Substring("Password: ".Length);
                        }
                    }

                    cbRememberMe.Checked = true;
                }
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveToFileTemporarily(string username, string encodedPassword)
        {

            string content = $"Username: {username}{Environment.NewLine}Password: {encodedPassword}";

            if (File.Exists(_filePath))
            {

                string[] lines = File.ReadAllLines(_filePath);
                File.WriteAllText(_filePath, content);
                    
            }

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser User = clsUser.Find(tbUsername.Text.ToString());

            string enteredPassword = tbPassword.Text;
            string EncodePassword = clsUser.EncodePassword(enteredPassword);


                if (User != null && User.Password == EncodePassword && User.IsActive == true)
            {
                this.Hide();

                Form frmMainDashbord = new frmDVLDMainDashboard(User);
                frmMainDashbord.Show();

                if (cbRememberMe.Checked)
                {
                    string Username = tbUsername.Text.Trim();
                    string Password = tbPassword.Text.ToString();

                    SaveToFileTemporarily(Username, Password);
                }
                else
                {
                    if(tbUsername.Text.Trim() == _Username  && tbPassword.Text.ToString() == _Password)
                    {
                        string content = "";
                        File.WriteAllText(_filePath, content);
                    }
                }
            }
            else           
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void cbRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
