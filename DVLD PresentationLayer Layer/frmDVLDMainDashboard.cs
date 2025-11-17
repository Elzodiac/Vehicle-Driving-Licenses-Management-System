using System;
using System.Drawing;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_Proj
{
    public partial class frmDVLDMainDashboard : Form
    {

        private clsUser _User;
        public frmDVLDMainDashboard(clsUser User)
        {
            _User = User;

            InitializeComponent();
        }

            private Panel GetParentPanel(Control ctrl)
            {
                if (ctrl is Panel)
                    return ctrl as Panel;
                else
                    return ctrl.Parent as Panel;
            }
            private void MouseEnterChangeColor(object sender, EventArgs e)
            {
                Panel parentPanel = GetParentPanel(sender as Control);

                if (parentPanel != null)
                {
                    parentPanel.BackColor = Color.Lavender;
                }
            }
            private void MouseLeaveResetColor(object sender, EventArgs e)
            {
                Panel parentPanel = GetParentPanel(sender as Control);

                if (parentPanel != null)
                {
                    parentPanel.BackColor = Color.WhiteSmoke;
                }
            }

            private void frmDVLDMainDashboard_Load(object sender, EventArgs e)
            {
                foreach (Control ctrl in pnlBar.Controls)
                {
                    if (ctrl is Panel panel)
                    {
                        panel.MouseEnter += MouseEnterChangeColor;
                        panel.MouseLeave += MouseLeaveResetColor;


                        foreach (Control child in panel.Controls)
                        {
                            child.MouseEnter += MouseEnterChangeColor;
                            child.MouseLeave += MouseLeaveResetColor;
                        }
                    }
                }

                foreach (Control ctrl in pnlPeople.Controls)
                {
                    ctrl.Click += pnlPeople_Click;
                }

                foreach (Control ctrl in pnlAccountSettings.Controls)
                {
                   ctrl.Click += pnlAccountSettings_Click;
                }

                foreach (Control ctrl in pnlUsers.Controls)
                {
                    ctrl.Click += pnlUsers_Click;
                }

                foreach (Control ctrl in pnlAppli.Controls)
                {
                    ctrl.Click += pnlAppli_Click;
                }

                foreach (Control ctrl in pnlDrivers.Controls)
                {
                    ctrl.Click += pnlDrivers_Click;
                }

        }

            private void pnlPeople_Click(object sender, EventArgs e)
            {
                Form frmManagePeopole = new frmManagePeople();
                frmManagePeopole.ShowDialog();
            }

        private void pnlAccountSettings_Click(object sender, EventArgs e)
        {
            Point location = pnlAccountSettings.PointToScreen(new Point(0, pnlAccountSettings.Height));
            cmsAccountSett.Show(location);
        }

        private void tsmiSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void pnlUsers_Click(object sender, EventArgs e)
        {
            Form frmManageUsers = new frmManageUsers();
            frmManageUsers.ShowDialog();
        }

        private void tsmiChangePassword_Click(object sender, EventArgs e)
        {
            Form frmChangePassword = new frmChangePassword(_User);
            frmChangePassword.ShowDialog();
        }

        private void tsmiCurrentUserInfo_Click(object sender, EventArgs e)
        {
            Form frmUserInfo = new frmUserInfo(_User.PersonID, _User.ID);
            frmUserInfo.ShowDialog();
        }

        private void pnlAppli_Click(object sender, EventArgs e)
        {
            Point location = pnlAppli.PointToScreen(new Point(0, pnlAppli.Height));
            cmsApplications.Show(location);
        }

        private void tsmiManageAppTypes_Click(object sender, EventArgs e)
        {
            Form frmManageAppTypes = new frmManageApplicationTypes();
            frmManageAppTypes.ShowDialog();
        }

        private void tsmiManageTestTypes_Click(object sender, EventArgs e)
        {
            Form frmManageTestTypes = new frmManageTestTypes();
            frmManageTestTypes.ShowDialog();
        }

        private void tsmiLocalLicense_Click(object sender, EventArgs e)
        {
            Form frmNewLocalLicense = new frmAddAndEditLDLApp(_User.ID, -1);
            frmNewLocalLicense.ShowDialog();
        }

        private void localDrivigLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmManageLDLApp = new frmManageLDLApp(_User.ID);
            frmManageLDLApp.ShowDialog();
        }

        private void pnlDrivers_Click(object sender, EventArgs e)
        {
            Form frmDrivers = new frmDriversList();
            frmDrivers.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmInterLicenseApp = new frmInternationalLicenseApplication(_User);
            frmInterLicenseApp.ShowDialog();
        }

        private void internationalLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmManageIntLicensesApp = new frmManageInternationalLicenseApplications(_User);
            frmManageIntLicensesApp.ShowDialog();
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmRenewLicense = new frmRenewLicenseApplication(_User);
            frmRenewLicense.ShowDialog();
        }

        private void replacementForToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmRepDamageOrLostLicense = new frmReplacementForDamagedOrLostLicense(_User);
            frmRepDamageOrLostLicense.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDetainLic = new frmDetainLicense(_User);
            frmDetainLic.ShowDialog();
        }

        private void releaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmReleaseDeLic = new frmReleaseDetainedLicense(_User);
            frmReleaseDeLic.ShowDialog();
        }

        private void manageDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmManageDetainedLicenses = new frmManageDetainedLicenses(_User);
            frmManageDetainedLicenses.ShowDialog();
        }

        private void releaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmReleaseDeLic = new frmReleaseDetainedLicense(_User);
            frmReleaseDeLic.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmManageLDLApp = new frmManageLDLApp(_User.ID);
            frmManageLDLApp.ShowDialog();
        }

    }
}
