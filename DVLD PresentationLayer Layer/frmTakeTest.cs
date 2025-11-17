using System;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmTakeTest : Form
    {
        private ctrlDrivingLicenseAppInfo _uc;
        private int _LDL_AppID, _TestTypeID, _TestAppoiID;
        public frmTakeTest(ctrlDrivingLicenseAppInfo ucDriLicAppliInfo, int LDL_AppID, int TestTypeID, int TestAppoiID)
        {
            InitializeComponent();
            _LDL_AppID = LDL_AppID;
            _TestTypeID = TestTypeID;
            _TestAppoiID = TestAppoiID;
            _uc = ucDriLicAppliInfo;
            this.Height += 160;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                clsTest Test = new clsTest();

                Test.TestAppointmentID = _TestAppoiID;
                Test.TestResult = rbPass.Checked ? true : false; // after completed for all tests >> com back and fix if there any error
                Test.Notes = tbNotes.Text.ToString();
                Test.CreatedByUserID = _uc.CreByUserID;

                clsTestAppointment TestAppoi = clsTestAppointment.Find(_TestAppoiID);
                TestAppoi.IsLocked = true;
                TestAppoi.Save();

                
                if (Test.Save())
                    MessageBox.Show("Data Saved Successfully.");
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.");

                // after completed for all tests >> com back and fix if there any error
                int ApplicationID = clsLDLApp.Find(_LDL_AppID).AppID;
                clsApplications Application = clsApplications.Find(ApplicationID);

                clsLDLApp LDL_App = clsLDLApp.Findvw(_LDL_AppID);

                if (LDL_App.PassedTest == 3)
                {
                    Application.AppStatusID = 2;
                    Application.LastStatusDate = DateTime.Now;
                    Application.Save();
                }

            }

        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            if(_TestTypeID == 1)
            {
                pbScheduleTest.Image = Properties.Resources.vision_test_doc;
                gbScheduleTest.Text = "Vision Test";
            }else if(_TestTypeID == 2)
            {
                pbScheduleTest.Image = Properties.Resources.ab_testing;
                gbScheduleTest.Text = "Written Test";
            }
            else
            {
                pbScheduleTest.Image = Properties.Resources.street_test_01;
                gbScheduleTest.Text = "Street Test";
            }

                lbLDL_AppID.Text = _uc.LDLAppID.ToString();
            lbDrivingClass.Text = _uc.DrivingClass.ToString();
            lbFullName.Text = _uc.FullName.ToString();
            decimal Fees = clsTestType.Find(_TestTypeID).Fees;
            lbPaidFees.Text = Fees.ToString();

            clsTestAppointment TestAppoi = clsTestAppointment.FindByLDL_AppID(_LDL_AppID, _TestTypeID, true); // > trial
            if (TestAppoi == null)
                lbTrial.Text = 0.ToString();
            else
                lbTrial.Text = TestAppoi.Trial.ToString();

            DateTime Today = DateTime.Now;
            lbDate.Text = Today.ToString();
        }
    }
}
