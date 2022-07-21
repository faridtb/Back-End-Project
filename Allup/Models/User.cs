using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Allup.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [NotMappedAttribute]
        public List<Order> Orders { get; set; }

        [NotMappedAttribute]
        public List<BasketItem> BasketItems { get; set; }
    }

    public enum Roles
    {
        Pending,
        Shipped,
    }
}
