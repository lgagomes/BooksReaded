using BooksReaded.Models;
using BooksReaded.Services;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using BooksReaded.Forms;
using System.Linq;

//TODO: Add edit button to the grid

namespace BooksReaded.UserControls
{
    public partial class UcMainScreen : UserControl
    {
        private AuthorService _authorService;
        private BookService _bookService;

        public UcMainScreen()
        {            
            InitializeComponent();

            _authorService = new AuthorService();
            _bookService = new BookService();

            InitializeCbAuthor();
            InitializaCbAuthorsList();
            UpdateAuthorList();
            GetBooksList();
        }

        private void GetBooksList()
        {
            GridViewBooks.DataSource = _bookService.GetBooksList();
        }

        private void InitializeCbAuthor()
        {
            CbAuthor.DisplayMember = "Name";
            CbAuthor.ValueMember = "IdAuthor";
        }

        private void InitializaCbAuthorsList()
        {
            CbAuthorsList.DisplayMember = "Name";
            CbAuthorsList.ValueMember = "IdAuthor";
        }

        private void UpdateAuthorList()
        {
            /* if both comboboxes share the same datasource, then each time we
               change the item in one of them, the other will change as well */
            
            List<Author> authorsListBookInsertion = _authorService.GetAuthorsList();
            List<Author> authorsListEdit = _authorService.GetAuthorsList();

            CbAuthor.DataSource = authorsListBookInsertion;
            CbAuthorsList.DataSource = authorsListEdit;
        }

        private void BtnCreateAuthor_Click(object sender, EventArgs e)
        {
            if (ValidateAuthorNameToInsertion())
            {
                _authorService.SaveAuthor(new Author { Name = TxtAuthorName.Text });
                MessageBox.Show("Author created sucessfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtAuthorName.Text = string.Empty;
                UpdateAuthorList();
            }
        }

        private void BtnEditAuthor_Click(object sender, EventArgs e)
        {
            var selectedAuthor = (Author)CbAuthorsList.SelectedItem;

            using (FrmEditAuthor frmEditAuthor = new FrmEditAuthor(selectedAuthor))
            {
                frmEditAuthor.ShowDialog();

                if(frmEditAuthor.DialogResult == DialogResult.OK)
                {
                    UpdateAuthorList();
                }
            }            
        }

        private bool ValidateAuthorNameToInsertion()
        {
            if (string.IsNullOrWhiteSpace(TxtAuthorName.Text))
            {
                MessageBox.Show("Please inform a Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void BtnNewBook_Click(object sender, EventArgs e)
        {
            var selectedAuthor = (Author)CbAuthor.SelectedItem;

            Book bookToSave = new Book
            {
                Title = TxtTitle.Text,
                YearPublication = TxtPublishYear.Text,
                Author = new Author
                {
                    IdAuthor = selectedAuthor.IdAuthor,
                }
            };

            bookToSave.ValidatePropertiesInfo();

            if (!bookToSave.Erros.Any())
            {
                _bookService.SaveBook(bookToSave);

                MessageBox.Show("Book created sucessfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TxtTitle.Text = string.Empty;
                TxtPublishYear.Text = string.Empty;

                GetBooksList();
            }
            else
            {
                string errosMessage = string.Join(Environment.NewLine, bookToSave.Erros);

                MessageBox.Show($"The following erros occured:{Environment.NewLine}{errosMessage}", "Warning", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GridViewBooks_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Book book = (Book)GridViewBooks.CurrentRow.DataBoundItem;

            using (FrmEditBook frmEditBook = new FrmEditBook(book))
            {
                frmEditBook.ShowDialog();

                if (frmEditBook.DialogResult == DialogResult.OK)
                {
                    GetBooksList();
                }
            }           
        }
    }
}
