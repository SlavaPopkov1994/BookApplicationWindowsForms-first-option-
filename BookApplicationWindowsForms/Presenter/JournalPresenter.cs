using BookApplicationWindowsForms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApplicationWindowsForms.Presenter
{
    public class JournalPresenter
    {
        private JournalList model;
        private JournalFormView view;

        public JournalPresenter(JournalList model, JournalFormView view)
        {
            this.model = model;
            this.view = view;
    
            view.Presenter = this;
        }

        public void ShowJournal()
        {
            BusinessLogic.PresentationOfJournals(model.JournalsList);
            view.JournalShow(model.JournalsList);
        }

        public void SaveJournal(string fullname)
        {
            BusinessLogic.SaveDataJournal(fullname, model.JournalsList);
        }
    }
}
