using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApplicationWindowsForms
{
    public class DateInitializer
    {
        public static void BooksInitialization(List<Book> bookList)
        {
            Author authorBook1 = new Author { Name = "Лев", MiddleName = "Николаевич", Surname = "Толстой" };
            Book book1 = new Book
            {
                Name = "Война и мир",
                Subjects = "Отмену крепостного права."
            };
            book1.Authors.Add(authorBook1);

            Author authorBook2 = new Author { Name = "Иван", MiddleName = "Сергеевич", Surname = "Тургенев" };
            Book book2 = new Book
            {
                Name = "Отцы и дети",
                Subjects = "Проблема отцов и детей, тема дружбы, тема любви."
            };
            book2.Authors.Add(authorBook2);

            Author authorBook3 = new Author { Name = "Антон", MiddleName = "Павлович", Surname = "Чехов" };
            Book book3 = new Book
            {
                Name = "Чайка",
                Subjects = "Тема любви. О людях искусства."
            };
            book3.Authors.Add(authorBook3);

            Author authorBook4 = new Author { Name = "Сергей", MiddleName = "Сергеевич", Surname = "Пивоваров" };
            Author authorBook5 = new Author { Name = "Иван", MiddleName = "Николаевич", Surname = "Тарасевич" };
            Book book4 = new Book
            {
                Name = "Международный менеджмент",
                Subjects = "Экономика и менеджмент."
            };
            book4.Authors.Add(authorBook4);
            book4.Authors.Add(authorBook5);

            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);
            bookList.Add(book4);
        }

        public static void JournalsInitialization(List<Journal> journalList)
        {
            Journal journal1 = new Journal { Name = "Men's health", Subjects = "Journal of Health and lifestyle for men.", Cover = "Cristiano Ronaldo" };
            Journal journal2 = new Journal { Name = "Playboy", Subjects = "Erotic Entertainment.", Cover = "Camille Rowe" };
            Journal journal3 = new Journal { Name = "Maxim", Subjects = "Fashion, celebrity, beauty.", Cover = "Вера Брежнева" };
            journalList.Add(journal1);
            journalList.Add(journal2);
            journalList.Add(journal3);
        }

        public static void NewspapersInitialization(List<Newspaper> newspaperList)
        {
            Newspaper newspaper1 = new Newspaper { Name = "Аргументы и факты", Subjects = "Информация, статистические данные, события." };
            Newspaper newspaper2 = new Newspaper { Name = "Сегодня", Subjects = "Полезная информация для семьи." };
            Newspaper newspaper3 = new Newspaper { Name = "Комсомольская правда в Украине", Subjects = "Общественно-политическая тематика." };
            newspaperList.Add(newspaper1);
            newspaperList.Add(newspaper2);
            newspaperList.Add(newspaper3);
        }
    }
}
