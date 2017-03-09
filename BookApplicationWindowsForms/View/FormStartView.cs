using BookApplicationWindowsForms.Model;
using BookApplicationWindowsForms.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApplicationWindowsForms
{
    public partial class FormStartView : Form
    {
        public FormStartView()
        {
            InitializeComponent();
        }

        private void ListBooks_Click(object sender, EventArgs e)
        {
            BookList model = new BookList();
            BookFormView view = new BookFormView();
            BookPresenter presenter = new BookPresenter(model, view);
            view.Show();
        }

        private void ListNewspapersBt_Click(object sender, EventArgs e)
        {
            NewspaperList model = new NewspaperList();
            NewspaperFormView view = new NewspaperFormView();
            NewspaperPresenter presenter = new NewspaperPresenter(model, view);
            view.Show();
        }

        private void ListJournalsBt_Click(object sender, EventArgs e)
        {
            JournalList model = new JournalList();
            JournalFormView view = new JournalFormView();
            JournalPresenter presenter = new JournalPresenter(model, view);
            view.Show();
        }
    }
}
