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
    public partial class UpdateUserDetails : Form
    {
        User me;
        public UpdateUserDetails(User u)
        {
            InitializeComponent();
            Student_Panel.Visible = false;
            Admin_Panel.Visible = false;
            me = u;

            Username_TB.Text = me.Username;
            Password_TB.Text = me.Password;
            Repass_TB.Text = me.Password;
            FName_TB.Text = me.FName;
            SName_TB.Text = me.SName;
            Birthdate_Picker.Text = me.Birthdate.ToString();
            Address_TB.Text = me.Address;
            Email_TB.Text = me.Email;
            Phone_TB.Text = me.PhoneNumber;
            NationalID_TB.Text = me.NationalID;
            if (me.Rolename == RolesEnum.Admin)
            {
                Student_Panel.Visible = true;
                Admin_Panel.Visible = true;
                Admin a = Admin.LoadByID(me.ID);
                Salary_TB.Text = a.Salary.ToString();
                HireDate_DB.Text = a.HireDate.ToString();
                Shift_TB.Text = a.Shift.ToString();
            }
            else
            {
                Student_Panel.Visible = true;
                Student s = Student.LoadByID(me.ID);
                University_TB.Text = s.University;
                Uni_ID_TB.Text = s.University_ID.ToString();
                GPA_TB.Text = s.GPA.ToString();
            }
        }

        private void UpdateUserDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            User loaded = User.LoadByUsername(Username_TB.Text);

            if (Username_TB.Text == "" || Password_TB.Text == "" || Repass_TB.Text == "")
            {
                MessageBox.Show("Please Enter Username and Passwords");
            }
            else if (loaded != null && loaded.ID != me.ID)
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
            else
            {
                User u = new User();
                u.ID = me.ID;
                u.Username = Username_TB.Text;
                u.Password = Password_TB.Text;
                u.FName = FName_TB.Text;
                u.SName = SName_TB.Text;
                u.Birthdate = Birthdate_Picker.Value.Date;
                u.Address = Address_TB.Text;
                u.Email = Email_TB.Text;
                u.PhoneNumber = Phone_TB.Text;
                u.NationalID = NationalID_TB.Text;
                if (me.Rolename == RolesEnum.Admin)
                {
                    u.Rolename = RolesEnum.Admin;
                    Admin a = new Admin();
                    a.CopyInto(ref u);
                    a.Shift = int.Parse(Shift_TB.Text);
                    a.Salary = double.Parse(Salary_TB.Text);
                    a.HireDate = HireDate_DB.Value.Date;
                    a.SaveChanges();
                    this.Close();
                }
                else
                {
                    u.Rolename = RolesEnum.Student;
                    Student s = new Student();
                    s.CopyInto(u);
                    s.University = University_TB.Text;
                    s.University_ID = Uni_ID_TB.Text;
                    s.GPA = double.Parse(GPA_TB.Text);
                    s.SaveChanges();
                    this.Close();
                }
            }
        }

        private void NationalID_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Repass_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Repass_TB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
