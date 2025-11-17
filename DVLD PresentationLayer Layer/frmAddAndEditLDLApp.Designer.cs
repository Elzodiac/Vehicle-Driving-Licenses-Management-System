namespace DVLD_Proj
{
    partial class frmAddAndEditLDLApp
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
            this.tabCAddAndEditUser = new System.Windows.Forms.TabControl();
            this.tpPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ucShowDetails = new DVLD_Proj.ctrShowDetails();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.tbFilterBy = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpLoginInfo = new System.Windows.Forms.TabPage();
            this.lbAppFees = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.cbLicenseClass = new System.Windows.Forms.ComboBox();
            this.lbAppDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDLAppID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lbAddEditUser = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabCAddAndEditUser.SuspendLayout();
            this.tpPersonalInfo.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.tpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCAddAndEditUser
            // 
            this.tabCAddAndEditUser.Controls.Add(this.tpPersonalInfo);
            this.tabCAddAndEditUser.Controls.Add(this.tpLoginInfo);
            this.tabCAddAndEditUser.Location = new System.Drawing.Point(21, 83);
            this.tabCAddAndEditUser.Name = "tabCAddAndEditUser";
            this.tabCAddAndEditUser.SelectedIndex = 0;
            this.tabCAddAndEditUser.Size = new System.Drawing.Size(1244, 606);
            this.tabCAddAndEditUser.TabIndex = 10;
            // 
            // tpPersonalInfo
            // 
            this.tpPersonalInfo.Controls.Add(this.btnNext);
            this.tpPersonalInfo.Controls.Add(this.ucShowDetails);
            this.tpPersonalInfo.Controls.Add(this.gbFilter);
            this.tpPersonalInfo.Location = new System.Drawing.Point(4, 29);
            this.tpPersonalInfo.Name = "tpPersonalInfo";
            this.tpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonalInfo.Size = new System.Drawing.Size(1236, 573);
            this.tpPersonalInfo.TabIndex = 0;
            this.tpPersonalInfo.Text = "Personal Info";
            this.tpPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNext.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Italic);
            this.btnNext.Image = global::DVLD_Proj.Properties.Resources.next;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(1058, 517);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(153, 49);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ucShowDetails
            // 
            this.ucShowDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucShowDetails.Location = new System.Drawing.Point(25, 124);
            this.ucShowDetails.Name = "ucShowDetails";
            this.ucShowDetails.PersonIDValue = "???";
            this.ucShowDetails.Size = new System.Drawing.Size(1179, 371);
            this.ucShowDetails.TabIndex = 4;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnAddPerson);
            this.gbFilter.Controls.Add(this.btnSearchUser);
            this.gbFilter.Controls.Add(this.tbFilterBy);
            this.gbFilter.Controls.Add(this.cbFilterBy);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Location = new System.Drawing.Point(25, 22);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(1179, 76);
            this.gbFilter.TabIndex = 3;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPerson.Image = global::DVLD_Proj.Properties.Resources.add_user__1_;
            this.btnAddPerson.Location = new System.Drawing.Point(839, 19);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(46, 45);
            this.btnAddPerson.TabIndex = 20;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUser.Image = global::DVLD_Proj.Properties.Resources.search;
            this.btnSearchUser.Location = new System.Drawing.Point(763, 19);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(46, 45);
            this.btnSearchUser.TabIndex = 18;
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // tbFilterBy
            // 
            this.tbFilterBy.Location = new System.Drawing.Point(445, 26);
            this.tbFilterBy.Name = "tbFilterBy";
            this.tbFilterBy.Size = new System.Drawing.Size(293, 26);
            this.tbFilterBy.TabIndex = 12;
            this.tbFilterBy.Visible = false;
            this.tbFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterBy_KeyPress);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "NationalNo"});
            this.cbFilterBy.Location = new System.Drawing.Point(157, 24);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(270, 28);
            this.cbFilterBy.TabIndex = 11;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filter By:";
            // 
            // tpLoginInfo
            // 
            this.tpLoginInfo.Controls.Add(this.lbAppFees);
            this.tpLoginInfo.Controls.Add(this.lbCreatedBy);
            this.tpLoginInfo.Controls.Add(this.cbLicenseClass);
            this.tpLoginInfo.Controls.Add(this.lbAppDate);
            this.tpLoginInfo.Controls.Add(this.label6);
            this.tpLoginInfo.Controls.Add(this.label5);
            this.tpLoginInfo.Controls.Add(this.label4);
            this.tpLoginInfo.Controls.Add(this.label3);
            this.tpLoginInfo.Controls.Add(this.lbDLAppID);
            this.tpLoginInfo.Controls.Add(this.label2);
            this.tpLoginInfo.Controls.Add(this.pictureBox4);
            this.tpLoginInfo.Controls.Add(this.btnPrevious);
            this.tpLoginInfo.Controls.Add(this.pictureBox3);
            this.tpLoginInfo.Controls.Add(this.pictureBox2);
            this.tpLoginInfo.Controls.Add(this.pictureBox1);
            this.tpLoginInfo.Controls.Add(this.pictureBox6);
            this.tpLoginInfo.Location = new System.Drawing.Point(4, 29);
            this.tpLoginInfo.Name = "tpLoginInfo";
            this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoginInfo.Size = new System.Drawing.Size(1236, 573);
            this.tpLoginInfo.TabIndex = 1;
            this.tpLoginInfo.Text = "Application Info";
            this.tpLoginInfo.UseVisualStyleBackColor = true;
            // 
            // lbAppFees
            // 
            this.lbAppFees.AutoSize = true;
            this.lbAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppFees.Location = new System.Drawing.Point(362, 249);
            this.lbAppFees.Name = "lbAppFees";
            this.lbAppFees.Size = new System.Drawing.Size(54, 25);
            this.lbAppFees.TabIndex = 46;
            this.lbAppFees.Text = "15 $";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(362, 300);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(48, 25);
            this.lbCreatedBy.TabIndex = 45;
            this.lbCreatedBy.Text = "???";
            // 
            // cbLicenseClass
            // 
            this.cbLicenseClass.BackColor = System.Drawing.SystemColors.Menu;
            this.cbLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClass.FormattingEnabled = true;
            this.cbLicenseClass.Items.AddRange(new object[] {
            "Class 1 - Small Motorcycle",
            "Class 2 - Heavy Motorcycle License",
            "Class 3 - Ordinary Driving License",
            "Class 4 - Commercial",
            "Class 5 - Agricultural",
            "Class 6 - Small and Medium Bus",
            "Class 7 - Truck and Heavy Vehicle"});
            this.cbLicenseClass.Location = new System.Drawing.Point(362, 190);
            this.cbLicenseClass.Name = "cbLicenseClass";
            this.cbLicenseClass.Size = new System.Drawing.Size(281, 28);
            this.cbLicenseClass.TabIndex = 44;
            // 
            // lbAppDate
            // 
            this.lbAppDate.AutoSize = true;
            this.lbAppDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppDate.Location = new System.Drawing.Point(362, 144);
            this.lbAppDate.Name = "lbAppDate";
            this.lbAppDate.Size = new System.Drawing.Size(48, 25);
            this.lbAppDate.TabIndex = 43;
            this.lbAppDate.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 32);
            this.label6.TabIndex = 41;
            this.label6.Text = "Created By:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 32);
            this.label5.TabIndex = 37;
            this.label5.Text = "Application Fees:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 32);
            this.label4.TabIndex = 34;
            this.label4.Text = "License Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 32);
            this.label3.TabIndex = 31;
            this.label3.Text = "Application Date:";
            // 
            // lbDLAppID
            // 
            this.lbDLAppID.AutoSize = true;
            this.lbDLAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDLAppID.Location = new System.Drawing.Point(362, 93);
            this.lbDLAppID.Name = "lbDLAppID";
            this.lbDLAppID.Size = new System.Drawing.Size(48, 25);
            this.lbDLAppID.TabIndex = 30;
            this.lbDLAppID.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "D.L.Application ID:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_Proj.Properties.Resources.Created_By;
            this.pictureBox4.Location = new System.Drawing.Point(285, 288);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 42;
            this.pictureBox4.TabStop = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrevious.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Image = global::DVLD_Proj.Properties.Resources.back;
            this.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevious.Location = new System.Drawing.Point(20, 508);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(146, 55);
            this.btnPrevious.TabIndex = 40;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Proj.Properties.Resources.Fees;
            this.pictureBox3.Location = new System.Drawing.Point(285, 235);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_Proj.Properties.Resources.License_Class;
            this.pictureBox2.Location = new System.Drawing.Point(285, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Proj.Properties.Resources.App_Date;
            this.pictureBox1.Location = new System.Drawing.Point(285, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLD_Proj.Properties.Resources.id_card;
            this.pictureBox6.Location = new System.Drawing.Point(287, 77);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 28;
            this.pictureBox6.TabStop = false;
            // 
            // lbAddEditUser
            // 
            this.lbAddEditUser.AutoSize = true;
            this.lbAddEditUser.BackColor = System.Drawing.Color.White;
            this.lbAddEditUser.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddEditUser.ForeColor = System.Drawing.Color.IndianRed;
            this.lbAddEditUser.Location = new System.Drawing.Point(233, 20);
            this.lbAddEditUser.Name = "lbAddEditUser";
            this.lbAddEditUser.Size = new System.Drawing.Size(899, 40);
            this.lbAddEditUser.TabIndex = 9;
            this.lbAddEditUser.Text = "Add-Edit Local Driving License Application";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::DVLD_Proj.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1115, 709);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 46);
            this.btnSave.TabIndex = 12;
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
            this.btnClose.Location = new System.Drawing.Point(937, 709);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 46);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddAndEditLDLApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1298, 779);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabCAddAndEditUser);
            this.Controls.Add(this.lbAddEditUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddAndEditLDLApp";
            this.Text = "New Local Driving License Application";
            this.Load += new System.EventHandler(this.frmAddAndEditLDLApp_Load);
            this.tabCAddAndEditUser.ResumeLayout(false);
            this.tpPersonalInfo.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.tpLoginInfo.ResumeLayout(false);
            this.tpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabCAddAndEditUser;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private System.Windows.Forms.Button btnNext;
        private ctrShowDetails ucShowDetails;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.TextBox tbFilterBy;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpLoginInfo;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDLAppID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lbAddEditUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbAppDate;
        private System.Windows.Forms.ComboBox cbLicenseClass;
        private System.Windows.Forms.Label lbAppFees;
        private System.Windows.Forms.Label lbCreatedBy;
    }
}