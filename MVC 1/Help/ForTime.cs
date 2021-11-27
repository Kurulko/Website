using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_1
{
    public class ForTime
    {
        public static string ZnamORChesl()
        {
            string now = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();

            return now;
        }
    }
}
