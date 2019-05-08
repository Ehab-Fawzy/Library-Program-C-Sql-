namespace Library_App.Forms
{
    partial class DeleteStudentForm
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
            this.Submit_btn = new System.Windows.Forms.Button();
            this.Username_TB = new System.Windows.Forms.TextBox();
            this.ISBN_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(16, 101);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(240, 36);
            this.Submit_btn.TabIndex = 2;
            this.Submit_btn.Text = "Delete";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // Username_TB
            // 
            this.Username_TB.Location = new System.Drawing.Point(135, 35);
            this.Username_TB.Name = "Username_TB";
            this.Username_TB.Size = new System.Drawing.Size(121, 20);
            this.Username_TB.TabIndex = 1;
            this.Username_TB.TextChanged += new System.EventHandler(this.Username_TB_TextChanged);
            // 
            // ISBN_lbl
            // 
            this.ISBN_lbl.AutoSize = true;
            this.ISBN_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ISBN_lbl.Location = new System.Drawing.Point(12, 30);
            this.ISBN_lbl.Name = "ISBN_lbl";
            this.ISBN_lbl.Size = new System.Drawing.Size(97, 24);
            this.ISBN_lbl.TabIndex = 20;
            this.ISBN_lbl.Text = "Username";
            this.ISBN_lbl.Click += new System.EventHandler(this.ISBN_lbl_Click);
            // 
            // DeleteStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 166);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.Username_TB);
            this.Controls.Add(this.ISBN_lbl);
            this.Name = "DeleteStudentForm";
            this.Text = "DeleteStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.TextBox Username_TB;
        private System.Windows.Forms.Label ISBN_lbl;
    }
}