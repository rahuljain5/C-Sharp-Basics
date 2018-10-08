using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class UserDefinedType
    {
        class Product
        {
            //private int productId;
            //private string name;
            //private double price;
            //Automatic properties
            public int ProductId { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }

            //Read only Properties
            public int ProductQty { get; private set; }

            //parameterized Constructor with variable Args
            //public Product(out int sum, int id = 011, string Name = "Something", double price = 10)
            //{
            //    ProductId = id;
            //    this.Name = Name;
            //    Price = price;
            //    sum = (int)(price * 1.2);
            //}
            public Product()
            {

            }
            ~Product()
            {
                Console.WriteLine("Dtor Callling bro!");
            }
        }
        public static void Main()
        {
            //Object Initialization Syntax (Available > .Net 4.0)
            Product p = new Product { ProductId = 099, Price = 19};
            
            // Anonymous Type
            var someclass = new { Name = "Crazyy Shit!" };
            Console.WriteLine(someclass.GetType());
            
        }
    }
}
