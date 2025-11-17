namespace DVLD_Proj
{
    partial class frmChangePassword
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
            this.gbLoginInfo = new System.Windows.Forms.GroupBox();
            this.lbIsActive = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCurrentPass = new System.Windows.Forms.TextBox();
            this.tbConfirmPass = new System.Windows.Forms.TextBox();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ucShowDetails = new DVLD_Proj.ctrShowDetails();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.gbLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLoginInfo
            // 
            this.gbLoginInfo.Controls.Add(this.lbIsActive);
            this.gbLoginInfo.Controls.Add(this.label3);
            this.gbLoginInfo.Controls.Add(this.lbUsername);
            this.gbLoginInfo.Controls.Add(this.label2);
            this.gbLoginInfo.Controls.Add(this.lbUserID);
            this.gbLoginInfo.Controls.Add(this.label1);
            this.gbLoginInfo.Location = new System.Drawing.Point(32, 460);
            this.gbLoginInfo.Name = "gbLoginInfo";
            this.gbLoginInfo.Size = new System.Drawing.Size(1213, 85);
            this.gbLoginInfo.TabIndex = 4;
            this.gbLoginInfo.TabStop = false;
            this.gbLoginInfo.Text = "Login Information";
            // 
            // lbIsActive
            // 
            this.lbIsActive.AutoSize = true;
            this.lbIsActive.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsActive.ForeColor = System.Drawing.Color.Black;
            this.lbIsActive.Location = new System.Drawing.Point(844, 35);
            this.lbIsActive.Name = "lbIsActive";
            this.lbIsActive.Size = new System.Drawing.Size(80, 26);
            this.lbIsActive.TabIndex = 15;
            this.lbIsActive.Text = "Active";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(720, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Is Active:";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.Black;
            this.lbUsername.Location = new System.Drawing.Point(582, 35);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(62, 26);
            this.lbUsername.TabIndex = 13;
            this.lbUsername.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(444, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Username:";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.ForeColor = System.Drawing.Color.Black;
            this.lbUserID.Location = new System.Drawing.Point(314, 35);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(36, 26);
            this.lbUserID.TabIndex = 11;
            this.lbUserID.Text = "-1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(203, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "User ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(41, 592);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Current Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(80, 639);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "New Password:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_Proj.Properties.Resources.password__1_;
            this.pictureBox4.Location = new System.Drawing.Point(277, 686);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(39, 684);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 26);
            this.label6.TabIndex = 24;
            this.label6.Text = "Confirm Password:";
            // 
            // tbCurrentPass
            // 
            this.tbCurrentPass.Location = new System.Drawing.Point(330, 591);
            this.tbCurrentPass.Multiline = true;
            this.tbCurrentPass.Name = "tbCurrentPass";
            this.tbCurrentPass.PasswordChar = '*';
            this.tbCurrentPass.Size = new System.Drawing.Size(214, 31);
            this.tbCurrentPass.TabIndex = 26;
            this.tbCurrentPass.TextChanged += new System.EventHandler(this.tbCurrentPass_TextChanged);
            // 
            // tbConfirmPass
            // 
            this.tbConfirmPass.Location = new System.Drawing.Point(330, 685);
            this.tbConfirmPass.Multiline = true;
            this.tbConfirmPass.Name = "tbConfirmPass";
            this.tbConfirmPass.PasswordChar = '*';
            this.tbConfirmPass.Size = new System.Drawing.Size(214, 31);
            this.tbConfirmPass.TabIndex = 27;
            this.tbConfirmPass.TextChanged += new System.EventHandler(this.tbConfirmPass_TextChanged);
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(330, 640);
            this.tbNewPass.Multiline = true;
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.PasswordChar = '*';
            this.tbNewPass.Size = new System.Drawing.Size(214, 31);
            this.tbNewPass.TabIndex = 28;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::DVLD_Proj.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1095, 766);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 46);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Proj.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(917, 766);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 46);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ucShowDetails
            // 
            this.ucShowDetails.BackColor = System.Drawing.Color.Transparent;
            this.ucShowDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucShowDetails.Location = new System.Drawing.Point(32, 46);
            this.ucShowDetails.Name = "ucShowDetails";
            this.ucShowDetails.PersonIDValue = "???";
            this.ucShowDetails.Size = new System.Drawing.Size(1213, 375);
            this.ucShowDetails.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Proj.Properties.Resources.password;
            this.pictureBox3.Location = new System.Drawing.Point(277, 594);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD_Proj.Properties.Resources.shield;
            this.pictureBox5.Location = new System.Drawing.Point(277, 641);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 838);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbNewPass);
            this.Controls.Add(this.tbConfirmPass);
            this.Controls.Add(this.tbCurrentPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbLoginInfo);
            this.Controls.Add(this.ucShowDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.gbLoginInfo.ResumeLayout(false);
            this.gbLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrShowDetails ucShowDetails;
        private System.Windows.Forms.GroupBox gbLoginInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label lbIsActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCurrentPass;
        private System.Windows.Forms.TextBox tbConfirmPass;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}