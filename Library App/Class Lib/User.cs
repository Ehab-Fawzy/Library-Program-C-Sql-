using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Form Roles = (Roles)Enum.Parse(typeof(Roles), myString);


namespace Library_App.Class_Lib
{
    public enum RolesEnum { Admin , Student };
    public class User
    {
        public int ID { get; set; }
        public string   Username { get; set; }
        public string   Password { get; set; }
        public string   FName { get; set; }
        public string   SName { get; set; }
        public DateTime Birthdate { get; set; }
        public string   Address { get; set; }
        public string   Email { get; set; }
        public string   PhoneNumber { get; set; }
        public string   NationalID { get; set; }
        public RolesEnum    Rolename { get; set; }


        public User() { }
        public void CopyInto(ref Admin u)
        {
            u.ID = ID;
            u.Username = Username;
            u.Password = Password;
            u.FName = FName;
            u.SName = SName;
            u.Birthdate = Birthdate;
            u.Address = Address;
            u.Email = Email;
            u.PhoneNumber = PhoneNumber;
            u.NationalID = NationalID;
            u.Rolename = Rolename;
        }
        public User(tbl_User u)
        {
            this.ID = u.ID;
            this.Username = u.Username;
            this.Password = u.Password;
            this.FName = u.FName;
            this.SName = u.SName;
            this.Birthdate = u.Birthdate;
            this.Address = u.Address;
            this.Email = u.Email;
            this.PhoneNumber = u.PhoneNumber;
            this.NationalID = u.NationalID;
            this.Rolename = (RolesEnum)Enum.Parse(typeof(RolesEnum), u.RoleName);
        }

        public virtual void Add()
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            tbl_User u = new tbl_User();

            u.Username = this.Username;
            u.Password = this.Password;
            u.FName = this.FName;
            u.SName = this.SName;
            u.Birthdate = this.Birthdate;
            u.Address = this.Address;
            u.Email = this.Email;
            u.PhoneNumber = this.PhoneNumber;
            u.NationalID = this.NationalID;
            u.RoleName = this.Rolename.ToString();

            db.tbl_Users.InsertOnSubmit(u);
            db.SubmitChanges();
            this.ID = u.ID;
        }
        public static User LoadByID(int ID)
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            User user = (
                            from u in db.tbl_Users
                            where u.ID == ID
                            select new User(u)
                        ).FirstOrDefault();
            return user;
        }
        public static User LoadByUsername(string username)
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            User user = (
                            from b in db.tbl_Users
                            where b.Username == username
                            select new User(b)
                        ).FirstOrDefault();
            return user;
        }
        public static User Login(string username,string password)
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            User user = (
                            from b in db.tbl_Users
                            where b.Username == username && b.Password==password
                            select new User(b)
                        ).FirstOrDefault();
            return user;
        }

        
    }
}
