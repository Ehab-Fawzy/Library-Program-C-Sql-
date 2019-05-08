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
    public partial class DeleteStudentForm : Form
    {
        public DeleteStudentForm()
        {
            InitializeComponent();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            if (Username_TB.Text.Length == 0) return;
            Student S = Student.LoadByUsername(Username_TB.Text);
            if (S == null)
            {
                MessageBox.Show("Username doesn't exist");
            }
            else
            {
                S.Delete_Student();
                this.Close();
            }
        }

        private void ISBN_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Username_TB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
