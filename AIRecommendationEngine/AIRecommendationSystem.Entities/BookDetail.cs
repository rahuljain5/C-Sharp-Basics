using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIRecommendationSystem.Entities
{
    public class BookDetail
    {
        public List<Book> Books { get; set; }
        public List<BookUserRating> BookRatings { get; set; }
        public List<User> Users { get; set; }

        public BookDetail()
        {
            Books = new List<Book>();
            BookRatings = new List<BookUserRating>();
            Users = new List<User>();
        }
    }
}
