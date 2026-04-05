using System;

namespace CSharp_Assignment_5
{
    internal class BankApplication
    {
        static double balance = 1000;

        public static void Start()
        {
            try
            {
                Console.WriteLine("Enter amount to deposit:");
                double depositAmount = double.Parse(Console.ReadLine());
                Deposit(depositAmount);

                Console.WriteLine("Enter amount to withdraw:");
                double withdrawAmount = double.Parse(Console.ReadLine());
                Withdraw(withdrawAmount);

                ShowBalance();
            }
            catch (InsuffientBalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }

        static void Deposit(double amount)
        {
            balance = balance + amount;
            Console.WriteLine("Amount deposited successfully.");
        }

        static void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new InsuffientBalanceException("Insufficient balance. Withdrawal not allowed.");
            }

            balance = balance - amount;
            Console.WriteLine("Amount withdrawn successfully.");
        }

        static void ShowBalance()
        {
            Console.WriteLine("Current Balance: " + balance);
        }
    }

    //User-defined Exception
    internal class InsuffientBalanceException : Exception
    {
        public InsuffientBalanceException(string message) : base(message)
        {
        }
    }
}
