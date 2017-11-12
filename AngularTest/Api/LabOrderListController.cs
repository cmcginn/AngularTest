using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularTest.Api
{
    public class LabOrderListController : ApiController
    {
        // GET: api/LabOrderList
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/LabOrderList/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/LabOrderList
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/LabOrderList/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LabOrderList/5
        public void Delete(int id)
        {
        }
    }
}
