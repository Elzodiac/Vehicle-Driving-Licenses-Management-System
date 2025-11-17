using System;
using System.Drawing;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmManageApplicationTypes : Form
    {
        public frmManageApplicationTypes()
        {
            InitializeComponent();
            this.Size = new Size(700, 600);
        }

        private void _RefreshAppTypes()
        {
            dgvGetAppTypes.DataSource = clsApplicationType.GetAllAppTypes();

            int rowCount = dgvGetAppTypes.Rows.Count;
            lbRecordNum.Text = rowCount.ToString();

            dgvGetAppTypes.Columns["ID"].FillWeight = 10;
            dgvGetAppTypes.Columns["Title"].FillWeight = 60;
            dgvGetAppTypes.Columns["Fees"].FillWeight = 20;

        }
        private void clsManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _RefreshAppTypes();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int AppTypeID = (int)dgvGetAppTypes.CurrentRow.Cells[0].Value;

            clsApplicationType AppType = clsApplicationType.Find(AppTypeID);

            Form frmUpdateAppType = new frmUpdateApplicationType(AppType);
            frmUpdateAppType.ShowDialog();

            _RefreshAppTypes();
        }
    }
}
