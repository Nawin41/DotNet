using System.Linq;
using System.Web.Mvc;
using NorthwindMVCApp.Models;

namespace NorthwindMVCApp.Controllers
{
    public class CodeController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();

        public ActionResult Index()
        {
            return View();
        }

        // Method 1: Customers from Germany
        public ActionResult GermanyCustomers()
        {
            var data = db.Customers
                         .Where(c => c.Country == "Germany")
                         .ToList();

            return View(data);
        }

        // Method 2: Customer details for OrderID = 10248
        public ActionResult CustomerByOrder()
        {
            var data = db.Orders
                         .Where(o => o.OrderID == 10248)
                         .Select(o => o.Customer)
                         .FirstOrDefault();

            return View(data);
        }
    }
}