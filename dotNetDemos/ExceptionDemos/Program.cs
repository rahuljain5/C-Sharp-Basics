using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account savings = new Account();
                Console.WriteLine(savings.Balance);
                double amt;
                Console.Write("Enter Amount to Deposit");
                amt = double.Parse(Console.ReadLine());
                savings.Deposit(amt);
                Console.WriteLine(savings.Balance);
                Console.Write("Enter Amount to Withdraw");
                amt = double.Parse(Console.ReadLine());
                savings.Withdraw(amt);
                Console.WriteLine(savings.Balance);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (OverflowException oe) { Console.WriteLine(oe.Message); }
            catch (InvalidAmountException ae) { Console.WriteLine(ae.Message); }
            catch (UnableToSendEmailException ue) { Console.WriteLine(ue.Message); Console.WriteLine(ue.InnerException.Message); }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
        private static void Add2Num()
        {
            //Accept 2 int numbers and find sum until user says stop
            while (true)
            {
                try
                {
                    int fno, sno, sum;
                    Console.WriteLine("Enter First Number");
                    fno = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Second Number");
                    sno = int.Parse(Console.ReadLine());
                    sum = fno + sno;
                    Console.WriteLine($"the Sum of {fno} and {sno} is {sum}");
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Invalid Number, Please enter only Numbers!!");
                }
                catch (OverflowException oe)
                {
                    Console.WriteLine("Invalid Number, Please enter a smaller Number!");
                }
                catch (Exception e) //CatchAll
                {
                    Console.WriteLine("Error Occured");
                }
            }
        }
    }
}
