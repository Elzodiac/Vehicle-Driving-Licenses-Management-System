namespace DVLD_Proj
{
    partial class frmTestsAppointments
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
            this.lbTestType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.cmsAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbRecordNum = new System.Windows.Forms.Label();
            this.lbRecords = new System.Windows.Forms.Label();
            this.ucDrivingLicenseAppInfo = new DVLD_Proj.ctrlDrivingLicenseAppInfo();
            this.btnClose = new System.Windows.Forms.Button();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddTestAppoi = new System.Windows.Forms.Button();
            this.pbTestType = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.cmsAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestType)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTestType
            // 
            this.lbTestType.AutoSize = true;
            this.lbTestType.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTestType.ForeColor = System.Drawing.Color.IndianRed;
            this.lbTestType.Location = new System.Drawing.Point(293, 211);
            this.lbTestType.Name = "lbTestType";
            this.lbTestType.Size = new System.Drawing.Size(521, 40);
            this.lbTestType.TabIndex = 21;
            this.lbTestType.Text = "Vision Test Appointments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 745);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "Appointments:";
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.ContextMenuStrip = this.cmsAppointments;
            this.dgvAppointments.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvAppointments.Location = new System.Drawing.Point(21, 789);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.RowHeadersWidth = 62;
            this.dgvAppointments.RowTemplate.Height = 28;
            this.dgvAppointments.Size = new System.Drawing.Size(1141, 144);
            this.dgvAppointments.TabIndex = 26;
            // 
            // cmsAppointments
            // 
            this.cmsAppointments.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.cmsAppointments.Name = "cmsAppointments";
            this.cmsAppointments.Size = new System.Drawing.Size(162, 68);
            // 
            // lbRecordNum
            // 
            this.lbRecordNum.AutoSize = true;
            this.lbRecordNum.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordNum.ForeColor = System.Drawing.Color.Black;
            this.lbRecordNum.Location = new System.Drawing.Point(155, 949);
            this.lbRecordNum.Name = "lbRecordNum";
            this.lbRecordNum.Size = new System.Drawing.Size(20, 20);
            this.lbRecordNum.TabIndex = 29;
            this.lbRecordNum.Text = "0";
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.ForeColor = System.Drawing.Color.Black;
            this.lbRecords.Location = new System.Drawing.Point(27, 949);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(109, 20);
            this.lbRecords.TabIndex = 28;
            this.lbRecords.Text = "# Records:";
            // 
            // ucDrivingLicenseAppInfo
            // 
            this.ucDrivingLicenseAppInfo.CreByUserID = 0;
            this.ucDrivingLicenseAppInfo.DrivingClass = null;
            this.ucDrivingLicenseAppInfo.FullName = null;
            this.ucDrivingLicenseAppInfo.LDLAppID = 0;
            this.ucDrivingLicenseAppInfo.Location = new System.Drawing.Point(12, 241);
            this.ucDrivingLicenseAppInfo.Name = "ucDrivingLicenseAppInfo";
            this.ucDrivingLicenseAppInfo.Size = new System.Drawing.Size(1167, 513);
            this.ucDrivingLicenseAppInfo.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Proj.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1033, 949);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 46);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD_Proj.Properties.Resources.edit_TestAppoin;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(161, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::DVLD_Proj.Properties.Resources.take_test;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(161, 32);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // btnAddTestAppoi
            // 
            this.btnAddTestAppoi.BackColor = System.Drawing.Color.LightGray;
            this.btnAddTestAppoi.Image = global::DVLD_Proj.Properties.Resources.exam_time;
            this.btnAddTestAppoi.Location = new System.Drawing.Point(1080, 725);
            this.btnAddTestAppoi.Name = "btnAddTestAppoi";
            this.btnAddTestAppoi.Size = new System.Drawing.Size(82, 58);
            this.btnAddTestAppoi.TabIndex = 23;
            this.btnAddTestAppoi.UseVisualStyleBackColor = false;
            this.btnAddTestAppoi.Click += new System.EventHandler(this.btnAddTestAppoi_Click);
            // 
            // pbTestType
            // 
            this.pbTestType.BackColor = System.Drawing.Color.White;
            this.pbTestType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbTestType.Image = global::DVLD_Proj.Properties.Resources.vision_test_doc;
            this.pbTestType.Location = new System.Drawing.Point(442, 2);
            this.pbTestType.Name = "pbTestType";
            this.pbTestType.Size = new System.Drawing.Size(241, 206);
            this.pbTestType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTestType.TabIndex = 22;
            this.pbTestType.TabStop = false;
            // 
            // frmTestsAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1191, 1050);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbRecordNum);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddTestAppoi);
            this.Controls.Add(this.pbTestType);
            this.Controls.Add(this.lbTestType);
            this.Controls.Add(this.ucDrivingLicenseAppInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTestsAppointments";
            this.Text = "frmVisionTestAppointments";
            this.Activated += new System.EventHandler(this.frmVisionTestAppointments_Activated);
            this.Load += new System.EventHandler(this.frmVisionTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.cmsAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlDrivingLicenseAppInfo ucDrivingLicenseAppInfo;
        private System.Windows.Forms.PictureBox pbTestType;
        private System.Windows.Forms.Label lbTestType;
        private System.Windows.Forms.Button btnAddTestAppoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbRecordNum;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.ContextMenuStrip cmsAppointments;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}