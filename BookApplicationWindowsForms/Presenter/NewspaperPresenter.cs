using BookApplicationWindowsForms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApplicationWindowsForms.Presenter
{
    public class NewspaperPresenter
    {
        private NewspaperList model;
        private NewspaperFormView view;

        public NewspaperPresenter(NewspaperList model, NewspaperFormView view)
        {
            this.model = model;
            this.view = view;

            view.Presenter = this;
        }

        public void ShowJournal()
        {
            BusinessLogic.PresentationOfNewspapers(model.NewspapersList);
            view.NewspaperShow(model.NewspapersList);
        }

        public void SaveNewspaper(string fullname)
        {
            BusinessLogic.SaveDataNewspaper(fullname, model.NewspapersList);
        }
    }
}
