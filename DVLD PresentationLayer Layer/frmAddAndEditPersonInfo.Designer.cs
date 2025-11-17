namespace DVLD_Proj
{
    partial class frmAddAndEditPersonInfo
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
            this.lbAddEditPerson = new System.Windows.Forms.Label();
            this.lbPersonID = new System.Windows.Forms.Label();
            this.lbNA = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ucAddAndEditPerson = new DVLD_Proj.ctrlAdd_Edit();
            this.SuspendLayout();
            // 
            // lbAddEditPerson
            // 
            this.lbAddEditPerson.AutoSize = true;
            this.lbAddEditPerson.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddEditPerson.ForeColor = System.Drawing.Color.IndianRed;
            this.lbAddEditPerson.Location = new System.Drawing.Point(473, 28);
            this.lbAddEditPerson.Name = "lbAddEditPerson";
            this.lbAddEditPerson.Size = new System.Drawing.Size(307, 36);
            this.lbAddEditPerson.TabIndex = 0;
            this.lbAddEditPerson.Text = "Add - Edit Person";
            // 
            // lbPersonID
            // 
            this.lbPersonID.AutoSize = true;
            this.lbPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonID.Location = new System.Drawing.Point(76, 102);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(120, 25);
            this.lbPersonID.TabIndex = 1;
            this.lbPersonID.Text = "Person ID :";
            // 
            // lbNA
            // 
            this.lbNA.AutoSize = true;
            this.lbNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNA.Location = new System.Drawing.Point(204, 103);
            this.lbNA.Name = "lbNA";
            this.lbNA.Size = new System.Drawing.Size(49, 25);
            this.lbNA.TabIndex = 2;
            this.lbNA.Text = "N/A";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ucAddAndEditPerson
            // 
            this.ucAddAndEditPerson.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucAddAndEditPerson.Location = new System.Drawing.Point(35, 138);
            this.ucAddAndEditPerson.Name = "ucAddAndEditPerson";
            this.ucAddAndEditPerson.Size = new System.Drawing.Size(1200, 486);
            this.ucAddAndEditPerson.TabIndex = 3;
            this.ucAddAndEditPerson.OnClose += new System.Action(this.ucAddAndEditPerson_OnClose);
            this.ucAddAndEditPerson.OnSave += new System.EventHandler<DVLD_Proj.ctrlAdd_Edit.SaveEventArgs>(this.ucAddAndEditPerson_OnSave);
            // 
            // frmAddAndEditPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 644);
            this.Controls.Add(this.ucAddAndEditPerson);
            this.Controls.Add(this.lbNA);
            this.Controls.Add(this.lbPersonID);
            this.Controls.Add(this.lbAddEditPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddAndEditPersonInfo";
            this.Text = "Add / Edit Person Info";
            this.Load += new System.EventHandler(this.frmAddAndEditPersonInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAddEditPerson;
        private System.Windows.Forms.Label lbPersonID;
        private System.Windows.Forms.Label lbNA;
        private DVLD_Proj.ctrlAdd_Edit ucAddAndEditPerson;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}