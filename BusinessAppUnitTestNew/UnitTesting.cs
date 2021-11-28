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

        //Unit Testing for Upgrade Membership Class
        [TestMethod]
        public void UpgradeMembershipTest()
        {
            var check = new UpgradeMembership();
            Assert.AreEqual("Membership Upgraded.", check.NonPhyInstructions[1]);
            Assert.AreEqual("Email Sent to Owner.", check.NonPhyInstructions[2]);
        }

        //Unit Testing for Video Class Condition else
        [TestMethod]
        public void VideoTest1()
        {
            var check = new Video("SuperMan");
            Assert.AreEqual("SuperMan", check.NonPhyProductName);
            Assert.AreEqual("You have added a Video", check.NonPhyInstructions[4]);
        }

        //Unit Testing for Video Class Condition 'learning to ski"
        [TestMethod]
        public void VideoTest2()
        {
            var check = new Video("learning to ski");
            Assert.AreEqual("learning to ski", check.NonPhyProductName);
            Assert.AreEqual("'First Aid' Video has been added.", check.NonPhyInstructions[3]);
        }
    }
}
