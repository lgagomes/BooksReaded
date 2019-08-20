using BooksReaded.Models;
using BooksReaded.Services;
using System;
using System.Windows.Forms;
using CreateAuthorMediator = BooksReaded.Mediator.Mediator;

namespace BooksReaded.UserControls
{
    public partial class UcCreateAuthor : UserControl
    {
        private AuthorService _authorService;
        protected CreateAuthorMediator Mediator;

        public UcCreateAuthor()
        {
            InitializeComponent();
        }

        public void SetUcCreateAuthorNediator(CreateAuthorMediator mediator)
        {
            Mediator = mediator;
        }

        private void BtnCreateAuthor_Click(object sender, EventArgs e)
        {
            if (ValidateAuthorNameToInsertion())
            {
                _authorService = new AuthorService();
                _authorService.SaveAuthor(new Author { Name = TxtAuthorName.Text });
                MessageBox.Show("Author created sucessfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtAuthorName.Text = string.Empty;

                Mediator.NotifyUpdateAuthorsList("AuthorCreation");
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
    }
}
