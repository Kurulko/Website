using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_1.Models.Abstract.Schedule
{
    public class Timer
    {
        public int Id { get; set; }
        public byte StartHours { get; set; }
        public byte StartMinutes { get; set; }
        public byte EndHours { get; set; }
        public byte EndMinutes { get; set; }
    }
}
