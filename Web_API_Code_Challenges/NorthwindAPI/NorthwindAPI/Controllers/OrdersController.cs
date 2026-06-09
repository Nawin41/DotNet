using System.Linq;
using System.Web.Http;
using NorthwindAPI.Models;

namespace NorthwindAPI.Controllers
{
    [RoutePrefix("api/orders")]
    public class OrdersController : ApiController
    {
        NorthwindEntities db = new NorthwindEntities();

        [HttpGet]
        [Route("employee5")]
        public IHttpActionResult GetOrdersByEmployee()
        {
            var data = db.Orders
                         .Where(o => o.EmployeeID == 5)
                         .Select(o => new
                         {
                             o.OrderID,
                             o.CustomerID,
                             o.OrderDate,
                             o.ShipName
                         })
                         .ToList();

            if (data == null || data.Count == 0)
                return NotFound();

            return Ok(data);
        }

        [HttpGet]
        [Route("customersbycountry")]
        public IHttpActionResult GetCustomersByCountry(string country)
        {
            var data = db.GetCustomersByCountry(country).ToList();

            if (data == null || data.Count == 0)
                return NotFound();

            return Ok(data);
        }
    }
}