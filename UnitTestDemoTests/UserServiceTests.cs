using System;
using UnitTestDemo.Data;
using UnitTestDemo.Models;
using UnitTestDemo.Services;
using Xunit;

namespace UnitTestDemoTests
{
    public class UserServiceTests
    {
        private static readonly Guid NonExistingGuid = new Guid("468c726c-bcde-4f79-97e2-f15f30c6ef59");
        private static readonly Guid ExistingGuid = new Guid("d8d78fd8-2b06-48a9-9741-a622209af4cc");
        [Fact]
        public void RegisterStoreKeeper_NoStoreId_ThrowsArgumentException()
        {
            var validStoreKeeper = new StoreKeeper()
            {
            };
            var service = new UserService();
            Assert.Throws<ArgumentException>(() => service.RegisterStoreKeeper(validStoreKeeper));
        }

        [Fact]
        public void RegisterStoreKeeper_NonExistingStoreId_ThrowsInvalidOperationExceptionException()
        {
            var validStoreKeeper = new StoreKeeper()
            {
                StoreId = NonExistingGuid
            };
            var service = new UserService();
            Assert.Throws<InvalidOperationException>(() => service.RegisterStoreKeeper(validStoreKeeper));
        }

        [Fact]
        public void RegisterStoreKeeper_ExistingStoreId_ThrowsInvalidOperationExceptionException()
        {
            MemoryDb.Instance.Stores.Add(new Store()
            {
                Id = ExistingGuid
            });
            var validStoreKeeper = new StoreKeeper()
            {
                StoreId = ExistingGuid
            };
            var service = new UserService();
            var id = service.RegisterStoreKeeper(validStoreKeeper);
            Assert.NotNull(id);
        }


        [Fact]
        public void TheAnswerToLifeUniverseAndEverything_ShouldBe42()
        {
            var theAnswer = CalculateAnswer();
            Assert.Equal(42, theAnswer);
        }

        private int CalculateAnswer()
        {
            return 42;
        }
    }
}