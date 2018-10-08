using AIRecommendation.CoreEngine;
using AIRecommendationEngine.DataTransferObject;
using AIRecommendationSystem.DataAccess;
using AIRecommendationSystem.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AIRecommendationEngine.Recommender
{
    public class RecommendationEngine
    {
        public IList<Book> Recommend(Preference preference, int limit)
        {
            IList<Book> books = new List<Book>(limit);
            DataLoaderFactory dataLoaderFactory = DataLoaderFactory.getInstance();
            IDataLoader loader = dataLoaderFactory.GetLoader();
            IRecommender recommender = new PearsonRecommender();
            IRatingsAggregator aggregator = new RatingsAggregator();

            BookDetail bookDetail = loader.Load();
            Dictionary<string, List<int>> bookRatings = aggregator.Aggregate(bookDetail, preference);

            List<int> Base = bookRatings[preference.ISBN];
            bookRatings.Remove(preference.ISBN);

            Dictionary<string, double> coefficients = new Dictionary<string, double>(); 
            foreach(var item in bookRatings)
            {
                coefficients.Add(item.Key, recommender.GetCorrelation(Base, bookRatings[item.Key]));
            }

            coefficients = coefficients.OrderByDescending(x => x.Value).ToDictionary(a => a.Key, b=> b.Value);
            coefficients = coefficients.Take(limit).ToDictionary(a => a.Key, b => b.Value);

            books.Add(bookDetail.Books.Find(b => b.ISBN == preference.ISBN));
            foreach(var isbn in coefficients.Keys)
            {
                books.Add(bookDetail.Books.Find(b => b.ISBN == isbn));
            }
            
            return books;
        }
    }
}
