using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_A_Nisargkumar_Chauhan.Controllers
{
    public class GreetingController : ApiController
    {
        // POST api/Greeting
        public string post()
        {
            return "Hello World";
        }

        public string get(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
