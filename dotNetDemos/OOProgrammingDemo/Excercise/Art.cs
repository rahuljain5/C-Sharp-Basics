using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProgrammingDemo.Excercise
{
    class Art : Property
    {
        public Art(string name, double cost, int yearPurchased, double assessment, string artist, int year) : base(name, cost, yearPurchased, assessment)
        {
            Artist = artist;
            YearCreated = year;
        }

        public string Artist { get; set; }
        public int YearCreated { get; set; }

        new public void Print()
        {
            base.Print();
            Console.WriteLine($"Artist : {Artist}, Year of Creation: {YearCreated}");
            
        }
    }
}
