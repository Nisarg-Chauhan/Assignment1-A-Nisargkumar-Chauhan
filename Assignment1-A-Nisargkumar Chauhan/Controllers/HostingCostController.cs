using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_A_Nisargkumar_Chauhan.Controllers
{
    //Bonus Question
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// When the GET request is received, this method returns three strings which describe the total hosting cost.
        /// <hostingcost>GET api/HostingCost/{id}</hostingcost>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>["costPerFortnight", "costWithHst", "totalCost"]</returns>
        public IEnumerable<string> Get(int id)
        {
            //Declare Variables
            int days;
            double fortnights, costPerFortnight, hst, totalCost;

            days = id;

            //Calculate total cost
            fortnights = days / 14;
            costPerFortnight = 5.50 * (fortnights + 1);
            hst = costPerFortnight * 0.13;
            totalCost = costPerFortnight + hst;

            //Return an array of string
            //ToString() method is used to set the precision of the decimal value 
            return new string[] { fortnights + " fortnights at $5.50/FN = $" + costPerFortnight.ToString("0.00") + " CAD",
               "HST 13% = $" + hst.ToString("0.00") + " CAD", "Total = $" + totalCost.ToString("0.00") + " CAD" };
        }
    }
}
