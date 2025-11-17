using System;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmTestsAppointments : Form
    {
        private int _LDL_AppID;
        private int _TestTypeID;
        public frmTestsAppointments(int LDL_AppID, int TestType)
        {
            _LDL_AppID = LDL_AppID;
            _TestTypeID = TestType;
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(790, 650);
        }

        private void _RefreshTestAppointmentsList()
        {
            dgvAppointments.DataSource = clsTestAppointment.GetAllPrvTestsAppointments(_LDL_AppID, _TestTypeID);

            int rowCount = dgvAppointments.Rows.Count;
            lbRecordNum.Text = rowCount.ToString();
        }

        private void frmVisionTestAppointments_Load(object sender, EventArgs e)
        {

            if (_TestTypeID == 1)
            {
                lbTestType.Text = "Vision Test Appointments";
                pbTestType.Image = Properties.Resources.vision_test_doc;
                this.Text = "Vision Test Appointments";
            } else if(_TestTypeID == 2)
            {
                lbTestType.Text = "Written Test Appointments";
                pbTestType.Image = Properties.Resources.ab_testing;
                this.Text = "Written Test Appointments";
            }
            else
            {
                lbTestType.Text = "Street Test Appointments";
                pbTestType.Image = Properties.Resources.street_test_01;
                this.Text = "Street Test Appointments";
            }

            ucDrivingLicenseAppInfo.FillApplicationInfo(_LDL_AppID);
            _RefreshTestAppointmentsList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddTestAppoi_Click(object sender, EventArgs e)
        {
            int LDL_AppID = ucDrivingLicenseAppInfo.LDLAppID;
            int PassedTest = clsLDLApp.Findvw(LDL_AppID).PassedTest;

            if(PassedTest == _TestTypeID)
            {
                MessageBox.Show("This person already passed this test before," +
                    " you can only retake faild test", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsTestAppointment TestAppoi = clsTestAppointment.FindByLDL_AppID(LDL_AppID, _TestTypeID, false);

            if(TestAppoi == null)
            {
                Form frmScheduleTest = new frmScheduleTest(ucDrivingLicenseAppInfo, _LDL_AppID, _TestTypeID, -1);
                frmScheduleTest.ShowDialog();
            }
            else
            {
                MessageBox.Show("Person already have an active appointment for" +
                    " this test, you cannot add new appointment", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmVisionTestAppointments_Activated(object sender, EventArgs e)
        {
            _RefreshTestAppointmentsList();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppoiID = Convert.ToInt32(dgvAppointments.CurrentRow.Cells[0].Value);

            clsTestAppointment TestAppointment = clsTestAppointment.Find(TestAppoiID);

            if(!TestAppointment.IsLocked)
            {
                Form frmTakeTest = new frmTakeTest(ucDrivingLicenseAppInfo, _LDL_AppID, _TestTypeID, TestAppoiID);
                frmTakeTest.ShowDialog();
            }
            else
                MessageBox.Show("The test has already been done.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppoiID = Convert.ToInt32(dgvAppointments.CurrentRow.Cells[0].Value);

            clsTestAppointment TestAppointment = clsTestAppointment.Find(TestAppoiID);

            if (!TestAppointment.IsLocked)
            {
                Form frmScheduleTest = new frmScheduleTest(ucDrivingLicenseAppInfo, _LDL_AppID, _TestTypeID, TestAppoiID);
                frmScheduleTest.ShowDialog();
            }
            else
                MessageBox.Show("You cannot edit this test appointment, The test has already been done.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
