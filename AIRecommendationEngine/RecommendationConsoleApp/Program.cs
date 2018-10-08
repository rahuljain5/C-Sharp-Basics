//using AIRecommendationEngine.BusinessLayer;
using AIRecommendationEngine.DataTransferObject;
using AIRecommendationEngine.Recommender;
using AIRecommendationSystem.DataAccess;
using AIRecommendationSystem.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecommendationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch w = new Stopwatch();
            w.Start();
            //IDataLoader loader = new CSVDataLoader();
            //BookDetail bd = loader.Load();
            string isbn = "0195153448";
            RecommendationEngine engine = new RecommendationEngine();
            IList<Book> books = engine.Recommend(new Preference { ISBN = isbn, Age = 18, State = " california" }, 10);
            Console.WriteLine($"You Bought:\n {books[0].BookTitle} By {books[0].BookAuthor} ({books[0].Year})");
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            books.Remove(books[0]);
            Console.WriteLine("Recommended For You");
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            foreach (Book b in books)
            {
                Console.WriteLine($"{b.BookTitle} by {b.BookAuthor} ({b.Year})\n");
            }
            Console.WriteLine("Obtained in: "+w.ElapsedMilliseconds + "ms");
        }
    }
}
