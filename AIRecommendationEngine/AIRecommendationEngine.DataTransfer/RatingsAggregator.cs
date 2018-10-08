using AIRecommendationSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIRecommendationEngine.DataTransferObject
{
    public class RatingsAggregator : IRatingsAggregator
    {
        public Dictionary<string, List<int>> Aggregate(BookDetail bookDetail, Preference preference)
        {
            Dictionary<string, List<int>> aggregatedList = new Dictionary<string, List<int>>();

            foreach (BookUserRating rating in bookDetail.BookRatings)
            {
                if ((Validator(preference.Age, rating.User.Age) && (rating.User.State == preference.State)) || (preference.ISBN == rating.ISBN))
                {
                    if (!aggregatedList.ContainsKey(rating.ISBN))
                    {
                        aggregatedList.Add(rating.ISBN, new List<int>());
                    }
                    else
                    {
                        aggregatedList[rating.ISBN].Add(rating.Rating);
                    }
                }
            }
            return aggregatedList;
        }
        private bool Validator(int prefAge, int userAge)
        {
            if ((Enumerable.Range(61, 40).Contains(prefAge)) && (Enumerable.Range(61, 40).Contains(userAge))) return true;
            else if ((Enumerable.Range(51, 10).Contains(prefAge)) && (Enumerable.Range(51, 10).Contains(userAge))) return true;
            else if ((Enumerable.Range(31, 40).Contains(prefAge)) && (Enumerable.Range(31, 20).Contains(userAge))) return true;
            else if ((Enumerable.Range(17, 14).Contains(prefAge)) && (Enumerable.Range(17, 14).Contains(userAge))) return true;
            else if ((Enumerable.Range(0, 16).Contains(prefAge)) && (Enumerable.Range(0, 16).Contains(userAge))) return true; 
            else return false;
        }
    }
}
