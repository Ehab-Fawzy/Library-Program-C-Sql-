namespace Library_App.Forms
{
    partial class AddPublisherFormcs
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
            this.Address_lbl = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Address_TB = new System.Windows.Forms.TextBox();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Submit_btn
            // 
            this.Submit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_btn.Location = new System.Drawing.Point(36, 202);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(247, 50);
            this.Submit_btn.TabIndex = 3;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // Address_lbl
            // 
            this.Address_lbl.AutoSize = true;
            this.Address_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Address_lbl.Location = new System.Drawing.Point(32, 107);
            this.Address_lbl.Name = "Address_lbl";
            this.Address_lbl.Size = new System.Drawing.Size(68, 20);
            this.Address_lbl.TabIndex = 10;
            this.Address_lbl.Text = "Address";
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.Location = new System.Drawing.Point(32, 43);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(51, 20);
            this.Name_lbl.TabIndex = 9;
            this.Name_lbl.Text = "Name";
            // 
            // Address_TB
            // 
            this.Address_TB.Location = new System.Drawing.Point(127, 107);
            this.Address_TB.Name = "Address_TB";
            this.Address_TB.Size = new System.Drawing.Size(156, 20);
            this.Address_TB.TabIndex = 2;
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(127, 43);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(156, 20);
            this.Name_TB.TabIndex = 1;
            // 
            // AddPublisherFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 275);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.Address_lbl);
            this.Controls.Add(this.Name_lbl);
            this.Controls.Add(this.Address_TB);
            this.Controls.Add(this.Name_TB);
            this.Name = "AddPublisherFormcs";
            this.Text = "AddPublisherFormcs";
            this.Load += new System.EventHandler(this.AddPublisherFormcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Label Address_lbl;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.TextBox Address_TB;
        private System.Windows.Forms.TextBox Name_TB;
    }
}