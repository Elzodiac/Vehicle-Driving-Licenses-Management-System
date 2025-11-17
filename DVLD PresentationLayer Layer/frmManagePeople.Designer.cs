using System.Windows.Forms;

namespace DVLD_Proj
{
    partial class frmManagePeople
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.dgvGetPeople = new System.Windows.Forms.DataGridView();
            this.cmsPerson = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbRecords = new System.Windows.Forms.Label();
            this.lbRecordNum = new System.Windows.Forms.Label();
            this.tbFilterBy = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetPeople)).BeginInit();
            this.cmsPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbManagePeople
            // 
            this.lbManagePeople.AutoSize = true;
            this.lbManagePeople.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManagePeople.ForeColor = System.Drawing.Color.IndianRed;
            this.lbManagePeople.Location = new System.Drawing.Point(736, 183);
            this.lbManagePeople.Name = "lbManagePeople";
            this.lbManagePeople.Size = new System.Drawing.Size(290, 40);
            this.lbManagePeople.TabIndex = 1;
            this.lbManagePeople.Text = "Manage People";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter By";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "National No.",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationality",
            "Gendor",
            "Phone",
            "Email"});
            this.cbFilterBy.Location = new System.Drawing.Point(134, 256);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(270, 28);
            this.cbFilterBy.TabIndex = 4;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // dgvGetPeople
            // 
            this.dgvGetPeople.AllowUserToAddRows = false;
            this.dgvGetPeople.AllowUserToDeleteRows = false;
            this.dgvGetPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGetPeople.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGetPeople.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvGetPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetPeople.ContextMenuStrip = this.cmsPerson;
            this.dgvGetPeople.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvGetPeople.Location = new System.Drawing.Point(14, 295);
            this.dgvGetPeople.Name = "dgvGetPeople";
            this.dgvGetPeople.RowHeadersWidth = 62;
            this.dgvGetPeople.RowTemplate.Height = 28;
            this.dgvGetPeople.Size = new System.Drawing.Size(1747, 489);
            this.dgvGetPeople.TabIndex = 5;
            // 
            // cmsPerson
            // 
            this.cmsPerson.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsPerson.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowDetails,
            this.toolStripSeparator1,
            this.tsmiAddNew,
            this.tsmiEdit,
            this.toolStripSeparator2,
            this.sendToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.cmsPerson.Name = "cmsPerson";
            this.cmsPerson.Size = new System.Drawing.Size(225, 176);
            // 
            // tsmiShowDetails
            // 
            this.tsmiShowDetails.Image = global::DVLD_Proj.Properties.Resources.show__det;
            this.tsmiShowDetails.Name = "tsmiShowDetails";
            this.tsmiShowDetails.Size = new System.Drawing.Size(224, 32);
            this.tsmiShowDetails.Text = "Show Details";
            this.tsmiShowDetails.Click += new System.EventHandler(this.tsmiShowDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // tsmiAddNew
            // 
            this.tsmiAddNew.Image = global::DVLD_Proj.Properties.Resources.add_new__person;
            this.tsmiAddNew.Name = "tsmiAddNew";
            this.tsmiAddNew.Size = new System.Drawing.Size(224, 32);
            this.tsmiAddNew.Text = "Add New Person";
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Image = global::DVLD_Proj.Properties.Resources.edit_person;
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(224, 32);
            this.tsmiEdit.Text = "Edit";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // sendToolStripMenuItem
            // 
            this.sendToolStripMenuItem.Image = global::DVLD_Proj.Properties.Resources.send_email;
            this.sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            this.sendToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.sendToolStripMenuItem.Text = "Send Email";
            this.sendToolStripMenuItem.Click += new System.EventHandler(this.sendToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = global::DVLD_Proj.Properties.Resources.person_telephone;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.phoneCallToolStripMenuItem.Text = " Phone Call";
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.ForeColor = System.Drawing.Color.Black;
            this.lbRecords.Location = new System.Drawing.Point(12, 802);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(109, 20);
            this.lbRecords.TabIndex = 7;
            this.lbRecords.Text = "# Records:";
            // 
            // lbRecordNum
            // 
            this.lbRecordNum.AutoSize = true;
            this.lbRecordNum.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordNum.ForeColor = System.Drawing.Color.Black;
            this.lbRecordNum.Location = new System.Drawing.Point(124, 803);
            this.lbRecordNum.Name = "lbRecordNum";
            this.lbRecordNum.Size = new System.Drawing.Size(20, 20);
            this.lbRecordNum.TabIndex = 8;
            this.lbRecordNum.Text = "0";
            // 
            // tbFilterBy
            // 
            this.tbFilterBy.Location = new System.Drawing.Point(422, 258);
            this.tbFilterBy.Name = "tbFilterBy";
            this.tbFilterBy.Size = new System.Drawing.Size(246, 26);
            this.tbFilterBy.TabIndex = 9;
            this.tbFilterBy.Visible = false;
            this.tbFilterBy.TextChanged += new System.EventHandler(this.tbFilterBy_TextChanged);
            this.tbFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterBy_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Proj.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1670, 801);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 46);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPerson.Image = global::DVLD_Proj.Properties.Resources.add_friend;
            this.btnAddPerson.Location = new System.Drawing.Point(1686, 246);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(75, 43);
            this.btnAddPerson.TabIndex = 2;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::DVLD_Proj.Properties.Resources.demographic__2_;
            this.pictureBox1.Location = new System.Drawing.Point(787, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1826, 875);
            this.Controls.Add(this.tbFilterBy);
            this.Controls.Add(this.lbRecordNum);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvGetPeople);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.lbManagePeople);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManagePeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.frmManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetPeople)).EndInit();
            this.cmsPerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbManagePeople;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.DataGridView dgvGetPeople;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Label lbRecordNum;
        private ContextMenuStrip cmsPerson;
        private ToolStripMenuItem tsmiAddNew;
        private ToolStripMenuItem tsmiEdit;
        private ToolStripMenuItem sendToolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
        private ToolStripMenuItem tsmiShowDetails;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private TextBox tbFilterBy;
    }
}