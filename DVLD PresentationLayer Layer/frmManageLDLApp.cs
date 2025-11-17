using System;
using System.Data;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmManageLDLApp : Form
    {
        private int _UserID; 
        public frmManageLDLApp(int UserID)
        {
            _UserID = UserID;
            InitializeComponent();
        }

        private void _RefreshLDLAppList()
        {
            dgvGetLDLApp.DataSource = clsLDLApp.GetAllLDLApp();

            int rowCount = dgvGetLDLApp.Rows.Count;
            lbRecordNum.Text = rowCount.ToString();
        } // 

        private void frmManageLDLApp_Load(object sender, EventArgs e)
        {
            _RefreshLDLAppList();
            cbFilterBy.SelectedIndex = 0;
        } ////

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        } //

        private void btnAddLDLApp_Click(object sender, EventArgs e)
        {
            Form frmAddAndEditLDLApp = new frmAddAndEditLDLApp(_UserID, -1);
            frmAddAndEditLDLApp.ShowDialog();
            _RefreshLDLAppList();
        } //

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedItem.ToString() != "None")
            {
                tbFilterBy.Visible = true;
                tbFilterBy.Focus();
                tbFilterBy.Text = "";
            }
            else
                tbFilterBy.Visible = false;

            if (cbFilterBy.SelectedIndex == 0)
                _RefreshLDLAppList();
        } //

        private void tbFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cbFilterBy.SelectedIndex)
            {
                case 1:
                    if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                        e.Handled = true;
                    break;
                case 2:
                    if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                        e.Handled = true;
                    break;
                case 3:
                case 4:
                    if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                        e.Handled = true;
                    break;
            }
        } //

        private void tbFilterBy_TextChanged(object sender, EventArgs e)
        {
            DataTable dtLDL_App = clsLDLApp.GetAllLDLApp();

            if (string.IsNullOrEmpty(tbFilterBy.Text.Trim()))
            {
                _RefreshLDLAppList();
                return;
            }

            string FilterExpression = "";

            switch (cbFilterBy.SelectedIndex)
            {
                case 1:
                    int LDL_AppID = int.Parse(tbFilterBy.Text);
                    FilterExpression = $"LDL_AppID = {LDL_AppID}";
                    break;
                case 2:
                    string NationalNo = tbFilterBy.Text.Trim();
                    FilterExpression = $"NationalNo = '{NationalNo}'";
                    break;
                case 3:
                    string FullName = tbFilterBy.Text.Trim();
                    FilterExpression = $"FullName = '{FullName}'";
                    break;
                case 4:
                    string StatusName = tbFilterBy.Text.Trim();
                    FilterExpression = $"StatusName = '{StatusName}'";
                    break;
            }

            DataView dv = new DataView(dtLDL_App);
            dv.RowFilter = FilterExpression;
            dgvGetLDLApp.DataSource = dv;

            int rowCount = dgvGetLDLApp.Rows.Count;
            lbRecordNum.Text = rowCount.ToString();

        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDL_AppID = (int)dgvGetLDLApp.CurrentRow.Cells[0].Value;

            Form frmVisionTestAppoi = new frmTestsAppointments(LDL_AppID, 3);
            frmVisionTestAppoi.ShowDialog();
        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int LDL_AppID = (int)dgvGetLDLApp.CurrentRow.Cells[0].Value;

            Form frmVisionTestAppoi = new frmTestsAppointments(LDL_AppID, 1);
            frmVisionTestAppoi.ShowDialog();
            
        }

        private void dgvGetLDLApp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                string ApplicationStatus = (string)dgvGetLDLApp.CurrentRow.Cells[6].Value;

                if (ApplicationStatus != "New")
                {
                    tsmiScheduleVisionTest.Enabled = false;
                    tsmiScheduleWrittenTest.Enabled = false;
                    tsmiScheduleStreetTest.Enabled = false;

                    if(ApplicationStatus == "Completed")
                    {
                         int LDL_AppID = (int)dgvGetLDLApp.CurrentRow.Cells[0].Value;

                        int AppliID = clsLDLApp.Find(LDL_AppID).AppID;
                        bool IsExists = clsLicense.IsLicenseExistsByAppliID(AppliID);

                        tsmiShowAppliDetails.Enabled = true;
                        tsmiEditAppli.Enabled = true;
                        tsmiDeleteAppli.Enabled = true;
                        tsmiCancelAppli.Enabled = true;
                        tsmiScheduleTests.Enabled = true;
                        tsmiIssueDrivingLicenseFirstTime.Enabled = true;
                        tsmiShowLicense.Enabled = true;

                        if (IsExists)
                        {
                            tsmiEditAppli.Enabled = false;
                            tsmiDeleteAppli.Enabled = false;
                            tsmiCancelAppli.Enabled = false;
                            tsmiScheduleTests.Enabled = false;
                            tsmiIssueDrivingLicenseFirstTime.Enabled = false;
                        }
                        else
                        {
                            tsmiEditAppli.Enabled = false;
                            tsmiDeleteAppli.Enabled = false;
                            tsmiCancelAppli.Enabled = false;
                            tsmiScheduleTests.Enabled = false;
                            tsmiShowLicense.Enabled = false;
                        }
                    }
                    else
                    {
                        tsmiShowAppliDetails.Enabled = false;
                        tsmiEditAppli.Enabled = false;
                        tsmiCancelAppli.Enabled = false;
                        tsmiScheduleTests.Enabled = false;
                        tsmiIssueDrivingLicenseFirstTime.Enabled = false;
                        tsmiShowLicense.Enabled = false;
                    }
                }
                else
                {
                    tsmiScheduleVisionTest.Enabled = false;
                    tsmiScheduleWrittenTest.Enabled = false;
                    tsmiScheduleStreetTest.Enabled = false;

                    tsmiShowAppliDetails.Enabled = true;
                    
                    int PassedTest = (int)dgvGetLDLApp.CurrentRow.Cells[5].Value;
                    if (PassedTest == 0)
                    {
                        tsmiDeleteAppli.Enabled = true;
                        tsmiCancelAppli.Enabled = true;
                        tsmiEditAppli.Enabled = true;
                    }
                    else
                    {
                        tsmiDeleteAppli.Enabled = false;
                        tsmiCancelAppli.Enabled = false;
                        tsmiEditAppli.Enabled = false;
                    }
                    tsmiScheduleTests.Enabled = true;
                    tsmiIssueDrivingLicenseFirstTime.Enabled = false;
                    tsmiShowLicense.Enabled = false;
                    tsmiShowPersonLicenseHistory.Enabled = true;

                    int TestPassed = (int)dgvGetLDLApp.CurrentRow.Cells[5].Value;

                    if (TestPassed == 0)
                        tsmiScheduleVisionTest.Enabled = true;
                    else if (TestPassed == 1)
                        tsmiScheduleWrittenTest.Enabled = true;
                    else if (TestPassed == 2)
                        tsmiScheduleStreetTest.Enabled = true;
                }
            }
        }

        private void frmManageLDLApp_Activated(object sender, EventArgs e)
        {
            _RefreshLDLAppList();
        }

        private void tsmiScheduleWrittenTest_Click(object sender, EventArgs e)
        {
            int LDL_AppID = (int)dgvGetLDLApp.CurrentRow.Cells[0].Value;

            Form frmVisionTestAppoi = new frmTestsAppointments(LDL_AppID, 2);
            frmVisionTestAppoi.ShowDialog();
        }

        private void isseuDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDL_AppID = (int)dgvGetLDLApp.CurrentRow.Cells[0].Value;

            Form frmIsseuDrivigLicense = new frmIssueDrivingLicenseForTheFirstTime(LDL_AppID);
            frmIsseuDrivigLicense.ShowDialog();
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDL_AppID = (int)dgvGetLDLApp.CurrentRow.Cells[0].Value;

            int ApplicationID = clsLDLApp.Find(LDL_AppID).AppID;
            clsApplications Application = clsApplications.Find(ApplicationID);

            Application.AppStatusID = 3;

            if(Application.Save())
            {
                MessageBox.Show("Application Cancelled Successfully.",
                        "Cancelled", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDL_AppID = (int)dgvGetLDLApp.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure do want to delete this application?",
                "Confirm", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                == DialogResult.OK) 
            {
                if(clsLDLApp.DeleteLDLApp(LDL_AppID) && clsApplications.DeleteApplication(LDL_AppID))
                    MessageBox.Show("Application Deleted Successfully.",
                        "Deleted", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }

        private void tsmiShowLicense_Click(object sender, EventArgs e)
        {
            int LDL_AppID = (int)dgvGetLDLApp.CurrentRow.Cells[0].Value;
            clsLDLApp lDLApp = clsLDLApp.Find(LDL_AppID);
            clsLicense License = clsLicense.FindByAppID(lDLApp.AppID);

            Form frmShowLicense = new frmShowDriverLicense(License);
            frmShowLicense.ShowDialog();
        }

        private void tsmiShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            string PersonNo = (string)dgvGetLDLApp.CurrentRow.Cells[2].Value;

            Form frmLicensesHistory = new frmLicensesHistory(PersonNo);
            frmLicensesHistory.ShowDialog();
        }

        private void tsmiEditAppli_Click(object sender, EventArgs e)
        {
            int LDL_AppID = (int)dgvGetLDLApp.CurrentRow.Cells[0].Value;

            Form frmAddAndEditLDLApp = new frmAddAndEditLDLApp(_UserID, LDL_AppID);
            frmAddAndEditLDLApp.ShowDialog();
            _RefreshLDLAppList();
        }

        private void tsmiShowAppliDetails_Click(object sender, EventArgs e)
        {
            int LDL_AppID = (int)dgvGetLDLApp.CurrentRow.Cells[0].Value;

            Form frmShowAppliDetails = new frmShowApplicationDetails(LDL_AppID);
            frmShowAppliDetails.ShowDialog();
        }
    }
}
