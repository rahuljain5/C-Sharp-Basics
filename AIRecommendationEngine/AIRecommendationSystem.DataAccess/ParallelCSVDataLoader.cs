using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AIRecommendationSystem.Entities;
using System.Threading;

namespace AIRecommendationSystem.DataAccess
{
    public class ParallelCSVDataLoader : IDataLoader
    {
        public BookDetail Load()
        {
            BookDetail bookDetail = new BookDetail();
            StreamReader reader = new StreamReader("..\\..\\..\\Data\\BX-Books.csv");
            string line = reader.ReadLine();
            //Task t1 = new Task(() => { 
            while (!reader.EndOfStream)
            {

                Book book = new Book();
                line = reader.ReadLine();
                //line.Replace('"', ' ');
                string[] details = line.Split(';');
                for (int i = 0; i < details.Length; i++) { details[i] = details[i].Trim('"'); };
                book.ISBN = details[0];
                book.BookTitle = details[1];
                book.BookAuthor = details[2];
                book.Year = int.Parse(details[3]);
                book.Publisher = details[4];
                book.ImageUrlSmall = details[5];
                book.ImageUrlMedium = details[6];
                book.ImageUrlLarge = details[7];
                bookDetail.Books.Add(book);
            }
            //});

            reader = new StreamReader("..\\..\\..\\Data\\BX-Users.csv");
            line = reader.ReadLine();
            //Task t2 = new Task(() => { 
            while (!reader.EndOfStream)
            {
                User user = new User();
                line = reader.ReadLine();
                //line.Replace('"', ' ');
                string[] details = line.Split(';');
                for (int i = 0; i < details.Length; i++) { details[i] = details[i].Trim('"'); };
                user.UserID = int.Parse(details[0].Trim('"'));
                string[] location = details[1].Split(',');
                user.City = location[0];
                user.State = location[1];
                user.Country = location[2];
                user.Age = int.Parse(details[2].Trim('"'));
                bookDetail.Users.Add(user);
            }
            //});
            //t1.Wait();
            //t2.Wait();

            reader = new StreamReader("..\\..\\..\\Data\\BX-Book-Ratings.csv");
            line = reader.ReadLine();
            while (!reader.EndOfStream)
            {
                bool isValidUser = false, isValidBook = false;
                BookUserRating Rating = new BookUserRating();
                line = reader.ReadLine();
                string[] details = line.Split(';');
                for (int i = 0; i < details.Length; i++) { details[i] = details[i].Trim('"'); };
                int uid = int.Parse(details[0].Trim('"'));
                Parallel.ForEach(bookDetail.Users, new ParallelOptions { MaxDegreeOfParallelism = (Environment.ProcessorCount / 3) }, (user) =>
                {

                    if (user.UserID == uid)
                    {
                        isValidUser = true;
                        Rating.User = user;
                        user.UserRatings.Add(Rating);
                    }
                });

                string isbn = details[1];

                Parallel.ForEach(bookDetail.Books, new ParallelOptions { MaxDegreeOfParallelism = (Environment.ProcessorCount / 3) }, (book) =>
                //Task task2 = Task.Factory.StartNew(() =>{
                {
                    if (book.ISBN == isbn)
                    {
                        isValidBook = true;
                        Rating.Book = book;
                        book.Ratings.Add(Rating);
                    }
                });
                //task.Wait();
                //task2.Wait();
                if (isValidUser && isValidBook)
                {
                    Rating.Rating = int.Parse(details[2].Trim('"'));
                    Rating.UserID = uid;
                    Rating.ISBN = isbn;
                    bookDetail.BookRatings.Add(Rating);
                }

            }
            return bookDetail;
        }
    }
}


