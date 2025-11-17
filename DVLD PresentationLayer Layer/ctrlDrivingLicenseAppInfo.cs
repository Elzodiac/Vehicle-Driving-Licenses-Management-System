using System;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class ctrlDrivingLicenseAppInfo : UserControl
    {
        private int _PersonID = -1;

        public int LDLAppID { get; set; }
        public string DrivingClass { get; set; }
        public string FullName { get; set; }
        public int CreByUserID { get; set; }
        public int PersonID { get; set; }
        public int ApplicationID { get; set; }


        public ctrlDrivingLicenseAppInfo()
        {
            InitializeComponent();
        }

        private void ctrlDrivingLicenseAppInfo_Load(object sender, EventArgs e)
        {

        }

        public void FillApplicationInfo(int LDL_AppID)
        {
            lbDL_AppID.Text = LDL_AppID.ToString();
            this.LDLAppID = LDL_AppID;

            clsLDLApp LDLapp = clsLDLApp.Findvw(LDL_AppID);
            lbLicenseClass.Text = LDLapp.DrivingClass.ToString(); // 
            this.DrivingClass = lbLicenseClass.Text;
            lbPassedTests.Text = LDLapp.PassedTest.ToString();
            lbStatus.Text = LDLapp.StatusName.ToString();
            lbApplicant.Text = LDLapp.FullName.ToString(); // 
            this.FullName = lbApplicant.Text;

            clsLDLApp LDLapp2 = clsLDLApp.Find(LDL_AppID);
            lbID.Text = LDLapp2.AppID.ToString();

            int AppID = LDLapp2.AppID;
            ApplicationID = AppID;

            clsApplications Appli = clsApplications.Find(AppID);
            lbFees.Text = Appli.PaidFees.ToString();
            lbDate.Text = Appli.AppDate.ToString("yyyy-MM-dd");
            lbStatusDate.Text = Appli.LastStatusDate.ToString("yyyy-MM-dd");
            lbCreatedBy.Text = clsUser.Find(Appli.CreaByUserID).Username.ToString();
            clsUser User = clsUser.Find(lbCreatedBy.Text.ToString());
            this.CreByUserID = User.ID;
            _PersonID = Appli.AppPersonID;
            this.PersonID = _PersonID;

            clsApplicationType AppType = clsApplicationType.Find(Appli.AppTypeID);
            lbType.Text = AppType.Title.ToString();


        }

        private void llbViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_PersonID != -1)
            {
                Form PersonInfo = new frmPersonDetails(_PersonID);
                PersonInfo.ShowDialog();
            }
        }

        private void llbShowLicInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsLicense.IsLicenseExistsByAppliID(clsLDLApp.Find(LDLAppID).AppID);
            if (clsLicense.IsLicenseExistsByAppliID(clsLDLApp.Find(LDLAppID).AppID))
            {
                clsLDLApp lDLApp = clsLDLApp.Find(LDLAppID);
                clsLicense License = clsLicense.FindByAppID(lDLApp.AppID);
            Form frmShowLicense = new frmShowDriverLicense(License);
            frmShowLicense.ShowDialog();
            }else
                MessageBox.Show("There is no License to show",
                    "License not Exists", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
    }
}
