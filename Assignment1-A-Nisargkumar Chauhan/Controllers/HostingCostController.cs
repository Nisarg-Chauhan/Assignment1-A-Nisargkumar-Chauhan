using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_A_Nisargkumar_Chauhan.Controllers
{
    public class HostingCostController : ApiController
    {
        // GET api/hostingcost
        public IEnumerable<string> Get(int id)
        {
            int days;
            double fortnights, costPerFortnight, hst, totalCost;

            days = id;

            fortnights = days / 14;
            costPerFortnight = 5.50 * (fortnights + 1);
            hst = costPerFortnight * 0.13;
            totalCost = costPerFortnight + hst;

            return new string[] { fortnights + " fortnights at $5.50/FN = $" + costPerFortnight.ToString("0.00") + " CAD",
               "HST 13% = $" + hst.ToString("0.00") + " CAD", "Total = $" + totalCost.ToString("0.00") + " CAD" };
        }
    }
}
