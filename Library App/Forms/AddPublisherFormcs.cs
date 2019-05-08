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
    public partial class AddPublisherFormcs : Form
    {
        public AddPublisherFormcs()
        {
            InitializeComponent();
        }

        private void AddPublisherFormcs_Load(object sender, EventArgs e)
        {

        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            Publisher p = new Publisher();
            p.Name = Name_TB.Text;
            p.Address = Address_TB.Text;
            if (p.Name == "")
            {
                MessageBox.Show("Publisher Name cannot be empty!");
            }
            else
            {
                p.Add();
                this.Close();
            }
        }
    }
}
