using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Models
{
    public class Income
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public DateTime Date { get; set; }
        public Field Field { get; set; }
    }

    public enum Field
    {
        Sale,
        Another,
    }
}
