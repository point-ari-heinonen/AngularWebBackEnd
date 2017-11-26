using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularWebBackEnd.Controllers
{
    public class ProductController : ApiController
    {
        public IEnumerable<Product> Get(string id)
        {
            //id = "Nitriili";
            JalkahoitolaEntities entities = new JalkahoitolaEntities();
            List<Product> items = (from o in entities.Products
                                   where o.Nmae == id
                                   select o).ToList();
            entities.Dispose();
            List<Product> result = new List<Product>();
            foreach (Product item in items)
            {

                Product data = new Product();
                data.Nmae = item.Nmae;
                data.Quantity = item.Quantity;
                data.UnitOfMeasure = item.UnitOfMeasure;
                result.Add(data);
            }

            return result;
        }
        // GET: api/Product
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        /*
        // GET: api/Product/5
        public string Get(int id)
        {
            return "value";
        }
        */

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
            

    }
}
