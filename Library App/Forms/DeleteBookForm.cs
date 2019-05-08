using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_App.Class_Lib;
namespace Library_App.Forms
{
    public partial class DeleteBookForm : Form
    {
        public DeleteBookForm()
        {
            InitializeComponent();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            if (ISBN_TB.Text.Length == 0) return;
            Book B = Book.LoadByISBN(int.Parse(ISBN_TB.Text));

            if (B == null)
            {
                MessageBox.Show("Book doesn't exist");
            }
            else
            {
                B.Delete_Book();
                this.Close();
            }
        }
    }
}
