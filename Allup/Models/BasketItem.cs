using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Allup.Models
{
    public class BasketItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }

        [NotMappedAttribute]
        public Product Product { get; set; }
        public string UserId { get; set; }

        [NotMappedAttribute]
        public User User { get; set; }
    }
}
