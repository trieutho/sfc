using sfc.api.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace sfc.api.Controllers
{
    public class ApiControllerBase : ApiController
    {
        public string GetClientIp(HttpRequestMessage request = null)
        {
            //request = request ?? Request;
            return request.GetClientIpAddress();
        }
    }
}