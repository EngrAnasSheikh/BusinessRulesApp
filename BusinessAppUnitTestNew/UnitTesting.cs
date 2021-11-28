using BusinessRulesApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessAppUnitTestNew
{
    [TestClass]
    public class BusinessRulesAppUnitTesting
    {
        [TestMethod]
        public void BookTest()
        {
            var check = new Book("Programming");
            Assert.AreEqual("Programming", check.ProductName);
            Assert.AreEqual("Packing Slip for Shipping Generated.", check.Instructions[0]);
        }
    }
}
