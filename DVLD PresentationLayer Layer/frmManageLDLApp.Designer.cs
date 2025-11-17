namespace DVLD_Proj
{
    partial class frmManageLDLApp
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
            this.lbRecordNum = new System.Windows.Forms.Label();
            this.lbRecords = new System.Windows.Forms.Label();
            this.dgvGetLDLApp = new System.Windows.Forms.DataGridView();
            this.cmsLDL_App = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowAppliDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditAppli = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteAppli = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCancelAppli = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScheduleTests = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScheduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScheduleWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScheduleStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIssueDrivingLicenseFirstTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.tbFilterBy = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbManagePeople = new System.Windows.Forms.Label();
            this.btnAddLDLApp = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetLDLApp)).BeginInit();
            this.cmsLDL_App.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRecordNum
            // 
            this.lbRecordNum.AutoSize = true;
            this.lbRecordNum.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordNum.ForeColor = System.Drawing.Color.Black;
            this.lbRecordNum.Location = new System.Drawing.Point(145, 642);
            this.lbRecordNum.Name = "lbRecordNum";
            this.lbRecordNum.Size = new System.Drawing.Size(20, 20);
            this.lbRecordNum.TabIndex = 26;
            this.lbRecordNum.Text = "0";
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.ForeColor = System.Drawing.Color.Black;
            this.lbRecords.Location = new System.Drawing.Point(33, 641);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(109, 20);
            this.lbRecords.TabIndex = 25;
            this.lbRecords.Text = "# Records:";
            // 
            // dgvGetLDLApp
            // 
            this.dgvGetLDLApp.AllowUserToAddRows = false;
            this.dgvGetLDLApp.AllowUserToDeleteRows = false;
            this.dgvGetLDLApp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGetLDLApp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGetLDLApp.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvGetLDLApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetLDLApp.ContextMenuStrip = this.cmsLDL_App;
            this.dgvGetLDLApp.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvGetLDLApp.Location = new System.Drawing.Point(37, 336);
            this.dgvGetLDLApp.Name = "dgvGetLDLApp";
            this.dgvGetLDLApp.RowHeadersWidth = 62;
            this.dgvGetLDLApp.RowTemplate.Height = 28;
            this.dgvGetLDLApp.Size = new System.Drawing.Size(1203, 286);
            this.dgvGetLDLApp.TabIndex = 24;
            this.dgvGetLDLApp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvGetLDLApp_MouseDown);
            // 
            // cmsLDL_App
            // 
            this.cmsLDL_App.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsLDL_App.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowAppliDetails,
            this.tsmiEditAppli,
            this.tsmiDeleteAppli,
            this.tsmiCancelAppli,
            this.tsmiScheduleTests,
            this.tsmiIssueDrivingLicenseFirstTime,
            this.tsmiShowLicense,
            this.tsmiShowPersonLicenseHistory});
            this.cmsLDL_App.Name = "cmsLDL_App";
            this.cmsLDL_App.Size = new System.Drawing.Size(347, 260);
            // 
            // tsmiShowAppliDetails
            // 
            this.tsmiShowAppliDetails.Image = global::DVLD_Proj.Properties.Resources.Show_Appli_Det;
            this.tsmiShowAppliDetails.Name = "tsmiShowAppliDetails";
            this.tsmiShowAppliDetails.Size = new System.Drawing.Size(346, 32);
            this.tsmiShowAppliDetails.Text = "Show Application Details";
            this.tsmiShowAppliDetails.Click += new System.EventHandler(this.tsmiShowAppliDetails_Click);
            // 
            // tsmiEditAppli
            // 
            this.tsmiEditAppli.Image = global::DVLD_Proj.Properties.Resources.Edit_Appli;
            this.tsmiEditAppli.Name = "tsmiEditAppli";
            this.tsmiEditAppli.Size = new System.Drawing.Size(346, 32);
            this.tsmiEditAppli.Text = "Edit Application";
            this.tsmiEditAppli.Click += new System.EventHandler(this.tsmiEditAppli_Click);
            // 
            // tsmiDeleteAppli
            // 
            this.tsmiDeleteAppli.Image = global::DVLD_Proj.Properties.Resources.Delete_Appli;
            this.tsmiDeleteAppli.Name = "tsmiDeleteAppli";
            this.tsmiDeleteAppli.Size = new System.Drawing.Size(346, 32);
            this.tsmiDeleteAppli.Text = "Delete Application";
            this.tsmiDeleteAppli.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // tsmiCancelAppli
            // 
            this.tsmiCancelAppli.Image = global::DVLD_Proj.Properties.Resources.cancel_app;
            this.tsmiCancelAppli.Name = "tsmiCancelAppli";
            this.tsmiCancelAppli.Size = new System.Drawing.Size(346, 32);
            this.tsmiCancelAppli.Text = "Cancel Application";
            this.tsmiCancelAppli.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // tsmiScheduleTests
            // 
            this.tsmiScheduleTests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiScheduleVisionTest,
            this.tsmiScheduleWrittenTest,
            this.tsmiScheduleStreetTest});
            this.tsmiScheduleTests.Image = global::DVLD_Proj.Properties.Resources.sch_tsets;
            this.tsmiScheduleTests.Name = "tsmiScheduleTests";
            this.tsmiScheduleTests.Size = new System.Drawing.Size(346, 32);
            this.tsmiScheduleTests.Text = "Schedule Tests";
            // 
            // tsmiScheduleVisionTest
            // 
            this.tsmiScheduleVisionTest.Enabled = false;
            this.tsmiScheduleVisionTest.Image = global::DVLD_Proj.Properties.Resources.eye;
            this.tsmiScheduleVisionTest.Name = "tsmiScheduleVisionTest";
            this.tsmiScheduleVisionTest.Size = new System.Drawing.Size(283, 34);
            this.tsmiScheduleVisionTest.Text = "Schedule Vision Test";
            this.tsmiScheduleVisionTest.Click += new System.EventHandler(this.scheduleVisionTestToolStripMenuItem_Click);
            // 
            // tsmiScheduleWrittenTest
            // 
            this.tsmiScheduleWrittenTest.Enabled = false;
            this.tsmiScheduleWrittenTest.Image = global::DVLD_Proj.Properties.Resources.written_test;
            this.tsmiScheduleWrittenTest.Name = "tsmiScheduleWrittenTest";
            this.tsmiScheduleWrittenTest.Size = new System.Drawing.Size(283, 34);
            this.tsmiScheduleWrittenTest.Text = "Schedule Written Test";
            this.tsmiScheduleWrittenTest.Click += new System.EventHandler(this.tsmiScheduleWrittenTest_Click);
            // 
            // tsmiScheduleStreetTest
            // 
            this.tsmiScheduleStreetTest.Enabled = false;
            this.tsmiScheduleStreetTest.Image = global::DVLD_Proj.Properties.Resources.driving_test3;
            this.tsmiScheduleStreetTest.Name = "tsmiScheduleStreetTest";
            this.tsmiScheduleStreetTest.Size = new System.Drawing.Size(283, 34);
            this.tsmiScheduleStreetTest.Text = "Schedule Street Test";
            this.tsmiScheduleStreetTest.Click += new System.EventHandler(this.scheduleStreetTestToolStripMenuItem_Click);
            // 
            // tsmiIssueDrivingLicenseFirstTime
            // 
            this.tsmiIssueDrivingLicenseFirstTime.Image = global::DVLD_Proj.Properties.Resources.first_license;
            this.tsmiIssueDrivingLicenseFirstTime.Name = "tsmiIssueDrivingLicenseFirstTime";
            this.tsmiIssueDrivingLicenseFirstTime.Size = new System.Drawing.Size(346, 32);
            this.tsmiIssueDrivingLicenseFirstTime.Text = "Issue Driving License (First Time)";
            this.tsmiIssueDrivingLicenseFirstTime.Click += new System.EventHandler(this.isseuDrivingLicenseFirstTimeToolStripMenuItem_Click);
            // 
            // tsmiShowLicense
            // 
            this.tsmiShowLicense.Image = global::DVLD_Proj.Properties.Resources.license_info;
            this.tsmiShowLicense.Name = "tsmiShowLicense";
            this.tsmiShowLicense.Size = new System.Drawing.Size(346, 32);
            this.tsmiShowLicense.Text = "Show License";
            this.tsmiShowLicense.Click += new System.EventHandler(this.tsmiShowLicense_Click);
            // 
            // tsmiShowPersonLicenseHistory
            // 
            this.tsmiShowPersonLicenseHistory.Image = global::DVLD_Proj.Properties.Resources.history_lic;
            this.tsmiShowPersonLicenseHistory.Name = "tsmiShowPersonLicenseHistory";
            this.tsmiShowPersonLicenseHistory.Size = new System.Drawing.Size(346, 32);
            this.tsmiShowPersonLicenseHistory.Text = "Show Person License History";
            this.tsmiShowPersonLicenseHistory.Click += new System.EventHandler(this.tsmiShowPersonLicenseHistory_Click);
            // 
            // tbFilterBy
            // 
            this.tbFilterBy.Location = new System.Drawing.Point(468, 298);
            this.tbFilterBy.Name = "tbFilterBy";
            this.tbFilterBy.Size = new System.Drawing.Size(248, 26);
            this.tbFilterBy.TabIndex = 23;
            this.tbFilterBy.Visible = false;
            this.tbFilterBy.TextChanged += new System.EventHandler(this.tbFilterBy_TextChanged);
            this.tbFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterBy_KeyPress);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "L.D.L AppID",
            "National No.",
            "Full Name",
            "Status"});
            this.cbFilterBy.Location = new System.Drawing.Point(154, 296);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(302, 28);
            this.cbFilterBy.TabIndex = 22;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Filter By:";
            // 
            // lbManagePeople
            // 
            this.lbManagePeople.AutoSize = true;
            this.lbManagePeople.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManagePeople.ForeColor = System.Drawing.Color.IndianRed;
            this.lbManagePeople.Location = new System.Drawing.Point(263, 233);
            this.lbManagePeople.Name = "lbManagePeople";
            this.lbManagePeople.Size = new System.Drawing.Size(710, 40);
            this.lbManagePeople.TabIndex = 19;
            this.lbManagePeople.Text = "Local Driving License Application";
            // 
            // btnAddLDLApp
            // 
            this.btnAddLDLApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLDLApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLDLApp.Image = global::DVLD_Proj.Properties.Resources.add_locDrivLiceApp;
            this.btnAddLDLApp.Location = new System.Drawing.Point(1149, 259);
            this.btnAddLDLApp.Name = "btnAddLDLApp";
            this.btnAddLDLApp.Size = new System.Drawing.Size(93, 65);
            this.btnAddLDLApp.TabIndex = 28;
            this.btnAddLDLApp.UseVisualStyleBackColor = true;
            this.btnAddLDLApp.Click += new System.EventHandler(this.btnAddLDLApp_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Proj.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1113, 635);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 46);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::DVLD_Proj.Properties.Resources.LDLApp;
            this.pictureBox1.Location = new System.Drawing.Point(485, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageLDLApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1275, 722);
            this.Controls.Add(this.btnAddLDLApp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbRecordNum);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.dgvGetLDLApp);
            this.Controls.Add(this.tbFilterBy);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbManagePeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageLDLApp";
            this.Text = "Local Driving License Application";
            this.Activated += new System.EventHandler(this.frmManageLDLApp_Activated);
            this.Load += new System.EventHandler(this.frmManageLDLApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetLDLApp)).EndInit();
            this.cmsLDL_App.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddLDLApp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbRecordNum;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.DataGridView dgvGetLDLApp;
        private System.Windows.Forms.TextBox tbFilterBy;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbManagePeople;
        private System.Windows.Forms.ContextMenuStrip cmsLDL_App;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowAppliDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditAppli;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteAppli;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancelAppli;
        private System.Windows.Forms.ToolStripMenuItem tsmiScheduleTests;
        private System.Windows.Forms.ToolStripMenuItem tsmiIssueDrivingLicenseFirstTime;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowPersonLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem tsmiScheduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiScheduleWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiScheduleStreetTest;
    }
}