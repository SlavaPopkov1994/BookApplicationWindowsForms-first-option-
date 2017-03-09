using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApplicationWindowsForms.Model
{
    public class JournalList
    {
        public JournalList()
        {
            JournalsList = new List<Journal>();
        }
        public List<Journal> JournalsList { get; set; }
    }
}
