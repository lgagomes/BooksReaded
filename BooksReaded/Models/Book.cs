namespace BooksReaded.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string YearPublication { get; set; }
        public Author Author { get; set; }
    }
}