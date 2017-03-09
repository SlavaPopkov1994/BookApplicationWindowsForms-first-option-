using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApplicationWindowsForms.Model
{
    public class BookList
    {
        public BookList()
        {
            BooksList = new List<Book>();
        }
        public List<Book> BooksList { get; set; }
    }
}
