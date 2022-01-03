using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_1
{
    public static class ForGuests
    {
        public static string Name(string name)
        {
            string result = name[0].ToString();

            for (int i = 1; i < name.Length; i++)
            {
                if (name[i] == ' ')
                {
                    result += ". " + name[i..];
                    break;
                }
            }
            return result;
        }
    }
}
