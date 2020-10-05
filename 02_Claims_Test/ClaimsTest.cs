using System;
using System.Security.Claims;
using _02_Claims;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Claims_Test
{
    [TestClass]
    public class ClaimsTest
    {
        [TestMethod]
        public void ClaimsTestIsValid(bool isValid)
        {
            ClaimContent claimContent = new ClaimContent(1234, ClaimType.Car, "Description", 1000, "01/01/2001", "01/02/2001", true);
            bool actual = claimContent.IsValid;
            bool expected = isValid;
            Assert.AreEqual(expected, actual);
        }
    }
}
