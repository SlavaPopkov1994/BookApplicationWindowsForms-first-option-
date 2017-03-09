using BookApplicationWindowsForms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApplicationWindowsForms.Presenter
{
    public class BookPresenter
    {
        private BookList model;
        private BookFormView view;

        public BookPresenter(BookList model, BookFormView view)
        {
            this.model = model;
            this.view = view;

            view.Presenter = this;
        }

        public void ShowBook()
        {
            BusinessLogic.PresentationOfBooks(model.BooksList);
            view.BookShow(model.BooksList);
        }

        public void SaveBookXML(string fullname)
        {
            BusinessLogic.SaveDataBookXML(fullname, model.BooksList);
        }

        public void SaveBookDB()
        {
            BusinessLogic.SaveDataBookDB(model.BooksList);
        }

        public void SqlConnectionClose()
        {
            BusinessLogic.SqlConnectionClose();
        }
    }
}
