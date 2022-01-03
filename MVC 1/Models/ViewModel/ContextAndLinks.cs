using MVC_1.Models.Abstract.Schedule;
using MVC_1.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_1.Models.ViewModel
{
    public class ContextAndLinks
    {
        public Dictionary<string, Place> Links { get; set; }
        public IBTSMContext db { get; set; }
        public ContextAndLinks(Dictionary<string, Place> Links, IBTSMContext db)
        {
            this.Links = Links;
            this.db = db;
        }
    }
}
