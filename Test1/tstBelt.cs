using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tstBelt
{
    [TestClass]
    public class tstBelt
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsBelt ABelt = new clsBelt();
            //test to see if it exists
            Assert.IsNotNull(ABelt);
        }

        [TestMethod]
        public void BeltNo()
        {
            //create an instance of the class
            clsBelt ABelt = new clsBelt();
            //create some test data to assign
            Int32 BeltNo = 1;
            //assign the data to the property
            ABelt.BeltNo = BeltNo;
            //test to see if the values are the same
            Assert.AreEqual(ABelt.BeltNo, BeltNo);
        }

        [TestMethod]
        public void BeltNameOK()
        {
            //create an instance of the class
            clsBelt ABelt = new clsBelt();
            //create some test data to assign
            string BeltName = "RAW Womens";
            //assign the data to the property
            ABelt.BeltName = BeltName;
            //test to see if the values are the same
            Assert.AreEqual(ABelt.BeltName, BeltName);
        }

        [TestMethod]
        public void BrandNo()
        {
            //create an instance of the class
            clsBelt ABelt = new clsBelt();
            //create some test data to assign
            Int32 BrandNo = 1;
            //assign the data to the property
            ABelt.BrandNo = BrandNo;
            //test to see if the values are the same
            Assert.AreEqual(ABelt.BrandNo, BrandNo);
        }

        [TestMethod]
        public void ManufacturerNo()
        {
            //create an instance of the class
            clsBelt ABelt = new clsBelt();
            //create some test data to assign
            Int32 ManufacturerNo = 1;
            //assign the data to the property
            ABelt.ManufacturerNo = ManufacturerNo;
            //test to see if the values are the same
            Assert.AreEqual(ABelt.ManufacturerNo, ManufacturerNo);
        }

        [TestMethod]
        public void BeltDescription()
        {
            //create an instance of the class
            clsBelt ABelt = new clsBelt();
            //create some test data to assign
            string BeltDescription = "Womens Tag";
            //assign the data to the property
            ABelt.BeltDescription = BeltDescription;
            //test to see if the values are the same
            Assert.AreEqual(ABelt.BeltDescription, BeltDescription);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsBelt ABelt = new clsBelt();
            //create a string variable to store validation result
            String Error = "";
            //create some test data to assign
            string BeltName = "Womens Tag";
            string BrandNo = "1";
            string ManufacturerNo = "1";
            string BeltDescription = "Womens Tag Team Belts - Replica, currently held by Alexa Bliss and Nikki Cross";
            //invoke the method
            Error = ABelt.BeltValidated(BeltName, BrandNo, ManufacturerNo, BeltDescription);
            //test to see if the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ValidationsMinLessOne()
        {
            //create an instance of the class
            clsBelt ABelt = new clsBelt();
            //create a string variable to store validation result
            String Error = "";
            //create some test data to assign
            string BeltName = "aa";
            string BrandNo = "";
            string ManufacturerNo = "";
            string BeltDescription = "aaaaaa";
            //invoke the method
            Error = ABelt.BeltValidated(BeltName, BrandNo, ManufacturerNo, BeltDescription);
            //test to see if the values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ValidationsMinBoundary()
        {
            //create an instance of the class
            clsBelt ABelt = new clsBelt();
            //create a string variable to store validation result
            String Error = "";
            //create some test data to assign
            string BeltName = "aaa";
            string BrandNo = "1";
            string ManufacturerNo = "1";
            string BeltDescription = "aaaaaaa";
            //invoke the method
            Error = ABelt.BeltValidated(BeltName, BrandNo, ManufacturerNo, BeltDescription);
            //test to see if the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ValidationsMinPlusOne()
        {
            //create an instance of the class
            clsBelt ABelt = new clsBelt();
            //create a string variable to store validation result
            String Error = "";
            //create some test data to assign
            string BeltName = "aaaa";
            string BrandNo = "11";
            string ManufacturerNo = "11";
            string BeltDescription = "aaaaaaaa";
            //invoke the method
            Error = ABelt.BeltValidated(BeltName, BrandNo, ManufacturerNo, BeltDescription);
            //test to see if the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ValidationsMaxLessOne()
        {
            //create an instance of the class
            clsBelt ABelt = new clsBelt();
            //create a string variable to store validation result
            String Error = "";
            //create some test data to assign
            string BeltName = "aaaaaaaaaaaaaaa";
            string BrandNo = "11";
            string ManufacturerNo = "11";
            string BeltDescription = "";
            //pad the string with characters
            BeltDescription = BeltDescription.PadRight(199, 'a');
            //invoke the method
            Error = ABelt.BeltValidated(BeltName, BrandNo, ManufacturerNo, BeltDescription);
            //test to see if the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ValidationsMaxBoundary()
        {
            //create an instance of the class
            clsBelt ABelt = new clsBelt();
            //create a string variable to store validation result
            String Error = "";
            //create some test data to assign
            string BeltName = "aaaaaaaaaaaaaaaa";
            string BrandNo = "111";
            string ManufacturerNo = "111";
            string BeltDescription = "";
            //pad the string with characters
            BeltDescription = BeltDescription.PadRight(200, 'a');
            //invoke the method
            Error = ABelt.BeltValidated(BeltName, BrandNo, ManufacturerNo, BeltDescription);
            //test to see if the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ValidationsMaxPlusOne()
        {
            //create an instance of the class
            clsBelt ABelt = new clsBelt();
            //create a string variable to store validation result
            String Error = "";
            //create some test data to assign
            string BeltName = "aaaaaaaaaaaaaaaaa";
            string BrandNo = "1111";
            string ManufacturerNo = "1111";
            string BeltDescription = "";
            //pad the string with characters
            BeltDescription = BeltDescription.PadRight(201, 'a');
            //invoke the method
            Error = ABelt.BeltValidated(BeltName, BrandNo, ManufacturerNo, BeltDescription);
            //test to see if the values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ValidationsMid()
        {
            //create an instance of the class
            clsBelt ABelt = new clsBelt();
            //create a string variable to store validation result
            String Error = "";
            //create some test data to assign
            string BeltName = "aaaaaaaa";
            string BrandNo = "11";
            string ManufacturerNo = "11";
            string BeltDescription = "";
            //pad the string with characters
            BeltDescription = BeltDescription.PadRight(100, 'a');
            //invoke the method
            Error = ABelt.BeltValidated(BeltName, BrandNo, ManufacturerNo, BeltDescription);
            //test to see if the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ValidationsExtremeMax()
        {
            //create an instance of the class
            clsBelt ABelt = new clsBelt();
            //create a string variable to store validation result
            String Error = "";
            //create some test data to assign
            string BeltName = "";
            string BrandNo = "";
            string ManufacturerNo = "";
            string BeltDescription = "";
            //pad the string with characters
            BeltName = BeltName.PadRight(500, 'a');
            BrandNo = BrandNo.PadRight(500, '1');
            ManufacturerNo = ManufacturerNo.PadRight(500, '1');
            BeltDescription = BeltDescription.PadRight(500, 'a');
            //invoke the method
            Error = ABelt.BeltValidated(BeltName, BrandNo, ManufacturerNo, BeltDescription);
            //test to see if the values are the same
            Assert.AreNotEqual(Error, "");
        }
    }
}
