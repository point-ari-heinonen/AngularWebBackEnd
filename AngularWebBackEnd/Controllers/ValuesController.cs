
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;

namespace AngularWebBackEnd.Controllers
{
    public class ValuesController : ApiController
    {  [System.Web.Http.HttpGet]
       [System.Web.Http.Route("api/values/ProductCount")]
        public int ProductCount()
        {
            
            JalkahoitolaEntities entities = new JalkahoitolaEntities();
            int productCount = entities.Products.Count();

            return productCount;
        }
        
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/values/ProductList")]
       
         public List<string> ProductList()
        {

            JalkahoitolaEntities entities = new JalkahoitolaEntities();
            List<Product> ListOfProducts = (from p in entities.Products
                                            select p).ToList();
            List<string> products = ListOfProducts.Select(p => p.Nmae).ToList();


            return (products);
        }
       
        }



    }


/*
 *  public List<string> ProductList()
        {

            JalkahoitolaEntities entities = new JalkahoitolaEntities();
            List<Product> ListOfProducts = (from p in entities.Products
                                           select p).ToList();
            List<string> products = ListOfProducts.Select(p => p.Nmae).ToList();
            

            return (products);
        }
*/