using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFDao.Implementation;
using NFDao.Model;
using System;
using System.Collections.Generic;

namespace NFTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SystemUserImpl impl = new SystemUserImpl();

            List<SystemUser> systemUsers = impl.Select();
        }
    }
}
