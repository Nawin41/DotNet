using System;

namespace ReportGenerator_FactoryPattern.Products
{
    public class ChartReport : IReport
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating Chart Report...");
        }
    }
}