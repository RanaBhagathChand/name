﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace name.Controllers
{
    public class noneController : ApiController
    {
        // GET: api/none
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/none/5
        public string Get(int id)
        {
            string name = "this is rana";
            string name2 = "this is rana2";
            return "value";
        }

        // POST: api/none
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/none/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/none/5
        public void Delete(int id)
        {
        }
    }
}
