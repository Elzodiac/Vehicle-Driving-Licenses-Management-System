namespace DVLD_Proj
{
    partial class frmPersonDetails
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
            this.lbPersonDetails = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ucShowDetails = new DVLD_Proj.ctrShowDetails();
            this.SuspendLayout();
            // 
            // lbPersonDetails
            // 
            this.lbPersonDetails.AutoSize = true;
            this.lbPersonDetails.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonDetails.ForeColor = System.Drawing.Color.IndianRed;
            this.lbPersonDetails.Location = new System.Drawing.Point(461, 52);
            this.lbPersonDetails.Name = "lbPersonDetails";
            this.lbPersonDetails.Size = new System.Drawing.Size(311, 40);
            this.lbPersonDetails.TabIndex = 2;
            this.lbPersonDetails.Text = "Person Details";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.btnClose.Image = global::DVLD_Proj.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1094, 554);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 49);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ucShowDetails
            // 
            this.ucShowDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucShowDetails.Location = new System.Drawing.Point(29, 160);
            this.ucShowDetails.Name = "ucShowDetails";
            this.ucShowDetails.Size = new System.Drawing.Size(1200, 375);
            this.ucShowDetails.TabIndex = 3;
            // 
            // frmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 634);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucShowDetails);
            this.Controls.Add(this.lbPersonDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonDetails";
            this.Text = "Person Details";
            this.Activated += new System.EventHandler(this.frmPersonDetails_Activated);
            this.Load += new System.EventHandler(this.frmPersonDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPersonDetails;
        private ctrShowDetails ucShowDetails;
        private System.Windows.Forms.Button btnClose;
    }
}