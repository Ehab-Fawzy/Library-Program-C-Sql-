using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_App.Class_Lib
{
    public class  Publisher
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }

        public Publisher() { }

        public Publisher(tbl_Publisher dbPublisher)
        {
            this.ID = dbPublisher.ID;
            this.Name = dbPublisher.Name;
            this.Address = dbPublisher.Address;
        }

        public void Add()
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            tbl_Publisher a = new tbl_Publisher();
            a.Name = this.Name;
            a.Address = this.Address;
            db.tbl_Publishers.InsertOnSubmit(a);
            db.SubmitChanges();
        }
        public static Publisher LoadById(int Id)
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            Publisher pb = (
                            from p in db.tbl_Publishers
                            where p.ID == Id
                            select new Publisher(p)
                        ).FirstOrDefault();
            return pb;
        }

        public static List<Publisher> LoadALL()
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            List<Publisher> pb = (
                            from p in db.tbl_Publishers
                            select new Publisher(p)
                        ).ToList<Publisher>();
            return pb;
        }
    }
}
