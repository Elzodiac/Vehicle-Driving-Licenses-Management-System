namespace DVLD_Proj
{
    partial class frmDVLDMainDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.pnlAccountSettings = new System.Windows.Forms.Panel();
            this.cmsAccountSett = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.pbAccountSettings = new System.Windows.Forms.PictureBox();
            this.lbAccountSettings = new System.Windows.Forms.Label();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.pbUsers = new System.Windows.Forms.PictureBox();
            this.lbUsers = new System.Windows.Forms.Label();
            this.pnlDrivers = new System.Windows.Forms.Panel();
            this.pbDrivers = new System.Windows.Forms.PictureBox();
            this.lbDrivers = new System.Windows.Forms.Label();
            this.pnlAppli = new System.Windows.Forms.Panel();
            this.pbAppli = new System.Windows.Forms.PictureBox();
            this.lbApplications = new System.Windows.Forms.Label();
            this.pnlPeople = new System.Windows.Forms.Panel();
            this.pbpeople = new System.Windows.Forms.PictureBox();
            this.lbpeople = new System.Windows.Forms.Label();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDriving = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLocalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacementForToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageApp = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivigLicenseApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiDetainLice = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageAppTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBar.SuspendLayout();
            this.pnlAccountSettings.SuspendLayout();
            this.cmsAccountSett.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccountSettings)).BeginInit();
            this.pnlUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).BeginInit();
            this.pnlDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrivers)).BeginInit();
            this.pnlAppli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppli)).BeginInit();
            this.pnlPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpeople)).BeginInit();
            this.cmsApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBar.Controls.Add(this.pnlAccountSettings);
            this.pnlBar.Controls.Add(this.pnlUsers);
            this.pnlBar.Controls.Add(this.pnlDrivers);
            this.pnlBar.Controls.Add(this.pnlAppli);
            this.pnlBar.Controls.Add(this.pnlPeople);
            this.pnlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBar.Location = new System.Drawing.Point(0, 0);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(1451, 79);
            this.pnlBar.TabIndex = 0;
            // 
            // pnlAccountSettings
            // 
            this.pnlAccountSettings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAccountSettings.ContextMenuStrip = this.cmsAccountSett;
            this.pnlAccountSettings.Controls.Add(this.pbAccountSettings);
            this.pnlAccountSettings.Controls.Add(this.lbAccountSettings);
            this.pnlAccountSettings.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlAccountSettings.Location = new System.Drawing.Point(689, 4);
            this.pnlAccountSettings.Name = "pnlAccountSettings";
            this.pnlAccountSettings.Size = new System.Drawing.Size(254, 74);
            this.pnlAccountSettings.TabIndex = 4;
            this.pnlAccountSettings.Click += new System.EventHandler(this.pnlAccountSettings_Click);
            // 
            // cmsAccountSett
            // 
            this.cmsAccountSett.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsAccountSett.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsAccountSett.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCurrentUserInfo,
            this.tsmiChangePassword,
            this.tsmiSignOut});
            this.cmsAccountSett.Name = "cmsAccountSett";
            this.cmsAccountSett.Size = new System.Drawing.Size(253, 106);
            // 
            // tsmiCurrentUserInfo
            // 
            this.tsmiCurrentUserInfo.Image = global::DVLD_Proj.Properties.Resources.user_info;
            this.tsmiCurrentUserInfo.Name = "tsmiCurrentUserInfo";
            this.tsmiCurrentUserInfo.Size = new System.Drawing.Size(252, 34);
            this.tsmiCurrentUserInfo.Text = "Current User Info";
            this.tsmiCurrentUserInfo.Click += new System.EventHandler(this.tsmiCurrentUserInfo_Click);
            // 
            // tsmiChangePassword
            // 
            this.tsmiChangePassword.Image = global::DVLD_Proj.Properties.Resources.Change_password;
            this.tsmiChangePassword.Name = "tsmiChangePassword";
            this.tsmiChangePassword.Size = new System.Drawing.Size(252, 34);
            this.tsmiChangePassword.Text = "Change Password";
            this.tsmiChangePassword.Click += new System.EventHandler(this.tsmiChangePassword_Click);
            // 
            // tsmiSignOut
            // 
            this.tsmiSignOut.Image = global::DVLD_Proj.Properties.Resources.logout;
            this.tsmiSignOut.Name = "tsmiSignOut";
            this.tsmiSignOut.Size = new System.Drawing.Size(252, 34);
            this.tsmiSignOut.Text = "Sign Out";
            this.tsmiSignOut.Click += new System.EventHandler(this.tsmiSignOut_Click);
            // 
            // pbAccountSettings
            // 
            this.pbAccountSettings.Image = global::DVLD_Proj.Properties.Resources.accou_settings;
            this.pbAccountSettings.Location = new System.Drawing.Point(3, 6);
            this.pbAccountSettings.Name = "pbAccountSettings";
            this.pbAccountSettings.Size = new System.Drawing.Size(70, 62);
            this.pbAccountSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAccountSettings.TabIndex = 1;
            this.pbAccountSettings.TabStop = false;
            // 
            // lbAccountSettings
            // 
            this.lbAccountSettings.AutoSize = true;
            this.lbAccountSettings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountSettings.Location = new System.Drawing.Point(76, 29);
            this.lbAccountSettings.Name = "lbAccountSettings";
            this.lbAccountSettings.Size = new System.Drawing.Size(176, 23);
            this.lbAccountSettings.TabIndex = 1;
            this.lbAccountSettings.Text = "Account Settings";
            // 
            // pnlUsers
            // 
            this.pnlUsers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlUsers.Controls.Add(this.pbUsers);
            this.pnlUsers.Controls.Add(this.lbUsers);
            this.pnlUsers.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlUsers.Location = new System.Drawing.Point(542, 4);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(146, 74);
            this.pnlUsers.TabIndex = 3;
            this.pnlUsers.Click += new System.EventHandler(this.pnlUsers_Click);
            // 
            // pbUsers
            // 
            this.pbUsers.Image = global::DVLD_Proj.Properties.Resources.users;
            this.pbUsers.Location = new System.Drawing.Point(3, 6);
            this.pbUsers.Name = "pbUsers";
            this.pbUsers.Size = new System.Drawing.Size(70, 62);
            this.pbUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsers.TabIndex = 1;
            this.pbUsers.TabStop = false;
            // 
            // lbUsers
            // 
            this.lbUsers.AutoSize = true;
            this.lbUsers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsers.Location = new System.Drawing.Point(76, 29);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(68, 23);
            this.lbUsers.TabIndex = 1;
            this.lbUsers.Text = "Users";
            // 
            // pnlDrivers
            // 
            this.pnlDrivers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDrivers.Controls.Add(this.pbDrivers);
            this.pnlDrivers.Controls.Add(this.lbDrivers);
            this.pnlDrivers.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlDrivers.Location = new System.Drawing.Point(380, 3);
            this.pnlDrivers.Name = "pnlDrivers";
            this.pnlDrivers.Size = new System.Drawing.Size(160, 74);
            this.pnlDrivers.TabIndex = 2;
            this.pnlDrivers.Click += new System.EventHandler(this.pnlDrivers_Click);
            // 
            // pbDrivers
            // 
            this.pbDrivers.Image = global::DVLD_Proj.Properties.Resources.output_onlinepngtools;
            this.pbDrivers.Location = new System.Drawing.Point(3, 6);
            this.pbDrivers.Name = "pbDrivers";
            this.pbDrivers.Size = new System.Drawing.Size(70, 62);
            this.pbDrivers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDrivers.TabIndex = 1;
            this.pbDrivers.TabStop = false;
            // 
            // lbDrivers
            // 
            this.lbDrivers.AutoSize = true;
            this.lbDrivers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDrivers.Location = new System.Drawing.Point(76, 29);
            this.lbDrivers.Name = "lbDrivers";
            this.lbDrivers.Size = new System.Drawing.Size(82, 23);
            this.lbDrivers.TabIndex = 1;
            this.lbDrivers.Text = "Drivers";
            // 
            // pnlAppli
            // 
            this.pnlAppli.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAppli.Controls.Add(this.pbAppli);
            this.pnlAppli.Controls.Add(this.lbApplications);
            this.pnlAppli.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlAppli.Location = new System.Drawing.Point(3, 3);
            this.pnlAppli.Name = "pnlAppli";
            this.pnlAppli.Size = new System.Drawing.Size(213, 74);
            this.pnlAppli.TabIndex = 2;
            this.pnlAppli.Click += new System.EventHandler(this.pnlAppli_Click);
            // 
            // pbAppli
            // 
            this.pbAppli.Image = global::DVLD_Proj.Properties.Resources.application_list;
            this.pbAppli.Location = new System.Drawing.Point(3, 6);
            this.pbAppli.Name = "pbAppli";
            this.pbAppli.Size = new System.Drawing.Size(70, 62);
            this.pbAppli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAppli.TabIndex = 1;
            this.pbAppli.TabStop = false;
            // 
            // lbApplications
            // 
            this.lbApplications.AutoSize = true;
            this.lbApplications.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplications.Location = new System.Drawing.Point(76, 29);
            this.lbApplications.Name = "lbApplications";
            this.lbApplications.Size = new System.Drawing.Size(131, 23);
            this.lbApplications.TabIndex = 1;
            this.lbApplications.Text = "Applications";
            // 
            // pnlPeople
            // 
            this.pnlPeople.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPeople.Controls.Add(this.pbpeople);
            this.pnlPeople.Controls.Add(this.lbpeople);
            this.pnlPeople.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlPeople.Location = new System.Drawing.Point(218, 3);
            this.pnlPeople.Name = "pnlPeople";
            this.pnlPeople.Size = new System.Drawing.Size(160, 74);
            this.pnlPeople.TabIndex = 1;
            this.pnlPeople.Click += new System.EventHandler(this.pnlPeople_Click);
            // 
            // pbpeople
            // 
            this.pbpeople.Image = global::DVLD_Proj.Properties.Resources.demographic__2_;
            this.pbpeople.Location = new System.Drawing.Point(3, 6);
            this.pbpeople.Name = "pbpeople";
            this.pbpeople.Size = new System.Drawing.Size(70, 62);
            this.pbpeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpeople.TabIndex = 1;
            this.pbpeople.TabStop = false;
            // 
            // lbpeople
            // 
            this.lbpeople.AutoSize = true;
            this.lbpeople.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpeople.Location = new System.Drawing.Point(76, 29);
            this.lbpeople.Name = "lbpeople";
            this.lbpeople.Size = new System.Drawing.Size(77, 23);
            this.lbpeople.TabIndex = 1;
            this.lbpeople.Text = "People";
            // 
            // cmsApplications
            // 
            this.cmsApplications.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsApplications.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDriving,
            this.tsmiManageApp,
            this.tmsiDetainLice,
            this.tsmiManageAppTypes,
            this.tsmiManageTestTypes});
            this.cmsApplications.Name = "cmsApplications";
            this.cmsApplications.Size = new System.Drawing.Size(332, 174);
            // 
            // tsmiDriving
            // 
            this.tsmiDriving.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.reToolStripMenuItem,
            this.replacementForToolStripMenuItem,
            this.releaseToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.tsmiDriving.Image = global::DVLD_Proj.Properties.Resources.drivers_license;
            this.tsmiDriving.Name = "tsmiDriving";
            this.tsmiDriving.Size = new System.Drawing.Size(331, 34);
            this.tsmiDriving.Text = "Driving Licenses Servises";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLocalLicense,
            this.internationalLicenseToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Image = global::DVLD_Proj.Properties.Resources.New_driving_license;
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(498, 36);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // tsmiLocalLicense
            // 
            this.tsmiLocalLicense.Image = global::DVLD_Proj.Properties.Resources.local;
            this.tsmiLocalLicense.Name = "tsmiLocalLicense";
            this.tsmiLocalLicense.Size = new System.Drawing.Size(303, 36);
            this.tsmiLocalLicense.Text = "Local License";
            this.tsmiLocalLicense.Click += new System.EventHandler(this.tsmiLocalLicense_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Image = global::DVLD_Proj.Properties.Resources.global;
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(303, 36);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            this.internationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem_Click);
            // 
            // reToolStripMenuItem
            // 
            this.reToolStripMenuItem.Image = global::DVLD_Proj.Properties.Resources.renew_drive_lic__1_;
            this.reToolStripMenuItem.Name = "reToolStripMenuItem";
            this.reToolStripMenuItem.Size = new System.Drawing.Size(498, 36);
            this.reToolStripMenuItem.Text = "Renew Driving License";
            this.reToolStripMenuItem.Click += new System.EventHandler(this.reToolStripMenuItem_Click);
            // 
            // replacementForToolStripMenuItem
            // 
            this.replacementForToolStripMenuItem.Image = global::DVLD_Proj.Properties.Resources.Rep_Driving_licen_lost;
            this.replacementForToolStripMenuItem.Name = "replacementForToolStripMenuItem";
            this.replacementForToolStripMenuItem.Size = new System.Drawing.Size(498, 36);
            this.replacementForToolStripMenuItem.Text = "Replacement  For Lost Or Damage License";
            this.replacementForToolStripMenuItem.Click += new System.EventHandler(this.replacementForToolStripMenuItem_Click);
            // 
            // releaseToolStripMenuItem
            // 
            this.releaseToolStripMenuItem.Image = global::DVLD_Proj.Properties.Resources.hand_give;
            this.releaseToolStripMenuItem.Name = "releaseToolStripMenuItem";
            this.releaseToolStripMenuItem.Size = new System.Drawing.Size(498, 36);
            this.releaseToolStripMenuItem.Text = "Release Detained Driving License";
            this.releaseToolStripMenuItem.Click += new System.EventHandler(this.releaseToolStripMenuItem_Click);
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Image = global::DVLD_Proj.Properties.Resources.Retest;
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(498, 36);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            this.retakeTestToolStripMenuItem.Click += new System.EventHandler(this.retakeTestToolStripMenuItem_Click);
            // 
            // tsmiManageApp
            // 
            this.tsmiManageApp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivigLicenseApplicationToolStripMenuItem,
            this.internationalLicenseApplicationToolStripMenuItem});
            this.tsmiManageApp.Image = global::DVLD_Proj.Properties.Resources.application;
            this.tsmiManageApp.Name = "tsmiManageApp";
            this.tsmiManageApp.Size = new System.Drawing.Size(331, 34);
            this.tsmiManageApp.Text = "Manage Applications";
            // 
            // localDrivigLicenseApplicationToolStripMenuItem
            // 
            this.localDrivigLicenseApplicationToolStripMenuItem.Image = global::DVLD_Proj.Properties.Resources.Mana_Local_License;
            this.localDrivigLicenseApplicationToolStripMenuItem.Name = "localDrivigLicenseApplicationToolStripMenuItem";
            this.localDrivigLicenseApplicationToolStripMenuItem.Size = new System.Drawing.Size(411, 36);
            this.localDrivigLicenseApplicationToolStripMenuItem.Text = "Local Drivig License Application";
            this.localDrivigLicenseApplicationToolStripMenuItem.Click += new System.EventHandler(this.localDrivigLicenseApplicationToolStripMenuItem_Click);
            // 
            // internationalLicenseApplicationToolStripMenuItem
            // 
            this.internationalLicenseApplicationToolStripMenuItem.Image = global::DVLD_Proj.Properties.Resources.Manage_Inter_License_11zon;
            this.internationalLicenseApplicationToolStripMenuItem.Name = "internationalLicenseApplicationToolStripMenuItem";
            this.internationalLicenseApplicationToolStripMenuItem.Size = new System.Drawing.Size(411, 36);
            this.internationalLicenseApplicationToolStripMenuItem.Text = "International License Application";
            this.internationalLicenseApplicationToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseApplicationToolStripMenuItem_Click);
            // 
            // tmsiDetainLice
            // 
            this.tmsiDetainLice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDeToolStripMenuItem,
            this.detainLicenseToolStripMenuItem,
            this.releaseToolStripMenuItem1});
            this.tmsiDetainLice.Image = global::DVLD_Proj.Properties.Resources.jail;
            this.tmsiDetainLice.Name = "tmsiDetainLice";
            this.tmsiDetainLice.Size = new System.Drawing.Size(331, 34);
            this.tmsiDetainLice.Text = "Detain Licenses";
            // 
            // manageDeToolStripMenuItem
            // 
            this.manageDeToolStripMenuItem.Image = global::DVLD_Proj.Properties.Resources.manage_detain;
            this.manageDeToolStripMenuItem.Name = "manageDeToolStripMenuItem";
            this.manageDeToolStripMenuItem.Size = new System.Drawing.Size(343, 36);
            this.manageDeToolStripMenuItem.Text = "Manage Detained";
            this.manageDeToolStripMenuItem.Click += new System.EventHandler(this.manageDeToolStripMenuItem_Click);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.Image = global::DVLD_Proj.Properties.Resources.arrest;
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(343, 36);
            this.detainLicenseToolStripMenuItem.Text = "Detain License";
            this.detainLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem_Click);
            // 
            // releaseToolStripMenuItem1
            // 
            this.releaseToolStripMenuItem1.Image = global::DVLD_Proj.Properties.Resources.hand_give;
            this.releaseToolStripMenuItem1.Name = "releaseToolStripMenuItem1";
            this.releaseToolStripMenuItem1.Size = new System.Drawing.Size(343, 36);
            this.releaseToolStripMenuItem1.Text = "Release Detained License";
            this.releaseToolStripMenuItem1.Click += new System.EventHandler(this.releaseToolStripMenuItem1_Click);
            // 
            // tsmiManageAppTypes
            // 
            this.tsmiManageAppTypes.Image = global::DVLD_Proj.Properties.Resources.management1;
            this.tsmiManageAppTypes.Name = "tsmiManageAppTypes";
            this.tsmiManageAppTypes.Size = new System.Drawing.Size(331, 34);
            this.tsmiManageAppTypes.Text = "Manage Application Types";
            this.tsmiManageAppTypes.Click += new System.EventHandler(this.tsmiManageAppTypes_Click);
            // 
            // tsmiManageTestTypes
            // 
            this.tsmiManageTestTypes.Image = global::DVLD_Proj.Properties.Resources.unit;
            this.tsmiManageTestTypes.Name = "tsmiManageTestTypes";
            this.tsmiManageTestTypes.Size = new System.Drawing.Size(331, 34);
            this.tsmiManageTestTypes.Text = "Manage Test Types";
            this.tsmiManageTestTypes.Click += new System.EventHandler(this.tsmiManageTestTypes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLD_Proj.Properties.Resources.logo_resized_1500x750;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1451, 615);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmDVLDMainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1451, 694);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlBar);
            this.IsMdiContainer = true;
            this.Name = "frmDVLDMainDashboard";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDVLDMainDashboard_Load);
            this.pnlBar.ResumeLayout(false);
            this.pnlAccountSettings.ResumeLayout(false);
            this.pnlAccountSettings.PerformLayout();
            this.cmsAccountSett.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAccountSettings)).EndInit();
            this.pnlUsers.ResumeLayout(false);
            this.pnlUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).EndInit();
            this.pnlDrivers.ResumeLayout(false);
            this.pnlDrivers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrivers)).EndInit();
            this.pnlAppli.ResumeLayout(false);
            this.pnlAppli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppli)).EndInit();
            this.pnlPeople.ResumeLayout(false);
            this.pnlPeople.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpeople)).EndInit();
            this.cmsApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Panel pnlPeople;
        private System.Windows.Forms.Label lbpeople;
        private System.Windows.Forms.PictureBox pbpeople;
        private System.Windows.Forms.Panel pnlAppli;
        private System.Windows.Forms.PictureBox pbAppli;
        private System.Windows.Forms.Label lbApplications;
        private System.Windows.Forms.Panel pnlDrivers;
        private System.Windows.Forms.PictureBox pbDrivers;
        private System.Windows.Forms.Label lbDrivers;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.PictureBox pbUsers;
        private System.Windows.Forms.Label lbUsers;
        private System.Windows.Forms.Panel pnlAccountSettings;
        private System.Windows.Forms.PictureBox pbAccountSettings;
        private System.Windows.Forms.Label lbAccountSettings;
        private System.Windows.Forms.ContextMenuStrip cmsAccountSett;
        private System.Windows.Forms.ToolStripMenuItem tsmiCurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsmiSignOut;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmiDriving;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageApp;
        private System.Windows.Forms.ToolStripMenuItem tmsiDetainLice;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageAppTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageTestTypes;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replacementForToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiLocalLicense;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivigLicenseApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

