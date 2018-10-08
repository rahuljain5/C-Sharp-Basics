using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSort 
{
    class Product : IComparable<Product>
    {
        public int ProductID { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public static int selection;
        public int CompareTo(Product y)
        {
            int result;
            if (selection == 1)
            {
                result = String.Compare(this.Brand, y.Brand);
                if (result > 0) return 1;
                else if (result < 0) return -1;
                else
                {
                    result = String.Compare(this.Description, y.Description);
                    if (result > 0) return 1;
                    else if (result < 0) return -1;
                }
            }
            else
            {
                if (this.Price > y.Price) return 1;
                else if (this.Price > y.Price) return -1;
                else
                {
                    if (this.ProductID > y.ProductID) return 1;
                    else return -1;
                }
            }
            return 1;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add( new Product{ ProductID =200, Brand = "Dell", Description ="15 inch Monitor",Price = 3400.44 });
            products.Add( new Product{ ProductID =100, Brand = "Logitech", Description = "Optical Mouse", Price = 540.00 });
            products.Add( new Product{ ProductID = 150, Brand = "Microsoft", Description = "Windows 7", Price = 7000.5 });
            products.Add( new Product{ ProductID = 120, Brand = "Dell ", Description = "Laptop", Price = 45000.00 });
            products.Sort();      
            foreach(var prod in products)
            {
                Console.WriteLine($"{prod.ProductID} , {prod.Brand}, {prod.Description}, {prod.Price}");
            }
            products = products.OrderBy(p => p.ProductID).ToList();
            Console.WriteLine("1.Sort By BrandName\n 2.Sort By Price");
            Product.selection = int.Parse(Console.ReadLine());
            products.Sort();
            foreach (var prod in products)
            {
                Console.WriteLine($"{prod.ProductID} , {prod.Brand}, {prod.Description}, {prod.Price}");
            }

        }
    }
}
