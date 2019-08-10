using System.Collections.Generic;

namespace BooksReaded.Models
{
    public class Book
    {
        private const int BOOK_TITLE_MAX_LENGHT = 255;
        private const int YEAR_MAX_LENGHT = 4;

        public int IdBook { get; set; }
        public string Title { get; set; }
        public string YearPublication { get; set; }
        public Author Author { get; set; }       
        public List<string> Erros { get; set; }

        public void ValidatePropertiesInfo()
        {
            Erros = new List<string>();

            if (string.IsNullOrWhiteSpace(Title))
            {
                Erros.Add("Please inform a Title");
            }

            if (Title.Length > BOOK_TITLE_MAX_LENGHT)
            {
                Erros.Add($"Title must have less than {BOOK_TITLE_MAX_LENGHT} characters");
            }

            if (YearPublication.Length > YEAR_MAX_LENGHT)
            {
                Erros.Add("Please inform a valid Year");
            }
        }
    }
}