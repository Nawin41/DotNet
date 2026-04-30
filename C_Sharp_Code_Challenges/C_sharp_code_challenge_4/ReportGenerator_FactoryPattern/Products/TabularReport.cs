using System;

namespace ReportGenerator_FactoryPattern.Products
{
    public class TabularReport : IReport
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating Tabular Report...");
        }
    }
}