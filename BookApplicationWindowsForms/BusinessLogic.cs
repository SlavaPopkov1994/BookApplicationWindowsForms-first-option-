using BookApplicationWindowsForms.Presenter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BookApplicationWindowsForms
{
    public static class BusinessLogic
    {
        public static void PresentationOfBooks(List<Book> bookList)
        {
            DateInitializer.BooksInitialization(bookList);
        }

        public static void PresentationOfJournals(List<Journal> journalList)
        {
            DateInitializer.JournalsInitialization(journalList);
        }

        public static void PresentationOfNewspapers(List<Newspaper> newspaperList)
        {
            DateInitializer.NewspapersInitialization(newspaperList);
        }

        public static void SaveDataJournal(string fullname, List<Journal> journalList)
        {
            StreamWriter writeListJournals = new StreamWriter(fullname);
            foreach (var journal in journalList)
            {
                writeListJournals.WriteLine(journal.Name + " " + journal.Subjects + " " + journal.Cover);
            }
            writeListJournals.Close();
        }

        public static void SaveDataNewspaper(string fullname, List<Newspaper> newspaperList)
        {
            StreamWriter writeListNewspapers = new StreamWriter(fullname);
            foreach (var newspaper in newspaperList)
            {
                writeListNewspapers.WriteLine(newspaper.Name + " " + newspaper.Subjects);
            }
            writeListNewspapers.Close();
        }

        public static void SaveDataBookXML(string fullname, List<Book> bookList)
        {
            XmlTextWriter writer = new XmlTextWriter(fullname, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            foreach (var book in bookList)
            {
                writer.WriteStartElement("Book");
                writer.WriteAttributeString("name", book.Name);
                writer.WriteAttributeString("subjects", book.Subjects);
                foreach (var author in book.Authors)
                {
                    writer.WriteAttributeString("name", author.Name);
                    writer.WriteAttributeString("middleName", author.MiddleName);
                    writer.WriteAttributeString("surname", author.Surname);
                }
                writer.WriteEndElement();
            }
            writer.Close();
        }

        public static void SaveDataBookDB(List<Book> bookList)
        {
            BookProvider bookProvider = new BookProvider();
            foreach (var book in bookList)
            {
                if (book.Name != null && book.Subjects != null)
                {
                    if (!bookProvider.FindBook(book.Name))
                    {
                        bookProvider.AddBook(book.Name, book.Subjects);
                    }
                    foreach (var author in book.Authors)
                    {
                        int _index = bookProvider.FindIndexBook(book.Name);
                        if (author.Name != null && author.Surname != null && author.MiddleName != null && _index != 0)
                        {
                            if (!bookProvider.FindAuthor(author.Name, author.Surname, author.MiddleName, _index))
                            {
                                bookProvider.AddAuthor(author.Name, author.Surname, author.MiddleName, _index);
                            }
                        }
                    }
                }
            }
        }

        public static void SqlConnectionClose()
        {
            BookProvider bookProvider = new BookProvider();
            bookProvider.SqlConnectionClose();
        }
    }
}
