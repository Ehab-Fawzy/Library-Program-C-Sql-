using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_App.Class_Lib
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; } 
        public Author() { }
        
        public Author(tbl_Author dbAuthor)
        {
            this.ID = dbAuthor.ID;
            this.Name = dbAuthor.Name;
            this.Birthdate = dbAuthor.Birthdate.Value;
            this.Address = dbAuthor.Address;
        }

        public void Add()
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            tbl_Author a = new tbl_Author();
            a.Name = this.Name;
            a.Address = this.Address;
            a.Birthdate = this.Birthdate;
            db.tbl_Authors.InsertOnSubmit(a);
            db.SubmitChanges();
            ID = a.ID;
        }
        public static Author LoadById(int Id)
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            Author au = (
                            from a in db.tbl_Authors
                            where a.ID == Id
                            select new Author(a)
                        ).FirstOrDefault();
            return au;            
        }

        public static List<Author> LoadALL()
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            List<Author> au = (
                            from a in db.tbl_Authors
                            select new Author(a)
                        ).ToList<Author>();
            return au;
        }


    }
    
   
}
