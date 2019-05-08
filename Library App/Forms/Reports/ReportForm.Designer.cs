namespace Library_App.Forms.Reports
{
    partial class ReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.borrowDataSet = new Library_App.borrowDataSet();
            this.borrowDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new Library_App.LibraryDataSet();
            this.tblBorrowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_BorrowTableAdapter = new Library_App.LibraryDataSetTableAdapters.tbl_BorrowTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.borrowDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBorrowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "borrowReport";
            reportDataSource1.Value = this.tblBorrowBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Library_App.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // borrowDataSet
            // 
            this.borrowDataSet.DataSetName = "borrowDataSet";
            this.borrowDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borrowDataSetBindingSource
            // 
            this.borrowDataSetBindingSource.DataSource = this.borrowDataSet;
            this.borrowDataSetBindingSource.Position = 0;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBorrowBindingSource
            // 
            this.tblBorrowBindingSource.DataMember = "tbl_Borrow";
            this.tblBorrowBindingSource.DataSource = this.libraryDataSet;
            // 
            // tbl_BorrowTableAdapter
            // 
            this.tbl_BorrowTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.borrowDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBorrowBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource borrowDataSetBindingSource;
        private borrowDataSet borrowDataSet;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource tblBorrowBindingSource;
        private LibraryDataSetTableAdapters.tbl_BorrowTableAdapter tbl_BorrowTableAdapter;
    }
}