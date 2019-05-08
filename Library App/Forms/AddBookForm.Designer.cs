namespace Library_App.Forms
{
    partial class AddBookForm
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
            this.ISBN_lbl = new System.Windows.Forms.Label();
            this.ISBN_TB = new System.Windows.Forms.TextBox();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Genre_TB = new System.Windows.Forms.TextBox();
            this.Genre_lbl = new System.Windows.Forms.Label();
            this.Copies_TB = new System.Windows.Forms.TextBox();
            this.Copies_lbl = new System.Windows.Forms.Label();
            this.AddBook_btn = new System.Windows.Forms.Button();
            this.au_CB = new System.Windows.Forms.ComboBox();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Pub_CB = new System.Windows.Forms.ComboBox();
            this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Author_lbl = new System.Windows.Forms.Label();
            this.Publisher_lbl = new System.Windows.Forms.Label();
            this.addAuthor_btn = new System.Windows.Forms.Button();
            this.add_pub_btn = new System.Windows.Forms.Button();
            this.publisherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ISBN_lbl
            // 
            this.ISBN_lbl.AutoSize = true;
            this.ISBN_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ISBN_lbl.Location = new System.Drawing.Point(31, 24);
            this.ISBN_lbl.Name = "ISBN_lbl";
            this.ISBN_lbl.Size = new System.Drawing.Size(52, 24);
            this.ISBN_lbl.TabIndex = 0;
            this.ISBN_lbl.Text = "ISBN";
            this.ISBN_lbl.Click += new System.EventHandler(this.ISBN_lbl_Click);
            // 
            // ISBN_TB
            // 
            this.ISBN_TB.Location = new System.Drawing.Point(131, 28);
            this.ISBN_TB.Name = "ISBN_TB";
            this.ISBN_TB.Size = new System.Drawing.Size(155, 20);
            this.ISBN_TB.TabIndex = 1;
            this.ISBN_TB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(131, 96);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(155, 20);
            this.Name_TB.TabIndex = 2;
            this.Name_TB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Name_lbl.Location = new System.Drawing.Point(31, 92);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(61, 24);
            this.Name_lbl.TabIndex = 2;
            this.Name_lbl.Text = "Name";
            this.Name_lbl.Click += new System.EventHandler(this.Name_lbl_Click);
            // 
            // Genre_TB
            // 
            this.Genre_TB.Location = new System.Drawing.Point(131, 167);
            this.Genre_TB.Name = "Genre_TB";
            this.Genre_TB.Size = new System.Drawing.Size(155, 20);
            this.Genre_TB.TabIndex = 3;
            this.Genre_TB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Genre_lbl
            // 
            this.Genre_lbl.AutoSize = true;
            this.Genre_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Genre_lbl.Location = new System.Drawing.Point(31, 158);
            this.Genre_lbl.Name = "Genre_lbl";
            this.Genre_lbl.Size = new System.Drawing.Size(63, 24);
            this.Genre_lbl.TabIndex = 4;
            this.Genre_lbl.Text = "Genre";
            this.Genre_lbl.Click += new System.EventHandler(this.Genre_lbl_Click);
            // 
            // Copies_TB
            // 
            this.Copies_TB.Location = new System.Drawing.Point(131, 231);
            this.Copies_TB.Name = "Copies_TB";
            this.Copies_TB.Size = new System.Drawing.Size(155, 20);
            this.Copies_TB.TabIndex = 4;
            this.Copies_TB.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Copies_lbl
            // 
            this.Copies_lbl.AutoSize = true;
            this.Copies_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Copies_lbl.Location = new System.Drawing.Point(31, 227);
            this.Copies_lbl.Name = "Copies_lbl";
            this.Copies_lbl.Size = new System.Drawing.Size(69, 24);
            this.Copies_lbl.TabIndex = 6;
            this.Copies_lbl.Text = "Copies";
            this.Copies_lbl.Click += new System.EventHandler(this.Copies_lbl_Click);
            // 
            // AddBook_btn
            // 
            this.AddBook_btn.Location = new System.Drawing.Point(340, 315);
            this.AddBook_btn.Name = "AddBook_btn";
            this.AddBook_btn.Size = new System.Drawing.Size(251, 39);
            this.AddBook_btn.TabIndex = 9;
            this.AddBook_btn.Text = "AddBook";
            this.AddBook_btn.UseVisualStyleBackColor = true;
            this.AddBook_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // au_CB
            // 
            this.au_CB.DataSource = this.authorBindingSource;
            this.au_CB.DisplayMember = "Name";
            this.au_CB.FormattingEnabled = true;
            this.au_CB.Location = new System.Drawing.Point(367, 95);
            this.au_CB.Name = "au_CB";
            this.au_CB.Size = new System.Drawing.Size(121, 21);
            this.au_CB.TabIndex = 5;
            this.au_CB.ValueMember = "ID";
            this.au_CB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataSource = typeof(Library_App.Class_Lib.Author);
            // 
            // Pub_CB
            // 
            this.Pub_CB.DataSource = this.publisherBindingSource;
            this.Pub_CB.DisplayMember = "Name";
            this.Pub_CB.FormattingEnabled = true;
            this.Pub_CB.Location = new System.Drawing.Point(367, 230);
            this.Pub_CB.Name = "Pub_CB";
            this.Pub_CB.Size = new System.Drawing.Size(121, 21);
            this.Pub_CB.TabIndex = 7;
            this.Pub_CB.ValueMember = "ID";
            // 
            // publisherBindingSource
            // 
            this.publisherBindingSource.DataSource = typeof(Library_App.Class_Lib.Publisher);
            // 
            // Author_lbl
            // 
            this.Author_lbl.AutoSize = true;
            this.Author_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Author_lbl.Location = new System.Drawing.Point(396, 52);
            this.Author_lbl.Name = "Author_lbl";
            this.Author_lbl.Size = new System.Drawing.Size(66, 24);
            this.Author_lbl.TabIndex = 11;
            this.Author_lbl.Text = "Author";
            // 
            // Publisher_lbl
            // 
            this.Publisher_lbl.AutoSize = true;
            this.Publisher_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Publisher_lbl.Location = new System.Drawing.Point(387, 194);
            this.Publisher_lbl.Name = "Publisher_lbl";
            this.Publisher_lbl.Size = new System.Drawing.Size(89, 24);
            this.Publisher_lbl.TabIndex = 12;
            this.Publisher_lbl.Text = "Publisher";
            // 
            // addAuthor_btn
            // 
            this.addAuthor_btn.Location = new System.Drawing.Point(508, 93);
            this.addAuthor_btn.Name = "addAuthor_btn";
            this.addAuthor_btn.Size = new System.Drawing.Size(83, 23);
            this.addAuthor_btn.TabIndex = 6;
            this.addAuthor_btn.Text = "Add Author";
            this.addAuthor_btn.UseVisualStyleBackColor = true;
            this.addAuthor_btn.Click += new System.EventHandler(this.addAuthor_btn_Click);
            // 
            // add_pub_btn
            // 
            this.add_pub_btn.Location = new System.Drawing.Point(508, 230);
            this.add_pub_btn.Name = "add_pub_btn";
            this.add_pub_btn.Size = new System.Drawing.Size(83, 23);
            this.add_pub_btn.TabIndex = 8;
            this.add_pub_btn.Text = "Add Publisher";
            this.add_pub_btn.UseVisualStyleBackColor = true;
            this.add_pub_btn.Click += new System.EventHandler(this.add_pub_btn_Click);
            // 
            // publisherBindingSource1
            // 
            this.publisherBindingSource1.DataSource = typeof(Library_App.Class_Lib.Publisher);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 387);
            this.Controls.Add(this.add_pub_btn);
            this.Controls.Add(this.addAuthor_btn);
            this.Controls.Add(this.Publisher_lbl);
            this.Controls.Add(this.Author_lbl);
            this.Controls.Add(this.Pub_CB);
            this.Controls.Add(this.au_CB);
            this.Controls.Add(this.AddBook_btn);
            this.Controls.Add(this.Copies_TB);
            this.Controls.Add(this.Copies_lbl);
            this.Controls.Add(this.Genre_TB);
            this.Controls.Add(this.Genre_lbl);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.Name_lbl);
            this.Controls.Add(this.ISBN_TB);
            this.Controls.Add(this.ISBN_lbl);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ISBN_lbl;
        private System.Windows.Forms.TextBox ISBN_TB;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.TextBox Genre_TB;
        private System.Windows.Forms.Label Genre_lbl;
        private System.Windows.Forms.TextBox Copies_TB;
        private System.Windows.Forms.Label Copies_lbl;
        private System.Windows.Forms.Button AddBook_btn;
        private System.Windows.Forms.ComboBox au_CB;
        private System.Windows.Forms.ComboBox Pub_CB;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private System.Windows.Forms.Label Author_lbl;
        private System.Windows.Forms.Label Publisher_lbl;
        private System.Windows.Forms.BindingSource publisherBindingSource;
        private System.Windows.Forms.Button addAuthor_btn;
        private System.Windows.Forms.Button add_pub_btn;
        private System.Windows.Forms.BindingSource publisherBindingSource1;
    }
}