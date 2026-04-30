using System;

namespace C_Sharp_Code_Challenge_2
{
    class Products
    {
        public int ProductId;
        public string ProductName;
        public double Price;

        public static void Sort_by_price()
        {
            Products[] products = new Products[10];

            for (int i = 0; i < 10; i++)
            {
                products[i] = new Products();

                Console.WriteLine("Enter Product ID:");
                products[i].ProductId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Product Name:");
                products[i].ProductName = Console.ReadLine();

                Console.WriteLine("Enter Product Price:");
                products[i].Price = double.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            //Sorting
            for (int i = 0; i < products.Length - 1; i++)
            {
                for (int j = 0; j < products.Length - i - 1; j++)
                {
                    if (products[j].Price > products[j + 1].Price)
                    {
                        Products temp = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Products Sorted by Price:");
            foreach (Products p in products)
            {
                Console.WriteLine("ID: " + p.ProductId +", Name: " + p.ProductName +", Price: " + p.Price);
            }
        }
    }
}