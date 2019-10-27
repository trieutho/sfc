using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using sfc.api.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace sfc.api.Controllers
{

    [RoutePrefix("api/chats")]
    public class ChatController : ApiController
    {
        private ChatHub _chatHub;
        public ChatController()
        {
            DefaultHubManager hubManager = new DefaultHubManager(GlobalHost.DependencyResolver);
            _chatHub = hubManager.ResolveHub("ChatHub") as ChatHub;
        }
        [Route("")]
        public IHttpActionResult Post()
        {
            _chatHub.Send("API", "I'm GOD! all you banned");
            return Ok();
        }
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
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