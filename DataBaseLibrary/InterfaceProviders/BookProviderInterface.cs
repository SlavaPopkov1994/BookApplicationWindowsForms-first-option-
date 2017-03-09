using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLibrary
{
    public interface BookProviderInterface
    {
        void AddBook(string Name, string Subjects);
        void AddAuthor(string Name, string Surname, string MiddleName, int _index);
        bool FindBook(string name);
        bool FindAuthor(string Name, string Surname, string MiddleName, int _index);
        int FindIndexBook(string Name); 
    }
}
