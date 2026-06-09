using System.Linq;
using System.Web.Http;
using CountryAPI.Models;

namespace CountryAPI.Controllers
{
    public class CountryController : ApiController
    {
        CountryContext db = new CountryContext();

        //GET
        public IHttpActionResult Get()
        {
            return Ok(db.Countries.ToList());
        }

        //GET
        public IHttpActionResult Get(int id)
        {
            var data = db.Countries.Find(id);

            if (data == null)
                return NotFound();

            return Ok(data);
        }

        //POST(Insert)
        public IHttpActionResult Post(Country c)
        {
            db.Countries.Add(c);
            db.SaveChanges();

            return Ok("Inserted Successfully");
        }

        //PUT(Update)
        public IHttpActionResult Put(int id, Country c)
        {
            var data = db.Countries.Find(id);

            if (data == null)
                return NotFound();

            data.CountryName = c.CountryName;
            data.Capital = c.Capital;

            db.SaveChanges();

            return Ok("Updated Successfully");
        }

        //DELETE
        public IHttpActionResult Delete(int id)
        {
            var data = db.Countries.Find(id);

            if (data == null)
                return NotFound();

            db.Countries.Remove(data);
            db.SaveChanges();

            return Ok("Deleted Successfully");
        }
    }
}