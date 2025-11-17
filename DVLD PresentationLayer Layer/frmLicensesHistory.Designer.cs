namespace DVLD_Proj
{
    partial class frmLicensesHistory
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
            this.lbAddEditUser = new System.Windows.Forms.Label();
            this.tabLocal = new System.Windows.Forms.TabControl();
            this.tpLocal = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRecordNum = new System.Windows.Forms.Label();
            this.lbRecords = new System.Windows.Forms.Label();
            this.dgvGetLocalLicensesHistroy = new System.Windows.Forms.DataGridView();
            this.tpInter = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRecordsNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvGetInternationalLicensesHistroy = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucShowDetails = new DVLD_Proj.ctrShowDetails();
            this.cmsShowLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLisenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabLocal.SuspendLayout();
            this.tpLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetLocalLicensesHistroy)).BeginInit();
            this.tpInter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetInternationalLicensesHistroy)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsShowLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAddEditUser
            // 
            this.lbAddEditUser.AutoSize = true;
            this.lbAddEditUser.BackColor = System.Drawing.Color.White;
            this.lbAddEditUser.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddEditUser.ForeColor = System.Drawing.Color.IndianRed;
            this.lbAddEditUser.Location = new System.Drawing.Point(556, 29);
            this.lbAddEditUser.Name = "lbAddEditUser";
            this.lbAddEditUser.Size = new System.Drawing.Size(332, 40);
            this.lbAddEditUser.TabIndex = 21;
            this.lbAddEditUser.Text = "License History";
            // 
            // tabLocal
            // 
            this.tabLocal.Controls.Add(this.tpLocal);
            this.tabLocal.Controls.Add(this.tpInter);
            this.tabLocal.Location = new System.Drawing.Point(6, 37);
            this.tabLocal.Name = "tabLocal";
            this.tabLocal.SelectedIndex = 0;
            this.tabLocal.Size = new System.Drawing.Size(1378, 320);
            this.tabLocal.TabIndex = 38;
            this.tabLocal.SelectedIndexChanged += new System.EventHandler(this.tabLocal_SelectedIndexChanged);
            // 
            // tpLocal
            // 
            this.tpLocal.Controls.Add(this.label2);
            this.tpLocal.Controls.Add(this.lbRecordNum);
            this.tpLocal.Controls.Add(this.lbRecords);
            this.tpLocal.Controls.Add(this.dgvGetLocalLicensesHistroy);
            this.tpLocal.Location = new System.Drawing.Point(4, 29);
            this.tpLocal.Name = "tpLocal";
            this.tpLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocal.Size = new System.Drawing.Size(1370, 287);
            this.tpLocal.TabIndex = 0;
            this.tpLocal.Text = "Local";
            this.tpLocal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Local Licenses History:";
            // 
            // lbRecordNum
            // 
            this.lbRecordNum.AutoSize = true;
            this.lbRecordNum.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordNum.ForeColor = System.Drawing.Color.Black;
            this.lbRecordNum.Location = new System.Drawing.Point(139, 259);
            this.lbRecordNum.Name = "lbRecordNum";
            this.lbRecordNum.Size = new System.Drawing.Size(20, 20);
            this.lbRecordNum.TabIndex = 28;
            this.lbRecordNum.Text = "0";
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.ForeColor = System.Drawing.Color.Black;
            this.lbRecords.Location = new System.Drawing.Point(27, 258);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(109, 20);
            this.lbRecords.TabIndex = 27;
            this.lbRecords.Text = "# Records:";
            // 
            // dgvGetLocalLicensesHistroy
            // 
            this.dgvGetLocalLicensesHistroy.AllowUserToAddRows = false;
            this.dgvGetLocalLicensesHistroy.AllowUserToDeleteRows = false;
            this.dgvGetLocalLicensesHistroy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGetLocalLicensesHistroy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGetLocalLicensesHistroy.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvGetLocalLicensesHistroy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetLocalLicensesHistroy.ContextMenuStrip = this.cmsShowLicense;
            this.dgvGetLocalLicensesHistroy.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvGetLocalLicensesHistroy.Location = new System.Drawing.Point(24, 35);
            this.dgvGetLocalLicensesHistroy.Name = "dgvGetLocalLicensesHistroy";
            this.dgvGetLocalLicensesHistroy.RowHeadersWidth = 62;
            this.dgvGetLocalLicensesHistroy.RowTemplate.Height = 28;
            this.dgvGetLocalLicensesHistroy.Size = new System.Drawing.Size(1312, 214);
            this.dgvGetLocalLicensesHistroy.TabIndex = 25;
            // 
            // tpInter
            // 
            this.tpInter.Controls.Add(this.label3);
            this.tpInter.Controls.Add(this.lbRecordsNum);
            this.tpInter.Controls.Add(this.label5);
            this.tpInter.Controls.Add(this.dgvGetInternationalLicensesHistroy);
            this.tpInter.Location = new System.Drawing.Point(4, 29);
            this.tpInter.Name = "tpInter";
            this.tpInter.Padding = new System.Windows.Forms.Padding(3);
            this.tpInter.Size = new System.Drawing.Size(1370, 287);
            this.tpInter.TabIndex = 1;
            this.tpInter.Text = "International";
            this.tpInter.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "International Licenses History:";
            // 
            // lbRecordsNum
            // 
            this.lbRecordsNum.AutoSize = true;
            this.lbRecordsNum.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsNum.ForeColor = System.Drawing.Color.Black;
            this.lbRecordsNum.Location = new System.Drawing.Point(143, 260);
            this.lbRecordsNum.Name = "lbRecordsNum";
            this.lbRecordsNum.Size = new System.Drawing.Size(20, 20);
            this.lbRecordsNum.TabIndex = 32;
            this.lbRecordsNum.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(31, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "# Records:";
            // 
            // dgvGetInternationalLicensesHistroy
            // 
            this.dgvGetInternationalLicensesHistroy.AllowUserToAddRows = false;
            this.dgvGetInternationalLicensesHistroy.AllowUserToDeleteRows = false;
            this.dgvGetInternationalLicensesHistroy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGetInternationalLicensesHistroy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGetInternationalLicensesHistroy.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvGetInternationalLicensesHistroy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetInternationalLicensesHistroy.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvGetInternationalLicensesHistroy.Location = new System.Drawing.Point(28, 38);
            this.dgvGetInternationalLicensesHistroy.Name = "dgvGetInternationalLicensesHistroy";
            this.dgvGetInternationalLicensesHistroy.RowHeadersWidth = 62;
            this.dgvGetInternationalLicensesHistroy.RowTemplate.Height = 28;
            this.dgvGetInternationalLicensesHistroy.Size = new System.Drawing.Size(1312, 214);
            this.dgvGetInternationalLicensesHistroy.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabLocal);
            this.groupBox1.Location = new System.Drawing.Point(11, 492);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1423, 363);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenses";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Proj.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1287, 869);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(147, 49);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::DVLD_Proj.Properties.Resources.local_licenses_history;
            this.pictureBox1.Location = new System.Drawing.Point(12, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // ucShowDetails
            // 
            this.ucShowDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucShowDetails.Location = new System.Drawing.Point(256, 103);
            this.ucShowDetails.Name = "ucShowDetails";
            this.ucShowDetails.PersonIDValue = "???";
            this.ucShowDetails.Size = new System.Drawing.Size(1179, 371);
            this.ucShowDetails.TabIndex = 6;
            // 
            // cmsShowLicense
            // 
            this.cmsShowLicense.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsShowLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLisenseInfoToolStripMenuItem});
            this.cmsShowLicense.Name = "cmsShowLicense";
            this.cmsShowLicense.Size = new System.Drawing.Size(235, 36);
            // 
            // showLisenseInfoToolStripMenuItem
            // 
            this.showLisenseInfoToolStripMenuItem.Image = global::DVLD_Proj.Properties.Resources.license_info;
            this.showLisenseInfoToolStripMenuItem.Name = "showLisenseInfoToolStripMenuItem";
            this.showLisenseInfoToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.showLisenseInfoToolStripMenuItem.Text = "Show Lisense Info";
            this.showLisenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLisenseInfoToolStripMenuItem_Click);
            // 
            // frmLicensesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1446, 930);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbAddEditUser);
            this.Controls.Add(this.ucShowDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLicensesHistory";
            this.Text = "License History";
            this.Load += new System.EventHandler(this.frmLicensesHistory_Load);
            this.tabLocal.ResumeLayout(false);
            this.tpLocal.ResumeLayout(false);
            this.tpLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetLocalLicensesHistroy)).EndInit();
            this.tpInter.ResumeLayout(false);
            this.tpInter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetInternationalLicensesHistroy)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsShowLicense.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrShowDetails ucShowDetails;
        private System.Windows.Forms.Label lbAddEditUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabLocal;
        private System.Windows.Forms.TabPage tpLocal;
        private System.Windows.Forms.TabPage tpInter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvGetLocalLicensesHistroy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRecordNum;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRecordsNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvGetInternationalLicensesHistroy;
        private System.Windows.Forms.ContextMenuStrip cmsShowLicense;
        private System.Windows.Forms.ToolStripMenuItem showLisenseInfoToolStripMenuItem;
    }
}