namespace my_books.Data.Models
{
    public class Book
    {

        public int Id { get; set; } 

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsRead { get; set; }

        public int? Rate { get; set; }

        public string CoverUrl { get; set; }

        public string Genre {  get; set; }

        public string Author { get; set; }

        public DateTime? DateRead { get; set; } //nese i shotjm pikpytje nfund e bejm opsionale

       


    }
}
