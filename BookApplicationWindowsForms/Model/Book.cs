using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApplicationWindowsForms
{
    public class Book : IPolygraphy
    {
        public Book()
        {
            Authors = new List<Author>();
        }
        public List<Author> Authors { get; set; }
        public string Name { get; set; }
        public string Subjects { get; set; }
    }
}
