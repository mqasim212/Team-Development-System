using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FlightClasses;

namespace FlightTesting
{
    [TestClass]
    public class tstTicketCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class
            clsTicketCollection AllTicket = new clsTicketCollection();
            //test to see that it exists
            Assert.IsNotNull(AllTicket);
        }

        [TestMethod]
        public void TicketList()
        {
            //create an instance of a class
            clsTicketCollection AllTicket = new clsTicketCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsTicket> TestList = new List<clsTicket>();
            //add an item to the list
            //create the item of test data
            clsTicket TestItem = new clsTicket();
            //set its properties
            TestItem.TicketID = 1;
            TestItem.FlightID = 2;
            TestItem.TicketPurchaseDate = DateTime.Now.Date;
            TestItem.TicketNo = "ASD456GH";
            TestItem.FlightNo = 535;
            TestItem.SeatNo = "53B";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllTicket.TicketList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllTicket.TicketList, TestList);
        }

        //[TestMethod]
        //public void CountProperty()
        //{
        //    //create an instance of a class
        //    clsTicketCollection AllTicket = new clsTicketCollection();
        //    //create some test data to assign to the property
        //    Int32 SomeCount = 2;
        //    //assign the data to the property
        //    AllTicket.Count = SomeCount;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllTicket.Count, SomeCount);
        //}

        [TestMethod]
        public void ThisTicketProperty()
        {
            //create an instance of a class
            clsTicketCollection AllTicket = new clsTicketCollection();
            //create some test data to assign to the property
            clsTicket TestTicket = new clsTicket();
            //set the properties of the test object
            TestTicket.TicketID = 1;
            TestTicket.FlightID = 2;
            TestTicket.TicketPurchaseDate = DateTime.Now.Date;
            TestTicket.TicketNo = "ASD456GH";
            TestTicket.FlightNo = 535;
            TestTicket.SeatNo = "53B";
            //assign the data to the property
            AllTicket.ThisTicket = TestTicket;
            //test to see that the two values are the same
            Assert.AreEqual(AllTicket.ThisTicket, TestTicket);
        }

        [TestMethod]
        public void ListAndCount()
        {
            //create an instance of a class
            clsTicketCollection AllTicket = new clsTicketCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsTicket> TestList = new List<clsTicket>();
            //add an item to the list
            //create the item of test data
            clsTicket TestItem = new clsTicket();
            //set its properties
            TestItem.TicketID = 1;
            TestItem.FlightID = 2;
            TestItem.TicketPurchaseDate = DateTime.Now.Date;
            TestItem.TicketNo = "ASD456GH";
            TestItem.FlightNo = 535;
            TestItem.SeatNo = "53B";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllTicket.TicketList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllTicket.Count, TestList.Count);
        }

        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    //create an instance of a class
        //    clsTicketCollection AllTicket = new clsTicketCollection();
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllTicket.Count, 2);
        //}
    }
}
