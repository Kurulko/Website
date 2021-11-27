using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_1.Models.Rating;

namespace MVC_1.Models.Abstract
{
    public class RatingSubject
    {
        public int Id { get; set; }
        public HighMath HighMath { get; set; }
        public OTK OTK { get; set; }
        public Philosophy Philosophy { get; set; }
        public KompBaza KompBaza { get; set; }
        public Metrologia Metrologia { get; set; }
    }
}
