using System;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmScheduleTest : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        private ctrlDrivingLicenseAppInfo _uc;
        private int _LDL_AppID, _TestTypeID, _Trial, _TestAppoinID;
        private clsTestAppointment _TestAppoin;


        public frmScheduleTest(ctrlDrivingLicenseAppInfo ucDriLicAppliInfo, int LDL_AppID, int TestTypeID, int TestAppoinID)
        {
            _LDL_AppID = LDL_AppID;
            _TestTypeID = TestTypeID;
            _TestAppoinID = TestAppoinID;

            if (TestAppoinID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

            InitializeComponent();
            _uc = ucDriLicAppliInfo;
            this.Height += 80;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            if(_TestTypeID == 1)
            {
                pbScheduleTest.Image = Properties.Resources.vision_test_doc;
                gbTestsType.Text = "Vision Test";
            }
            else if(_TestTypeID == 2)
            {
                pbScheduleTest.Image = Properties.Resources.ab_testing;
                gbTestsType.Text = "Written Test";
            }
            else
            {
                pbScheduleTest.Image = Properties.Resources.street_test_01;
                gbTestsType.Text = "Street Test";
            }

            if (_Mode == enMode.AddNew)
            {
                _TestAppoin = new clsTestAppointment();
            }
            else
            {
                _TestAppoin = clsTestAppointment.Find(_TestAppoinID);
            }


            lbLDL_AppID.Text = _uc.LDLAppID.ToString();
            lbDrivingClass.Text = _uc.DrivingClass.ToString();
            lbFullName.Text = _uc.FullName.ToString();
            lbPaidFees.Text = clsTestType.Find(_TestTypeID).Fees.ToString();

            clsTestAppointment TestAppoi = clsTestAppointment.FindByLDL_AppID(_LDL_AppID, _TestTypeID, true); // > trial
            if (TestAppoi == null)
                lbTrial.Text = 0.ToString();
            else
            {
                lbScheduleTest.Text = "Schedule Retake Test";
                gpRetakeTestInfo.Enabled = true;
                decimal TotalFees = decimal.Parse(lbPaidFees.Text) + decimal.Parse(lbRetakeTestFees.Text);
                lbTotalFees.Text = TotalFees.ToString();
                lbRetakeTestAppID.Text = _TestAppoinID.ToString();
                lbRetakeTestFees.Text = clsTestType.Find(_TestTypeID).RetakeTestFees.ToString();

                lbTrial.Text = TestAppoi.Trial.ToString();
                _Trial = TestAppoi.Trial;
            }
                

            DateTime Today = DateTime.Now;
            dtpTestDate.MinDate = Today;
    }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
            _TestAppoin.TestTypeID = _TestTypeID;
            _TestAppoin.LDL_AppID = int.Parse(lbLDL_AppID.Text);
            _TestAppoin.AppoinDate = dtpTestDate.Value;
            _TestAppoin.PaidFees = clsTestType.Find(_TestTypeID).Fees;
            _TestAppoin.CreaByUserID = _uc.CreByUserID;
            _TestAppoin.IsLocked = false;
            _TestAppoin.Trial = _Trial + 1;

            if (lbScheduleTest.Text == "Schedule Retake Test")
            {
                clsApplications Application = new clsApplications();
                clsLDLApp LDL_App = clsLDLApp.Find(_LDL_AppID);
                clsApplications App = clsApplications.Find(LDL_App.AppID);

                Application.AppPersonID = App.AppPersonID;
                Application.AppDate = DateTime.Now;
                Application.AppTypeID = 8;
                Application.AppStatusID = 1;
                Application.LastStatusDate = DateTime.Now;
                Application.PaidFees = 7;
                Application.CreaByUserID = _uc.CreByUserID;

                Application.Save();

                _TestAppoin.RetakeTestAppID = Application.AppID;
                lbRetakeTestAppID.Text = Application.AppID.ToString();

            }


            if (_TestAppoin.Save())
                MessageBox.Show("Data Saved Successfully.");
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.");
        }
    }
}
