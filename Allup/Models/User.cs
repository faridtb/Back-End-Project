﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Allup.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        [NotMappedAttribute]
        public List<Order> Orders { get; set; }

        [NotMappedAttribute]
        public List<BasketItem> BasketItems { get; set; }
        public List<Comment> Comments { get; set; }
    }

    public enum Roles
    {
        Admin,
        Member,
    }
}
