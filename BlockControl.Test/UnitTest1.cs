using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlockControl.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MainViewModel mv = new MainViewModel();
            mv.CanChanged = true;
            Assert.IsTrue(mv.CanChanged);
        }
    }
}
