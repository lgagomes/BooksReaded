using BooksReaded.Models;
using BooksReaded.Services;
using System;
using System.Linq;
using System.Windows.Forms;
using CreateBookMediator = BooksReaded.Mediator.Mediator;

namespace BooksReaded.UserControls
{
    public partial class UcCreateBook : UserControl
    {
        AuthorService _authorService;
        BookService _bookService;
        protected CreateBookMediator Mediator;

        public UcCreateBook()
        {
            InitializeComponent();

            GeneralInitializations();
            UpdateAuthorsListDatasource();
        }

        private void GeneralInitializations()
        {
            _authorService = new AuthorService();
            _bookService = new BookService();

            CbAuthor.DisplayMember = "Name";
            CbAuthor.ValueMember = "IdAuthor";
        }

        public void SetUcEditAuthorMediator(CreateBookMediator mediator)
        {
            Mediator = mediator;
        }

        public void UpdateAuthorsListDatasource()
        {
            CbAuthor.DataSource = _authorService.GetAuthorsList();
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
                Mediator.NotifyUpdateBooksList();
            }
            else
            {
                string errosMessage = string.Join(Environment.NewLine, bookToSave.Erros);

                MessageBox.Show($"The following erros occured:{Environment.NewLine}{errosMessage}", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtPublishYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
