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
    public partial class AddAuthorForm : Form
    {
        public AddAuthorForm()
        {
            InitializeComponent();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            Author a = new Author();
            a.Name = Name_TB.Text;
            a.Address = Address_TB.Text;
            a.Birthdate = dateTimePicker1.Value.Date;
            if (a.Name == "")
            {
                MessageBox.Show("Name Cannot be empty!");
            }
            else
            {
                a.Add();
                this.Close();
            }
        }

        private void AddAuthorForm_Load(object sender, EventArgs e)
        {

        }

        private void Name_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Address_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Address_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Birthdate_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
