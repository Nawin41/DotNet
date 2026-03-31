using System;

public class Accounts
{
    
    int accountNo;
    string customerName;
    string accountType;
    char transactionType;
    double amount;
    double balance;

 
    public Accounts(int accNo, string custName, string accType, double initialBalance)
    {
        accountNo = accNo;
        customerName = custName;
        accountType = accType;
        balance = initialBalance;
    }

    // Deposit
    public void Credit(double amt)
    {
        balance = balance + amt;
        Console.WriteLine("Amount Deposited: " + amt);
    }

    // Withdraw
    public void Debit(double amt)
    {
        if (amt <= balance)
        {
            balance = balance - amt;
            Console.WriteLine("Amount Withdrawn: " + amt);
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }

   
    public void GetTransaction()
    {
        Console.Write("Enter Transaction Type (D/W): ");
        transactionType = char.Parse(Console.ReadLine());

        Console.Write("Enter Amount: ");
        amount = double.Parse(Console.ReadLine());

        if (transactionType == 'D' || transactionType == 'd')
        {
            Credit(amount);
        }
        else if (transactionType == 'W' || transactionType == 'w')
        {
            Debit(amount);
        }
        else
        {
            Console.WriteLine("Invalid Transaction Type");
        }
    }

   
    public void ShowData()
    {
        Console.WriteLine("\n--- Account Details ---");
        Console.WriteLine("Account No: " + accountNo);
        Console.WriteLine("Customer Name: " + customerName);
        Console.WriteLine("Account Type: " + accountType);
        Console.WriteLine("Balance: " + balance);
    }

    
    public static void Start()
    {
        Console.Write("Enter Account No: ");
        int accNo = int.Parse(Console.ReadLine());

        Console.Write("Enter Customer Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Account Type: ");
        string type = Console.ReadLine();

        Console.Write("Enter Initial Balance: ");
        double bal = double.Parse(Console.ReadLine());

        Accounts acc = new Accounts(accNo, name, type, bal);

        acc.GetTransaction();
        acc.ShowData();
    }
}