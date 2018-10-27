using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text;
using SampleApplication.Models;

namespace SampleApplication.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        //get api/values/sampledata
        public List<SampleData> getSampleData()
        {
            List <SampleData> data = new List<SampleData>();
            
            
            SampleData newData = new SampleData();
            newData.ApplicationId = 9000;
            newData.Id = 12345;
            newData.Summary = "test";
            newData.Type = "test123";
            newData.IsCleared = false;
            newData.PostingDate = new DateTime();
            newData.ClearedDate = new DateTime();
            data.Add(newData);

            return data;



        }
    }
}
