using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApplicationWindowsForms.Model
{
    public class NewspaperList
    {
        public NewspaperList()
        {
            NewspapersList = new List<Newspaper>();
        }
        public List<Newspaper> NewspapersList { get; set; }
    }
}
