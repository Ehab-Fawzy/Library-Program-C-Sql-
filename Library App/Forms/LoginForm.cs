using Library_App.Class_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Library_App.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (Username_TB.Text == "" || Password_TB.Text == "")
            {
                MessageBox.Show("Please Enter Username and Passwords");
            }
            else
            {
                User user = new Admin();
                user = User.Login(Username_TB.Text, Password_TB.Text);
                
                if (user == null)
                {
                    MessageBox.Show("Not Found!");
                    Username_TB.Clear();
                    Password_TB.Clear();
                }
                else
                {
                    if (user.Rolename == RolesEnum.Admin)
                    {
                        this.Hide();
                        Admin admin = new Admin();
                        user.CopyInto(ref admin);
                        admin.loadAdminDetails();
                        AdminForm form = new AdminForm(admin);
                        form.ShowDialog();
                    }
                    else
                    {
                        this.Hide();
                        StudentForm form = new StudentForm(user);
                        form.ShowDialog();
                    }
                    this.Close();
                }
            }
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccountForm form = new CreateAccountForm();
            form.ShowDialog();
            this.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
