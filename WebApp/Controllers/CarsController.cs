using ClassLib;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Linq;

namespace WebApp.Controllers
{
    public class CarsController : ApiController
    {
        private DBLayer dbl = new DBLayer();
        public IEnumerable<Car> Get()
        {
            return (IEnumerable<Car>)dbl.GetAllCars();
        }

        public IEnumerable<Car> Get(int id)
        {
            return (IEnumerable<Car>)dbl.GetAllCars().Where(i => i.ID == id);
        }

        public string Get(int id, int id2)
        {
            return "id2";
        }

        public void Post([FromBody]string value)
        {
        }

        public void Put(int id, [FromBody]string value)
        {
        }

        public void Delete(int id)
        {
        }
    }
}
