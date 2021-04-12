using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FlightClasses;

namespace FlightTesting
{
    [TestClass]
    public class tstFlightCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class
            clsFlightCollection AllFlight = new clsFlightCollection();
            //test to see that it exists
            Assert.IsNotNull(AllFlight);
        }

        [TestMethod]
        public void FlightList()
        {
            //create an instance of a class
            clsFlightCollection AllFlight = new clsFlightCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsFlight> TestList = new List<clsFlight>();
            //add an item to the list
            //create the item of test data
            clsFlight TestItem = new clsFlight();
            //set its properties
            TestItem.FlightID = 1;
            TestItem.TicketID = 2;
            TestItem.DateOfBirth = "1st May 2000";
            TestItem.Gate = "12B";
            TestItem.DepartureDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllFlight.FlightList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllFlight.FlightList, TestList);
        }

        [TestMethod]
        public void ThisFlightProperty()
        {
            //create an instance of a class
            clsFlightCollection AllFlight = new clsFlightCollection();
            //create some test data to assign to the property
            clsFlight TestFlight = new clsFlight();
            TestFlight.FlightID = 1;
            TestFlight.TicketID = 2;
            TestFlight.DateOfBirth = "1st May 2000";
            TestFlight.Gate = "12B";
            TestFlight.DepartureDate = DateTime.Now.Date;
            //assign the data to the property
            AllFlight.ThisFlight = TestFlight;
            //test to see that the two value are the same
            Assert.AreEqual(AllFlight.ThisFlight, TestFlight);
        }

        [TestMethod]
        public void ListAndCount()
        {
            //create an instance of a class
            clsFlightCollection AllFlight = new clsFlightCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsFlight> TestList = new List<clsFlight>();
            //add an item to the list
            //create the item of test data
            clsFlight TestItem = new clsFlight();
            //set its properties
            TestItem.FlightID = 1;
            TestItem.TicketID = 2;
            TestItem.DateOfBirth = "1st May 2000";
            TestItem.Gate = "12B";
            TestItem.DepartureDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllFlight.FlightList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllFlight.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethod()
        {
            //create an instance of a class
            clsFlightCollection AllFlight = new clsFlightCollection();
            //create the item of test data
            clsFlight TestItem = new clsFlight();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FlightID = 1;
            TestItem.TicketID = 2;
            TestItem.DateOfBirth = "1st May 2000";
            TestItem.Gate = "12B";
            TestItem.DepartureDate = DateTime.Now.Date;
            //set thisflight to the test data
            AllFlight.ThisFlight = TestItem;
            //add the record
            PrimaryKey = AllFlight.Add();
            //set the primary key of the test data
            TestItem.FlightID = PrimaryKey;
            //find the record
            AllFlight.ThisFlight.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllFlight.ThisFlight, TestItem);
        }

        [TestMethod]
        public void DeleteMethod()
        {
            //create an instance of a class
            clsFlightCollection AllFlight = new clsFlightCollection();
            //create the item of test data
            clsFlight TestItem = new clsFlight();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FlightID = 1;
            TestItem.TicketID = 2;
            TestItem.DateOfBirth = "1st May 2000";
            TestItem.Gate = "12B";
            TestItem.DepartureDate = DateTime.Now.Date;
            //set thisflight to the test data
            AllFlight.ThisFlight = TestItem;
            //add the record
            PrimaryKey = AllFlight.Add();
            //set the primary key of the test data
            TestItem.FlightID = PrimaryKey;
            //find the record
            AllFlight.ThisFlight.Find(PrimaryKey);
            //delete the record
            AllFlight.Delete();
            //now find the record
            Boolean Found = AllFlight.ThisFlight.Find(PrimaryKey);
            //test to see that record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethod()
        {
            //create an instance of a class
            clsFlightCollection AllFlight = new clsFlightCollection();
            //create the item of test data
            clsFlight TestItem = new clsFlight();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.TicketID = 2;
            TestItem.DateOfBirth = "1st May 2000";
            TestItem.Gate = "12B";
            TestItem.DepartureDate = DateTime.Now.Date;
            //set thisflight to the test data
            AllFlight.ThisFlight = TestItem;
            //add the record
            PrimaryKey = AllFlight.Add();
            //set the primary key of the test data
            TestItem.FlightID = PrimaryKey;
            //modify the test data
            TestItem.TicketID = 3;
            TestItem.DateOfBirth = "11th April 2001";
            TestItem.Gate = "1D";
            TestItem.DepartureDate = DateTime.Now.Date;
            //set the record based on the new test data
            AllFlight.ThisFlight = TestItem;
            //update the record
            AllFlight.Update();
            //find the record
            AllFlight.ThisFlight.Find(PrimaryKey);
            //test to see thisflight matches the test data
            Assert.AreEqual(AllFlight.ThisFlight, TestItem);
        }

        [TestMethod]
        public void ReportByDateOfBirthMethod()
        {
            //create an instance of the class containing unfiltered results
            clsFlightCollection AllFlight = new clsFlightCollection();
            //create an instance of the filtered data
            clsFlightCollection FilteredFlight = new clsFlightCollection();
            //apply a blank string (should return all records)
            FilteredFlight.ReportByDateOfBirth("");
            //test to see that the two values are the same
            Assert.AreEqual(AllFlight.Count, FilteredFlight.Count);
        }

        [TestMethod]
        public void ReportByDateOfBirthNoneFound()
        {
            //create an instance of the filtered data
            clsFlightCollection FilteredFlight = new clsFlightCollection();
            //apply a date of birth that doesnt exist
            FilteredFlight.ReportByDateOfBirth("xxx xxxx xxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredFlight.Count);
        }

        [TestMethod]
        public void ReportByDateOFBirthTestDataFound()
        {
            //create an instance of the filtered data
            clsFlightCollection FilteredFlight = new clsFlightCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a name that doesnt exist
            FilteredFlight.ReportByDateOfBirth("June 2020");
            //check that the correct number of records are found
            if (FilteredFlight.Count == 2)
            {
                //check of the record is ID 8
                if (FilteredFlight.FlightList[0].FlightID != 20)
                {
                    OK = false;
                }
                //check that the first record is ID 10
                if (FilteredFlight.FlightList[1].FlightID != 22)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }


        [TestMethod]
        //used to test the flight find method of the class
        public void FindMethod()
        {
            //create an instance of a class
            clsFlight AFlight = new clsFlight();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 FlightID = 26;
            //invoke the method
            Found = AFlight.Find(FlightID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        //used to test the FlightID property of the class
        public void TestFlightIDFound()
        {
            //create an instance of a class
            clsFlight AFlight = new clsFlight();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightID = 26;
            //invoke the method
            Found = AFlight.Find(FlightID);
            //check the StaffID
            if (AFlight.FlightID != 26)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        //used to test the DateOfBirth property of the class
        public void TestDateOfBirthFound()
        {
            //create an instance of a class
            clsFlight AFlight = new clsFlight();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightID = 26;
            //invoke the method
            Found = AFlight.Find(FlightID);
            //check the StaffID
            if (AFlight.DateOfBirth != "testbirth")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        //used to test the Gate property of the class
        public void TestGateFound()
        {
            //create an instance of a class
            clsFlight AFlight = new clsFlight();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightID = 26;
            //invoke the method
            Found = AFlight.Find(FlightID);
            //check the StaffID
            if (AFlight.Gate != "testg")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        //used to test the DepartureDate property of the class
        public void TestDepartureDateFound()
        {
            //create an instance of a class
            clsFlight AFlight = new clsFlight();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightID = 26;
            //invoke the method
            Found = AFlight.Find(FlightID);
            //check the StaffID
            if (AFlight.DepartureDate != Convert.ToDateTime("2001/01/01"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        //used to test the TicketID property of the class
        public void TestTicketIDFound()
        {
            //create an instance of a class
            clsFlight AFlight = new clsFlight();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightID = 26;
            //invoke the method
            Found = AFlight.Find(FlightID);
            //check the StaffID
            if (AFlight.TicketID != 10)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
