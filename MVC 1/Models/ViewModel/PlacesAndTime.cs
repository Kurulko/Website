using MVC_1.Models.Abstract.Schedule;
using System.Collections.Generic;

namespace MVC_1.Models.ViewModel
{
    public class PlacesAndTime
    {
        public List<NameLink> NameLinks { get; set; }
        public List<Timer> Time { get; set; }
    }
}
