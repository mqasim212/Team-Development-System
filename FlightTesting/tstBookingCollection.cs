using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FlightClasses;

namespace FlightTesting
{
    [TestClass]
    public class tstBookingCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class
            clsBookingCollection AllBooking = new clsBookingCollection();
            //test to see that it exists
            Assert.IsNotNull(AllBooking);
        }

        [TestMethod]
        public void BookingList()
        {
            //create an instance of a class
            clsBookingCollection AllBooking = new clsBookingCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsBooking> TestList = new List<clsBooking>();
            //add an item to the list
            //create the item of test data
            clsBooking TestItem = new clsBooking();
            //set its properties
            TestItem.BookingID = 1;
            TestItem.CustomerID = 2;
            TestItem.StaffID = 2;
            TestItem.FlightID = 2;
            TestItem.BookingName = "Tom";
            TestItem.BookingDate = DateTime.Now.Date;
            TestItem.BookingValidity = 30;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllBooking.BookingList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllBooking.BookingList, TestList);
        }

        //[TestMethod]
        //public void CountProperty()
        //{
        //    //create an instance of a class
        //    clsBookingCollection AllBooking = new clsBookingCollection();
        //    //create some test data to assign to the property
        //    Int32 SomeCount = 2;
        //    //assign the data to the property
        //    AllBooking.Count = SomeCount;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllBooking.Count, SomeCount);
        //}

        [TestMethod]
        public void ThisBookingProperty()
        {
            //create an instance of a class
            clsBookingCollection AllBooking = new clsBookingCollection();
            //create some test data to assign to the property
            clsBooking TestBooking = new clsBooking();
            //set the properties of the test object
            TestBooking.BookingID = 1;
            TestBooking.CustomerID = 2;
            TestBooking.StaffID = 2;
            TestBooking.FlightID = 2;
            TestBooking.BookingName = "Tom";
            TestBooking.BookingDate = DateTime.Now.Date;
            TestBooking.BookingValidity = 30;
            //assign the data to the property
            AllBooking.ThisBooking = TestBooking;
            //test to see that the two values are the same
            Assert.AreEqual(AllBooking.ThisBooking, TestBooking);
        }

        [TestMethod]
        public void ListAndCount()
        {
            //create an instance of a class
            clsBookingCollection AllBooking = new clsBookingCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsBooking> TestList = new List<clsBooking>();
            //add an item to the list
            //create the item of test data
            clsBooking TestItem = new clsBooking();
            //set its properties
            TestItem.BookingID = 1;
            TestItem.CustomerID = 2;
            TestItem.StaffID = 2;
            TestItem.FlightID = 2;
            TestItem.BookingName = "Tom";
            TestItem.BookingDate = DateTime.Now.Date;
            TestItem.BookingValidity = 30;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllBooking.BookingList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllBooking.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethod()
        {
            //create an instance of a class
            clsBookingCollection AllBooking = new clsBookingCollection();
            //create the item of test data
            clsBooking TestItem = new clsBooking();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.BookingID = 1;
            TestItem.CustomerID = 2;
            TestItem.StaffID = 2;
            TestItem.FlightID = 2;
            TestItem.BookingName = "Tom";
            TestItem.BookingDate = DateTime.Now.Date;
            TestItem.BookingValidity = 30;
            //set thisBooking to the test data
            AllBooking.ThisBooking = TestItem;
            //add the record
            PrimaryKey = AllBooking.Add();
            //set the primary key of the test data
            TestItem.BookingID = PrimaryKey;
            //find the record
            AllBooking.ThisBooking.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllBooking.ThisBooking, TestItem);
        }

        [TestMethod]
        public void DeleteMethod()
        {
            //create an instance of a class
            clsBookingCollection AllBooking = new clsBookingCollection();
            //create the item of test data
            clsBooking TestItem = new clsBooking();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.BookingID = 1;
            TestItem.CustomerID = 2;
            TestItem.StaffID = 2;
            TestItem.FlightID = 2;
            TestItem.BookingName = "Tom";
            TestItem.BookingDate = DateTime.Now.Date;
            TestItem.BookingValidity = 30;
            //set thisBooking to the test data
            AllBooking.ThisBooking = TestItem;
            //add the record
            PrimaryKey = AllBooking.Add();
            //set the primary key of the test data
            TestItem.BookingID = PrimaryKey;
            //find the record
            AllBooking.ThisBooking.Find(PrimaryKey);
            //delete this record
            AllBooking.Delete();
            //now find the record
            Boolean Found = AllBooking.ThisBooking.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethod()
        {
            //create an instance of a class
            clsBookingCollection AllBooking = new clsBookingCollection();
            //create the item of test data
            clsBooking TestItem = new clsBooking();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 2;
            TestItem.StaffID = 2;
            TestItem.FlightID = 2;
            TestItem.BookingName = "Tom";
            TestItem.BookingDate = DateTime.Now.Date;
            TestItem.BookingValidity = 30;
            //set thisBooking to the test data
            AllBooking.ThisBooking = TestItem;
            //add the record
            PrimaryKey = AllBooking.Add();
            //set the primary key of the test data
            TestItem.BookingID = PrimaryKey;
            //modify the test data
            TestItem.CustomerID = 3;
            TestItem.StaffID = 3;
            TestItem.FlightID = 3;
            TestItem.BookingName = "John";
            TestItem.BookingDate = DateTime.Now.Date;
            TestItem.BookingValidity = 40;
            //set the record based on the new test data
            AllBooking.ThisBooking = TestItem;
            //update the record
            AllBooking.Update();
            //find the record
            AllBooking.ThisBooking.Find(PrimaryKey);
            //test to see thisbooking matches the test data
            Assert.AreEqual(AllBooking.ThisBooking, TestItem);
        }

        [TestMethod]
        public void ReportByBookingName()
        {
            //create an instance of the class containing unfiltered results
            clsBookingCollection AllBooking = new clsBookingCollection();
            //create an instance of the filtered data
            clsBookingCollection FilteredBooking = new clsBookingCollection();
            //apply a blank string (should return all records)
            FilteredBooking.ReportByBookingName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllBooking.Count, FilteredBooking.Count);
        }

        [TestMethod]
        public void ReportByBookingNameNoneFound()
        {
            //create an instance of the class containing unfiltered results
            clsBookingCollection FilteredBooking = new clsBookingCollection();
            //apply a booking that does not exist
            FilteredBooking.ReportByBookingName("XXXXX");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredBooking.Count);
        }

        [TestMethod]
        public void ReportByBookingNameTestDataFound()
        {
            //create an instance of the filtered data
            clsBookingCollection FilteredBooking = new clsBookingCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a name that does not exist
            FilteredBooking.ReportByBookingName("Gabriela");
            //check that the correct number of records are found
            if (FilteredBooking.Count == 2)
            {
                //Check that the first record is ID 23
                if (FilteredBooking.BookingList[0].BookingID != 23)
                {
                    OK = false;
                }
                //Check that the first record is ID 24
                if (FilteredBooking.BookingList[1].BookingID != 24)
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
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 BookingID = 31;
            //invoke the method
            Found = ABooking.Find(BookingID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestBookingIDFound()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //boolean variable to store the result of the search
            Boolean Found = false;
            ////boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 BookingID = 31;
            //imvoke the method
            Found = ABooking.Find(BookingID);
            //check the booking id
            if (ABooking.BookingID != 31)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBookingNameFound()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //boolean variable to store the result of the search
            Boolean Found = false;
            ////boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 BookingID = 31;
            //imvoke the method
            Found = ABooking.Find(BookingID);
            //check the booking id
            if (ABooking.BookingName != "testname")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBookingDateFound()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //boolean variable to store the result of the search
            Boolean Found = false;
            ////boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 BookingID = 31;
            //imvoke the method
            Found = ABooking.Find(BookingID);
            //check the booking id
            if (ABooking.BookingDate != Convert.ToDateTime("2000/01/01"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBookingValidityFound()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //boolean variable to store the result of the search
            Boolean Found = false;
            ////boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 BookingID = 31;
            //imvoke the method
            Found = ABooking.Find(BookingID);
            //check the booking id
            if (ABooking.BookingValidity != 123)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //boolean variable to store the result of the search
            Boolean Found = false;
            ////boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 BookingID = 31;
            //imvoke the method
            Found = ABooking.Find(BookingID);
            //check the booking id
            if (ABooking.CustomerID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //boolean variable to store the result of the search
            Boolean Found = false;
            ////boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 BookingID = 31;
            //imvoke the method
            Found = ABooking.Find(BookingID);
            //check the booking id
            if (ABooking.StaffID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFlightIDFound()
        {
            //create an instance of the class
            clsBooking ABooking = new clsBooking();
            //boolean variable to store the result of the search
            Boolean Found = false;
            ////boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 BookingID = 31;
            //imvoke the method
            Found = ABooking.Find(BookingID);
            //check the booking id
            if (ABooking.FlightID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
