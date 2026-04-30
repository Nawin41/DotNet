using ReportGenerator_FactoryPattern.Products;

namespace ReportGenerator_FactoryPattern.Factory
{
    public interface IReportFactory
    {
        IReport CreateReport(string type);
    }
}