using System.Windows.Forms;
using FormMediator = BooksReaded.Mediator.Mediator;

namespace BooksReaded.Forms
{
    public partial class FrmMainScreen : Form
    {
        private FormMediator mediator;

        public FrmMainScreen()
        {
            InitializeComponent();
            mediator = new FormMediator(ucEditAuthor1, ucCreateAuthor1, ucCreateBook1, ucBooksList1);
        }
    }
}
