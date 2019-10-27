using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace sfc.api.Controllers
{
    public class ValuesController : ApiController
    {
        //https://www.infoworld.com/article/3192176/my-two-cents-on-using-the-ihttpactionresult-interface-in-webapi.html
        // GET api/values
        public IHttpActionResult Get()
        {
            JObject o = new JObject();
            o.Add("ip", "10.239.89.10");
            o.Add("prg_name", "sfc_pack");
            var columns = new Dictionary<string, string>
            {
                { "FirstName", "Mathew"},
                { "Surname", "Thompson"},
                { "Gender", "Male"},
                { "SerializeMe", "GoOnThen"}
            };

            string prettyJson = JToken.Parse(o.ToString()).ToString(Formatting.Indented);
            var jsSerializer = new JavaScriptSerializer();

            var serialized = jsSerializer.Serialize(columns);
          var json =  JsonConvert.SerializeObject(columns, Formatting.Indented);
            //dynamic foo = new ExpandoObject();
            //foo.Bar = "something";
            //var js = new JavaScriptSerializer();
            //string json = js.Serialize(foo);
            return Ok(json);
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {


            return "value";
        }

        // POST api/values
        public IHttpActionResult Post([FromBody]JObject json)
        {
            if (json.GetValue("ip")==null)
            {
                json.Add("ip", "10.239.89.10");
            }

            string jsonString = Regex.Unescape(Newtonsoft.Json.JsonConvert.SerializeObject(json));

            return Ok(json);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
