using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApplicationWindowsForms
{
    public class Journal : IPolygraphy
    {
        public string Name { get; set; }
        public string Subjects { get; set; }
        public string Cover { get; set; }
    }
}
