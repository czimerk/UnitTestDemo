using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestDemo.Data;
using UnitTestDemo.Models;

namespace UnitTestDemo.Services
{
    public class UserService
    {
        public Guid? RegisterStoreKeeper(StoreKeeper storeKeeper)
        {
            storeKeeper.Id = Guid.NewGuid();
            MemoryDb.Instance.StoreKeepers.Add(storeKeeper);

            return storeKeeper.Id;
        }
    }
}
