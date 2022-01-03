using MVC_1.Models.Abstract;
using MVC_1.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_1.Models.ViewModel
{
    public class RatingsAndSelected
    {
        public IEnumerable<IdRating> Ratings { get; set; }
        public Selected Selected { get; set; }
    }

    public class Selected
    {
        public string Name { get; set; }
        public SortIdRating SortIdRating { get; set; }
    }
}
