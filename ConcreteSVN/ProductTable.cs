﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConcreteSVN
{
    public class ProductTable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
