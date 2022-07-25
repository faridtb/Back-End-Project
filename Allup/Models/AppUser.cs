﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Order> Orders { get; set; }
        public List<BasketItem> BasketItems { get; set; }
        public List<WishList> WishLists { get; set; }
    }
}
