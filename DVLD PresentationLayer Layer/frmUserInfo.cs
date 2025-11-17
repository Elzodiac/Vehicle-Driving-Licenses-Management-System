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
    public partial class frmUserInfo : Form
    {
        private int _UserID, _PersonID;
        public frmUserInfo(int PersonID, int UserID)
        {
            _PersonID = PersonID;
            _UserID = UserID;

            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            clsPeople Person = clsPeople.Find(_PersonID);
            clsUser User = clsUser.Find(_UserID);

            ucShowDetails.FillPersonInfo(Person);

            lbUserID.Text = User.ID.ToString();
            lbUsername.Text = User.Username.ToString();
            lbIsActive.Text = User.IsActive ? "Active" : "Inactive";
        }
    }
}
