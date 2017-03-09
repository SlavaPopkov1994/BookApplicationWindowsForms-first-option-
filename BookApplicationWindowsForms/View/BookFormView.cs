using BookApplicationWindowsForms.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace BookApplicationWindowsForms
{
    public partial class BookFormView : Form
    {
        public BookPresenter Presenter { get; set; }

        public BookFormView()
        {
            InitializeComponent();
        }

        private void ListBooksBt_Click(object sender, EventArgs e)
        {
            try
            {
                Presenter.ShowBook();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void SaveBooksXML_Click(object sender, EventArgs e)
        {
            if (openFileDialogBook.ShowDialog() == DialogResult.OK)
            {
                string fullname = openFileDialogBook.FileName;
                Presenter.SaveBookXML(fullname);
            }
        }

        private void SaveBooksDB_Click(object sender, EventArgs e)
        {
            Presenter.SaveBookDB();
        }

        public void BookShow(List<Book> bookList)
        {
            ListBooksTb.Items.Add("Книги");
            foreach (var book in bookList)
            {
                ListBooksTb.Items.Add(book.Name + " " + book.Subjects);
                foreach (var author in book.Authors)
                {
                    ListBooksTb.Items.Add(author.Name + " " + author.MiddleName + " " + author.Surname);
                }
                ListBooksTb.Items.Add("-------------------------------------------------");
            }
        }

        private void ExitBt_Click(object sender, EventArgs e)
        {
            Presenter.SqlConnectionClose();
            Close();
        }

        private void BookForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Presenter.SqlConnectionClose();
        }
    }
}
