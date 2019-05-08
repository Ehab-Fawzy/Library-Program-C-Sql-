namespace Library_App.Forms
{
    partial class Add_Edition_Form
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
            this.ISBN_TB = new System.Windows.Forms.TextBox();
            this.ISBN_lbl = new System.Windows.Forms.Label();
            this.Edition_TB = new System.Windows.Forms.TextBox();
            this.Edition = new System.Windows.Forms.Label();
            this.Pages_TB = new System.Windows.Forms.TextBox();
            this.Pages = new System.Windows.Forms.Label();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ISBN_TB
            // 
            this.ISBN_TB.Location = new System.Drawing.Point(104, 19);
            this.ISBN_TB.Name = "ISBN_TB";
            this.ISBN_TB.Size = new System.Drawing.Size(167, 20);
            this.ISBN_TB.TabIndex = 1;
            // 
            // ISBN_lbl
            // 
            this.ISBN_lbl.AutoSize = true;
            this.ISBN_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ISBN_lbl.Location = new System.Drawing.Point(22, 19);
            this.ISBN_lbl.Name = "ISBN_lbl";
            this.ISBN_lbl.Size = new System.Drawing.Size(47, 20);
            this.ISBN_lbl.TabIndex = 2;
            this.ISBN_lbl.Text = "ISBN";
            // 
            // Edition_TB
            // 
            this.Edition_TB.Location = new System.Drawing.Point(104, 148);
            this.Edition_TB.Name = "Edition_TB";
            this.Edition_TB.Size = new System.Drawing.Size(167, 20);
            this.Edition_TB.TabIndex = 3;
            this.Edition_TB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Edition
            // 
            this.Edition.AutoSize = true;
            this.Edition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Edition.Location = new System.Drawing.Point(21, 148);
            this.Edition.Name = "Edition";
            this.Edition.Size = new System.Drawing.Size(58, 20);
            this.Edition.TabIndex = 6;
            this.Edition.Text = "Edition";
            // 
            // Pages_TB
            // 
            this.Pages_TB.Location = new System.Drawing.Point(104, 87);
            this.Pages_TB.Name = "Pages_TB";
            this.Pages_TB.Size = new System.Drawing.Size(167, 20);
            this.Pages_TB.TabIndex = 2;
            // 
            // Pages
            // 
            this.Pages.AutoSize = true;
            this.Pages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Pages.Location = new System.Drawing.Point(22, 87);
            this.Pages.Name = "Pages";
            this.Pages.Size = new System.Drawing.Size(54, 20);
            this.Pages.TabIndex = 8;
            this.Pages.Text = "Pages";
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(25, 216);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(246, 48);
            this.Submit_btn.TabIndex = 4;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_Edition_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 283);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.Pages_TB);
            this.Controls.Add(this.Pages);
            this.Controls.Add(this.Edition_TB);
            this.Controls.Add(this.Edition);
            this.Controls.Add(this.ISBN_TB);
            this.Controls.Add(this.ISBN_lbl);
            this.Name = "Add_Edition_Form";
            this.Text = "Add_Edition_Form";
            this.Load += new System.EventHandler(this.Add_Edition_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ISBN_TB;
        private System.Windows.Forms.Label ISBN_lbl;
        private System.Windows.Forms.TextBox Edition_TB;
        private System.Windows.Forms.Label Edition;
        private System.Windows.Forms.TextBox Pages_TB;
        private System.Windows.Forms.Label Pages;
        private System.Windows.Forms.Button Submit_btn;
    }
}