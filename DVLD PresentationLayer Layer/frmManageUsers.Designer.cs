namespace DVLD_Proj
{
    partial class frmManageUsers
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
            this.lbManagePeople = new System.Windows.Forms.Label();
            this.tbFilterBy = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGetUsers = new System.Windows.Forms.DataGridView();
            this.cmsUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.lbRecordNum = new System.Windows.Forms.Label();
            this.lbRecords = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbActiveOrInactive = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetUsers)).BeginInit();
            this.cmsUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbManagePeople
            // 
            this.lbManagePeople.AutoSize = true;
            this.lbManagePeople.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManagePeople.ForeColor = System.Drawing.Color.IndianRed;
            this.lbManagePeople.Location = new System.Drawing.Point(480, 224);
            this.lbManagePeople.Name = "lbManagePeople";
            this.lbManagePeople.Size = new System.Drawing.Size(269, 40);
            this.lbManagePeople.TabIndex = 2;
            this.lbManagePeople.Text = "Manage Users";
            // 
            // tbFilterBy
            // 
            this.tbFilterBy.Location = new System.Drawing.Point(470, 291);
            this.tbFilterBy.Name = "tbFilterBy";
            this.tbFilterBy.Size = new System.Drawing.Size(248, 26);
            this.tbFilterBy.TabIndex = 12;
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
            "UserID",
            "PersonID",
            "Full Name",
            "UserName",
            "Is Active"});
            this.cbFilterBy.Location = new System.Drawing.Point(156, 289);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(302, 28);
            this.cbFilterBy.TabIndex = 11;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filter By:";
            // 
            // dgvGetUsers
            // 
            this.dgvGetUsers.AllowUserToAddRows = false;
            this.dgvGetUsers.AllowUserToDeleteRows = false;
            this.dgvGetUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGetUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGetUsers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvGetUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetUsers.ContextMenuStrip = this.cmsUser;
            this.dgvGetUsers.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvGetUsers.Location = new System.Drawing.Point(39, 329);
            this.dgvGetUsers.Name = "dgvGetUsers";
            this.dgvGetUsers.RowHeadersWidth = 62;
            this.dgvGetUsers.RowTemplate.Height = 28;
            this.dgvGetUsers.Size = new System.Drawing.Size(1203, 286);
            this.dgvGetUsers.TabIndex = 13;
            // 
            // cmsUser
            // 
            this.cmsUser.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowDetails,
            this.toolStripSeparator1,
            this.tsmiAddNew,
            this.tsmiEdit,
            this.tsmiDelete,
            this.tsmiChangePass,
            this.toolStripSeparator2,
            this.tsmiSendEmail,
            this.tsmiPhoneCall});
            this.cmsUser.Name = "cmsPerson";
            this.cmsUser.Size = new System.Drawing.Size(233, 240);
            // 
            // tsmiShowDetails
            // 
            this.tsmiShowDetails.Image = global::DVLD_Proj.Properties.Resources.show__det;
            this.tsmiShowDetails.Name = "tsmiShowDetails";
            this.tsmiShowDetails.Size = new System.Drawing.Size(232, 32);
            this.tsmiShowDetails.Text = "Show Details";
            this.tsmiShowDetails.Click += new System.EventHandler(this.tsmiShowDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // tsmiAddNew
            // 
            this.tsmiAddNew.Image = global::DVLD_Proj.Properties.Resources.add_new__person;
            this.tsmiAddNew.Name = "tsmiAddNew";
            this.tsmiAddNew.Size = new System.Drawing.Size(232, 32);
            this.tsmiAddNew.Text = "Add New User";
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Image = global::DVLD_Proj.Properties.Resources.edit_person;
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(232, 32);
            this.tsmiEdit.Text = "Edit";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Image = global::DVLD_Proj.Properties.Resources.delete_person;
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(232, 32);
            this.tsmiDelete.Text = "Delete";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tsmiChangePass
            // 
            this.tsmiChangePass.Image = global::DVLD_Proj.Properties.Resources.Change_password;
            this.tsmiChangePass.Name = "tsmiChangePass";
            this.tsmiChangePass.Size = new System.Drawing.Size(232, 32);
            this.tsmiChangePass.Text = "Change Password";
            this.tsmiChangePass.Click += new System.EventHandler(this.tsmiChangePass_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(229, 6);
            // 
            // tsmiSendEmail
            // 
            this.tsmiSendEmail.Image = global::DVLD_Proj.Properties.Resources.send_email;
            this.tsmiSendEmail.Name = "tsmiSendEmail";
            this.tsmiSendEmail.Size = new System.Drawing.Size(232, 32);
            this.tsmiSendEmail.Text = "Send Email";
            // 
            // tsmiPhoneCall
            // 
            this.tsmiPhoneCall.Image = global::DVLD_Proj.Properties.Resources.person_telephone;
            this.tsmiPhoneCall.Name = "tsmiPhoneCall";
            this.tsmiPhoneCall.Size = new System.Drawing.Size(232, 32);
            this.tsmiPhoneCall.Text = " Phone Call";
            // 
            // lbRecordNum
            // 
            this.lbRecordNum.AutoSize = true;
            this.lbRecordNum.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordNum.ForeColor = System.Drawing.Color.Black;
            this.lbRecordNum.Location = new System.Drawing.Point(147, 635);
            this.lbRecordNum.Name = "lbRecordNum";
            this.lbRecordNum.Size = new System.Drawing.Size(20, 20);
            this.lbRecordNum.TabIndex = 15;
            this.lbRecordNum.Text = "0";
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.ForeColor = System.Drawing.Color.Black;
            this.lbRecords.Location = new System.Drawing.Point(35, 634);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(109, 20);
            this.lbRecords.TabIndex = 14;
            this.lbRecords.Text = "# Records:";
            // 
            // btnAddUser
            // 
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Image = global::DVLD_Proj.Properties.Resources.add_user__1_;
            this.btnAddUser.Location = new System.Drawing.Point(1169, 259);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 58);
            this.btnAddUser.TabIndex = 17;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Proj.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1115, 628);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 46);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::DVLD_Proj.Properties.Resources.management__2_;
            this.pictureBox1.Location = new System.Drawing.Point(514, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
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
            this.cbActiveOrInactive.Location = new System.Drawing.Point(470, 289);
            this.cbActiveOrInactive.Name = "cbActiveOrInactive";
            this.cbActiveOrInactive.Size = new System.Drawing.Size(111, 28);
            this.cbActiveOrInactive.TabIndex = 18;
            this.cbActiveOrInactive.Visible = false;
            this.cbActiveOrInactive.SelectedIndexChanged += new System.EventHandler(this.cbActiveOrInactive_SelectedIndexChanged);
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 695);
            this.Controls.Add(this.cbActiveOrInactive);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbRecordNum);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.dgvGetUsers);
            this.Controls.Add(this.tbFilterBy);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbManagePeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmManageUsers";
            this.Text = "Manage Users";
            this.Activated += new System.EventHandler(this.frmManageUsers_Activated);
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetUsers)).EndInit();
            this.cmsUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbManagePeople;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbFilterBy;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGetUsers;
        private System.Windows.Forms.Label lbRecordNum;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ComboBox cbActiveOrInactive;
        private System.Windows.Forms.ContextMenuStrip cmsUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiSendEmail;
        private System.Windows.Forms.ToolStripMenuItem tsmiPhoneCall;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePass;
    }
}