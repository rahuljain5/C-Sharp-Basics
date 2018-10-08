using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class AccountProgram
    {
        public static void Main()
        {
            Account acc1 = new Account();
            acc1.Deposit(1000000);
            Console.WriteLine(acc1.Balance);
            acc1.alert += Notification.SendEmail;
            acc1.alert += Notification.SendSMS;
            acc1.Deposit(10000);
        }
    }

    delegate void AlertDelegate();

    class Account
    {
        public int Balance { get; set; }
        public event AlertDelegate alert;
        public void Deposit(int amt)
        {
            Balance += amt;
            if(alert != null)
            alert();
        }
        public void Withdraw(int amt)
        {
            Balance -= amt;
            if (alert != null)
                alert();
        }
        
    }
    
    class Notification
    {
        static public void SendEmail()
        {
            Console.WriteLine("Email: Sending to ............");
        }
        static public void SendSMS()
        {
            Console.WriteLine("SMS: Sending to ............");
        }
    }
}
