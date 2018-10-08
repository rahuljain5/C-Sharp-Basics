using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemos
{
    /// <summary>
    /// Account Class is used for managing the account info
    /// Create an account object for deposit and withdraw operations
    /// </summary>
    class Account
    {
        /// <summary>
        /// Get Balance of Account
        /// </summary>
        public double Balance { get; private set; }
        /// <summary>
        /// Deposit amount into account
        /// Increase the bal
        /// </summary>
        /// <exception cref="InvalidAmountException">Throws invalid Amount Exception when amount is negative</exception>
        /// <param name="amt">Provide positive double value</param>
        public void Deposit(double amt)
        {
            if(amt <= 0)
            {
                throw new InvalidAmountException("Amount should be greater than zero");
            }
            Balance += amt;
            try { 
            SmtpClient smtpClient = new SmtpClient();
            MailMessage msg = new MailMessage("abc@mail.com", "xyz@mail.com");
            msg.Subject = "";
            msg.Body = "";
            smtpClient.Host = "";
            smtpClient.Send(msg);
            }
            catch(InvalidOperationException ie)
            {
                //log exception
                UnableToSendEmailException mailExp = new UnableToSendEmailException("Mail Sending Failed", ie);
                throw mailExp;
            }
        }
        /// <summary>
        /// Withdraw amount from account
        /// </summary>
        /// <exception cref="InsufficientFundsException">Throws invalid Amount Exception when amount is negative</exception>
        /// <param name="amt">Provide positive double value</param>
        public void Withdraw(double amt)
        {
            if (amt > Balance)
            {
                throw new InsufficientFundsException("Insufficient Funds!");
            }
            Balance -= amt;
        }
    }
}
