﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Allup.Models
{
    public class Brand : Common
    {
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        [NotMappedAttribute]
        public List<Product> Products { get; set; }

    }
}