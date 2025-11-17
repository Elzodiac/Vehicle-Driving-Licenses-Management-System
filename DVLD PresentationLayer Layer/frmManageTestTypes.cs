using System;
using System.Drawing;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
            this.Size = new Size(700, 600);

        }

        private void _RefreshTestTypes()
        {
            dgvGetTestTypes.DataSource = clsTestType.GetAllTestTypes();

            int rowCount = dgvGetTestTypes.Rows.Count;
            lbRecordNum.Text = rowCount.ToString();

            dgvGetTestTypes.Columns["ID"].FillWeight = 10;
            dgvGetTestTypes.Columns["Title"].FillWeight = 40;
            dgvGetTestTypes.Columns["Description"].FillWeight = 80;
            dgvGetTestTypes.Columns["Fees"].FillWeight = 20;
        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshTestTypes();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestTypeID = (int)dgvGetTestTypes.CurrentRow.Cells[0].Value;

            clsTestType TestType = clsTestType.Find(TestTypeID);

            Form frmUpdateTestType = new frmUpdateTestType(TestType);
            frmUpdateTestType.ShowDialog();

            _RefreshTestTypes();
        }
    }
}
