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
    public partial class NewspaperFormView : Form
    {
        public NewspaperPresenter Presenter { get; set; }

        public NewspaperFormView()
        {
            InitializeComponent();
        }

        private void ListNewspapersBt_Click(object sender, EventArgs e)
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

        private void SaveNewspapers_Click(object sender, EventArgs e)
        {
            if (openFileDialogNewspaper.ShowDialog() == DialogResult.OK)
            {
                string fullname = openFileDialogNewspaper.FileName;
                Presenter.SaveNewspaper(fullname);
            }
        }

        public void NewspaperShow(List<Newspaper> newspaperList)
        {
            ListNewspapersTb.Items.Add("Газеты");
            foreach (var newspaper in newspaperList)
            {
                ListNewspapersTb.Items.Add(newspaper.Name + " " + newspaper.Subjects);
            }
        }
    }
}
