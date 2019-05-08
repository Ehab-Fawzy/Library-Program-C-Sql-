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
using Library_App.Forms.Reports;

namespace Library_App.Forms
{
    public partial class AdminForm : Form
    {
        Admin me;
        public AdminForm(Admin a)
        {
            InitializeComponent();
            me = a;

            StudentsBind();
            BooksBind();
            Book_Grid.Visible = false;
            Students_Grid.Visible = true;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void StudentsBind()
        {
            studentBindingSource.DataSource = Student.LoadALL();
        }

        private void BooksBind()
        {
            bookBindingSource.DataSource = Book.LoadALL();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void view_std_btn_Click(object sender, EventArgs e)
        {
            Book_Grid.Visible = false;
            Students_Grid.Visible = true;
            label1.Text = "Students";
        }

        private void view_books_btn_Click(object sender, EventArgs e)
        {
            Book_Grid.Visible = true;
            Students_Grid.Visible = false;
            label1.Text = "Books";
        }

        private void Book_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addBook_btn_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.FormClosed += new FormClosedEventHandler(Form_Closed);
            addBookForm.Show();
        }
        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            BooksBind();
            StudentsBind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Edition_Form form = new Add_Edition_Form();
            form.FormClosed += new FormClosedEventHandler(Form_Closed);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteStudentForm form = new DeleteStudentForm();
            form.FormClosed += new FormClosedEventHandler(Form_Closed);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteBookForm form = new DeleteBookForm();
            form.FormClosed += new FormClosedEventHandler(Form_Closed);
            form.Show();

        }

        private void editBook_btn_Click(object sender, EventArgs e)
        {
            Book c = (Book)Book_Grid.CurrentRow.DataBoundItem;
            c.saveChanges();
            MessageBox.Show("Saved");
            BooksBind();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            User Current = User.LoadByID(me.ID);
            UpdateUserDetails form = new UpdateUserDetails(Current);
            form.Show();
        }

        private void reportbtn_Click(object sender, EventArgs e)
        {
            ReportForm rf = new ReportForm();
            rf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lg = new LoginForm();
            lg.ShowDialog();
            this.Close();
        }
    }
}
