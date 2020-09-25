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
        /// <summary>
        /// When the POST request is received, this method returns the string "Hello World"
        /// <greeting> POST api/Greeting </greeting>
        /// </summary>
        /// <returns> "Hello World" </returns>    
        public string Post()
        {
            return "Hello World";
        }


        /// <summary>
        /// When the GET request is received, this method returns the string "Greetings to {id} people!"
        /// <greeting> GET api/Greeting/{id} </greeting>
        /// </summary>
        /// <param name="id"></param>
        /// <returns> "Greetings to {id} people!" </returns>
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
