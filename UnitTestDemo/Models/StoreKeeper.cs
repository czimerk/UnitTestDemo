using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo.Models
{
    internal class StoreKeeper :User
    {
        public Store Store { get; set; }
        public Guid StoreId { get; set; }
    }
}
