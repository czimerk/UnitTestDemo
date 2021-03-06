using System;
using System.Collections.Generic;
using System.Text;
using UnitTestDemo.Models;

namespace UnitTestDemo.Data
{
    public class MemoryDb
    {
        public List<StoreKeeper> StoreKeepers { get; private set; }
        public List<Order> Orders { get; private set; }
        public List<Store> Stores { get; private set; }
        public List<Customer> Customers { get; private set; }

        private MemoryDb()
        {
            StoreKeepers = new List<StoreKeeper>();
            Orders = new List<Order>();
            Customers = new List<Customer>();
            Stores = new List<Store>();
            
        }

        private static readonly Lazy<MemoryDb> lazy = new Lazy<MemoryDb>(() => new MemoryDb());
        public static MemoryDb Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
