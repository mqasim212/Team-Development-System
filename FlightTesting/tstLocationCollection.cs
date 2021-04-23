using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FlightClasses;

namespace FlightTesting
{
    [TestClass]
    public class tstLocationCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class
            clsLocationCollection AllLocation = new clsLocationCollection();
            //test to see that it exists
            Assert.IsNotNull(AllLocation);
        }

        [TestMethod]
        public void LocationList()
        {
            //create an instance of a class
            clsLocationCollection AllLocation = new clsLocationCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsLocation> TestList = new List<clsLocation>();
            //add an item to the list
            //create the item of test data
            clsLocation TestItem = new clsLocation();
            //set its properties
            TestItem.LocationID = 1;
            TestItem.PlaneID = 2;
            TestItem.CountryDeparture = "Bulgaria";
            TestItem.CountryDestination = "Africa";
            TestItem.AirportDeparture = "Heathrow";
            TestItem.AirportDestination = "Gatwick";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllLocation.LocationList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllLocation.LocationList, TestList);
        }

        [TestMethod]
        public void ThisLocationProperty()
        {
            //create an instance of a class
            clsLocationCollection AllLocation = new clsLocationCollection();
            //create some test data to assign to the property
            clsLocation TestLocation = new clsLocation();
            //set the properties of the test object
            TestLocation.LocationID = 1;
            TestLocation.PlaneID = 2;
            TestLocation.CountryDeparture = "Bulgaria";
            TestLocation.CountryDestination = "Africa";
            TestLocation.AirportDeparture = "Heathrow";
            TestLocation.AirportDestination = "Gatwick";
            //assign the data to the property
            AllLocation.ThisLocation = TestLocation;
            //test to see that the two values are the same
            Assert.AreEqual(AllLocation.ThisLocation, TestLocation);
        }

        [TestMethod]
        public void ListAndCount()
        {
            //create an instance of a class
            clsLocationCollection AllLocation = new clsLocationCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsLocation> TestList = new List<clsLocation>();
            //add an item to the list
            //create the item of test data
            clsLocation TestItem = new clsLocation();
            //set its properties
            TestItem.LocationID = 1;
            TestItem.PlaneID = 2;
            TestItem.CountryDeparture = "Bulgaria";
            TestItem.CountryDestination = "Africa";
            TestItem.AirportDeparture = "Heathrow";
            TestItem.AirportDestination = "Gatwick";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllLocation.LocationList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllLocation.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethod()
        {
            //create an instance of a class
            clsLocationCollection AllLocation = new clsLocationCollection();
            //create the item of test data
            clsLocation TestItem = new clsLocation();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.LocationID = 1;
            TestItem.PlaneID = 2;
            TestItem.CountryDeparture = "Bulgaria";
            TestItem.CountryDestination = "Africa";
            TestItem.AirportDeparture = "Heathrow";
            TestItem.AirportDestination = "Gatwick";
            //set this location to the test data
            AllLocation.ThisLocation = TestItem;
            //add the record
            PrimaryKey = AllLocation.Add();
            //set the primary key of the test data
            TestItem.LocationID = PrimaryKey;
            //find the record
            AllLocation.ThisLocation.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllLocation.ThisLocation, TestItem);
        }

        [TestMethod]
        public void DeleteMethod()
        {
            //create an instance of a class
            clsLocationCollection AllLocation = new clsLocationCollection();
            //create the item of test data
            clsLocation TestItem = new clsLocation();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.LocationID = 1;
            TestItem.PlaneID = 2;
            TestItem.CountryDeparture = "Bulgaria";
            TestItem.CountryDestination = "Africa";
            TestItem.AirportDeparture = "Heathrow";
            TestItem.AirportDestination = "Gatwick";
            //set this location to the test data
            AllLocation.ThisLocation = TestItem;
            //add the record
            PrimaryKey = AllLocation.Add();
            //set the primary key of the test data
            TestItem.LocationID = PrimaryKey;
            //find the record
            AllLocation.ThisLocation.Find(PrimaryKey);
            //delete the record
            AllLocation.Delete();
            //now find the record
            Boolean Found = AllLocation.ThisLocation.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethod()
        {
            //create an instance of a class
            clsLocationCollection AllLocation = new clsLocationCollection();
            //create the item of test data
            clsLocation TestItem = new clsLocation();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PlaneID = 2;
            TestItem.CountryDeparture = "Bulgaria";
            TestItem.CountryDestination = "Africa";
            TestItem.AirportDeparture = "Heathrow";
            TestItem.AirportDestination = "Gatwick";
            //set this location to the test data
            AllLocation.ThisLocation = TestItem;
            //add the record
            PrimaryKey = AllLocation.Add();
            //set the primary key of the test data
            TestItem.LocationID = PrimaryKey;
            //modify the test data
            TestItem.PlaneID = 3;
            TestItem.CountryDeparture = "Belgium";
            TestItem.CountryDestination = "Zimbabwe";
            TestItem.AirportDeparture = "Lahore";
            TestItem.AirportDestination = "Heathrow";
            //set the record based on the new test data
            AllLocation.ThisLocation = TestItem;
            //update the record
            AllLocation.Update();
            //find the record
            AllLocation.ThisLocation.Find(PrimaryKey);
            //test to see thislocation matches the test data
            Assert.AreEqual(AllLocation.ThisLocation, TestItem);
        }

        [TestMethod]
        public void ReportByCountryDepartureMethod()
        {
            //create an instance of the class containing unfiltered results
            clsLocationCollection AllLocation = new clsLocationCollection();
            //create an instance of the filtered data
            clsLocationCollection FilteredLocation = new clsLocationCollection();
            //apply a blank string (should return all records)
            FilteredLocation.ReportByCountryDeparture("");
            //test to see that the two values are the same
            Assert.AreEqual(AllLocation.Count, FilteredLocation.Count);
        }

        [TestMethod]
        public void ReportByCountryDepartureNoneFound()
        {
            //create an instance of the class containing unfiltered results
            clsLocationCollection FilteredLocation = new clsLocationCollection();
            //apply a country of departure that dont exist
            FilteredLocation.ReportByCountryDeparture("XXXXXXX");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredLocation.Count);
        }

        [TestMethod]
        public void ReportByCountryDepartureTestDataFound()
        {
            //create an instance of the class containing unfiltered results
            clsLocationCollection FilteredLocation = new clsLocationCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a name that does not exist
            FilteredLocation.ReportByCountryDeparture("India");
            //check that the correct number of records are found
            if (FilteredLocation.Count == 2)
            {
                //Check that the first record is ID 23
                if (FilteredLocation.LocationList[0].LocationID != 1)
                {
                    OK = false;
                }
                //Check that the first record is ID 24
                if (FilteredLocation.LocationList[1].LocationID != 9)
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
            clsLocation ALocation = new clsLocation();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 LocationID = 14;
            //invoke the method
            Found = ALocation.Find(LocationID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestLocationIDFound()
        {
            //create an instance of the class
            clsLocation ALocation = new clsLocation();
            //boolean variable to store the result of the search
            Boolean Found = false;
            ////boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LocationID = 14;
            //imvoke the method
            Found = ALocation.Find(LocationID);
            //check the location id
            if (ALocation.LocationID != 14)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCountryDepartureFound()
        {
            //create an instance of the class
            clsLocation ALocation = new clsLocation();
            //boolean variable to store the result of the search
            Boolean Found = false;
            ////boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LocationID = 14;
            //imvoke the method
            Found = ALocation.Find(LocationID);
            //check the CountryDeparture 
            if (ALocation.CountryDeparture != "testdeparture")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCountryDestinationFound()
        {
            //create an instance of the class
            clsLocation ALocation = new clsLocation();
            //boolean variable to store the result of the search
            Boolean Found = false;
            ////boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LocationID = 14;
            //imvoke the method
            Found = ALocation.Find(LocationID);
            //check the CountryDestination 
            if (ALocation.CountryDestination != "testdestination")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAirportDepartureFound()
        {
            //create an instance of the class
            clsLocation ALocation = new clsLocation();
            //boolean variable to store the result of the search
            Boolean Found = false;
            ////boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LocationID = 14;
            //imvoke the method
            Found = ALocation.Find(LocationID);
            //check the AirportDeparture 
            if (ALocation.AirportDeparture != "testdeparture")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAirportDestinationFound()
        {
            //create an instance of the class
            clsLocation ALocation = new clsLocation();
            //boolean variable to store the result of the search
            Boolean Found = false;
            ////boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LocationID = 14;
            //imvoke the method
            Found = ALocation.Find(LocationID);
            //check the AirportDestination 
            if (ALocation.AirportDestination != "testdestinationn")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPlaneIDFound()
        {
            //create an instance of the class
            clsLocation ALocation = new clsLocation();
            //boolean variable to store the result of the search
            Boolean Found = false;
            ////boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LocationID = 14;
            //imvoke the method
            Found = ALocation.Find(LocationID);
            //check the plane id
            if (ALocation.PlaneID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
