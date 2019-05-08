using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_App.Class_Lib
{
    public class Admin : User
    {
        public double Salary { get; set; }
        public DateTime HireDate { get; set; }
        public int Shift { get; set; }

        public Admin(tbl_AdminDetail a)
        {
            ID = a.UserID;
            Salary = a.Salary;
            HireDate = a.HireDate.Value;
            Shift = a.Shift;
        }

        public Admin() { }
        public new void Add()
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            base.Add();
            tbl_AdminDetail a = new tbl_AdminDetail();
            a.UserID = base.ID;
            a.Salary = this.Salary;
            a.HireDate = this.HireDate;
            a.Shift = this.Shift;

            db.tbl_AdminDetails.InsertOnSubmit(a);
            db.SubmitChanges();
        }
        public void loadAdminDetails()
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            tbl_AdminDetail a = (from temp in db.tbl_AdminDetails
                       where temp.UserID == this.ID
                       select temp
                       ).FirstOrDefault();
            this.Salary = a.Salary;
            this.HireDate = a.HireDate.Value;
            this.Shift = a.Shift;
        }
        public static new Admin LoadByID(int ID)
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            Admin a = (
                            from u in db.tbl_AdminDetails
                            where u.UserID == ID
                            select new Admin(u)
                        ).FirstOrDefault();
            return a;
        }
        public void CopyInto(ref User u)
        {
            ID = u.ID;
            Username = u.Username;
            Password = u.Password;
            FName = u.FName;
            SName = u.SName;
            Birthdate = u.Birthdate;
            Address = u.Address;
            Email = u.Email;
            PhoneNumber = u.PhoneNumber;
            NationalID = u.NationalID;
            Rolename = u.Rolename;
        }

        public void SaveChanges()
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            var editAdmin = (from B in db.tbl_AdminDetails
                            where B.UserID == this.ID
                            select B).FirstOrDefault();
            var editUser = (from U in db.tbl_Users
                            where U.ID == this.ID
                            select U).FirstOrDefault();
            editUser.Username = this.Username;
            editUser.Password = this.Password;
            editUser.FName = this.FName;
            editUser.SName = this.SName;
            editUser.Birthdate = this.Birthdate;
            editUser.Address = this.Address;
            editUser.Email = this.Email;
            editUser.PhoneNumber = this.PhoneNumber;
            editUser.NationalID = this.NationalID;
            editUser.RoleName = this.Rolename.ToString();
            editAdmin.Shift = this.Shift;
            editAdmin.Salary = this.Salary;
            editAdmin.HireDate = this.HireDate;
            
            db.SubmitChanges();
        }
    }
}
