using System;
using System.Collections.Generic;

namespace _03.BankAccountTest
{
    public class BankAccountTest
    {
        public static void Main()
        {
            var accounts = new Dictionary<int, BankAccount>();
            var input = Console.ReadLine();

            while (input != "End")
            {
                string[] commandArgs = input.Split();
                var command = commandArgs[0];
                var id = int.Parse(commandArgs[1]);

                switch (command)
                {
                    case "Create":
                        Create(id, accounts);
                        break;
                    case "Deposit":
                        Deposit(id, double.Parse(commandArgs[2]), accounts);
                        break;
                    case "Withdraw":
                        Withdraw(id, double.Parse(commandArgs[2]), accounts);
                        break;
                    case "Print":
                        Print(id, accounts);
                        break;
                }

                input = Console.ReadLine();
            }
        }

        private static void Print(int id, Dictionary<int, BankAccount> accounts)
        {
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine(accounts[id].ToString());
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Withdraw(int id, double amount, Dictionary<int, BankAccount> accounts)
        {
            if (accounts.ContainsKey(id))
            {
                if (accounts[id].Balance >= amount)
                {
                    accounts[id].Withdraw(amount);
                }
                else
                {
                    Console.WriteLine("Insufficient balance");
                }
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Deposit(int id, double amount, Dictionary<int, BankAccount> accounts)
        {
            if (accounts.ContainsKey(id))
            {
                accounts[id].Deposit(amount);
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Create(int id, Dictionary<int, BankAccount> accounts)
        {
            if (!accounts.ContainsKey(id))
            {
                var acc = new BankAccount();
                acc.ID = id;
                accounts.Add(id, acc);
            }
            else
            {
                Console.WriteLine("Account already exists");
            }
        }
    }
}
