using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement
{
    class AccountManager
    {
        private static List<Account> accounts = new List<Account>();
        static int number = 0;

        public Account OpenAccount(string name, string pin, double balance)
        {
            foreach(var acc in accounts)
            {
                if (acc.Name == name && acc.PIN == pin)
                    throw new AccountOpeningFailedException("Account already Exists!");
            }
            Account account = new Account();
            account.AccNo = "1800BANK" + number++;
            account.Name = name;
            account.PIN = pin;
            account.Balance = balance;
            account.isActive = true;
            accounts.Add(account);
            return account;
        }
        public void CloseAccount(Account acc)
        {
            if (accounts.Exists(e => e.Equals(acc)))
            {
                if (!acc.isActive)
                    throw new AccountClosingFailedException("Cannot close inactive account");
                else if (acc.Balance != 0)
                {
                    throw new AccountClosingFailedException("Cannot close account with Non Zero Balance");
                }
                else acc.isActive = false;
            }
        }
        public void Deposit(Account acc, double amt)
        {
            if (acc.isActive)
            {
            if (amt <= 0)
            {
                throw new FailedDepositException("Amount Cannot be less than zero");
            }
            acc.Balance += amt;
            }
            else throw new FailedDepositException("Cannot deposit into Inactive Account");
        }
        public void Withdraw(Account acc, double amt, string pin)
        {
            if (acc.isActive)
            {
                if(pin != acc.PIN)
                {
                    throw new FailedWithdrawException("InCorrect PIN");
                }
                if (acc.Balance < amt)
            {
                throw new FailedWithdrawException("Insufficient Funds!");
            }
            acc.Balance -= amt;
            }
            else throw new FailedWithdrawException("Cannot WithDraw From Inactive Account");
        }
        public void FundTransfer(Account acc1, Account acc2, double amt, string pin)
        {
            if (acc1.isActive && acc2.isActive)
            {
                Withdraw(acc1, amt, pin);
                Deposit(acc2, amt);
            }
            else if(!acc2.isActive) throw new FailedFundTransferException("Cannot Transact to an inactive account");
            else throw new FailedFundTransferException("Cannot Transact from an inactive account");
        }

    }
}
