﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCare.View_Models
{
    public class ItemVM
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Vat { get; set; }
    }
}
