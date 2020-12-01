using System;
using System.Collections.Generic;
using System.Text;

namespace BookDAL
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public bool IsLiked { get; set; }
        public string BookDetail { get; set; }
    }
}
