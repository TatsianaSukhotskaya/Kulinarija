using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kylinariia.Domain.Service;
using Kylinariia.Domain.Model;

namespace Cookery.Domain.Services.Static.Tests
{
    [TestClass]
    public class CommonUserServiceTests 
    {
        private readonly ICommonUserService service;

        public CommonUserServiceTests()
        {
            service.Add(new CommonUserDao()
            {
                Id = 0,
                Name = "John"
            });
            service.Add(new CommonUserDao()
            {
                Id = 1,
                Name = "Max"
            });
            service.Add(new Kylinariia.Domain.Model.CommonUserDao()
            {
                Id = 2,
                Name = "Tor"
            });
        }

        [TestMethod]
        public void AddTest()
        {
            string name = Guid.NewGuid().ToString();
        }
    }
}
