using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;

namespace NorthwindMVCClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<dynamic> orders = new List<dynamic>();

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44389/");

                var response = client.GetAsync("api/orders/employee5").Result;

                if (response.IsSuccessStatusCode)
                {
                    orders = response.Content.ReadAsAsync<List<dynamic>>().Result;
                }
            }

            return View(orders);
        }
    }
}