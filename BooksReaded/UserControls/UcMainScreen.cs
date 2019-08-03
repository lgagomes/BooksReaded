using BooksReaded.Models;
using BooksReaded.Services;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using BooksReaded.Forms;
//using BooksReaded.Forms;

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

            FrmEditAuthor frmEditAuthor = new FrmEditAuthor(selectedAuthor);
            frmEditAuthor.ShowDialog();
            UpdateAuthorList();
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
            if (ValidateBookData())
            {
                var selectedAuthor = (Author)CbAuthor.SelectedItem;

                _bookService.SaveBook(
                    new Book
                    {
                        Title = TxtTitle.Text,
                        YearPublication = TxtPublishYear.Text,
                        Author = new Author
                        {
                            IdAuthor = selectedAuthor.IdAuthor,
                        }
                    });

                MessageBox.Show("Book created sucessfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TxtTitle.Text = string.Empty;
                TxtPublishYear.Text = string.Empty;

                GetBooksList();
            }
        }

        private bool ValidateBookData()
        {
            if (string.IsNullOrWhiteSpace(TxtTitle.Text))
            {
                MessageBox.Show("Please inform a Title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (TxtTitle.Text.Length > 255)
            {
                MessageBox.Show("Title must have less than 255 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (TxtPublishYear.Text.Length > 4)
            {
                MessageBox.Show("Please inform a valid Year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
