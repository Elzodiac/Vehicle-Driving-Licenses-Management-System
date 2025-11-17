namespace DVLD_Proj
{
    partial class frmIssueDrivingLicenseForTheFirstTime
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
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // ucDrivingLicenseAppInfo
            // 
            this.ucDrivingLicenseAppInfo.CreByUserID = 0;
            this.ucDrivingLicenseAppInfo.DrivingClass = null;
            this.ucDrivingLicenseAppInfo.FullName = null;
            this.ucDrivingLicenseAppInfo.LDLAppID = 0;
            this.ucDrivingLicenseAppInfo.Location = new System.Drawing.Point(12, 53);
            this.ucDrivingLicenseAppInfo.Name = "ucDrivingLicenseAppInfo";
            this.ucDrivingLicenseAppInfo.Size = new System.Drawing.Size(1167, 481);
            this.ucDrivingLicenseAppInfo.TabIndex = 0;
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(176, 564);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(987, 161);
            this.tbNotes.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(28, 564);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 26);
            this.label10.TabIndex = 67;
            this.label10.Text = "Notes:";
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIssue.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Image = global::DVLD_Proj.Properties.Resources.issue_license2;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(1013, 749);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(150, 46);
            this.btnIssue.TabIndex = 71;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Proj.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(835, 749);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 46);
            this.btnClose.TabIndex = 70;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::DVLD_Proj.Properties.Resources.notes;
            this.pictureBox10.Location = new System.Drawing.Point(127, 564);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(24, 24);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox10.TabIndex = 68;
            this.pictureBox10.TabStop = false;
            // 
            // frmIssueDrivingLicenseForTheFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 822);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ucDrivingLicenseAppInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIssueDrivingLicenseForTheFirstTime";
            this.Text = "Issue Driving License For The First Time";
            this.Load += new System.EventHandler(this.frmIssueDrivingLicenseForTheFirstTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlDrivingLicenseAppInfo ucDrivingLicenseAppInfo;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnClose;
    }
}