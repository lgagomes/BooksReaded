using BooksReaded.Models;
using BooksReaded.Services;
using System;
using System.Windows.Forms;

namespace BooksReaded.UserControls
{
    public partial class UcMainScreen : UserControl
    {
        private AuthorService _authorService;

        public UcMainScreen()
        {            
            InitializeComponent();

            _authorService = new AuthorService();
            InitializeCBAuthor();
            GetAuthorList();
        }

        private void InitializeCBAuthor()
        {
            CbAuthor.DisplayMember = "Name";
            CbAuthor.ValueMember = "IdAuthor";
        }

        private void GetAuthorList()
        {            
            CbAuthor.DataSource = _authorService.GetAuthorsList();            
        }

        private void BtnCreateAuthor_Click(object sender, EventArgs e)
        {
            _authorService.SaveAuthor(new Author { Name = TxtAuthorName.Text });
            MessageBox.Show("Author created sucessfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtAuthorName.Text = string.Empty;
            GetAuthorList();
        }
    }
}
