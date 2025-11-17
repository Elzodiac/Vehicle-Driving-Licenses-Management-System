using System;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmIssueDrivingLicenseForTheFirstTime : Form
    {
        int _LDL_AppID, _DriverID;
        public frmIssueDrivingLicenseForTheFirstTime(int LDL_AppID)
        {
            _LDL_AppID = LDL_AppID;
            InitializeComponent();
            this.Height += 130;
        }

        private void frmIssueDrivingLicenseForTheFirstTime_Load(object sender, EventArgs e)
        {
            ucDrivingLicenseAppInfo.FillApplicationInfo(_LDL_AppID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool IsExists = clsDriver.IsDriverExists(ucDrivingLicenseAppInfo.PersonID);

            if (!IsExists)
            {
                clsDriver Driver = new clsDriver();

                Driver.PersonID = ucDrivingLicenseAppInfo.PersonID;
                Driver.CreatedByUserID = ucDrivingLicenseAppInfo.CreByUserID;
                Driver.CreatedDate = DateTime.Now;

                _DriverID = Driver.Save();
            }

            clsLicense License = new clsLicense();

            License.ApplicationID = ucDrivingLicenseAppInfo.ApplicationID;
            if (IsExists)
            {
                int DriverID = clsDriver.FindByPersonID(ucDrivingLicenseAppInfo.PersonID).DriverID;
                License.DriverID = DriverID;
            }
            else
                License.DriverID = _DriverID;

            int LicenseClassID = clsLicenseClass.Find(ucDrivingLicenseAppInfo.DrivingClass).LicClassID;
            License.LicenseClass = LicenseClassID;
            License.IssueDate = DateTime.Now;

            if(LicenseClassID == 1 || LicenseClassID == 2)
                License.ExpDate = DateTime.Now.AddYears(5);
            else
                License.ExpDate = DateTime.Now.AddYears(10);

            License.Notes = tbNotes.Text.ToString();

            decimal ClassFees = clsLicenseClass.Find(LicenseClassID).ClassFees;
            License.PaidFees = ClassFees;

            License.IsActive = true;
            License.IssueReason = 1;
            License.CreatedByUserID = ucDrivingLicenseAppInfo.CreByUserID;

            if(License.Save())
            {
                MessageBox.Show("License Issued Successfully with License ID = " 
                    + License.LicenseID, "Succeeded", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            
        }

    }
}
