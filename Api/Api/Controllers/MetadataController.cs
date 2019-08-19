using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class MetadataController : ApiController
    {
        // GET: api/Metadata
        public List<ImageMetadata> Get()
        {
            CSVHelper cvhelper = new CSVHelper();

            return cvhelper.getMetadata();
        }

        // GET: api/Metadata/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Metadata
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Metadata/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Metadata/5
        public void Delete(int id)
        {
        }
    }
}
