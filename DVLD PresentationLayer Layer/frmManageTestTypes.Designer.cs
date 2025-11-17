namespace DVLD_Proj
{
    partial class frmManageTestTypes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbRecordNum = new System.Windows.Forms.Label();
            this.lbRecords = new System.Windows.Forms.Label();
            this.dgvGetTestTypes = new System.Windows.Forms.DataGridView();
            this.lbTestTypes = new System.Windows.Forms.Label();
            this.cmsTestType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editTestTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetTestTypes)).BeginInit();
            this.cmsTestType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRecordNum
            // 
            this.lbRecordNum.AutoSize = true;
            this.lbRecordNum.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lbRecordNum.ForeColor = System.Drawing.Color.Black;
            this.lbRecordNum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbRecordNum.Location = new System.Drawing.Point(174, 800);
            this.lbRecordNum.Name = "lbRecordNum";
            this.lbRecordNum.Size = new System.Drawing.Size(20, 20);
            this.lbRecordNum.TabIndex = 25;
            this.lbRecordNum.Text = "0";
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lbRecords.ForeColor = System.Drawing.Color.Black;
            this.lbRecords.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbRecords.Location = new System.Drawing.Point(62, 799);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(109, 20);
            this.lbRecords.TabIndex = 24;
            this.lbRecords.Text = "# Records:";
            // 
            // dgvGetTestTypes
            // 
            this.dgvGetTestTypes.AllowUserToAddRows = false;
            this.dgvGetTestTypes.AllowUserToDeleteRows = false;
            this.dgvGetTestTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGetTestTypes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvGetTestTypes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGetTestTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGetTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetTestTypes.ContextMenuStrip = this.cmsTestType;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGetTestTypes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGetTestTypes.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvGetTestTypes.Location = new System.Drawing.Point(23, 316);
            this.dgvGetTestTypes.Name = "dgvGetTestTypes";
            this.dgvGetTestTypes.RowHeadersWidth = 62;
            this.dgvGetTestTypes.RowTemplate.Height = 28;
            this.dgvGetTestTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGetTestTypes.Size = new System.Drawing.Size(978, 453);
            this.dgvGetTestTypes.TabIndex = 22;
            // 
            // lbTestTypes
            // 
            this.lbTestTypes.AutoSize = true;
            this.lbTestTypes.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.lbTestTypes.ForeColor = System.Drawing.Color.IndianRed;
            this.lbTestTypes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTestTypes.Location = new System.Drawing.Point(324, 240);
            this.lbTestTypes.Name = "lbTestTypes";
            this.lbTestTypes.Size = new System.Drawing.Size(374, 40);
            this.lbTestTypes.TabIndex = 21;
            this.lbTestTypes.Text = "Manage Test Types";
            // 
            // cmsTestType
            // 
            this.cmsTestType.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsTestType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTestTypeToolStripMenuItem});
            this.cmsTestType.Name = "contextMenuStrip1";
            this.cmsTestType.Size = new System.Drawing.Size(200, 36);
            // 
            // editTestTypeToolStripMenuItem
            // 
            this.editTestTypeToolStripMenuItem.Image = global::DVLD_Proj.Properties.Resources.test_cases;
            this.editTestTypeToolStripMenuItem.Name = "editTestTypeToolStripMenuItem";
            this.editTestTypeToolStripMenuItem.Size = new System.Drawing.Size(199, 32);
            this.editTestTypeToolStripMenuItem.Text = "Edit Test Type";
            this.editTestTypeToolStripMenuItem.Click += new System.EventHandler(this.editTestTypeToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Italic);
            this.btnClose.Image = global::DVLD_Proj.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(838, 785);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(163, 46);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::DVLD_Proj.Properties.Resources.development_plan;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(413, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 866);
            this.Controls.Add(this.lbRecordNum);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvGetTestTypes);
            this.Controls.Add(this.lbTestTypes);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmManageTestTypes";
            this.Text = "Manage Test Types";
            this.Load += new System.EventHandler(this.frmManageTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetTestTypes)).EndInit();
            this.cmsTestType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRecordNum;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvGetTestTypes;
        private System.Windows.Forms.Label lbTestTypes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmsTestType;
        private System.Windows.Forms.ToolStripMenuItem editTestTypeToolStripMenuItem;
    }
}