using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmManageDetainedLicenses : Form
    {
        clsUser _User;
        public frmManageDetainedLicenses(clsUser User)
        {
            _User = User;
            InitializeComponent();
        }

        private void _RefreshDetainedLicensesList()
        {
            dgvGetDetainedLicenses.DataSource = clsDetainedLicense.GetAllDetainLicenses();

            int rowCount = dgvGetDetainedLicenses.Rows.Count;
            lbRecordNum.Text = rowCount.ToString();
        }  //

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            _RefreshDetainedLicensesList();
            cbFilterBy.SelectedIndex = 0;
            cbIsReleased.SelectedIndex = 0;
        }

        private void tbFilterBy_TextChanged(object sender, EventArgs e)
        {
            DataTable dtPeople = clsDetainedLicense.GetAllDetainLicenses();

            if (string.IsNullOrEmpty(tbFilterBy.Text.Trim()))
            {
                _RefreshDetainedLicensesList();
                return;
            }

            string FilterExpression = "";

            switch (cbFilterBy.SelectedIndex)
            {
                case 1:
                    int DetainID = int.Parse(tbFilterBy.Text);
                    FilterExpression = $"DetainID = {DetainID}";
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

            DataView dv = new DataView(dtPeople);
            dv.RowFilter = FilterExpression;
            dgvGetDetainedLicenses.DataSource = dv;

            int rowCount = dgvGetDetainedLicenses.Rows.Count;
            lbRecordNum.Text = rowCount.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedItem.ToString() != "None")
            {
                if (cbFilterBy.SelectedItem.ToString() == "Is Released")
                {
                    cbIsReleased.Visible = true;
                    tbFilterBy.Visible = false;
                }
                else
                {
                    tbFilterBy.Visible = true;
                    cbIsReleased.Visible = false;
                    tbFilterBy.Focus();
                    tbFilterBy.Text = "";
                }

            }
            else
                tbFilterBy.Visible = false;

            if (cbFilterBy.SelectedIndex == 0)
                _RefreshDetainedLicensesList();
        }

        private void tbFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cbFilterBy.SelectedIndex)
            {
                case 1:
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

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            Form frmDetainLic = new frmDetainLicense(_User);
            frmDetainLic.ShowDialog();
        }

        private void btnReleaseLicense_Click(object sender, EventArgs e)
        {
            Form frmReleaseDeLic = new frmReleaseDetainedLicense(_User);
            frmReleaseDeLic.ShowDialog();
        }

        private void frmManageDetainedLicenses_Activated(object sender, EventArgs e)
        {
            _RefreshDetainedLicensesList();
        }

        private void cbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterExpression = "";
            bool IsReleased = false;

            DataTable dtPeople = clsDetainedLicense.GetAllDetainLicenses();

            switch (cbIsReleased.SelectedIndex)
            {
                case 1:
                    IsReleased = true;
                    FilterExpression = $"IsReleased = {IsReleased}";
                    break;
                case 2:
                    IsReleased = false;
                    FilterExpression = $"IsReleased = {IsReleased}";
                    break;
            }

            DataView dv = new DataView(dtPeople);
            dv.RowFilter = FilterExpression;
            dgvGetDetainedLicenses.DataSource = dv;
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvGetDetainedLicenses.CurrentRow.Cells[1].Value;
            clsLicense License = clsLicense.Find(LicenseID);

            Form frmShowLicense = new frmShowDriverLicense(License);
            frmShowLicense.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string PersonNo = (string)dgvGetDetainedLicenses.CurrentRow.Cells[6].Value;

            Form frmLicensesHistory = new frmLicensesHistory(PersonNo);
            frmLicensesHistory.ShowDialog();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NationalNo = (string)dgvGetDetainedLicenses.CurrentRow.Cells[6].Value;
            clsPeople Person = clsPeople.Find(NationalNo);

            Form PersonDet = new frmPersonDetails(Person.ID);
            PersonDet.ShowDialog();
            _RefreshDetainedLicensesList();
        }

        private void dgvGetDetainedLicenses_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                bool IsReleased = (bool)dgvGetDetainedLicenses.CurrentRow.Cells[4].Value;
                TSMIReleaseDetainedLicense.Enabled = true;

                if (IsReleased == true)
                {
                    TSMIReleaseDetainedLicense.Enabled = false;
                }
            }
        }

        private void TSMIReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvGetDetainedLicenses.CurrentRow.Cells[1].Value;

            Form frmReleaseDeLic = new frmReleaseDetainedLicense(_User, LicenseID);
            frmReleaseDeLic.ShowDialog();
        }
    }
}
