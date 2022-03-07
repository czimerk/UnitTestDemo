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
            if (storeKeeper.StoreId == Guid.Empty)
            { 
                throw new ArgumentException("Invalid " + nameof(storeKeeper.StoreId));
            }

            var store = MemoryDb.Instance.Stores.FirstOrDefault(store => store.Id == storeKeeper.StoreId);
            if (store == null)
            {
                throw new InvalidOperationException($"Specified store does not exist in the database {storeKeeper.StoreId}");
            }

            storeKeeper.Id = Guid.NewGuid();
            MemoryDb.Instance.StoreKeepers.Add(storeKeeper);

            return storeKeeper.Id;
        }
    }
}
