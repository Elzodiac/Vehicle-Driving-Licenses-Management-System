namespace DVLD_Proj
{
    partial class frmUserInfo
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
            this.gbLoginInfo = new System.Windows.Forms.GroupBox();
            this.lbIsActive = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ucShowDetails = new DVLD_Proj.ctrShowDetails();
            this.gbLoginInfo.SuspendLayout();
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
            this.gbLoginInfo.Location = new System.Drawing.Point(29, 434);
            this.gbLoginInfo.Name = "gbLoginInfo";
            this.gbLoginInfo.Size = new System.Drawing.Size(1230, 90);
            this.gbLoginInfo.TabIndex = 5;
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
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Proj.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1153, 541);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 46);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ucShowDetails
            // 
            this.ucShowDetails.BackColor = System.Drawing.Color.White;
            this.ucShowDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucShowDetails.Location = new System.Drawing.Point(29, 37);
            this.ucShowDetails.Name = "ucShowDetails";
            this.ucShowDetails.PersonIDValue = "???";
            this.ucShowDetails.Size = new System.Drawing.Size(1230, 375);
            this.ucShowDetails.TabIndex = 0;
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1291, 599);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbLoginInfo);
            this.Controls.Add(this.ucShowDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUserInfo";
            this.Text = "frmUserInfo";
            this.Load += new System.EventHandler(this.frmUserInfo_Load);
            this.gbLoginInfo.ResumeLayout(false);
            this.gbLoginInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrShowDetails ucShowDetails;
        private System.Windows.Forms.GroupBox gbLoginInfo;
        private System.Windows.Forms.Label lbIsActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}