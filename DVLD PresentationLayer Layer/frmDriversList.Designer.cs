namespace DVLD_Proj
{
    partial class frmDriversList
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
            this.lbRecordNum = new System.Windows.Forms.Label();
            this.lbRecords = new System.Windows.Forms.Label();
            this.dgvGetDriversList = new System.Windows.Forms.DataGridView();
            this.tbFilterBy = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbManagePeople = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetDriversList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRecordNum
            // 
            this.lbRecordNum.AutoSize = true;
            this.lbRecordNum.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordNum.ForeColor = System.Drawing.Color.Black;
            this.lbRecordNum.Location = new System.Drawing.Point(144, 672);
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
            this.lbRecords.Location = new System.Drawing.Point(32, 671);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(109, 20);
            this.lbRecords.TabIndex = 35;
            this.lbRecords.Text = "# Records:";
            // 
            // dgvGetDriversList
            // 
            this.dgvGetDriversList.AllowUserToAddRows = false;
            this.dgvGetDriversList.AllowUserToDeleteRows = false;
            this.dgvGetDriversList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGetDriversList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGetDriversList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvGetDriversList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetDriversList.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvGetDriversList.Location = new System.Drawing.Point(36, 366);
            this.dgvGetDriversList.Name = "dgvGetDriversList";
            this.dgvGetDriversList.RowHeadersWidth = 62;
            this.dgvGetDriversList.RowTemplate.Height = 28;
            this.dgvGetDriversList.Size = new System.Drawing.Size(1203, 286);
            this.dgvGetDriversList.TabIndex = 34;
            // 
            // tbFilterBy
            // 
            this.tbFilterBy.Location = new System.Drawing.Point(467, 328);
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
            "Driver ID",
            "Person ID",
            "National No.",
            "Full Name"});
            this.cbFilterBy.Location = new System.Drawing.Point(153, 326);
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
            this.label1.Location = new System.Drawing.Point(31, 326);
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
            this.lbManagePeople.Location = new System.Drawing.Point(451, 250);
            this.lbManagePeople.Name = "lbManagePeople";
            this.lbManagePeople.Size = new System.Drawing.Size(311, 40);
            this.lbManagePeople.TabIndex = 29;
            this.lbManagePeople.Text = "Manage Drivers";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Proj.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1112, 671);
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
            this.pictureBox1.Image = global::DVLD_Proj.Properties.Resources.driver;
            this.pictureBox1.Location = new System.Drawing.Point(485, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // frmDriversList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1272, 789);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbRecordNum);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.dgvGetDriversList);
            this.Controls.Add(this.tbFilterBy);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbManagePeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDriversList";
            this.Text = "Drivers List";
            this.Load += new System.EventHandler(this.clsDriversList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetDriversList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbRecordNum;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.DataGridView dgvGetDriversList;
        private System.Windows.Forms.TextBox tbFilterBy;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbManagePeople;
    }
}