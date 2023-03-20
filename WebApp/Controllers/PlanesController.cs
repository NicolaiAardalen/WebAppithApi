using ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApp.Controllers
{
    public class PlanesController : ApiController
    {
        private DBLayer dbl = new DBLayer();
        public IEnumerable<Plane> Get()
        {
            return (IEnumerable<Plane>)dbl.GetAllPlanes();
        }

        public IEnumerable<Plane> Get(int id)
        {
            return (IEnumerable<Plane>)dbl.GetAllPlanes().Where(i=> i.ID == id);
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
