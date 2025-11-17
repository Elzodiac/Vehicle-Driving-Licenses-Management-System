using System;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmPersonDetails : Form
    {
        private int _PersonID;

        public frmPersonDetails(int PersonID)
        {
            _PersonID = PersonID;

            InitializeComponent();
        }

        public frmPersonDetails()
        {
        }

        private void frmPersonDetails_Load(object sender, EventArgs e)
        {
            clsPeople Person = clsPeople.Find(_PersonID);
            ucShowDetails.FillPersonInfo(Person);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPersonDetails_Activated(object sender, EventArgs e)
        {
            clsPeople Person = clsPeople.Find(_PersonID);
            ucShowDetails.FillPersonInfo(Person);
        }
    }
}
