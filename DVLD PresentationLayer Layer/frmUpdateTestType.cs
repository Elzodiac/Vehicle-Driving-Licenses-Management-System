using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmUpdateTestType : Form
    {

        private clsTestType _TestType;
        public frmUpdateTestType(clsTestType TestType)
        {
            _TestType = TestType;
            InitializeComponent();
        }

        private void _LoadData()
        {
            lbID.Text = _TestType.ID.ToString();
            tbTitle.Text = _TestType.Title.ToString();
            tbDesc.Text = _TestType.Description.ToString();
            tbFees.Text = _TestType.Fees.ToString();
        }

        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _TestType.Title = tbTitle.Text.Trim();
            _TestType.Description = tbDesc.Text.Trim();
            _TestType.Fees = decimal.Parse(tbFees.Text);

            if (_TestType.Save())
                MessageBox.Show("Data Saved Successfully.");
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.");
        }
    }
}
