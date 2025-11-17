namespace DVLD_Proj
{
    partial class frmShowApplicationDetails
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
            this.ucDrivingLicenseAppInfo = new DVLD_Proj.ctrlDrivingLicenseAppInfo();
            this.lbTestType = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucDrivingLicenseAppInfo
            // 
            this.ucDrivingLicenseAppInfo.ApplicationID = 0;
            this.ucDrivingLicenseAppInfo.CreByUserID = 0;
            this.ucDrivingLicenseAppInfo.DrivingClass = null;
            this.ucDrivingLicenseAppInfo.FullName = null;
            this.ucDrivingLicenseAppInfo.LDLAppID = 0;
            this.ucDrivingLicenseAppInfo.Location = new System.Drawing.Point(12, 98);
            this.ucDrivingLicenseAppInfo.Name = "ucDrivingLicenseAppInfo";
            this.ucDrivingLicenseAppInfo.PersonID = 0;
            this.ucDrivingLicenseAppInfo.Size = new System.Drawing.Size(1167, 481);
            this.ucDrivingLicenseAppInfo.TabIndex = 0;
            // 
            // lbTestType
            // 
            this.lbTestType.AutoSize = true;
            this.lbTestType.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTestType.ForeColor = System.Drawing.Color.IndianRed;
            this.lbTestType.Location = new System.Drawing.Point(358, 36);
            this.lbTestType.Name = "lbTestType";
            this.lbTestType.Size = new System.Drawing.Size(416, 40);
            this.lbTestType.TabIndex = 22;
            this.lbTestType.Text = "Application Details";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Proj.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1031, 590);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 46);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowApplicationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1181, 648);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbTestType);
            this.Controls.Add(this.ucDrivingLicenseAppInfo);
            this.Name = "frmShowApplicationDetails";
            this.Text = "Application Details";
            this.Load += new System.EventHandler(this.frmShowApplicationDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlDrivingLicenseAppInfo ucDrivingLicenseAppInfo;
        private System.Windows.Forms.Label lbTestType;
        private System.Windows.Forms.Button btnClose;
    }
}