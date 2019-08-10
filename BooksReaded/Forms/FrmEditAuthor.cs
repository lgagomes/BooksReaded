using BooksReaded.Models;
using BooksReaded.Services;
using System;
using System.Windows.Forms;

namespace BooksReaded.Forms
{
    public partial class FrmEditAuthor : Form
    {
        private Author selectedAuthor;

        public FrmEditAuthor(Author author)
        {
            InitializeComponent();
            selectedAuthor = author;
            TxtAuthorEditName.Text = author.Name;            
        }

        private void TxtAuthorEditName_TextChanged(object sender, EventArgs e)
        {
            selectedAuthor.Name = TxtAuthorEditName.Text;
        }

        private bool ValidateName()
        {
            if (string.IsNullOrWhiteSpace(TxtAuthorEditName.Text))
            {
                MessageBox.Show("Please inform a Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void BtnSaveAuthorChange_Click(object sender, EventArgs e)
        {
            if (ValidateName())
            {
                AuthorService _authorService = new AuthorService();
                _authorService.EditAuthor(selectedAuthor);
                MessageBox.Show("Author edited sucessfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
        }

        private void BtnCancelAuthorEdit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
