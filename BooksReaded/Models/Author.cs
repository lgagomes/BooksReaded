namespace BooksReaded.Models
{
    public class Author
    {
        public int IdAuthor { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}