using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public double Total { get; set; }
    }
}
