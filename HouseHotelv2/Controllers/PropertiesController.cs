using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HouseHotelv2.Infrastructure;



namespace HouseHotelv2.Controllers
{
    public class PropertiesController : ApiController
    {
        private happyhousesv4Entities db = new happyhousesv4Entities();
        
        // GET api/<controller>
        public IEnumerable<Property> GetProperties()
        {
            return db.Properties;
        }

       
       /* [HttpGet]
        // GET api/<controller>/P0005
        public Property GetProperty(string id)
        {
            return db.Properties.First(p => p.PropertyID == id);

        }
        */
        public IEnumerable<Property> GetPropertiesByCountry(string country)
        {
            return db.Properties.Where(p =>p.Country == country);
        }

    

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}