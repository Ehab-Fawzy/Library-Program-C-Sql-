namespace Library_App.Forms
{
    partial class BorrowForm
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
            this.ISBN_TB = new System.Windows.Forms.TextBox();
            this.ISBN_lbl = new System.Windows.Forms.Label();
            this.Edition_CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(168, 159);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(103, 36);
            this.Submit_btn.TabIndex = 4;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // ISBN_TB
            // 
            this.ISBN_TB.Location = new System.Drawing.Point(132, 31);
            this.ISBN_TB.Name = "ISBN_TB";
            this.ISBN_TB.Size = new System.Drawing.Size(141, 20);
            this.ISBN_TB.TabIndex = 1;
            // 
            // ISBN_lbl
            // 
            this.ISBN_lbl.AutoSize = true;
            this.ISBN_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ISBN_lbl.Location = new System.Drawing.Point(27, 31);
            this.ISBN_lbl.Name = "ISBN_lbl";
            this.ISBN_lbl.Size = new System.Drawing.Size(52, 24);
            this.ISBN_lbl.TabIndex = 11;
            this.ISBN_lbl.Text = "ISBN";
            // 
            // Edition_CB
            // 
            this.Edition_CB.FormattingEnabled = true;
            this.Edition_CB.Location = new System.Drawing.Point(132, 84);
            this.Edition_CB.Name = "Edition_CB";
            this.Edition_CB.Size = new System.Drawing.Size(141, 21);
            this.Edition_CB.TabIndex = 2;
            this.Edition_CB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(27, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Edition";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show Edition";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 221);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Edition_CB);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.ISBN_TB);
            this.Controls.Add(this.ISBN_lbl);
            this.Name = "BorrowForm";
            this.Text = "BorrowForm";
            this.Load += new System.EventHandler(this.BorrowForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.TextBox ISBN_TB;
        private System.Windows.Forms.Label ISBN_lbl;
        private System.Windows.Forms.ComboBox Edition_CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}