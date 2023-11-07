using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookClassExample
{
    public class Book
    {
        public List<Author> Authors { get; private set; }
        public string Title { get; private set; }
        public List<Page> Pages { get; private set; }
        //public Page[] Pages { get; set; }

        public Book()
        {
            Title = "{Fill In The Title - No Title Given}";
            Authors = new List<Author>();
            Pages = new List<Page>();
            //Pages = new Page[4];
        }

        public Book(string firstName, string lastName, string psName = "")
        {
            Title = "{Fill In The Title - No Title Given}";
            Pages = new List<Page>();
            Authors = new List<Author>();
            
            /*
            Author a1 = new Author(); 
            a1.FirstName = firstName;
            a1.LastName = lastName;
            a1.PsName = psName;
            Authors.Add(a1);
            */

            Authors.Add(new Author { FirstName = firstName, LastName = lastName, PsName = psName});
            
            //Authors.Add(new Author(firstName, lastName, psName));
        }
        public Book(Author author)
        {
            Authors.Add(new Author { FirstName = author.FirstName, LastName = author.LastName, PsName = author.PsName });
            // bad!!!!! potentially Authors.Add(author);
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(new Author(author));
        }

        public override string ToString()
        {
            string msg = "";

            msg += $"Title: {Title}\n";

            foreach (var item in Authors)
            {
                if (item.PsName is not null && item.PsName != "")
                {
                    msg += $"{item.FirstName} {item.LastName} ({item.PsName}) \n";
                }
                else
                {
                    msg += $"{item.FirstName} {item.LastName}\n";
                }
            }

            msg += $"Number of Pages: {Pages.Count}";

            return msg;
        }
        public static string BooksAreFun()
        {
            return "YES!!!";
        }
    }
}
