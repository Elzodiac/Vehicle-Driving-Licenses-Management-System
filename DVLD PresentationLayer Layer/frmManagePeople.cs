using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();
        }

        private void _RefreshPeopleList()
        {
            dgvGetPeople.DataSource = clsPeople.GetAllPeople();

            int rowCount = dgvGetPeople.Rows.Count;
            lbRecordNum.Text = rowCount.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        } 

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _RefreshPeopleList();
            tsmiAddNew.Click += btnAddPerson_Click;
            this.Size = new Size(1200, 600);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form frmAddAndEdit = new frmAddAndEditPersonInfo(-1);
            frmAddAndEdit.ShowDialog();
            _RefreshPeopleList();
        }

      
        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvGetPeople.CurrentRow.Cells[0].Value;
            
            Form frmAddAndEdit = new frmAddAndEditPersonInfo(PersonID);
            frmAddAndEdit.ShowDialog();
            _RefreshPeopleList();
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedItem.ToString() != "None")
            {
                tbFilterBy.Visible = true;
                tbFilterBy.Focus();
                tbFilterBy.Text = "";
            }
            else
                tbFilterBy.Visible = false;

            if (cbFilterBy.SelectedIndex == 0)
                _RefreshPeopleList();
        }

        private void tbFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cbFilterBy.SelectedIndex)
            {
                case 1:
                case 7:
                case 8:
                case 9:
                    if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                        e.Handled = true;
                    break;
                case 2:
                    if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                        e.Handled = true;
                    break;
                case 3:
                case 4:
                case 5:
                case 6:
                    if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                        e.Handled = true;
                    break;
            }
        }

        private void tbFilterBy_TextChanged(object sender, EventArgs e)
        {
            DataTable dtPeople = clsPeople.GetAllPeople();

            if (string.IsNullOrEmpty(tbFilterBy.Text.Trim()))
            {
                _RefreshPeopleList();
                return;
            }

            string FilterExpression = "";

            switch (cbFilterBy.SelectedIndex)
            {
                case 1:
                    int personID = int.Parse(tbFilterBy.Text);
                    FilterExpression = $"PersonID = {personID}";
                    break;
                case 2:
                    string NationalNo = tbFilterBy.Text.Trim();
                    FilterExpression = $"NationalNo = '{NationalNo}'";
                    break;
                case 3:
                    string FirstName = tbFilterBy.Text.Trim();
                    FilterExpression = $"FirstName = '{FirstName}'";
                    break;
                case 4:
                    string SecondName = tbFilterBy.Text.Trim();
                    FilterExpression = $"SecondName = '{SecondName}'";
                    break;
                case 5:
                    string ThirdName = tbFilterBy.Text.Trim();
                    FilterExpression = $"ThirdName = '{ThirdName}'";
                    break;
                case 6:
                    string LastName = tbFilterBy.Text.Trim();
                    FilterExpression = $"LastName = '{LastName}'";
                    break;
                case 7:
                    string NationalityCountryID = tbFilterBy.Text.Trim();
                    FilterExpression = $"NationalityCountryID = '{NationalityCountryID}'";
                    break;
                case 8:
                    byte Gendor = byte.Parse(tbFilterBy.Text);
                    FilterExpression = $"Gendor = '{Gendor}'";
                    break;
                case 9:
                    string Phone = tbFilterBy.Text.Trim();
                    FilterExpression = $"Phone = '{Phone}'";
                    break;
                case 10:
                    string Email = tbFilterBy.Text.Trim();
                    FilterExpression = $"Email = '{Email}'";
                    break;
            }

            DataView dv = new DataView(dtPeople);
            dv.RowFilter = FilterExpression;
            dgvGetPeople.DataSource = dv;

            int rowCount = dgvGetPeople.Rows.Count;
            lbRecordNum.Text = rowCount.ToString();
        }

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvGetPeople.CurrentRow.Cells[0].Value;
            clsPeople Person = clsPeople.Find(PersonID);

            //frmSendEmail SendEmail = new frmSendEmail(Person.Email);
        }

        private void tsmiShowDetails_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvGetPeople.CurrentRow.Cells[0].Value;

            Form PersonDet = new frmPersonDetails(PersonID);
            PersonDet.ShowDialog();
            _RefreshPeopleList();
        }

    }
}
