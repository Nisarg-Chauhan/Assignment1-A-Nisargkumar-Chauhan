using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_A_Nisargkumar_Chauhan.Controllers
{
    public class SquareController : ApiController
    {
        // GET api/square/10
        public int Get(int id)
        {
            return id * id;
        }
    }
}
