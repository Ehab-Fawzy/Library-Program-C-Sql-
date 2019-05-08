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
    public partial class Add_Edition_Form : Form
    {
        public Add_Edition_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ISBN_TB.Text.Length == 0) return;
            Book b = Book.LoadByISBN(int.Parse(ISBN_TB.Text));
            int bookID = b.ID;
            if (b == null)
            {
                MessageBox.Show("Book doesn't exist");
            }
            else
            {
                LibraryDBDataContext db = new LibraryDBDataContext();
                tbl_Edition ed = (
                            from Edition in db.tbl_Editions
                            where (Edition.BookID == bookID) && (Edition.Version == Edition_TB.Text)
                            select Edition
                        ).FirstOrDefault();
                if (ed != null)
                {
                    MessageBox.Show("Edition already exists");
                }
                else
                {
                    tbl_Edition Edition = new tbl_Edition();
                    Edition.BookID = bookID;
                    Edition.Version = Edition_TB.Text;
                    Edition.Pages = int.Parse(Pages_TB.Text);
                    db.tbl_Editions.InsertOnSubmit(Edition);
                    db.SubmitChanges();
                    this.Close();
                }
            }
        }

        private void Add_Edition_Form_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
