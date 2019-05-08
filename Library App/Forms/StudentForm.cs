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
    public partial class StudentForm : Form
    {
        public User me = new User();
        public StudentForm(User u)
        {
            me = u;
            InitializeComponent();
            label1.Text += (me.FName + " " + me.SName);
            BookBind();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
        
        private void BookBind()
        {
            Book_Grid.DataSource = Book.LoadALLDistinct();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            BorrowForm form = new BorrowForm(me.ID);
            form.Show();
            form.FormClosed += new FormClosedEventHandler(Form_Closed);
        }
        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            BookBind();
        }

        private void Borrowed_ChB_CheckedChanged(object sender, EventArgs e)
        {
            if (Borrowed_ChB.Checked)
            {
                Student s = Student.LoadByID(me.ID);
                Book_Grid.DataSource = s.LoadAllBorrowedBooks();
                copiesDataGridViewTextBoxColumn.Visible = false;
            }
            else
            {
                BookBind();
                copiesDataGridViewTextBoxColumn.Visible = true;
            }
               
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            /*List<Book> lst = ((Student)me).LoadAllBorrowedBooks();

            foreach( var item in lst )
            {
                if 
            }*/

            ReturnForm form = new ReturnForm(me.ID);
            form.Show();
            form.FormClosed += new FormClosedEventHandler(Form_Closed);
        }

        private void Book_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            User Current = User.LoadByID(me.ID);
            UpdateUserDetails form = new UpdateUserDetails(Current);
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lg = new LoginForm();
            lg.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
