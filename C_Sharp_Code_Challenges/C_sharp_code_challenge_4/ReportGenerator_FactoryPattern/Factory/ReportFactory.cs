using ReportGenerator_FactoryPattern.Products;

namespace ReportGenerator_FactoryPattern.Factory
{
    public class ReportFactory : IReportFactory
    {
        public IReport CreateReport(string type)
        {
            switch (type.ToLower())
            {
                case "chart":
                    return new ChartReport();
                case "tabular":
                    return new TabularReport();
                case "summary":
                    return new SummaryReport();
                default:
                    return null;
            }
        }
    }
}