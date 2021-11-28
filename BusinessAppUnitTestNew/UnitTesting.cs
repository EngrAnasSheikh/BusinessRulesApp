using BusinessRulesApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;


/*
 * Developer Anas Mudassar
 * Unit Test Version 1.0
 * Business Rules Engine Unit Testing
 */

namespace BusinessAppUnitTestNew
{
    [TestClass]
    public class BusinessRulesAppUnitTesting
    {
        //Unit Testing for Book Class
        [TestMethod]
        public void BookTest()
        {
            var check = new Book("Programming"); //Enter name of the Book
            Assert.AreEqual("Programming", check.PhyProductName); //Test the Name of the Book
            Assert.AreEqual("Packing Slip for Shipping Generated.", check.PhyInstructions[0]); //Test Shipping Slip
            Assert.AreEqual("Duplicate Packing Slip for Royalty Department Generated.", check.PhyInstructions[1]); //Test Slip for Royalty Department
            Assert.AreEqual("Commission Payment to the agent Generated.", check.PhyInstructions[2]); //Test Slip for Agent
        }

        //Unit Testing for OtherPhysicalProducts Class
        [TestMethod]
        public void OtherPhysicalProductsTest()
        {
            var check = new OtherPhysicalProduct("Bat"); //Enter name of the Other Physical Product
            Assert.AreEqual("Bat", check.PhyProductName); //Test the Name of the Other Item
            Assert.AreEqual("Packing Slip for Shipping Generated.", check.PhyInstructions[0]); //Test the Shipping Slip
            Assert.AreEqual("Commission Payment to the agent Generated.", check.PhyInstructions[2]); //Test Slip for Royalty Department
        }

        //Unit Testing for Membership Class
        [TestMethod]
        public void MembershipTest()
        {
            var check = new Membership();
            Assert.AreEqual("Membership Activated.", check.NonPhyInstructions[0]); //Test Membership Message
            Assert.AreEqual("Email Sent to Owner.", check.NonPhyInstructions[2]); //Test email Sent
        }

        //Unit Testing for Upgrade Membership Class
        [TestMethod]
        public void UpgradeMembershipTest()
        {
            var check = new UpgradeMembership();
            Assert.AreEqual("Membership Upgraded.", check.NonPhyInstructions[1]); //Test Membership Upgrade
            Assert.AreEqual("Email Sent to Owner.", check.NonPhyInstructions[2]); //Test Email Sent
        }

        //Unit Testing for Video Class Condition else
        [TestMethod]
        public void VideoTest1()
        {
            var check = new Video("SuperMan"); //Enter name of the Video
            Assert.AreEqual("SuperMan", check.NonPhyProductName); //Test the name of the Video
            Assert.AreEqual("You have added a Video", check.NonPhyInstructions[4]); //Test the message for Other Video
        }

        //Unit Testing for Video Class Condition 'learning to ski"
        [TestMethod]
        public void VideoTest2()
        {
            var check = new Video("learning to ski"); //Enter name of the Video
            Assert.AreEqual("learning to ski", check.NonPhyProductName); //Test the name of the Video
            Assert.AreEqual("'First Aid' Video has been added.", check.NonPhyInstructions[3]); //Test the 'First Aid' Video Add
        }
    }
}
