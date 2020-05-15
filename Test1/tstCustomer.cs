using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEHOWBSystem
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //test to see if it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerFirstNameOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign
            string CustomerFirstName = "Courtney";
            //assign the data to the property
            ACustomer.CustomerFirstName = CustomerFirstName;
            //test to see if the values are the same
            Assert.AreEqual(ACustomer.CustomerFirstName, CustomerFirstName);
        }

        [TestMethod]
        public void CustomerNoOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign
            Int32 CustomerNo = 1;
            //assign the data to the property
            ACustomer.CustomerNo = CustomerNo;
            //test to see if the values are the same
            Assert.AreEqual(ACustomer.CustomerNo, CustomerNo);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store validation result
            String Error = "";
            //create some test data to assign
            string CustomerFirstName = "Courtney";
            string CustomerLastName = "Marsden";
            string CustomerEmail = "p2430551@my365.dmu.ac.uk";
            string CustomerPostcode = "LE2 7EQ";
            string CustomerTelNo = "00000000000";
            //invoke the method
            Error = ACustomer.CustomerValidated(CustomerFirstName, CustomerLastName, CustomerEmail, CustomerPostcode, CustomerTelNo);
            //test to see if the values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ValidationsMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create error string
            String Error = "";
            //set test data
            string CustomerFirstName = "a";
            string CustomerLastName = "a";
            string CustomerEmail = "aaaaaaaaaa";
            string CustomerPostcode = "aaaaa";
            string CustomerTelNo = "0000000000";            
            //invoke test
            Error = ACustomer.CustomerValidated(CustomerFirstName, CustomerLastName, CustomerEmail, CustomerPostcode, CustomerTelNo);
            //test to see if equal
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ValidationsMinBoundary()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create error string
            String Error = "";
            //set test data
            string CustomerFirstName = "aa";
            string CustomerLastName = "aa";
            string CustomerEmail = "aaaaaaaaaaa";
            string CustomerPostcode = "aaaaaa";
            string CustomerTelNo = "00000000000";
            //invoke test
            Error = ACustomer.CustomerValidated(CustomerFirstName, CustomerLastName, CustomerEmail, CustomerPostcode, CustomerTelNo);
            //test to see if equal
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ValidationsMinPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create error string
            String Error = "";
            //set test data
            string CustomerFirstName = "aaa";
            string CustomerLastName = "aaa";
            string CustomerEmail = "aaaaaaaaaaaa";
            string CustomerPostcode = "aaaaaaa";
            string CustomerTelNo = "000000000000";
            //invoke test
            Error = ACustomer.CustomerValidated(CustomerFirstName, CustomerLastName, CustomerEmail, CustomerPostcode, CustomerTelNo);
            //test to see if equal
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ValidationsMaxLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create error string
            String Error = "";
            //set test data
            string CustomerFirstName = "aaaaaaaaaa";
            string CustomerLastName = "aaaaaaaaaa";
            string CustomerEmail = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string CustomerPostcode = "aaaaaaa";
            string CustomerTelNo = "0000000000";
            //invoke test
            Error = ACustomer.CustomerValidated(CustomerFirstName, CustomerLastName, CustomerEmail, CustomerPostcode, CustomerTelNo);
            //test to see if equal
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ValidationsMaxBoundary()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create error string
            String Error = "";
            //set test data
            string CustomerFirstName = "aaaaaaaaaaa";
            string CustomerLastName = "aaaaaaaaaaa";
            string CustomerEmail = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string CustomerPostcode = "aaaaaaaa";
            string CustomerTelNo = "00000000000";
            //invoke test
            Error = ACustomer.CustomerValidated(CustomerFirstName, CustomerLastName, CustomerEmail, CustomerPostcode, CustomerTelNo);
            //test to see if equal
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ValidationsMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create error string
            String Error = "";
            //set test data
            string CustomerFirstName = "aaaaaaaaaaaa";
            string CustomerLastName = "aaaaaaaaaaaa";
            string CustomerEmail = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string CustomerPostcode = "aaaaaaaaa";
            string CustomerTelNo = "000000000000";
            //invoke test
            Error = ACustomer.CustomerValidated(CustomerFirstName, CustomerLastName, CustomerEmail, CustomerPostcode, CustomerTelNo);
            //test to see if equal
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ValidationsMid()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create error string
            String Error = "";
            //set test data
            string CustomerFirstName = "aaaaaa";
            string CustomerLastName = "aaaaaa";
            string CustomerEmail = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            string CustomerPostcode = "aaaaaaa";
            string CustomerTelNo = "00000000000";
            //invoke test
            Error = ACustomer.CustomerValidated(CustomerFirstName, CustomerLastName, CustomerEmail, CustomerPostcode, CustomerTelNo);
            //test to see if equal
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ValidationsExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create error string
            String Error = "";
            //set test data
            string CustomerFirstName = "";
            string CustomerLastName = "";
            string CustomerEmail = "";
            string CustomerPostcode = "";
            string CustomerTelNo = "";
            //pad the string with characters
            CustomerFirstName = CustomerFirstName.PadRight(500, 'a');
            CustomerLastName = CustomerLastName.PadRight(500, 'a');
            CustomerEmail = CustomerEmail.PadRight(500, 'a');
            CustomerPostcode = CustomerPostcode.PadRight(500, 'a');
            CustomerTelNo = CustomerTelNo.PadRight(500, '0');
            //invoke test
            Error = ACustomer.CustomerValidated(CustomerFirstName, CustomerLastName, CustomerEmail, CustomerPostcode, CustomerTelNo);
            //test to see if equal
            Assert.AreNotEqual(Error, "");
        }
    }
}
