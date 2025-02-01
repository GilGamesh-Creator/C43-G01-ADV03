using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advancedC_3
{
    public class BookFunctions
    {
        public static string GetTitle(Book b)
        {
            return b.Title;
        }

        public static string GetAuthor(Book b)
        {
            return b.Author;
        }

        public static string GetISBN(Book b)
        {
            return b.ISBN;
        }

        public static DateTime GetPublicationDate(Book b)
        {
            return b.PublicationDate;
        }
    }
}
