using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace tstBeltCollection
{
    [TestClass]
    public class tstBeltCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsBeltCollection AllBelts = new clsBeltCollection();
            //test
            Assert.IsNotNull(AllBelts);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class
            clsBeltCollection AllBelts = new clsBeltCollection();
            //test data
            Int32 BeltCount = 18;
            //assign data
            AllBelts.Count = BeltCount;
            //test
            Assert.AreEqual(AllBelts.Count, BeltCount);
        }

        [TestMethod]
        public void AllBeltsOK()
        {
            //create an instance of the class
            clsBeltCollection Belts = new clsBeltCollection();
            //test data - list
            List<clsBelt> BeltList = new List<clsBelt>();
            //add item, create test data
            clsBelt BeltTest = new clsBelt();
            //set properties
            BeltTest.BeltNo = 1;
            BeltTest.BeltName = "Undisputed";
            //add items to list
            BeltList.Add(BeltTest);
            //assign data
            Belts.AllBelts = BeltList;
            //test
            Assert.AreEqual(Belts.AllBelts, BeltList);
        }

        [TestMethod]
        public void CountMatchesList()
        {
            //instance of class
            clsBeltCollection Belts = new clsBeltCollection();
            //test data, list
            List<clsBelt> BeltList = new List<clsBelt>();
            //test data
            clsBelt BeltTest = new clsBelt();
            //set properties
            BeltTest.BeltNo = 1;
            BeltTest.BeltName = "Undisputed";
            //add items to list
            BeltList.Add(BeltTest);
            //assign data
            Belts.AllBelts = BeltList;
            //test
            Assert.AreEqual(Belts.Count, BeltList.Count);
        }

        [TestMethod]
        public void EighteenBeltsPresent()
        {
            //instance of class
            clsBeltCollection Belts = new clsBeltCollection();
            //test
            Assert.AreEqual(Belts.Count, 18);
        }
    }
    }
