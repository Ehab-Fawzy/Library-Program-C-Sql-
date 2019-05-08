using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_App.Forms.Reports
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.tbl_Borrow' table. You can move, or remove it, as needed.
            this.tbl_BorrowTableAdapter.Fill(this.libraryDataSet.tbl_Borrow);

            this.reportViewer1.RefreshReport();
        }
    }
}
