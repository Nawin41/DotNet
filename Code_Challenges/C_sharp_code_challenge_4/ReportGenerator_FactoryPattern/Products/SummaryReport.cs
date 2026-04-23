using System;

namespace ReportGenerator_FactoryPattern.Products
{
    public class SummaryReport : IReport
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating Summary Report...");
        }
    }
}