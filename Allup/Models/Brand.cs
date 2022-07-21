﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Allup.Models
{
    internal class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public Nullable<DateTime> CreatedAt { get; set; }
        public Nullable<DateTime> DeletedAt { get; set; }
        public Nullable<DateTime> UptadetAt { get; set; }

        public List<Product> Products { get; set; }

    }
}
