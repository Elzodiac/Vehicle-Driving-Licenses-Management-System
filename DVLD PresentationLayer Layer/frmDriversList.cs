using System;
using System.Data;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmDriversList : Form
    {
        public frmDriversList()
        {
            InitializeComponent();
            this.Height += 20;
        }

        private void _RefreshDriversListList()
        {
            dgvGetDriversList.DataSource = clsDriver.GetAllDriversList();

            int rowCount = dgvGetDriversList.Rows.Count;
            lbRecordNum.Text = rowCount.ToString();
        }
        private void clsDriversList_Load(object sender, EventArgs e)
        {
            _RefreshDriversListList();
        }

        private void tbFilterBy_TextChanged(object sender, EventArgs e)
        {
            DataTable dtDrivers = clsDriver.GetAllDriversList();

            if (string.IsNullOrEmpty(tbFilterBy.Text.Trim()))
            {
                _RefreshDriversListList();
                return;
            }

            string FilterExpression = "";

            switch (cbFilterBy.SelectedIndex)
            {
                case 1:
                    int DriverID = int.Parse(tbFilterBy.Text);
                    FilterExpression = $"DriverID = {DriverID}";
                    break;
                case 2:
                    int PersonID = int.Parse(tbFilterBy.Text);
                    FilterExpression = $"PersonID = '{PersonID}'";
                    break;
                case 3:
                    string NationalNo = tbFilterBy.Text.Trim();
                    FilterExpression = $"NationalNo = '{NationalNo}'";
                    break;
                case 4:
                    string FullName = tbFilterBy.Text.Trim();
                    FilterExpression = $"FullName = '{FullName}'";
                    break;
            }

            DataView dv = new DataView(dtDrivers);
            dv.RowFilter = FilterExpression;
            dgvGetDriversList.DataSource = dv;

            int rowCount = dgvGetDriversList.Rows.Count;
            lbRecordNum.Text = rowCount.ToString();
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
                case 3:
                    if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                        e.Handled = true;
                    break;
                case 4:
                    if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                        e.Handled = true;
                    break;
            }
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
                _RefreshDriversListList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
