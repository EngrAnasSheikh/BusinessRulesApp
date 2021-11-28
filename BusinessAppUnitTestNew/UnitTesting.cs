using BusinessRulesApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessAppUnitTestNew
{
    [TestClass]
    public class BusinessRulesAppUnitTesting
    {
        //Unit Testing for Book Class
        [TestMethod]
        public void BookTest()
        {
            var check = new Book("Programming");
            Assert.AreEqual("Programming", check.PhyProductName);
            Assert.AreEqual("Packing Slip for Shipping Generated.", check.PhyInstructions[0]);
            Assert.AreEqual("Duplicate Packing Slip for Royalty Department Generated.", check.PhyInstructions[1]);
            Assert.AreEqual("Commission Payment to the agent Generated.", check.PhyInstructions[2]);
        }
    }
}
