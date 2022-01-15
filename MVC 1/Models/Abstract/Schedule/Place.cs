using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_1.Models.Abstract.Schedule
{
    public class Place
    {
        public string NameTeacher { get; set; }
        public string NameSubject { get; set; }
        public string Link { get; set; }
        public int Id { get; set; }

        public int NameLinkId { get; set; }
        public NameLink NameLink { get; set; }
    }
}
