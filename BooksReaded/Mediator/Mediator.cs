using BooksReaded.UserControls;

namespace BooksReaded.Mediator
{
    // https://refactoring.guru/design-patterns/mediator/csharp/example
    public class Mediator
    {
        private readonly UcEditAuthor EditAuthor;
        private readonly UcCreateAuthor CreateAuthor;
        private readonly UcCreateBook CreateBook;
        private readonly UcBooksList BooksList;

        private const string AUTHOR_CREATION = "AuthorCreation";
        private const string AUTHOR_UPDATE ="AuthorUpdate";

        public Mediator(UcEditAuthor editAuthor, UcCreateAuthor createAuthor, UcCreateBook createBook, UcBooksList booksList)
        {
            EditAuthor = editAuthor;
            EditAuthor.SetUcCreateBookMediator(this);

            CreateAuthor = createAuthor;
            CreateAuthor.SetUcCreateAuthorNediator(this);

            CreateBook = createBook;
            CreateBook.SetUcEditAuthorMediator(this);

            BooksList = booksList;
        }

        public void NotifyUpdateAuthorsList(string sender)
        {
            CreateBook.UpdateAuthorsListDatasource();

            switch (sender)
            {
                case AUTHOR_CREATION:                    
                    EditAuthor.GetAuthorsList();
                    break;

                case AUTHOR_UPDATE:
                    BooksList.GetBooksList();
                    break;
            }
        }

        public void NotifyUpdateBooksList()
        {
            BooksList.GetBooksList();
        }
    }
}
