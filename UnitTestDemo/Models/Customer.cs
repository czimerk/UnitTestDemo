using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo.Models
{
    public class Customer : User
    {
        public List<Order> Orders { get; set; }

    }
}
