using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIRecommendationSystem.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public List<BookUserRating> UserRatings { get; set; }

        public User()
        {
            UserRatings = new List<BookUserRating>();
        }
    }
    
}
