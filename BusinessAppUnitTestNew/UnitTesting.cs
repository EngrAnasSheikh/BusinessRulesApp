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

        //Unit Testing for OtherPhysicalProducts Class
        [TestMethod]
        public void OtherPhysicalProductsTest()
        {
            var check = new OtherPhysicalProduct("Bat");
            Assert.AreEqual("Bat", check.PhyProductName);
            Assert.AreEqual("Packing Slip for Shipping Generated.", check.PhyInstructions[0]);
            Assert.AreEqual("Commission Payment to the agent Generated.", check.PhyInstructions[2]);
        }

        //Unit Testing for Membership Class
        [TestMethod]
        public void MembershipTest()
        {
            var check = new Membership();
            Assert.AreEqual("Membership Activated.", check.NonPhyInstructions[0]);
            Assert.AreEqual("Email Sent to Owner.", check.NonPhyInstructions[2]);
        }
    }
}
