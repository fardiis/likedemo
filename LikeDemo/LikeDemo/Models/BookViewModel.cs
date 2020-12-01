using System.Collections.Generic;

namespace LikeDemo.Models
{
    public class BookViewModel
    {
        public string BookName { get; set; }
        public bool IsLiked { get; set; }

        public string BookDetail { get; set; }
        public IEnumerable<BookDAL.Book> books { get; set; }
    }
}
