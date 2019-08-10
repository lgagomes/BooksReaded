using BooksReaded.Models;
using BooksReaded.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BooksReaded.Forms
{
    public partial class FrmEditBook : Form
    {
        private Book _actualBook;

        public FrmEditBook(Book book)
        {
            _actualBook = book;
            InitializeComponent();
            InitializeAuthorCombobox();
            InitializeTxtTitle();
            InitalizeTxtYear();
        }        

        private void InitializeAuthorCombobox()
        {
            AuthorService authorService = new AuthorService();
            CbAuthorToEdit.DataSource = authorService.GetAuthorsList();
            CbAuthorToEdit.SelectedItem = _actualBook.Author;
        }

        private void InitializeTxtTitle()
        {
            TxtTitleToEdit.Text = _actualBook.Title;
        }

        private void InitalizeTxtYear()
        {
            TxtYearToEdit.Text = _actualBook.YearPublication;
        }

        private void CbAuthorToEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var author = (Author)CbAuthorToEdit.SelectedItem;

            _actualBook.Author.IdAuthor = author.IdAuthor;
            _actualBook.Author.Name = author.Name;
        }

        private void TxtTitleToEdit_TextChanged(object sender, EventArgs e)
        {
            _actualBook.Title = TxtTitleToEdit.Text;
        }

        private void TxtYearToEdit_TextChanged(object sender, EventArgs e)
        {
            _actualBook.YearPublication = TxtYearToEdit.Text;
        }

        private void BtnSaveBookChanges_Click(object sender, EventArgs e)
        {
            _actualBook.ValidatePropertiesInfo();

            if (!_actualBook.Erros.Any())
            {
                BookService bookService = new BookService();
                bookService.EditBook(_actualBook);
                MessageBox.Show("Book edited sucessfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                var errosMessage = string.Join(Environment.NewLine, _actualBook.Erros);
                MessageBox.Show($"The following erros occured:{Environment.NewLine}{errosMessage}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelBookChanges_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }               
    }
}
