using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_App.Class_Lib;

namespace Library_App.Class_Lib
{
    class Student : User
    {
        public string University { get; set; }
        public double  GPA { get; set; }
        public string University_ID { get; set;}

        public Student() { }
        public Student(tbl_Student s)
        {
            ID = s.User_ID;
            University = s.University;
            University_ID = s.University_ID;
            GPA = (double)s.GPA;
        }
        public new void Add()
        {
            base.Add();
            LibraryDBDataContext db = new LibraryDBDataContext();

            tbl_Student s = new tbl_Student();
            s.User_ID = base.ID;
            s.University = University;
            s.University_ID = University_ID;
            s.GPA = GPA;

            db.tbl_Students.InsertOnSubmit(s);
            db.SubmitChanges();
        }

        public void CopyInto(User u)
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

        public void CopyInto(tbl_User u)
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
            Rolename = (RolesEnum)Enum.Parse(typeof(RolesEnum), u.RoleName);
        }

        public static new Student LoadByID(int ID)
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            Student user = (
                            from u in db.tbl_Students
                            where u.User_ID == ID
                            select new Student(u)
                        ).FirstOrDefault();
            return user;
        }
        
        public static dynamic LoadALL()
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            var stds = ( from S in db.tbl_Students
                       join U in db.tbl_Users on S.User_ID equals U.ID
                       select new
                       {
                           U.Username,
                           U.FName,
                           U.SName,
                           S.University_ID,
                           S.University,
                           S.GPA,
                           U.Birthdate,
                           U.Address,
                           U.Email,
                           U.PhoneNumber,
                           U.NationalID,
                       }  
                       ).ToList();

            return stds;
        }

        public static new Student LoadByUsername(string username)
        {
            int id = User.LoadByUsername(username).ID;

            LibraryDBDataContext db = new LibraryDBDataContext();
            Student std = (
                            from S in db.tbl_Students
                            where S.User_ID == id
                            select new Student(S)
                        ).FirstOrDefault();
            return std;
        }
        public List<Book> LoadAllBorrowedBooks()
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            List<Book> books = (
                from br in db.tbl_Borrows
                join B in db.tbl_Books
                on br.BookID equals B.ID
                where br.UserID == this.ID
                select new Book(B)
                ).ToList<Book>();
            return books;
        }

        public void Borrow(int ISBN)
        {
            Book b = Book.LoadByISBN(ISBN);
            List<Book> Borrowed = LoadAllBorrowedBooks();
            foreach (Book temp in Borrowed)
            {
                if (temp.ID == b.ID)
                {
                    MessageBox.Show("You Have already borrowed it!");
                    return;
                }
            }

            if (b == null)
            {
                MessageBox.Show("Book doesn't exist");
                return;
            }
            else if (b.Copies == 0)
            {
                MessageBox.Show("Book is currently unavailable");
                return;
            }
            else
            {
                b.Copies--;
                b.saveChanges();
                MessageBox.Show("Done!");
                LibraryDBDataContext db = new LibraryDBDataContext();
                tbl_Borrow bor = new tbl_Borrow();
                bor.UserID = this.ID;
                bor.BookID = b.ID;
                bor.Date = DateTime.Now;
                db.tbl_Borrows.InsertOnSubmit(bor);
                db.SubmitChanges();
            }
        }

        public void Return(int ISBN)
        {
            Book b = Book.LoadByISBN(ISBN);
            if (b == null)
            {
                MessageBox.Show("Book doesn't exist");
                return;
            }
            else
            {
                b.Copies++;
                b.saveChanges();
                LibraryDBDataContext db = new LibraryDBDataContext();
                tbl_Borrow bor = (from B in db.tbl_Borrows
                                  where B.BookID == b.ID && this.ID == B.UserID
                                  select B
                    ).FirstOrDefault();
                
                db.tbl_Borrows.DeleteOnSubmit(bor);
                db.SubmitChanges();
            }
        }

        public void Delete_Student()
        {
            List<Book> Borrowed = this.LoadAllBorrowedBooks();
            foreach (Book i in Borrowed)
            {
                this.Return(i.ISBN);
            }
            LibraryDBDataContext db = new LibraryDBDataContext();
            tbl_Student S = (from std in db.tbl_Students
                             where std.User_ID == this.ID
                             select std
                             ).FirstOrDefault();

            tbl_User U = (from US in db.tbl_Users
                          where US.ID == this.ID
                          select US).FirstOrDefault();

            db.tbl_Students.DeleteOnSubmit(S);
            db.tbl_Users.DeleteOnSubmit(U);

            db.SubmitChanges();
        }

        public void SaveChanges()
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            var editStudent = (from B in db.tbl_Students
                             where B.User_ID == this.ID
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
            editStudent.University = this.University;
            editStudent.University_ID = this.University_ID;
            editStudent.GPA = this.GPA;

            db.SubmitChanges();
        }
    }
}
