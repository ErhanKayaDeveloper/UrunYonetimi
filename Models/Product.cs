﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UrunYonetimi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }
        public int? Stock { get; set; }
        public bool Status { get; set; }
    }
}