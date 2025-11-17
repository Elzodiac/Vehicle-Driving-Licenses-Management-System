using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Proj
{
    public partial class frmShowApplicationDetails : Form
    {
        int _LDL_AppID;
        public frmShowApplicationDetails(int LDL_AppID)
        {
            _LDL_AppID = LDL_AppID;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowApplicationDetails_Load(object sender, EventArgs e)
        {
            ucDrivingLicenseAppInfo.FillApplicationInfo(_LDL_AppID);
        }
    }
}
