using System;
using FlightClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FlightTesting
{
    [TestClass]
    public class tstOrderlineCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class
            clsOrderlineCollection AllOrderline = new clsOrderlineCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrderline);
        }

        [TestMethod]
        public void OrderlineList()
        {
            //create an instance of a class
            clsOrderlineCollection AllOrderline = new clsOrderlineCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrderline> TestList = new List<clsOrderline>();
            //add an item to the list
            //create the item of test data
            clsOrderline TestItem = new clsOrderline();
            //set its properties
            TestItem.OrderlineID = 1;
            TestItem.BookingID = 1;
            TestItem.BookingNo = "CASD4";
            TestItem.Quantity = 10;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrderline.OrderlineList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderline.OrderlineList, TestList);
        }

        [TestMethod]
        public void ThisOrderlineProperty()
        {
            //create an instance of a class
            clsOrderlineCollection AllOrderline = new clsOrderlineCollection();
            //create some test data to assign to the property
            clsOrderline TestOrderline = new clsOrderline();
            //set the properties of the test object
            TestOrderline.OrderlineID = 1;
            TestOrderline.BookingID = 1;
            TestOrderline.BookingNo = "CASD4";
            TestOrderline.Quantity = 10;
            //assign the data to the property
            AllOrderline.ThisOrderline = TestOrderline;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderline.ThisOrderline, TestOrderline);
        }

        [TestMethod]
        public void ListAndCount()
        {
            //create an instance of a class
            clsOrderlineCollection AllOrderline = new clsOrderlineCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrderline> TestList = new List<clsOrderline>();
            //add an item to the list
            //create the item of test data
            clsOrderline TestItem = new clsOrderline();
            //set its properties
            TestItem.OrderlineID = 1;
            TestItem.BookingID = 1;
            TestItem.BookingNo = "CASD4";
            TestItem.Quantity = 10;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrderline.OrderlineList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderline.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethod()
        {
            //create an instance of a class
            clsOrderlineCollection AllOrderline = new clsOrderlineCollection();
            //create the item of test data
            clsOrderline TestItem = new clsOrderline();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderlineID = 1;
            TestItem.BookingID = 1;
            TestItem.BookingNo = "CASD4";
            TestItem.Quantity = 10;
            //set ThisOrderline to the test data
            AllOrderline.ThisOrderline = TestItem;
            //add the record
            PrimaryKey = AllOrderline.Add();
            //set the primary key of the test data
            TestItem.OrderlineID = PrimaryKey;
            //find the record
            AllOrderline.ThisOrderline.Find(PrimaryKey);
        }

        [TestMethod]
        public void DeleteMethod()
        {
            //create an instance of a class
            clsOrderlineCollection AllOrderline = new clsOrderlineCollection();
            //create the item of test data
            clsOrderline TestItem = new clsOrderline();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderlineID = 1;
            TestItem.BookingID = 1;
            TestItem.BookingNo = "CASD4";
            TestItem.Quantity = 10;
            //set ThisOrderline to the test data
            AllOrderline.ThisOrderline = TestItem;
            //add the record
            PrimaryKey = AllOrderline.Add();
            //set the primary key of the test data
            TestItem.OrderlineID = PrimaryKey;
            //find the record
            AllOrderline.ThisOrderline.Find(PrimaryKey);
            //delete the record
            AllOrderline.Delete();
            //now find the record
            Boolean Found = AllOrderline.ThisOrderline.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethod()
        {
            //create an instance of a class
            clsOrderlineCollection AllOrderline = new clsOrderlineCollection();
            //create the item of test data
            clsOrderline TestItem = new clsOrderline();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.BookingID = 1;
            TestItem.BookingNo = "CASD4";
            TestItem.Quantity = 10;
            //set ThisOrderline to the test data
            AllOrderline.ThisOrderline = TestItem;
            //add the record
            PrimaryKey = AllOrderline.Add();
            //set the primary key of the test data
            TestItem.OrderlineID = PrimaryKey;
            //modify the test data
            TestItem.BookingID = 3;
            TestItem.BookingNo = "FGSD7";
            TestItem.Quantity = 5;
            //set the record based on the new test data
            AllOrderline.ThisOrderline = TestItem;
            //update the record
            AllOrderline.Update();
            //find the record
            AllOrderline.ThisOrderline.Find(PrimaryKey);
            //test to see thisOrderline matches the test data
            Assert.AreEqual(AllOrderline.ThisOrderline, TestItem);
        }

        [TestMethod]
        public void ReportByBookingNoMethod()
        {
            //create an instance of the class containing unfiltered results
            clsOrderlineCollection AllOrderline = new clsOrderlineCollection();
            //create an instance of the filtered data
            clsOrderlineCollection FilteredOrderline = new clsOrderlineCollection();
            //apply a blank string (should return all records)
            FilteredOrderline.ReportByBookingNo("");
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderline.Count, FilteredOrderline.Count);
        }

        [TestMethod]
        public void ReportByBookingNoNoneMethod()
        {
            //create an instance of the filtered data
            clsOrderlineCollection FilteredOrderline = new clsOrderlineCollection();
            //apply a Booking Number that does not exist
            FilteredOrderline.ReportByBookingNo("xxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrderline.Count);
        }
    }
}