using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountManager accountManager = new AccountManager();
            //while (true)
            //{
                //Console.WriteLine("1. Open Account\n2. Close Account\n3. Deposit");
                try
                {
                //Open Account
                    Account acc = accountManager.OpenAccount("RJ", "1234", 67890.0);
                //Duplicate Account Request
                //accountManager.OpenAccount("RJ", "1234", 67890.0);
                //Negative Deposit
                //accountManager.Deposit(acc, -567);
                //Deposit
                accountManager.Deposit(acc, 567);
                //Withdrawal higher than balance
                //accountManager.Withdraw(acc, 99999, "1234");
                ////Incorrect PIN
                //accountManager.Withdraw(acc, 99999, "5555");
                ////Withdrawal
                //accountManager.Withdraw(acc, 99, "1234");
                //Close Acc with Balance>0
                //accountManager.CloseAccount(acc);
                Account acc2 = accountManager.OpenAccount("Someone", "3333", 8888);
                Console.WriteLine($"Account1 bal: {acc.Balance}, Account 2 Bal: {acc2.Balance}");
                accountManager.FundTransfer(acc, acc2, 20, "1234");
                Console.WriteLine($"Account1 bal: {acc.Balance}, Account 2 Bal: {acc2.Balance}");
            }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            //}
        }
    }
}
