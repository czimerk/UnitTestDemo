using System;
using UnitTestDemo.Data;
using UnitTestDemo.Models;
using UnitTestDemo.Services;
using Xunit;

namespace UnitTestDemoTests
{
    public class UserServiceTests
    {
        private static readonly string NonExistingGuid = "2944f688-5ac9-4fcd-bfb0-b877c41686e8";
        private static readonly string ExistingGuid = "27ecaa8a-f543-40bf-8b99-6762a76241ac";

        [Fact]
        public void RegisterStoreKeeper_StoreKeeperWithNotStoreId_ThrowsArgumentException()
        {
            var validStoreKeeper = new StoreKeeper()
            {
            };
            var service = new UserService();
            Assert.Throws<ArgumentException>(() => service.RegisterStoreKeeper(validStoreKeeper));
        }

        [Fact]
        public void RegisterStoreKeeper_StoreKeeperWithNonExistentStore_ThrowsInvalidOperationException()
        {
            var validStoreKeeper = new StoreKeeper()
            {
                StoreId = new Guid(NonExistingGuid)
            };
            var service = new UserService();
            Assert.Throws<InvalidOperationException>(() => service.RegisterStoreKeeper(validStoreKeeper));
        }

        [Fact]
        public void RegisterStoreKeeper_StoreKeeperWithExistentStore_ReturnId()
        {
            MemoryDb.Instance.Stores.Add(new Store()
            { 
                Id = new Guid(ExistingGuid)
            });
            var validStoreKeeper = new StoreKeeper()
            {
                StoreId = new Guid(ExistingGuid)
            };
            var service = new UserService();
            var id = service.RegisterStoreKeeper(validStoreKeeper);
            Assert.NotNull(id);
        }
    }
}