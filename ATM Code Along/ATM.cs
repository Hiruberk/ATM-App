using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Code_Along
{
    class ATM
    {
        public List<Account> Accounts { get; set; }
        public Account CurrentAccount { get; set; }

        public ATM()
        {
            Accounts = new List<Account>();
        }

        public void Register(string name, string password)
        {
            Account account = new Account();//Alternate way is to put Accounts.Add(new Account(name, password));

            account.Name = name;
            account.Password = password;

            Accounts.Add(account);
        }

        public void Login(string username, string password)
        {
            if(CurrentAccount == null)
            {
                foreach (Account account in Accounts)
                {
                    if(account.Name == username && account.Password == password)
                    {
                        CurrentAccount = account;
                        break;
                    }
                                            
                }

                if (CurrentAccount == null)
                {
                    Console.WriteLine("Unable to find match. Invalid username or password.");
                }
            }
            else
            {
                Console.WriteLine("Current account is already in use.");
                Console.WriteLine("Please log out.");
            }
        }

        public void Logout()
        {
            CurrentAccount = null;
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Current Balance: {CurrentAccount.Balance.ToString("C2")}");
        }

        public void Deposit(int cash)
        {
            CurrentAccount.Balance += cash;
        }

        public void Withdraw(int cash)
        {
            if(CurrentAccount.Balance >= cash)
            {
                CurrentAccount.Balance -= cash;
            }
            else
            {
                Console.WriteLine("Insufficient Funds!");
            }
        }

    }
}
