using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_A_Nisargkumar_Chauhan.Controllers
{
    public class AddTenController : ApiController
    {

        /// <summary>
        /// When the GET request is received, this method adds 10 in the id and returns it
        /// <addten> GET api/AddTen/{id} </addten>
        /// </summary>
        /// <param name="id"></param>
        /// <returns> id+10 </returns>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
