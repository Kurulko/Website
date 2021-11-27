using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_1
{
    public class ScoreColor
    {
        public static string Color(int score) => score == 0 ? "red" : "white";
    }
}
