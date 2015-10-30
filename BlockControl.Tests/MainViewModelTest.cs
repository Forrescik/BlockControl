// <copyright file="MainViewModelTest.cs">Copyright ©  2015</copyright>
using System;
using BlockControl;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlockControl.Tests
{
    /// <summary>This class contains parameterized unit tests for MainViewModel</summary>
    [PexClass(typeof(MainViewModel))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class MainViewModelTest
    {
        [TestMethod]
        public void Switch_Change()
        {
            MainViewModel mv = new MainViewModel();
            mv.CanChanged = true;
            Assert.IsTrue(mv.CanChanged);
        }
    }
}
