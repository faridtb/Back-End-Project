﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Allup.Models
{
    internal class OrderItem
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public int Count { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }


    }
}
