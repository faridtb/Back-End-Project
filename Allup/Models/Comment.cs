using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Models
{
    public class Comment : Common
    {
        public string Content { get; set; }
        public int UserId { get; set; }
        public int MyProperty { get; set; }
    }
}
