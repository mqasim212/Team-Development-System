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

        [TestMethod]
        public void ThisTicketProperty()
        {
            //create an instance of a class
            clsTicketCollection AllTicket = new clsTicketCollection();
            //create some test data to assign to the property
            clsTicket TestTicket = new clsTicket();
            //set the properties of the test object
            TestTicket.TicketID = 1;
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

        [TestMethod]
        public void AddMethod()
        {
            //create an instance of a class
            clsTicketCollection AllTicket = new clsTicketCollection();
            //create the item of test data
            clsTicket TestItem = new clsTicket();
            //var to store the primarykey
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.TicketID = 1;
            TestItem.TicketPurchaseDate = DateTime.Now.Date;
            TestItem.TicketNo = "ASD456GH";
            TestItem.FlightNo = 535;
            TestItem.SeatNo = "53B";
            //set thisticket to the test data
            AllTicket.ThisTicket = TestItem;
            //add the record
            PrimaryKey = AllTicket.Add();
            //set the primary key of the test data
            TestItem.TicketID = PrimaryKey;
            //find the record
            AllTicket.ThisTicket.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllTicket.ThisTicket, TestItem);
        }

        [TestMethod]
        public void DeleteMethod()
        {
            //create an instance of a class
            clsTicketCollection AllTicket = new clsTicketCollection();
            //create the item of test data
            clsTicket TestItem = new clsTicket();
            //var to store the primarykey
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.TicketID = 1;
            TestItem.TicketPurchaseDate = DateTime.Now.Date;
            TestItem.TicketNo = "ASD456GH";
            TestItem.FlightNo = 535;
            TestItem.SeatNo = "53B";
            //set thisticket to the test data
            AllTicket.ThisTicket = TestItem;
            //add the record
            PrimaryKey = AllTicket.Add();
            //set the primary key of the test data
            TestItem.TicketID = PrimaryKey;
            //find the record
            AllTicket.ThisTicket.Find(PrimaryKey);
            //delete the record
            AllTicket.Delete();
            //now find the record
            Boolean Found = AllTicket.ThisTicket.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethod()
        {
            //create an instance of a class
            clsTicketCollection AllTicket = new clsTicketCollection();
            //create the item of test data
            clsTicket TestItem = new clsTicket();
            //var to store the primarykey
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.TicketPurchaseDate = DateTime.Now.Date;
            TestItem.TicketNo = "ASD456GH";
            TestItem.FlightNo = 535;
            TestItem.SeatNo = "53B";
            //set thisticket to the test data
            AllTicket.ThisTicket = TestItem;
            //add the record
            PrimaryKey = AllTicket.Add();
            //set the primary key of the test data
            TestItem.TicketID = PrimaryKey;
            //modify the test data
            TestItem.TicketPurchaseDate = DateTime.Now.Date;
            TestItem.TicketNo = "HGF3F72";
            TestItem.FlightNo = 767;
            TestItem.SeatNo = "5B";
            //Set the record based on the new test data
            AllTicket.ThisTicket = TestItem;
            //update the record
            AllTicket.Update();
            //find the record
            AllTicket.ThisTicket.Find(PrimaryKey);
            //test to see this ticket matches the test data
            Assert.AreEqual(AllTicket.ThisTicket, TestItem);
        }

        [TestMethod]
        public void ReportByTicketNo()
        {
            //create an instance of the class containing unfiltered results
            clsTicketCollection AllTicket = new clsTicketCollection();
            //create an instance of the filtered data
            clsTicketCollection FilteredTicket = new clsTicketCollection();
            //apply a blank string (should return all records)
            FilteredTicket.ReportByTicketNo("");
            //test to see that the two values are the same
            Assert.AreEqual(AllTicket.Count, FilteredTicket.Count);
        }

        [TestMethod]
        public void ReportByTicketNoNoneFound()
        {
            //create an instance of the class containing unfiltered results
            clsTicketCollection FilteredTicket = new clsTicketCollection();
            //apply a ticket no that doesnt exist
            FilteredTicket.ReportByTicketNo("XXXXXX");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredTicket.Count);
        }

        [TestMethod]
        public void ReportByTicketNoTestDataFound()
        {
            //create an instance of the filtered data
            clsTicketCollection FilteredTicket = new clsTicketCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a name that does not exist
            FilteredTicket.ReportByTicketNo("test1");
            //check that the correct number of records are found
            if (FilteredTicket.Count == 2)
            {
                //Check that the first record is ID 7
                if (FilteredTicket.TicketList[0].TicketID != 7)
                {
                    OK = false;
                }
                //Check that the first record is ID 9
                if (FilteredTicket.TicketList[1].TicketID != 9)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no record
            Assert.IsTrue(OK);
        }

        [TestMethod]
        //used to test the find method of the class
        public void FindMethod()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //boolean vsrisble to store the the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 TicketID = 15;
            //invoke the method
            Found = ATicket.Find(TicketID);
            //test to see that the result is ok
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestTicketIDFound()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //boolean variable to store the result of the search
            Boolean Found = false;
            ////boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 TicketID = 15;
            //imvoke the method
            Found = ATicket.Find(TicketID);
            //check the booking id
            if (ATicket.TicketID != 15)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTicketPurchaseDateFound()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //boolean variable to store the result of the search
            Boolean Found = false;
            ////boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 TicketID = 15;
            //imvoke the method
            Found = ATicket.Find(TicketID);
            //check the booking id
            if (ATicket.TicketPurchaseDate != Convert.ToDateTime("2000/01/01"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTicketNoFound()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //boolean variable to store the result of the search
            Boolean Found = false;
            ////boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 TicketID = 15;
            //imvoke the method
            Found = ATicket.Find(TicketID);
            //check the booking id
            if (ATicket.TicketNo != "test")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFlightNoFound()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //boolean variable to store the result of the search
            Boolean Found = false;
            ////boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 TicketID = 15;
            //imvoke the method
            Found = ATicket.Find(TicketID);
            //check the booking id
            if (ATicket.FlightNo != 111)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSeatNoFound()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //boolean variable to store the result of the search
            Boolean Found = false;
            ////boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 TicketID = 15;
            //imvoke the method
            Found = ATicket.Find(TicketID);
            //check the booking id
            if (ATicket.SeatNo != "test")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
