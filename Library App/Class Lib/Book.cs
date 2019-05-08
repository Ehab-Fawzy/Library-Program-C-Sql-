using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace Library_App.Class_Lib
{
    public class Book
    {
        public int ID { get; set; }
        public int ISBN { get; set; }
        public Publisher Publisher;
        public Author Author;
        public string Name { get; set; }
        public string Genre { get; set; }
        public short Copies { get; set; }
        public int Pages { get; set; }
        public string Version { get; set; }
        
        public string PublisherName
        {
            get { return Publisher.Name; }
        }
        public string PublihserAddress
        {
            get { return Publisher.Address.ToString(); }
        }
        public string AuthorName
        {
            get { return Author.Name; }
        }
        public string AuthorAddress
        {
            get { return Author.Address; }
        }
        public string AuthorBirthDate
        {
            get { return Author.Birthdate.ToString(); }
        }

        public Book() { }
        public Book(tbl_Book b, tbl_Edition e)
        {
            this.ID = b.ID;
            this.ISBN = b.ISBN;
            this.Publisher = Publisher.LoadById(b.PublisherID);
            this.Author = Author.LoadById(b.AuthorID);
            this.Name = b.Name;
            this.Genre = b.Genre;
            this.Copies = b.Copies;
            if (e != null)
            {
                this.Pages = e.Pages;
                this.Version = e.Version;
            }
        }
        public Book(tbl_Book b)
        {
            this.ID = b.ID;
            this.ISBN = b.ISBN;
            this.Publisher = Publisher.LoadById(b.PublisherID);
            this.Author = Author.LoadById(b.AuthorID);
            this.Name = b.Name;
            this.Genre = b.Genre;
            this.Copies = b.Copies;
        }

        public void add()
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            tbl_Book b = new tbl_Book();
            b.ISBN = this.ISBN;
            b.Name = this.Name;
            b.PublisherID = this.Publisher.ID;
            b.AuthorID = this.Author.ID;
            b.Copies = this.Copies;
            b.Genre = this.Genre;

            db.tbl_Books.InsertOnSubmit(b);
            db.SubmitChanges();
        }
        public static Book LoadByID(int ID)
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            Book book = (
                            from b in db.tbl_Books
                            where b.ID == ID
                            select new Book(b)
                        ).FirstOrDefault();
            return book;
        }

        public static Book LoadByISBN(int ISBN)
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            Book book = (
                            from b in db.tbl_Books
                            where b.ISBN == ISBN
                            select new Book(b)
                        ).FirstOrDefault();
            return book;
        }

        public static List<Book> LoadALL()
        {
            /// implement left out join
            LibraryDBDataContext db = new LibraryDBDataContext();
            List<Book> Books = (from B in db.tbl_Books
                        join E in db.tbl_Editions on B.ID equals E.BookID into joined
                        from E in joined.DefaultIfEmpty()
                        select new Book(B,E)
                       ).ToList<Book>();
            return Books;
        }
        public static List<Book> LoadALLDistinct()
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            List<Book> Books = (from B in db.tbl_Books
                                select new Book(B)
                       ).ToList<Book>();
            return Books;
        }
        public List<string> LoadAllEditions()
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            List<string> editions = (from E in db.tbl_Editions
                                     where E.BookID == this.ID
                                     select E.Version
                ).ToList<string>();
            return editions;
        }
        public void saveChanges()
        {
            LibraryDBDataContext db = new LibraryDBDataContext();
            var editBook = (from B in db.tbl_Books
                            where B.ID == this.ID
                            select B).FirstOrDefault();
            var oldEdition = (from E in db.tbl_Editions
                               where E.BookID == this.ID
                               select E).FirstOrDefault();
            tbl_Edition newEdition = new tbl_Edition();


            editBook.ISBN = this.ISBN;
            editBook.Name = this.Name;
            editBook.PublisherID = this.Publisher.ID;
            editBook.AuthorID = this.Author.ID; //l stren dol 7atet feehom l touch bta3y
            editBook.Genre = this.Genre;
            editBook.Copies = this.Copies;

            if ( oldEdition != null && this.Version != null )
            { 
                newEdition.BookID = oldEdition.BookID;
                newEdition.Pages = this.Pages;
                newEdition.Version = this.Version;
                db.tbl_Editions.DeleteOnSubmit(oldEdition);
                db.tbl_Editions.InsertOnSubmit(newEdition);
            }

            db.SubmitChanges();
        }
        public void Delete_Book()
        {
            LibraryDBDataContext db = new LibraryDBDataContext();

            tbl_Borrow temp = (from T in db.tbl_Borrows
                             where T.BookID == this.ID
                             select T
                             ).FirstOrDefault();

            if (temp != null)
            {
                MessageBox.Show("Someone has this Book!");
                return;
            }
            else
            {
                tbl_Book B = (from T in db.tbl_Books
                              where T.ID == this.ID
                              select T).FirstOrDefault();
                tbl_Edition e = (from E in db.tbl_Editions
                                 where E.BookID == this.ID
                                 select E).FirstOrDefault();

                if (e != null)
                {
                    db.tbl_Editions.DeleteOnSubmit(e);
                }
                db.tbl_Books.DeleteOnSubmit(B);
                db.SubmitChanges();
            }
        }
    }
}
