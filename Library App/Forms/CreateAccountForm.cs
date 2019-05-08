using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_App.Class_Lib;
using System.Windows.Forms;

namespace Library_App.Forms
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
            Admin_Panel.Visible = false;
            Student_Panel.Visible = true;
            Code_Panel.Visible = false;
        }
        

        private void Create_btn_Click(object sender, EventArgs e)
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            if (Username_TB.Text == "" || Password_TB.Text == "" || Repass_TB.Text == "")
            {
                MessageBox.Show("Please Enter Username and Passwords");
            }
            else if (User.LoadByUsername(Username_TB.Text) != null)
            {
                MessageBox.Show("UserName Exists!");
            }        
            else if (Password_TB.Text != Repass_TB.Text)
            {
                MessageBox.Show("Passwords aren't identical!");
            }
            else if (FName_TB.Text == "" || SName_TB.Text == "")
            {
                MessageBox.Show("Please Enter Your Name!");
            }
            else if (Phone_TB.Text == "")
            {
                MessageBox.Show("Please Enter Your Phone Number!");
            }
            else if ( Admin_CB.Checked && Admin_Panel.Visible && ( Shift_TB.Text.Length == 0) )
            {
                MessageBox.Show("Please Enter The number of shifts!");
            }
            else if ( Admin_CB.Checked && Admin_Panel.Visible && (Salary_TB.Text.Length == 0) )
            {
                MessageBox.Show("Please Enter The Salary!");
            }
            else
            {
                User u = new User() ;
                u.Username = Username_TB.Text;
                u.Password = Password_TB.Text;
                u.FName = FName_TB.Text;
                u.SName = SName_TB.Text;
                u.Birthdate = Birthdate_Picker.Value.Date;
                u.Address = Address_TB.Text;
                u.Email = Email_TB.Text;
                u.PhoneNumber = Phone_TB.Text;
                u.NationalID = NationalID_TB.Text;
                if (Admin_CB.Checked)
                {
                    if (Admin_Panel.Visible == true)
                    {
                        u.Rolename = RolesEnum.Admin;
                        Admin a = new Admin();
                        a.CopyInto(ref u);
                        a.Shift = int.Parse(Shift_TB.Text);
                        a.Salary = double.Parse(Salary_TB.Text);
                        a.HireDate = HireDate_DB.Value.Date;
                        a.Add();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Please Enter The Code First");
                }
                else
                {
                    Student s = new Student();
                    u.Rolename = RolesEnum.Student;
                    s.CopyInto(u);
                    s.University = University_TB.Text;
                    s.University_ID = Uni_ID_TB.Text;

                    if (GPA_TB.Text.Length == 0)
                        s.GPA = 0;
                    else
                        s.GPA = double.Parse(GPA_TB.Text);
                    s.Add();
                    this.Close();
                }
                
                
            }

        }

        private void Admin_CB_CheckedChanged(object sender, EventArgs e)
        {
            if (Admin_CB.Checked)
            {
                Code_Panel.Visible = true;
                Student_Panel.Visible = false;
                Admin_Panel.Visible = false;
            }
            else
            {
                Admin_Panel.Visible = false;
                Student_Panel.Visible = true;
                Code_Panel.Visible = false;
            }
        }

        private void CreateAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Check_btn_Click(object sender, EventArgs e)
        {
            if (Code_TB.Text == "admin")
            {
                Code_Panel.Visible = false;
                Admin_Panel.Visible = true;
            }
            else
                MessageBox.Show("Wrong Code!");
            Code_TB.Clear();
        }

        private void Username_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Username_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Repass_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Repass_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Phone_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Address_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void SName_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void FName_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void University_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void NationalID_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Birthdate_Picker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HireDate_DB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Shift_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salary_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void HD_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Salary_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Uni_ID_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void GPA_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Student_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Code_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Code_TB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
