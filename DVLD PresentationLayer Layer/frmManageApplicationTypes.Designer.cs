namespace DVLD_Proj
{
    partial class frmManageApplicationTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageApplicationTypes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbAppTypes = new System.Windows.Forms.Label();
            this.dgvGetAppTypes = new System.Windows.Forms.DataGridView();
            this.cmsAppTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbRecordNum = new System.Windows.Forms.Label();
            this.lbRecords = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetAppTypes)).BeginInit();
            this.cmsAppTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAppTypes
            // 
            resources.ApplyResources(this.lbAppTypes, "lbAppTypes");
            this.lbAppTypes.ForeColor = System.Drawing.Color.IndianRed;
            this.lbAppTypes.Name = "lbAppTypes";
            // 
            // dgvGetAppTypes
            // 
            this.dgvGetAppTypes.AllowUserToAddRows = false;
            this.dgvGetAppTypes.AllowUserToDeleteRows = false;
            this.dgvGetAppTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGetAppTypes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvGetAppTypes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGetAppTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGetAppTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetAppTypes.ContextMenuStrip = this.cmsAppTypes;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGetAppTypes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGetAppTypes.GridColor = System.Drawing.SystemColors.AppWorkspace;
            resources.ApplyResources(this.dgvGetAppTypes, "dgvGetAppTypes");
            this.dgvGetAppTypes.Name = "dgvGetAppTypes";
            this.dgvGetAppTypes.RowTemplate.Height = 28;
            this.dgvGetAppTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // cmsAppTypes
            // 
            this.cmsAppTypes.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsAppTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.cmsAppTypes.Name = "cmsAppTypes";
            resources.ApplyResources(this.cmsAppTypes, "cmsAppTypes");
            // 
            // lbRecordNum
            // 
            resources.ApplyResources(this.lbRecordNum, "lbRecordNum");
            this.lbRecordNum.ForeColor = System.Drawing.Color.Black;
            this.lbRecordNum.Name = "lbRecordNum";
            // 
            // lbRecords
            // 
            resources.ApplyResources(this.lbRecords, "lbRecords");
            this.lbRecords.ForeColor = System.Drawing.Color.Black;
            this.lbRecords.Name = "lbRecords";
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Image = global::DVLD_Proj.Properties.Resources.close;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::DVLD_Proj.Properties.Resources.feature;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::DVLD_Proj.Properties.Resources.management3;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // frmManageApplicationTypes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lbRecordNum);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvGetAppTypes);
            this.Controls.Add(this.lbAppTypes);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageApplicationTypes";
            this.Load += new System.EventHandler(this.clsManageApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetAppTypes)).EndInit();
            this.cmsAppTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbAppTypes;
        private System.Windows.Forms.DataGridView dgvGetAppTypes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbRecordNum;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.ContextMenuStrip cmsAppTypes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}