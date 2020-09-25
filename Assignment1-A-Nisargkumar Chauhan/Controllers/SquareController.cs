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
        /// <summary>
        /// When the GET request is received, this method returns the square of the id
        /// <square> GET api/square/{id} </square>
        /// </summary>
        /// <param name="id"></param>
        /// <returns> id * id </returns>
        public int Get(int id)
        {
            return id * id;
        }
    }
}
