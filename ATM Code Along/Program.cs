using System;

namespace ATM_Code_Along
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();

            Console.WriteLine("Welcome to the BankStop");

            while (true)
            {
                

                if (atm.CurrentAccount == null)
                {
                    Menu();
                    Console.Write("Select option: ");
                    string userInput = Console.ReadLine();

                    if (userInput == "1")
                    {
                        Console.Write("Enter username: ");
                        string userName = Console.ReadLine();

                        Console.Write("Enter password: ");
                        string password = Console.ReadLine();

                        atm.Register(userName, password);
                    }
                    else if (userInput == "2")
                    {
                        Console.Write("Enter username ");
                        string userName = Console.ReadLine();

                        Console.Write("Enter username ");
                        string password = Console.ReadLine();

                        atm.Login(userName, password);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }

                }
                else
                {
                    while (true)
                    {
                        AccountOptions();

                        Console.Write("Select option: ");
                        string userInput = Console.ReadLine();

                        if (userInput == "1")
                        {
                            atm.CheckBalance();
                        }

                        if (userInput == "2")
                        {
                            Console.Write("Enter amount to deposit: ");
                            int amount = int.Parse(Console.ReadLine());
                            atm.Deposit(amount);
                        }

                        if (userInput == "3")
                        {
                            Console.Write("Enter amount to withdraw: ");
                            int amount = int.Parse(Console.ReadLine());
                            atm.Withdraw(amount);
                        }

                        if (userInput == "4")
                        {
                            atm.Logout();
                            break;
                        }
                    }
                }

                
                
            }
        }


        public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine();
        }

        public static void AccountOptions()
        {
            Console.WriteLine();
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Logout");
            Console.WriteLine();
        }
    }
}
