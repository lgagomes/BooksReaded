using BooksReaded.Forms;
using BooksReaded.Models;
using BooksReaded.Services;
using System;
using System.Windows.Forms;
using EditAuthorMediator = BooksReaded.Mediator.Mediator;

namespace BooksReaded.UserControls
{
    public partial class UcEditAuthor : UserControl
    {
        private AuthorService _authorService;
        protected EditAuthorMediator Mediator;

        public UcEditAuthor()
        {
            InitializeComponent();

            _authorService = new AuthorService();

            CbAuthorsList.DisplayMember = "Name";
            CbAuthorsList.ValueMember = "IdAuthor";

            GetAuthorsList();
        }

        public void SetUcCreateBookMediator(EditAuthorMediator mediator)
        {
            Mediator = mediator;
        }

        public void GetAuthorsList()
        {
            CbAuthorsList.DataSource = _authorService.GetAuthorsList();
        }

        private void BtnEditAuthor_Click(object sender, EventArgs e)
        {
            var selectedAuthor = (Author)CbAuthorsList.SelectedItem;

            using (FrmEditAuthor frmEditAuthor = new FrmEditAuthor(selectedAuthor))
            {
                frmEditAuthor.ShowDialog();

                if (frmEditAuthor.DialogResult == DialogResult.OK)
                {
                    GetAuthorsList();
                    Mediator.NotifyUpdateAuthorsList("AuthorUpdate");
                }
            }
        }
    }
}
