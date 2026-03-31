using System;

public class Saledetails
{
    
    int salesNo;
    int productNo;
    double price;
    int qty;
    double totalAmount;
    string dateOfSale;

    //Constructor
    public Saledetails(int sNo, int pNo, double pr, int q, string date)
    {
        salesNo = sNo;
        productNo = pNo;
        price = pr;
        qty = q;
        dateOfSale = date;
    }

    //Method to calculate total amount
    public void Sales()
    {
        totalAmount = qty * price;
    }

    //Display method
    public void ShowData()
    {
        Console.WriteLine("\n--- Sales Details ---");
        Console.WriteLine("Sales No: " + salesNo);
        Console.WriteLine("Product No: " + productNo);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Quantity: " + qty);
        Console.WriteLine("Date of Sale: " + dateOfSale);
        Console.WriteLine("Total Amount: " + totalAmount);
    }

    //Static method
    public static void Start()
    {
        Console.Write("Enter Sales No: ");
        int sNo = int.Parse(Console.ReadLine());

        Console.Write("Enter Product No: ");
        int pNo = int.Parse(Console.ReadLine());

        Console.Write("Enter Price: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Enter Quantity: ");
        int qty = int.Parse(Console.ReadLine());

        Console.Write("Enter Date of Sale: ");
        string date = Console.ReadLine();

        //Object created inside class
        Saledetails s = new Saledetails(sNo, pNo, price, qty, date);

        s.Sales();     
        s.ShowData();   
    }
}