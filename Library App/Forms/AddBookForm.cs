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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
            BindComboBox();
        }

        private void BindComboBox()
        {
            au_CB.DataSource = Author.LoadALL();
            Pub_CB.DataSource = Publisher.LoadALL();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }

        private void ISBN_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Name_lbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Genre_lbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Copies_lbl_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Book.LoadByISBN(int.Parse(ISBN_TB.Text)) != null)
            {
                MessageBox.Show("ISBN already exists");
            }
            else
            {
                Book b = new Book();
                b.ISBN = int.Parse(ISBN_TB.Text);
                b.Name = Name_TB.Text;
                b.Genre = Genre_TB.Text;
                b.Copies = short.Parse(Copies_TB.Text);

                int Author_id;
                int Publisher_id;
                
                if (Pub_CB.SelectedIndex == -1) { Publisher_id = -1; MessageBox.Show("Choose Publisher or Add one"); return; }
                else                            Publisher_id = (int)Pub_CB.SelectedValue;

                if (au_CB.SelectedIndex == -1) { Author_id = -1; MessageBox.Show("Choose Publisher or Add one"); return; }
                else                            Author_id = (int)au_CB.SelectedValue;

                
                b.Author = Author.LoadById(Author_id);
                b.Publisher = Publisher.LoadById(Publisher_id);
                b.add();
                this.Close();
            }
        }

        private void addAuthor_btn_Click(object sender, EventArgs e)
        {
            AddAuthorForm form = new AddAuthorForm();
            form.FormClosed += new FormClosedEventHandler(Form_Closed);
            form.ShowDialog();
        }
        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            BindComboBox();
        }

        private void add_pub_btn_Click(object sender, EventArgs e)
        {
            AddPublisherFormcs form = new AddPublisherFormcs();
            form.FormClosed += new FormClosedEventHandler(Form_Closed);
            form.ShowDialog();
        }
    }
}
