using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPFChocolate.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFChocolate.Windows.Tests
{
    [TestClass()]
    public class AuthTests
    {
        [TestMethod()]
        public void AllCorrectTest()
        {
            Assert.AreEqual(true, Auth.enterAuth("1", "1"));
        }

        [TestMethod()]
        public void OnlyLoginTest()
        {
            Assert.AreEqual(false, Auth.enterAuth("1", ""));
        }

        [TestMethod()]
        public void OnlyPasswordTest()
        {
            Assert.AreEqual(false, Auth.enterAuth("", "1"));
        }

        [TestMethod()]
        public void DoesnExistsUserTest()
        {
            Assert.AreEqual(false, Auth.enterAuth("asd", "asd"));
        }

        [TestMethod()]
        public void AllEmptyTest()
        {
            Assert.AreEqual(false, Auth.enterAuth("", ""));
        }
    }
}