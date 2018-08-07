using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class Shopping
    {
        static void Main()
        {
            int itemPrice, itemQuantity, itemTotal;
            double grandTotal = 0;
            string itemCode, itemDescription;
            char userInput;
            bool payByCard = false;
            do
            {
                Console.WriteLine("Enter Item Code:");
                itemCode = Console.ReadLine();
                Console.WriteLine("Enter Item Description:");
                itemDescription = Console.ReadLine();
                Console.WriteLine("Enter Item Qty:");
                itemQuantity = (int.Parse(Console.ReadLine()));
                Console.WriteLine("Enter Item Price:");
                itemPrice = (int.Parse(Console.ReadLine()));
                itemTotal = itemQuantity * itemPrice;
                grandTotal += itemTotal;
                Console.WriteLine("Add More Items? y/n");
            } while (Console.ReadLine() == "y");
            if (grandTotal > 10000)
            {
                grandTotal = grandTotal * 0.9;
            }
            else if (grandTotal< 1000)
            {
                Console.WriteLine("Paying By Card? y/n");
                userInput = char.Parse(Console.ReadLine());
                if (userInput == 'y') payByCard = true;
                if (payByCard)
                {
                    grandTotal = grandTotal * 1.025;
                }
            }
            Console.WriteLine("Grand Total is: " + grandTotal);
        }
    }
}
