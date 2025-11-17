using System;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmLicensesHistory : Form
    {
        private string _PersonNo;
        public frmLicensesHistory(string PersonNo)
        {
            _PersonNo = PersonNo;
            InitializeComponent();
            this.Height += 150;
            this.Width += 110;
        }

        private void frmLicensesHistory_Load(object sender, EventArgs e)
        {
            clsPeople Person = clsPeople.Find(_PersonNo);
            ucShowDetails.FillPersonInfo(Person);

            int DriverID = clsDriver.FindByPersonID(Person.ID).DriverID;
            dgvGetLocalLicensesHistroy.DataSource = clsLicense.GetAllLicenses(DriverID);
            dgvGetInternationalLicensesHistroy.DataSource = clsInternationalLicense.GetAllInterDriverLicenses(DriverID);

            lbRecordNum.Text = dgvGetLocalLicensesHistroy.RowCount.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabLocal.SelectedTab == tpInter)
                lbRecordsNum.Text = dgvGetInternationalLicensesHistroy.RowCount.ToString();
        }

        private void showLisenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvGetLocalLicensesHistroy.CurrentRow.Cells[0].Value;
            clsLicense License = clsLicense.Find(LicenseID);

            Form frmShowLicense = new frmShowDriverLicense(License);
            frmShowLicense.ShowDialog();
        }
    }
}
