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
    public partial class BorrowForm : Form
    {
        public int std_ID;
        public BorrowForm(int std_id)
        {
            InitializeComponent();
            std_ID = std_id ;
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {

        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            Student s = Student.LoadByID(std_ID);
            s.Borrow(int.Parse(ISBN_TB.Text));
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ISBN_TB.Text != null)
            {
                Book b = Book.LoadByISBN(int.Parse(ISBN_TB.Text));
                if (b != null)
                {
                    Edition_CB.DataSource = b.LoadAllEditions();
                }
            }
        }
    }
}
