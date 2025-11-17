using System;
using System.Data;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmManageInternationalLicenseApplications : Form
    {
        private clsUser _User;
        public frmManageInternationalLicenseApplications(clsUser User)
        {
            _User = User;
            InitializeComponent();
        }

        private void _RefreshIntLicensesList()
        {
            dgvGetIntLicApp.DataSource = clsInternationalLicense.GetAllInterDriverLicenses();

            int rowCount = dgvGetIntLicApp.Rows.Count;
            lbRecordNum.Text = rowCount.ToString();
        }

        private void frmManageInternationalLicenseApplications_Load(object sender, EventArgs e)
        {
            _RefreshIntLicensesList();
            cbFilterBy.SelectedIndex = 0;
            cbActiveOrInactive.SelectedIndex = 0;
        }

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
                    tbFilterBy.Visible = false;
                }
                else
                {
                    tbFilterBy.Visible = true;
                    cbActiveOrInactive.Visible = false;
                    tbFilterBy.Focus();
                    tbFilterBy.Text = "";
                }

            }
            else
                tbFilterBy.Visible = false;

            if (cbFilterBy.SelectedIndex == 0)
                _RefreshIntLicensesList();
        }

        private void tbFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cbFilterBy.SelectedIndex)
            {
                case 1:
                case 2:
                case 3:
                    if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                        e.Handled = true;
                    break;
                case 4:
                    if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                        e.Handled = true;
                    break;
            }
        }

        private void tbFilterBy_TextChanged(object sender, EventArgs e)
        {
            DataTable dtIntLicenses = clsInternationalLicense.GetAllInterDriverLicenses();

            if (string.IsNullOrEmpty(tbFilterBy.Text.Trim()))
            {
                _RefreshIntLicensesList();
                return;
            }

            string FilterExpression = "";

            switch (cbFilterBy.SelectedIndex)
            {
                case 1:
                    int IntLicenseID = int.Parse(tbFilterBy.Text);
                    FilterExpression = $"InternationalLicenseID = {IntLicenseID}";
                    break;
                case 2:
                    int DriverID = int.Parse(tbFilterBy.Text);
                    FilterExpression = $"DriverID = {DriverID}";
                    break;
                case 3:
                    string License = tbFilterBy.Text.Trim();
                    FilterExpression = $"IssuedUsingLocalLicenseID = '{License}'";
                    break;
            }

            DataView dv = new DataView(dtIntLicenses);
            dv.RowFilter = FilterExpression;
            dgvGetIntLicApp.DataSource = dv;

            int rowCount = dgvGetIntLicApp.Rows.Count;
            lbRecordNum.Text = rowCount.ToString();
        }

        private void cbActiveOrInactive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterExpression = "";
            bool IsActive = false;

            DataTable dtIntLicense = clsInternationalLicense.GetAllInterDriverLicenses();

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

            DataView dv = new DataView(dtIntLicense);
            dv.RowFilter = FilterExpression;
            dgvGetIntLicApp.DataSource = dv;
        }

        private void btnAddIntLicApp_Click(object sender, EventArgs e)
        {
            Form frmInterLicenseApp = new frmInternationalLicenseApplication(_User);
            frmInterLicenseApp.ShowDialog();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationID = (int)dgvGetIntLicApp.CurrentRow.Cells[1].Value;
            clsApplications Application = clsApplications.Find(ApplicationID);
            int PersonID = Application.AppPersonID;

            Form PersonDet = new frmPersonDetails(PersonID);
            PersonDet.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationID = (int)dgvGetIntLicApp.CurrentRow.Cells[1].Value;
            clsApplications Application = clsApplications.Find(ApplicationID);
            int PersonID = Application.AppPersonID;
            clsPeople Person = clsPeople.Find(PersonID);

            int IntLicenseID = (int)dgvGetIntLicApp.CurrentRow.Cells[0].Value;
            clsInternationalLicense IntLicense = clsInternationalLicense.Find(IntLicenseID);

            Form frmShowIntLicense = new frmShowInternationalLicense(Person, IntLicense);
            frmShowIntLicense.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationID = (int)dgvGetIntLicApp.CurrentRow.Cells[1].Value;
            clsApplications Application = clsApplications.Find(ApplicationID);
            int PersonID = Application.AppPersonID;
            clsPeople Person = clsPeople.Find(PersonID);

            Form frmLicensesHistory = new frmLicensesHistory(Person.NationalNo);
            frmLicensesHistory.ShowDialog();
        }
    }
}
