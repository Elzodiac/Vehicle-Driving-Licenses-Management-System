namespace DVLD_Proj
{
    partial class frmManageInternationalLicenseApplications
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
            this.dgvGetIntLicApp = new System.Windows.Forms.DataGridView();
            this.tbFilterBy = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbManagePeople = new System.Windows.Forms.Label();
            this.btnAddIntLicApp = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbActiveOrInactive = new System.Windows.Forms.ComboBox();
            this.cmsIntLicenseApp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetIntLicApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsIntLicenseApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRecordNum
            // 
            this.lbRecordNum.AutoSize = true;
            this.lbRecordNum.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordNum.ForeColor = System.Drawing.Color.Black;
            this.lbRecordNum.Location = new System.Drawing.Point(129, 620);
            this.lbRecordNum.Name = "lbRecordNum";
            this.lbRecordNum.Size = new System.Drawing.Size(20, 20);
            this.lbRecordNum.TabIndex = 36;
            this.lbRecordNum.Text = "0";
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.ForeColor = System.Drawing.Color.Black;
            this.lbRecords.Location = new System.Drawing.Point(17, 619);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(109, 20);
            this.lbRecords.TabIndex = 35;
            this.lbRecords.Text = "# Records:";
            // 
            // dgvGetIntLicApp
            // 
            this.dgvGetIntLicApp.AllowUserToAddRows = false;
            this.dgvGetIntLicApp.AllowUserToDeleteRows = false;
            this.dgvGetIntLicApp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGetIntLicApp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGetIntLicApp.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvGetIntLicApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetIntLicApp.ContextMenuStrip = this.cmsIntLicenseApp;
            this.dgvGetIntLicApp.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvGetIntLicApp.Location = new System.Drawing.Point(21, 314);
            this.dgvGetIntLicApp.Name = "dgvGetIntLicApp";
            this.dgvGetIntLicApp.RowHeadersWidth = 62;
            this.dgvGetIntLicApp.RowTemplate.Height = 28;
            this.dgvGetIntLicApp.Size = new System.Drawing.Size(1203, 286);
            this.dgvGetIntLicApp.TabIndex = 34;
            // 
            // tbFilterBy
            // 
            this.tbFilterBy.Location = new System.Drawing.Point(452, 276);
            this.tbFilterBy.Name = "tbFilterBy";
            this.tbFilterBy.Size = new System.Drawing.Size(248, 26);
            this.tbFilterBy.TabIndex = 33;
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
            "Int.License ID",
            "Driver ID",
            "License ID",
            "Is Active"});
            this.cbFilterBy.Location = new System.Drawing.Point(138, 274);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(302, 28);
            this.cbFilterBy.TabIndex = 32;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "Filter By:";
            // 
            // lbManagePeople
            // 
            this.lbManagePeople.AutoSize = true;
            this.lbManagePeople.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManagePeople.ForeColor = System.Drawing.Color.IndianRed;
            this.lbManagePeople.Location = new System.Drawing.Point(247, 211);
            this.lbManagePeople.Name = "lbManagePeople";
            this.lbManagePeople.Size = new System.Drawing.Size(731, 40);
            this.lbManagePeople.TabIndex = 29;
            this.lbManagePeople.Text = "International License Applications";
            // 
            // btnAddIntLicApp
            // 
            this.btnAddIntLicApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIntLicApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIntLicApp.Image = global::DVLD_Proj.Properties.Resources.add_locDrivLiceApp;
            this.btnAddIntLicApp.Location = new System.Drawing.Point(1133, 237);
            this.btnAddIntLicApp.Name = "btnAddIntLicApp";
            this.btnAddIntLicApp.Size = new System.Drawing.Size(93, 65);
            this.btnAddIntLicApp.TabIndex = 38;
            this.btnAddIntLicApp.UseVisualStyleBackColor = true;
            this.btnAddIntLicApp.Click += new System.EventHandler(this.btnAddIntLicApp_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Proj.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1097, 613);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 46);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::DVLD_Proj.Properties.Resources.Manage_Int_License_Appli;
            this.pictureBox1.Location = new System.Drawing.Point(469, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // cbActiveOrInactive
            // 
            this.cbActiveOrInactive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActiveOrInactive.FormattingEnabled = true;
            this.cbActiveOrInactive.Items.AddRange(new object[] {
            "All",
            "Active",
            "Inactive"});
            this.cbActiveOrInactive.Location = new System.Drawing.Point(452, 274);
            this.cbActiveOrInactive.Name = "cbActiveOrInactive";
            this.cbActiveOrInactive.Size = new System.Drawing.Size(111, 28);
            this.cbActiveOrInactive.TabIndex = 39;
            this.cbActiveOrInactive.Visible = false;
            this.cbActiveOrInactive.SelectedIndexChanged += new System.EventHandler(this.cbActiveOrInactive_SelectedIndexChanged);
            // 
            // cmsIntLicenseApp
            // 
            this.cmsIntLicenseApp.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsIntLicenseApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cmsIntLicenseApp.Name = "cmsIntLicenseApp";
            this.cmsIntLicenseApp.Size = new System.Drawing.Size(318, 133);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Image = global::DVLD_Proj.Properties.Resources.show__det;
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Image = global::DVLD_Proj.Properties.Resources.license_info;
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD_Proj.Properties.Resources.history_lic;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // frmManageInternationalLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1245, 670);
            this.Controls.Add(this.cbActiveOrInactive);
            this.Controls.Add(this.btnAddIntLicApp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbRecordNum);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.dgvGetIntLicApp);
            this.Controls.Add(this.tbFilterBy);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbManagePeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageInternationalLicenseApplications";
            this.Text = "List Internationa lLicense Applications";
            this.Load += new System.EventHandler(this.frmManageInternationalLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetIntLicApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsIntLicenseApp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddIntLicApp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbRecordNum;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.DataGridView dgvGetIntLicApp;
        private System.Windows.Forms.TextBox tbFilterBy;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbManagePeople;
        private System.Windows.Forms.ComboBox cbActiveOrInactive;
        private System.Windows.Forms.ContextMenuStrip cmsIntLicenseApp;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}