using System;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmUpdateApplicationType : Form
    {
        
        private clsApplicationType _AppType;
        public frmUpdateApplicationType(clsApplicationType AppType)
        {
            _AppType = AppType;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadData()
        {
            lbID.Text = _AppType.ID.ToString();
            tbTitle.Text = _AppType.Title.ToString();
            tbFees.Text = _AppType.Fees.ToString();
        }

        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _AppType.Title = tbTitle.Text.Trim();
            _AppType.Fees = decimal.Parse( tbFees.Text);

            if(_AppType.Save())
                MessageBox.Show("Data Saved Successfully.");
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.");

        }
    }
}
