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
    public partial class ReturnForm : Form
    {
        public int std_ID;
        public ReturnForm(int Std_ID)
        {
            InitializeComponent();
            std_ID = Std_ID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( ISBN_TB.Text.Length > 0 )
            {
                Book b = Book.LoadByISBN(int.Parse(ISBN_TB.Text));
                if (b != null)
                {
                    Edition_CB.DataSource = b.LoadAllEditions();
                }
            }
            else
                MessageBox.Show("ISBN is empty");
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            if ( ISBN_TB.Text.Length == 0 )
            {
                MessageBox.Show("ISBN is empty");
            }
            else
            {
                Book b = Book.LoadByISBN(int.Parse(ISBN_TB.Text));
                if (b == null)
                {
                    MessageBox.Show("You Haven't Borrowed Book with this ISBN");
                }
                else
                {
                    bool isFound = false;
                    Student me = Student.LoadByID(std_ID);
                    List<Book> lst = me.LoadAllBorrowedBooks();
                    foreach (var item in lst)
                    {
                        if (item.ISBN == int.Parse(ISBN_TB.Text))
                        {
                            Student s = Student.LoadByID(std_ID);
                            s.Return(int.Parse(ISBN_TB.Text));
                            isFound = true;
                        }
                    }
                    if (!isFound)
                    {
                        MessageBox.Show("You Haven't Borrowed Book with this ISBN");
                    }
                }
            }
            this.Close();
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {

        }
    }
}
