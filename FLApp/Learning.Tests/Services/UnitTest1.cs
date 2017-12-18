using FriendlyLearning.Models.cs.Domain;
using FriendlyLearning.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Learning.Tests.Services
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UsersService_SelectAll_Test()
        {
            UsersService svc = new UsersService();
            List<Users> model = svc.SelectAll();
            Assert.IsNotNull(model);
        }
    }
}
