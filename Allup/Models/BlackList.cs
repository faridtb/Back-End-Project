using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Models
{
    public class BlackList
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int GivenTime { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
