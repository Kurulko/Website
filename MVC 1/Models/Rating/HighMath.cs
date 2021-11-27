using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_1.Models.Rating
{
    //[NotMapped]
    public class HighMath
    {
        public int Id { get; set; }
        public /*List<byte>*/string SR { get; set; }
    }
}
