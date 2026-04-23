using System;
using ReportGenerator_FactoryPattern.Factory;
using ReportGenerator_FactoryPattern.Products;

namespace ReportGenerator_FactoryPattern
{
    class Program
    {
        static void Main()
        {
            IReportFactory factory = new ReportFactory();

            Console.Write("Enter Report Type (chart/tabular/summary): ");
            string choice = Console.ReadLine();

            IReport report = factory.CreateReport(choice);

            if (report != null)
                report.GenerateReport();
            else
                Console.WriteLine("Invalid Report Type");
        }
    }
}