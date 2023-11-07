using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClassExample
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PsName { get; set; }

        public Author()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            PsName = string.Empty;
        }
        public Author(Author author)
        {
            FirstName = author.FirstName;
            LastName = author.LastName;
            PsName = author.PsName;
        }
        /*
        public Author(string firstName, string lastName, string psName)
        {
            FirstName = firstName;
            LastName = lastName;
            PsName = psName;
        }
        */

    }

   
}
