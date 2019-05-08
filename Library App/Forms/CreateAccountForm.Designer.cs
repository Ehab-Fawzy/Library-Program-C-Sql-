namespace Library_App.Forms
{
    partial class CreateAccountForm
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
            this.Password_TB = new System.Windows.Forms.TextBox();
            this.Username_TB = new System.Windows.Forms.TextBox();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.Repass_TB = new System.Windows.Forms.TextBox();
            this.Repass_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Phone_TB = new System.Windows.Forms.TextBox();
            this.Email_TB = new System.Windows.Forms.TextBox();
            this.Address_TB = new System.Windows.Forms.TextBox();
            this.SName_TB = new System.Windows.Forms.TextBox();
            this.FName_TB = new System.Windows.Forms.TextBox();
            this.University_TB = new System.Windows.Forms.TextBox();
            this.NationalID_TB = new System.Windows.Forms.TextBox();
            this.Birthdate_Picker = new System.Windows.Forms.DateTimePicker();
            this.Admin_CB = new System.Windows.Forms.CheckBox();
            this.Admin_Panel = new System.Windows.Forms.Panel();
            this.HireDate_DB = new System.Windows.Forms.DateTimePicker();
            this.Shift_TB = new System.Windows.Forms.TextBox();
            this.Salary_TB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.HD_lbl = new System.Windows.Forms.Label();
            this.Salary_lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Uni_ID_TB = new System.Windows.Forms.TextBox();
            this.GPA_TB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Student_Panel = new System.Windows.Forms.Panel();
            this.Code_Panel = new System.Windows.Forms.Panel();
            this.Check_btn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.Code_TB = new System.Windows.Forms.TextBox();
            this.Admin_Panel.SuspendLayout();
            this.Student_Panel.SuspendLayout();
            this.Code_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Password_TB
            // 
            this.Password_TB.Location = new System.Drawing.Point(315, 117);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.PasswordChar = '*';
            this.Password_TB.Size = new System.Drawing.Size(200, 20);
            this.Password_TB.TabIndex = 2;
            this.Password_TB.UseSystemPasswordChar = true;
            this.Password_TB.TextChanged += new System.EventHandler(this.Password_TB_TextChanged);
            // 
            // Username_TB
            // 
            this.Username_TB.Location = new System.Drawing.Point(315, 61);
            this.Username_TB.Name = "Username_TB";
            this.Username_TB.Size = new System.Drawing.Size(200, 20);
            this.Username_TB.TabIndex = 1;
            this.Username_TB.TextChanged += new System.EventHandler(this.Username_TB_TextChanged);
            // 
            // Submit_btn
            // 
            this.Submit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_btn.Location = new System.Drawing.Point(31, 622);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(218, 40);
            this.Submit_btn.TabIndex = 16;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Create_btn_Click);
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Password_lbl.Location = new System.Drawing.Point(26, 117);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(92, 24);
            this.Password_lbl.TabIndex = 8;
            this.Password_lbl.Text = "Password";
            this.Password_lbl.Click += new System.EventHandler(this.Password_lbl_Click);
            // 
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Username_lbl.Location = new System.Drawing.Point(26, 61);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(97, 24);
            this.Username_lbl.TabIndex = 7;
            this.Username_lbl.Text = "Username";
            this.Username_lbl.Click += new System.EventHandler(this.Username_lbl_Click);
            // 
            // Repass_TB
            // 
            this.Repass_TB.Location = new System.Drawing.Point(315, 176);
            this.Repass_TB.Name = "Repass_TB";
            this.Repass_TB.PasswordChar = '*';
            this.Repass_TB.Size = new System.Drawing.Size(200, 20);
            this.Repass_TB.TabIndex = 3;
            this.Repass_TB.UseSystemPasswordChar = true;
            this.Repass_TB.TextChanged += new System.EventHandler(this.Repass_TB_TextChanged);
            // 
            // Repass_lbl
            // 
            this.Repass_lbl.AutoSize = true;
            this.Repass_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Repass_lbl.Location = new System.Drawing.Point(26, 176);
            this.Repass_lbl.Name = "Repass_lbl";
            this.Repass_lbl.Size = new System.Drawing.Size(156, 24);
            this.Repass_lbl.TabIndex = 12;
            this.Repass_lbl.Text = "Retype Password";
            this.Repass_lbl.Click += new System.EventHandler(this.Repass_lbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(26, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Phone Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(26, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(26, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Address";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(27, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Birthdate";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(27, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Last Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(27, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "First Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.Location = new System.Drawing.Point(8, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "University";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label8.Location = new System.Drawing.Point(27, 548);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "National ID";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Phone_TB
            // 
            this.Phone_TB.Location = new System.Drawing.Point(315, 502);
            this.Phone_TB.Name = "Phone_TB";
            this.Phone_TB.Size = new System.Drawing.Size(200, 20);
            this.Phone_TB.TabIndex = 9;
            this.Phone_TB.TextChanged += new System.EventHandler(this.Phone_TB_TextChanged);
            // 
            // Email_TB
            // 
            this.Email_TB.Location = new System.Drawing.Point(315, 450);
            this.Email_TB.Name = "Email_TB";
            this.Email_TB.Size = new System.Drawing.Size(200, 20);
            this.Email_TB.TabIndex = 8;
            this.Email_TB.TextChanged += new System.EventHandler(this.Email_TB_TextChanged);
            // 
            // Address_TB
            // 
            this.Address_TB.Location = new System.Drawing.Point(315, 393);
            this.Address_TB.Name = "Address_TB";
            this.Address_TB.Size = new System.Drawing.Size(200, 20);
            this.Address_TB.TabIndex = 7;
            this.Address_TB.TextChanged += new System.EventHandler(this.Address_TB_TextChanged);
            // 
            // SName_TB
            // 
            this.SName_TB.Location = new System.Drawing.Point(315, 289);
            this.SName_TB.Name = "SName_TB";
            this.SName_TB.Size = new System.Drawing.Size(200, 20);
            this.SName_TB.TabIndex = 5;
            this.SName_TB.TextChanged += new System.EventHandler(this.SName_TB_TextChanged);
            // 
            // FName_TB
            // 
            this.FName_TB.Location = new System.Drawing.Point(315, 226);
            this.FName_TB.Name = "FName_TB";
            this.FName_TB.Size = new System.Drawing.Size(200, 20);
            this.FName_TB.TabIndex = 4;
            this.FName_TB.TextChanged += new System.EventHandler(this.FName_TB_TextChanged);
            // 
            // University_TB
            // 
            this.University_TB.Location = new System.Drawing.Point(146, 90);
            this.University_TB.Name = "University_TB";
            this.University_TB.Size = new System.Drawing.Size(151, 20);
            this.University_TB.TabIndex = 11;
            this.University_TB.TextChanged += new System.EventHandler(this.University_TB_TextChanged);
            // 
            // NationalID_TB
            // 
            this.NationalID_TB.Location = new System.Drawing.Point(315, 548);
            this.NationalID_TB.Name = "NationalID_TB";
            this.NationalID_TB.Size = new System.Drawing.Size(200, 20);
            this.NationalID_TB.TabIndex = 10;
            this.NationalID_TB.TextChanged += new System.EventHandler(this.NationalID_TB_TextChanged);
            // 
            // Birthdate_Picker
            // 
            this.Birthdate_Picker.Location = new System.Drawing.Point(315, 346);
            this.Birthdate_Picker.Name = "Birthdate_Picker";
            this.Birthdate_Picker.Size = new System.Drawing.Size(200, 20);
            this.Birthdate_Picker.TabIndex = 6;
            this.Birthdate_Picker.ValueChanged += new System.EventHandler(this.Birthdate_Picker_ValueChanged);
            // 
            // Admin_CB
            // 
            this.Admin_CB.AutoSize = true;
            this.Admin_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_CB.Location = new System.Drawing.Point(682, 498);
            this.Admin_CB.Name = "Admin_CB";
            this.Admin_CB.Size = new System.Drawing.Size(78, 24);
            this.Admin_CB.TabIndex = 15;
            this.Admin_CB.Text = "Admin";
            this.Admin_CB.UseVisualStyleBackColor = true;
            this.Admin_CB.CheckedChanged += new System.EventHandler(this.Admin_CB_CheckedChanged);
            // 
            // Admin_Panel
            // 
            this.Admin_Panel.Controls.Add(this.HireDate_DB);
            this.Admin_Panel.Controls.Add(this.Shift_TB);
            this.Admin_Panel.Controls.Add(this.Salary_TB);
            this.Admin_Panel.Controls.Add(this.label9);
            this.Admin_Panel.Controls.Add(this.label12);
            this.Admin_Panel.Controls.Add(this.HD_lbl);
            this.Admin_Panel.Controls.Add(this.Salary_lbl);
            this.Admin_Panel.Location = new System.Drawing.Point(583, 57);
            this.Admin_Panel.Name = "Admin_Panel";
            this.Admin_Panel.Size = new System.Drawing.Size(334, 329);
            this.Admin_Panel.TabIndex = 32;
            this.Admin_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Admin_Panel_Paint);
            // 
            // HireDate_DB
            // 
            this.HireDate_DB.Location = new System.Drawing.Point(122, 170);
            this.HireDate_DB.Name = "HireDate_DB";
            this.HireDate_DB.Size = new System.Drawing.Size(200, 20);
            this.HireDate_DB.TabIndex = 36;
            this.HireDate_DB.ValueChanged += new System.EventHandler(this.HireDate_DB_ValueChanged);
            // 
            // Shift_TB
            // 
            this.Shift_TB.Location = new System.Drawing.Point(146, 246);
            this.Shift_TB.Name = "Shift_TB";
            this.Shift_TB.Size = new System.Drawing.Size(151, 20);
            this.Shift_TB.TabIndex = 35;
            this.Shift_TB.TextChanged += new System.EventHandler(this.Shift_TB_TextChanged);
            // 
            // Salary_TB
            // 
            this.Salary_TB.Location = new System.Drawing.Point(146, 90);
            this.Salary_TB.Name = "Salary_TB";
            this.Salary_TB.Size = new System.Drawing.Size(151, 20);
            this.Salary_TB.TabIndex = 34;
            this.Salary_TB.TextChanged += new System.EventHandler(this.Salary_TB_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(107, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 24);
            this.label9.TabIndex = 33;
            this.label9.Text = "Admin";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 24);
            this.label12.TabIndex = 2;
            this.label12.Text = "Shift";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // HD_lbl
            // 
            this.HD_lbl.AutoSize = true;
            this.HD_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HD_lbl.Location = new System.Drawing.Point(11, 170);
            this.HD_lbl.Name = "HD_lbl";
            this.HD_lbl.Size = new System.Drawing.Size(88, 24);
            this.HD_lbl.TabIndex = 1;
            this.HD_lbl.Text = "Hire Date";
            this.HD_lbl.Click += new System.EventHandler(this.HD_lbl_Click);
            // 
            // Salary_lbl
            // 
            this.Salary_lbl.AutoSize = true;
            this.Salary_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary_lbl.Location = new System.Drawing.Point(11, 90);
            this.Salary_lbl.Name = "Salary_lbl";
            this.Salary_lbl.Size = new System.Drawing.Size(61, 24);
            this.Salary_lbl.TabIndex = 0;
            this.Salary_lbl.Text = "Salary";
            this.Salary_lbl.Click += new System.EventHandler(this.Salary_lbl_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label10.Location = new System.Drawing.Point(8, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 24);
            this.label10.TabIndex = 33;
            this.label10.Text = "University ID";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Uni_ID_TB
            // 
            this.Uni_ID_TB.Location = new System.Drawing.Point(144, 170);
            this.Uni_ID_TB.Name = "Uni_ID_TB";
            this.Uni_ID_TB.Size = new System.Drawing.Size(151, 20);
            this.Uni_ID_TB.TabIndex = 12;
            this.Uni_ID_TB.TextChanged += new System.EventHandler(this.Uni_ID_TB_TextChanged);
            // 
            // GPA_TB
            // 
            this.GPA_TB.Location = new System.Drawing.Point(146, 241);
            this.GPA_TB.Name = "GPA_TB";
            this.GPA_TB.Size = new System.Drawing.Size(151, 20);
            this.GPA_TB.TabIndex = 13;
            this.GPA_TB.TextChanged += new System.EventHandler(this.GPA_TB_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label11.Location = new System.Drawing.Point(11, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 24);
            this.label11.TabIndex = 36;
            this.label11.Text = "GPA";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(112, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 24);
            this.label13.TabIndex = 37;
            this.label13.Text = "Student";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Student_Panel
            // 
            this.Student_Panel.Controls.Add(this.label13);
            this.Student_Panel.Controls.Add(this.label7);
            this.Student_Panel.Controls.Add(this.label11);
            this.Student_Panel.Controls.Add(this.University_TB);
            this.Student_Panel.Controls.Add(this.GPA_TB);
            this.Student_Panel.Controls.Add(this.label10);
            this.Student_Panel.Controls.Add(this.Uni_ID_TB);
            this.Student_Panel.Location = new System.Drawing.Point(584, 61);
            this.Student_Panel.Name = "Student_Panel";
            this.Student_Panel.Size = new System.Drawing.Size(336, 325);
            this.Student_Panel.TabIndex = 38;
            this.Student_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Student_Panel_Paint);
            // 
            // Code_Panel
            // 
            this.Code_Panel.Controls.Add(this.Check_btn);
            this.Code_Panel.Controls.Add(this.label14);
            this.Code_Panel.Controls.Add(this.Code_TB);
            this.Code_Panel.Location = new System.Drawing.Point(598, 536);
            this.Code_Panel.Name = "Code_Panel";
            this.Code_Panel.Size = new System.Drawing.Size(331, 36);
            this.Code_Panel.TabIndex = 39;
            this.Code_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Code_Panel_Paint);
            // 
            // Check_btn
            // 
            this.Check_btn.Location = new System.Drawing.Point(240, 10);
            this.Check_btn.Name = "Check_btn";
            this.Check_btn.Size = new System.Drawing.Size(75, 23);
            this.Check_btn.TabIndex = 42;
            this.Check_btn.Text = "Check";
            this.Check_btn.UseVisualStyleBackColor = true;
            this.Check_btn.Click += new System.EventHandler(this.Check_btn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label14.Location = new System.Drawing.Point(3, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 24);
            this.label14.TabIndex = 41;
            this.label14.Text = "Code";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // Code_TB
            // 
            this.Code_TB.Location = new System.Drawing.Point(83, 11);
            this.Code_TB.Name = "Code_TB";
            this.Code_TB.Size = new System.Drawing.Size(151, 20);
            this.Code_TB.TabIndex = 40;
            this.Code_TB.UseSystemPasswordChar = true;
            this.Code_TB.TextChanged += new System.EventHandler(this.Code_TB_TextChanged);
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 683);
            this.Controls.Add(this.Code_Panel);
            this.Controls.Add(this.Student_Panel);
            this.Controls.Add(this.Admin_Panel);
            this.Controls.Add(this.Admin_CB);
            this.Controls.Add(this.Birthdate_Picker);
            this.Controls.Add(this.NationalID_TB);
            this.Controls.Add(this.FName_TB);
            this.Controls.Add(this.SName_TB);
            this.Controls.Add(this.Address_TB);
            this.Controls.Add(this.Email_TB);
            this.Controls.Add(this.Phone_TB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Repass_TB);
            this.Controls.Add(this.Repass_lbl);
            this.Controls.Add(this.Password_TB);
            this.Controls.Add(this.Username_TB);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.Username_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateAccountForm";
            this.Text = "CreateUserForm";
            this.Load += new System.EventHandler(this.CreateAccountForm_Load);
            this.Admin_Panel.ResumeLayout(false);
            this.Admin_Panel.PerformLayout();
            this.Student_Panel.ResumeLayout(false);
            this.Student_Panel.PerformLayout();
            this.Code_Panel.ResumeLayout(false);
            this.Code_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password_TB;
        private System.Windows.Forms.TextBox Username_TB;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.TextBox Repass_TB;
        private System.Windows.Forms.Label Repass_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Phone_TB;
        private System.Windows.Forms.TextBox Email_TB;
        private System.Windows.Forms.TextBox Address_TB;
        private System.Windows.Forms.TextBox SName_TB;
        private System.Windows.Forms.TextBox FName_TB;
        private System.Windows.Forms.TextBox University_TB;
        private System.Windows.Forms.TextBox NationalID_TB;
        private System.Windows.Forms.DateTimePicker Birthdate_Picker;
        private System.Windows.Forms.CheckBox Admin_CB;
        private System.Windows.Forms.Panel Admin_Panel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker HireDate_DB;
        private System.Windows.Forms.TextBox Shift_TB;
        private System.Windows.Forms.TextBox Salary_TB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label HD_lbl;
        private System.Windows.Forms.Label Salary_lbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Uni_ID_TB;
        private System.Windows.Forms.TextBox GPA_TB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel Student_Panel;
        private System.Windows.Forms.Panel Code_Panel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Code_TB;
        private System.Windows.Forms.Button Check_btn;
    }
}