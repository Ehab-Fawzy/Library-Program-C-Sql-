namespace Library_App.Forms
{
    partial class DeleteBookForm
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
            this.SuspendLayout();
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(28, 90);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(203, 34);
            this.Submit_btn.TabIndex = 2;
            this.Submit_btn.Text = "Delete";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // ISBN_TB
            // 
            this.ISBN_TB.Location = new System.Drawing.Point(110, 32);
            this.ISBN_TB.Name = "ISBN_TB";
            this.ISBN_TB.Size = new System.Drawing.Size(121, 20);
            this.ISBN_TB.TabIndex = 1;
            // 
            // ISBN_lbl
            // 
            this.ISBN_lbl.AutoSize = true;
            this.ISBN_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ISBN_lbl.Location = new System.Drawing.Point(24, 28);
            this.ISBN_lbl.Name = "ISBN_lbl";
            this.ISBN_lbl.Size = new System.Drawing.Size(52, 24);
            this.ISBN_lbl.TabIndex = 23;
            this.ISBN_lbl.Text = "ISBN";
            // 
            // DeleteBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 149);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.ISBN_TB);
            this.Controls.Add(this.ISBN_lbl);
            this.Name = "DeleteBookForm";
            this.Text = "DeleteBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.TextBox ISBN_TB;
        private System.Windows.Forms.Label ISBN_lbl;
    }
}