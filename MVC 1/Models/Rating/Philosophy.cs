﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace MVC_1.Models.Rating
{
    //[NotMapped]
    public class Philosophy
    {
        public int Id { get; set; }
        public /*List<byte>*/string Seminar { get; set; }
    }
}