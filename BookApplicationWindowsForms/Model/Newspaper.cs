using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApplicationWindowsForms
{
    public class Newspaper : IPolygraphy
    {
        public string Name { get; set; }
        public string Subjects { get; set; }
    }
}
