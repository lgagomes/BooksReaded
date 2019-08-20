using BooksReaded.Forms;
using BooksReaded.Models;
using BooksReaded.Services;
using System.Windows.Forms;

namespace BooksReaded.UserControls
{
    public partial class UcBooksList : UserControl
    {
        private BookService _bookService;

        private const int EDIT_BUTTON_COLUMN_INDEX = 4;

        public UcBooksList()
        {
            InitializeComponent();
            _bookService = new BookService();
            GetBooksList();
        }

        public void GetBooksList()
        {
            GridViewBooks.DataSource = _bookService.GetBooksList();
        }

        private void GridViewBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GridViewBooks.Rows[e.RowIndex].Cells[EDIT_BUTTON_COLUMN_INDEX].Value = "Edit";
        }

        private void GridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == EDIT_BUTTON_COLUMN_INDEX)
            {
                EditBook();
            }
        }

        private void EditBook()
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
