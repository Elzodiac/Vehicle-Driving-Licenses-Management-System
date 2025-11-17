using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class ctrlAdd_Edit : UserControl
    {

        public ctrlAdd_Edit()
        {
            InitializeComponent();
        }

        private string _CountryName;
        private string _OldImagePath;
        private int _PersonID;
        public void FillCountries(DataTable dtCountries)
        {
            
            cbCountry.Items.Clear();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"].ToString());
            }

            cbCountry.SelectedIndex = 118;

        }

        public void GetCountryNameById(string Country)
        {
            _CountryName = Country;
        }

        public void FillPersonFields(clsPeople Person)
        {
            _PersonID = Person.ID;

            tbFirst.Text = Person.FirstName;
            tbSecond.Text = Person.SecondName;
            tbThird.Text = Person.ThirdName;
            tbLast.Text = Person.LastName;
            tbNationalNo.Text = Person.NationalNo;
            dtpDateOfBirth.Value = Person.DateOfBirth;
            tbPhone.Text = Person.Phone;
            tbEmail.Text = Person.Email;
            tbAddress.Text = Person.Address;

            if (Person.Gendor == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            if (!string.IsNullOrEmpty(Person.ImagePath) && Person.ImagePath != "default" && File.Exists(Person.ImagePath))
            {
                try
                {

                    byte[] imageBytes = File.ReadAllBytes(Person.ImagePath);


                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pbPersonPic.Image = Image.FromStream(ms);
                    }

                    pbPersonPic.Tag = Person.ImagePath;
                    _OldImagePath = Person.ImagePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    pbPersonPic.Image = Properties.Resources.person1;
                    pbPersonPic.Tag = "default";
                    _OldImagePath = "default";
                }
            }
            else
            {
                pbPersonPic.Image = Properties.Resources.person1;
                pbPersonPic.Tag = "default";
                _OldImagePath = "default";
            }

            llbRemove.Visible = (pbPersonPic.Tag.ToString() != "default");
            cbCountry.SelectedIndex = cbCountry.FindString(_CountryName);

        }

        private void tbFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFirst.Text))
            {
                e.Cancel = true;
                tbFirst.Focus();
                errorProvider1.SetError(tbFirst, "FirstName should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbFirst, "");
            }
        }

        private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // stop writting
            }
        }

        private void tbSecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // stop writting
            }
        }

        private void tbThirdName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // stop writting
            }
        }

        private void tbLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLast.Text))
            {
                e.Cancel = true;
                tbLast.Focus();
                errorProvider1.SetError(tbLast, "LastName should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbLast, "");
            }
        }

        private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // stop writting
            }
        }

        private void tbNationalNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNationalNo.Text))
            {
                e.Cancel = true;
                tbNationalNo.Focus();
                errorProvider1.SetError(tbNationalNo, "NationalNo should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbNationalNo, "");
            }

            bool isExists = clsPeople.isPersonExistsByNationalNo(tbNationalNo.Text.ToString());

            if(isExists)
            {
                e.Cancel = true;
                tbNationalNo.Focus();
                errorProvider1.SetError(tbNationalNo, "National Number is used for another person");
            }
        }

        private void tbNationalNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true; // stop writting
            }
        }

        private void ctrlAdd_Edit_Load(object sender, EventArgs e)
        {
            rbMale.Checked = true;
        }

        private void tbPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                e.Cancel = true;
                tbPhone.Focus();
                errorProvider1.SetError(tbPhone, "you should Enter your Phone Number!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbPhone, "");
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true; // stop writting
            }
        }

        private void tbAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAddress.Text))
            {
                e.Cancel = true;
                tbAddress.Focus();
                errorProvider1.SetError(tbAddress, "you should Enter your Address!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbAddress, "");
            }
        }

        private void tbAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // stop writting
            }
        }

        private void llbSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                pbPersonPic.Load(selectedFilePath);
                pbPersonPic.Tag = "not default";


                llbRemove.Visible = true;
            }
        }

        private void llbRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonPic.Image = Properties.Resources.person1;
            llbRemove.Visible = false;
        }

        public void RemoveVisible()
        {
            llbRemove.Visible = false;
        }
        public void MaxDateTime()
        {
            DateTime Today = DateTime.Now;
            DateTime EighteenYearsAgo = Today.AddYears(-18);

            dtpDateOfBirth.Value = EighteenYearsAgo;
            dtpDateOfBirth.MaxDate = EighteenYearsAgo; 
        }



        public event Action OnClose;
        protected virtual void Close()
        {
            Action handler = OnClose;
            if (handler != null)
            {
                handler();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (OnClose != null)
            {
                Close();
            }
        }

        public class SaveEventArgs : EventArgs
        {
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public string ThirdName { get; set; }
            public string LastName { get; set; }
            public string NationalNo { get; set; }
            public DateTime DateOfBirth { get; set; }
            public byte Gendor { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public int Country { get; set; }
            public string Address { get; set; }
            public string ImagePath { get; set; }
        }

        public event EventHandler<SaveEventArgs> OnSave;

        protected virtual void SaveInfo()
        {
            if (pbPersonPic.Tag.ToString() != "default" && pbPersonPic.Tag.ToString() != _OldImagePath)
            {
                string imagesFolder = @"C:\DVLD_People_Images";

                if (!Directory.Exists(imagesFolder))
                {
                    Directory.CreateDirectory(imagesFolder);
                }


                string newFileName = Guid.NewGuid().ToString() + ".jpg";
                string newFilePath = Path.Combine(imagesFolder, newFileName);


                try
                {
                    
                    pbPersonPic.Image.Save(newFilePath, ImageFormat.Jpeg);
                    pbPersonPic.Tag = newFilePath;

                    if (!string.IsNullOrEmpty(_OldImagePath) && File.Exists(_OldImagePath) && _OldImagePath != "default")
                    {
                        if (pbPersonPic.Image != null)
                        {
                            pbPersonPic.Image.Dispose();
                        }

                        File.Delete(_OldImagePath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            var args = new SaveEventArgs
                {
                    FirstName = tbFirst.Text,
                    SecondName = tbSecond.Text,
                    ThirdName = tbThird.Text,
                    LastName = tbLast.Text,
                    NationalNo = tbNationalNo.Text,
                    DateOfBirth = dtpDateOfBirth.Value,
                    Gendor = rbMale.Checked ? (byte)0 : (byte)1,
                    Phone = tbPhone.Text,
                    Email = tbEmail.Text,
                    Country = cbCountry.SelectedIndex + 1,
                    Address = tbAddress.Text,
                    ImagePath = pbPersonPic.Tag?.ToString()

                };

                OnSave?.Invoke(this, args);  
        }

            
    

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveInfo();
        }

        private void tbEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string email = tbEmail.Text.Trim();
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";


            if (!Regex.IsMatch(email, pattern))
            {
                e.Cancel = true;
                tbEmail.Focus();
                errorProvider1.SetError(tbEmail, "you should Enter Email!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbEmail, "");
            }
        }

        private void tbFirst_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
