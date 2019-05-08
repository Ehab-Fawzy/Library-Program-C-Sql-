namespace Library_App.Forms
{
    partial class AddAuthorForm
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
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Address_TB = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Address_lbl = new System.Windows.Forms.Label();
            this.Birthdate = new System.Windows.Forms.Label();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(141, 28);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(200, 20);
            this.Name_TB.TabIndex = 0;
            this.Name_TB.TextChanged += new System.EventHandler(this.Name_TB_TextChanged);
            // 
            // Address_TB
            // 
            this.Address_TB.Location = new System.Drawing.Point(141, 92);
            this.Address_TB.Name = "Address_TB";
            this.Address_TB.Size = new System.Drawing.Size(200, 20);
            this.Address_TB.TabIndex = 1;
            this.Address_TB.TextChanged += new System.EventHandler(this.Address_TB_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.Location = new System.Drawing.Point(27, 28);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(51, 20);
            this.Name_lbl.TabIndex = 3;
            this.Name_lbl.Text = "Name";
            this.Name_lbl.Click += new System.EventHandler(this.Name_lbl_Click);
            // 
            // Address_lbl
            // 
            this.Address_lbl.AutoSize = true;
            this.Address_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Address_lbl.Location = new System.Drawing.Point(27, 92);
            this.Address_lbl.Name = "Address_lbl";
            this.Address_lbl.Size = new System.Drawing.Size(68, 20);
            this.Address_lbl.TabIndex = 4;
            this.Address_lbl.Text = "Address";
            this.Address_lbl.Click += new System.EventHandler(this.Address_lbl_Click);
            // 
            // Birthdate
            // 
            this.Birthdate.AutoSize = true;
            this.Birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Birthdate.Location = new System.Drawing.Point(27, 159);
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.Size = new System.Drawing.Size(74, 20);
            this.Birthdate.TabIndex = 5;
            this.Birthdate.Text = "Birthdate";
            this.Birthdate.Click += new System.EventHandler(this.Birthdate_Click);
            // 
            // Submit_btn
            // 
            this.Submit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_btn.Location = new System.Drawing.Point(31, 255);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(310, 57);
            this.Submit_btn.TabIndex = 3;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // AddAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 332);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.Birthdate);
            this.Controls.Add(this.Address_lbl);
            this.Controls.Add(this.Name_lbl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Address_TB);
            this.Controls.Add(this.Name_TB);
            this.Name = "AddAuthorForm";
            this.Text = "AddAuthorForm";
            this.Load += new System.EventHandler(this.AddAuthorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.TextBox Address_TB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Label Address_lbl;
        private System.Windows.Forms.Label Birthdate;
        private System.Windows.Forms.Button Submit_btn;
    }
}