namespace Library_App.Forms
{
    partial class AdminForm
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
            this.Students_Grid = new System.Windows.Forms.DataGridView();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Book_Grid = new System.Windows.Forms.DataGridView();
            this.addBook_btn = new System.Windows.Forms.Button();
            this.editBook_btn = new System.Windows.Forms.Button();
            this.view_books_btn = new System.Windows.Forms.Button();
            this.view_std_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.reportbtn = new System.Windows.Forms.Button();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publihserAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorBirthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Students_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Book_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Students_Grid
            // 
            this.Students_Grid.AutoGenerateColumns = false;
            this.Students_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Students_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.SName,
            this.universityIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.gPADataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.nationalIDDataGridViewTextBoxColumn});
            this.Students_Grid.DataSource = this.studentBindingSource;
            this.Students_Grid.Location = new System.Drawing.Point(12, 127);
            this.Students_Grid.Name = "Students_Grid";
            this.Students_Grid.Size = new System.Drawing.Size(843, 399);
            this.Students_Grid.TabIndex = 0;
            this.Students_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SName
            // 
            this.SName.DataPropertyName = "SName";
            this.SName.HeaderText = "Last Name";
            this.SName.Name = "SName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students";
            // 
            // Book_Grid
            // 
            this.Book_Grid.AllowUserToAddRows = false;
            this.Book_Grid.AutoGenerateColumns = false;
            this.Book_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Book_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBNDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.copiesDataGridViewTextBoxColumn,
            this.pagesDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.publisherNameDataGridViewTextBoxColumn,
            this.publihserAddressDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn,
            this.authorAddressDataGridViewTextBoxColumn,
            this.authorBirthDateDataGridViewTextBoxColumn});
            this.Book_Grid.DataSource = this.bookBindingSource;
            this.Book_Grid.Location = new System.Drawing.Point(12, 127);
            this.Book_Grid.Name = "Book_Grid";
            this.Book_Grid.Size = new System.Drawing.Size(843, 399);
            this.Book_Grid.TabIndex = 2;
            this.Book_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Book_Grid_CellContentClick);
            // 
            // addBook_btn
            // 
            this.addBook_btn.Location = new System.Drawing.Point(12, 550);
            this.addBook_btn.Name = "addBook_btn";
            this.addBook_btn.Size = new System.Drawing.Size(133, 45);
            this.addBook_btn.TabIndex = 5;
            this.addBook_btn.Text = "Add Book";
            this.addBook_btn.UseVisualStyleBackColor = true;
            this.addBook_btn.Click += new System.EventHandler(this.addBook_btn_Click);
            // 
            // editBook_btn
            // 
            this.editBook_btn.Location = new System.Drawing.Point(296, 550);
            this.editBook_btn.Name = "editBook_btn";
            this.editBook_btn.Size = new System.Drawing.Size(133, 45);
            this.editBook_btn.TabIndex = 6;
            this.editBook_btn.Text = "Edit Book";
            this.editBook_btn.UseVisualStyleBackColor = true;
            this.editBook_btn.Click += new System.EventHandler(this.editBook_btn_Click);
            // 
            // view_books_btn
            // 
            this.view_books_btn.Location = new System.Drawing.Point(568, 36);
            this.view_books_btn.Name = "view_books_btn";
            this.view_books_btn.Size = new System.Drawing.Size(132, 46);
            this.view_books_btn.TabIndex = 3;
            this.view_books_btn.Text = "View Books";
            this.view_books_btn.UseVisualStyleBackColor = true;
            this.view_books_btn.Click += new System.EventHandler(this.view_books_btn_Click);
            // 
            // view_std_btn
            // 
            this.view_std_btn.Location = new System.Drawing.Point(706, 36);
            this.view_std_btn.Name = "view_std_btn";
            this.view_std_btn.Size = new System.Drawing.Size(149, 47);
            this.view_std_btn.TabIndex = 2;
            this.view_std_btn.Text = "View Students";
            this.view_std_btn.UseVisualStyleBackColor = true;
            this.view_std_btn.Click += new System.EventHandler(this.view_std_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Edition Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 550);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete Student";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(579, 550);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 45);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete Book";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 48);
            this.button4.TabIndex = 1;
            this.button4.Text = "Update Account Details";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // reportbtn
            // 
            this.reportbtn.Location = new System.Drawing.Point(151, 36);
            this.reportbtn.Name = "reportbtn";
            this.reportbtn.Size = new System.Drawing.Size(133, 48);
            this.reportbtn.TabIndex = 9;
            this.reportbtn.Text = "Generate Report";
            this.reportbtn.UseVisualStyleBackColor = true;
            this.reportbtn.Click += new System.EventHandler(this.reportbtn_Click);
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // copiesDataGridViewTextBoxColumn
            // 
            this.copiesDataGridViewTextBoxColumn.DataPropertyName = "Copies";
            this.copiesDataGridViewTextBoxColumn.HeaderText = "Copies";
            this.copiesDataGridViewTextBoxColumn.Name = "copiesDataGridViewTextBoxColumn";
            // 
            // pagesDataGridViewTextBoxColumn
            // 
            this.pagesDataGridViewTextBoxColumn.DataPropertyName = "Pages";
            this.pagesDataGridViewTextBoxColumn.HeaderText = "Pages";
            this.pagesDataGridViewTextBoxColumn.Name = "pagesDataGridViewTextBoxColumn";
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "Version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "Version";
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            // 
            // publisherNameDataGridViewTextBoxColumn
            // 
            this.publisherNameDataGridViewTextBoxColumn.DataPropertyName = "PublisherName";
            this.publisherNameDataGridViewTextBoxColumn.HeaderText = "PublisherName";
            this.publisherNameDataGridViewTextBoxColumn.Name = "publisherNameDataGridViewTextBoxColumn";
            this.publisherNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publihserAddressDataGridViewTextBoxColumn
            // 
            this.publihserAddressDataGridViewTextBoxColumn.DataPropertyName = "PublihserAddress";
            this.publihserAddressDataGridViewTextBoxColumn.HeaderText = "PublihserAddress";
            this.publihserAddressDataGridViewTextBoxColumn.Name = "publihserAddressDataGridViewTextBoxColumn";
            this.publihserAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorNameDataGridViewTextBoxColumn
            // 
            this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "AuthorName";
            this.authorNameDataGridViewTextBoxColumn.HeaderText = "AuthorName";
            this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
            this.authorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorAddressDataGridViewTextBoxColumn
            // 
            this.authorAddressDataGridViewTextBoxColumn.DataPropertyName = "AuthorAddress";
            this.authorAddressDataGridViewTextBoxColumn.HeaderText = "AuthorAddress";
            this.authorAddressDataGridViewTextBoxColumn.Name = "authorAddressDataGridViewTextBoxColumn";
            this.authorAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorBirthDateDataGridViewTextBoxColumn
            // 
            this.authorBirthDateDataGridViewTextBoxColumn.DataPropertyName = "AuthorBirthDate";
            this.authorBirthDateDataGridViewTextBoxColumn.HeaderText = "AuthorBirthDate";
            this.authorBirthDateDataGridViewTextBoxColumn.Name = "authorBirthDateDataGridViewTextBoxColumn";
            this.authorBirthDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Library_App.Class_Lib.Book);
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "FName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            // 
            // universityIDDataGridViewTextBoxColumn
            // 
            this.universityIDDataGridViewTextBoxColumn.DataPropertyName = "University_ID";
            this.universityIDDataGridViewTextBoxColumn.HeaderText = "University_ID";
            this.universityIDDataGridViewTextBoxColumn.Name = "universityIDDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "University";
            this.dataGridViewTextBoxColumn1.HeaderText = "University";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // gPADataGridViewTextBoxColumn
            // 
            this.gPADataGridViewTextBoxColumn.DataPropertyName = "GPA";
            this.gPADataGridViewTextBoxColumn.HeaderText = "GPA";
            this.gPADataGridViewTextBoxColumn.Name = "gPADataGridViewTextBoxColumn";
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // nationalIDDataGridViewTextBoxColumn
            // 
            this.nationalIDDataGridViewTextBoxColumn.DataPropertyName = "NationalID";
            this.nationalIDDataGridViewTextBoxColumn.HeaderText = "NationalID";
            this.nationalIDDataGridViewTextBoxColumn.Name = "nationalIDDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Library_App.Class_Lib.Student);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Library_App.Class_Lib.User);
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataSource = typeof(Library_App.Class_Lib.Admin);
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataSource = typeof(Library_App.Class_Lib.User);
            // 
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataSource = typeof(Library_App.Class_Lib.Publisher);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(722, 550);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 45);
            this.button5.TabIndex = 10;
            this.button5.Text = "Log out";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 606);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.reportbtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.view_std_btn);
            this.Controls.Add(this.view_books_btn);
            this.Controls.Add(this.editBook_btn);
            this.Controls.Add(this.addBook_btn);
            this.Controls.Add(this.Book_Grid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Students_Grid);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Students_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Book_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Students_Grid;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        //private System.Windows.Forms.DataGridViewTextBoxColumn universityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn universityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView Book_Grid;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.Button addBook_btn;
        private System.Windows.Forms.Button editBook_btn;
        private System.Windows.Forms.Button view_books_btn;
        private System.Windows.Forms.Button view_std_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn copiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publihserAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorBirthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button reportbtn;
        private System.Windows.Forms.Button button5;
    }
}