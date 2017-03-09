using BookApplicationWindowsForms.Model;
using BookApplicationWindowsForms.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApplicationWindowsForms
{
    public partial class JournalFormView : Form
    {
        public JournalPresenter Presenter { get; set; }

        public JournalFormView()
        {
            InitializeComponent();
        }

        private void ListJournalsBt_Click(object sender, EventArgs e)
        {
            try
            {
                Presenter.ShowJournal();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void SaveJournals_Click(object sender, EventArgs e)
        {
            if (openFileDialogJournal.ShowDialog() == DialogResult.OK)
            {
                string fullname = openFileDialogJournal.FileName;
                Presenter.SaveJournal(fullname);
            }
        }

        public void JournalShow(List<Journal> journalList)
        {
            ListJournalsTb.Items.Add("Журналы");
            foreach (var journal in journalList)
            {
                ListJournalsTb.Items.Add(journal.Name + " " + journal.Subjects + " " + journal.Cover);
            }
        }
    }
}
