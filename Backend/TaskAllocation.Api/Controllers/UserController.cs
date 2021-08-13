using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TaskAllocation.Api.Controllers
{
    public class UserController : ApiController
    {
        public string GetUser(int id)
        {
            if (id == 1)
            {
                return "Id is 1";
            }
            else
            {
                return "badusha";
            }
          
        }
    }
}
