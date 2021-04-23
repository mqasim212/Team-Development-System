using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FlightClasses;
namespace FlightTesting
{
    [TestClass]
    public class tstPlaneCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class
            clsPlaneCollection AllPlane = new clsPlaneCollection();
            //test to see that it exists
            Assert.IsNotNull(AllPlane);
        }

        [TestMethod]
        public void PlaneList()
        {
            //create an instance of a class
            clsPlaneCollection AllPlane = new clsPlaneCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsPlane> TestList = new List<clsPlane>();
            //add an item to the list
            //create the item of test data
            clsPlane TestItem = new clsPlane();
            //set its properties
            TestItem.PlaneID = 1;
            TestItem.LocationID = 2;
            TestItem.PlaneName = "Emirates";
            TestItem.HoursFly = 12;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllPlane.PlaneList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllPlane.PlaneList, TestList);
        }

        [TestMethod]
        public void ThisPlaneProperty()
        {
            //create an instance of a class
            clsPlaneCollection AllPlane = new clsPlaneCollection();
            //create some test data to assign to the property
            clsPlane TestPlane = new clsPlane();
            //set the properties of the test object
            TestPlane.PlaneID = 1;
            TestPlane.LocationID = 2;
            TestPlane.PlaneName = "Emirates";
            TestPlane.HoursFly = 12;
            //assign the data to the property
            AllPlane.ThisPlane = TestPlane;
            //test to see that the two values are the same
            Assert.AreEqual(AllPlane.ThisPlane, TestPlane);
        }


        [TestMethod]
        public void ListAndCount()
        {
            //create an instance of a class
            clsPlaneCollection AllPlane = new clsPlaneCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsPlane> TestList = new List<clsPlane>();
            //add an item to the list
            //create the item of test data
            clsPlane TestItem = new clsPlane();
            //set its properties
            TestItem.PlaneID = 1;
            TestItem.LocationID = 2;
            TestItem.PlaneName = "Emirates";
            TestItem.HoursFly = 12;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllPlane.PlaneList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllPlane.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethod()
        {
            //create an instance of a class
            clsPlaneCollection AllPlane = new clsPlaneCollection();
            //create the item of test data
            clsPlane TestItem = new clsPlane();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PlaneID = 1;
            TestItem.LocationID = 2;
            TestItem.PlaneName = "Emirates";
            TestItem.HoursFly = 12;
            //set thisplane to the test data
            AllPlane.ThisPlane = TestItem;
            //add the record
            PrimaryKey = AllPlane.Add();
            //set the primary key of the test data
            TestItem.PlaneID = PrimaryKey;
            //find the record
            AllPlane.ThisPlane.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllPlane.ThisPlane, TestItem);
        }

        [TestMethod]
        public void DeleteMethod()
        {
            //create an instance of a class
            clsPlaneCollection AllPlane = new clsPlaneCollection();
            //create the item of test data
            clsPlane TestItem = new clsPlane();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PlaneID = 1;
            TestItem.LocationID = 2;
            TestItem.PlaneName = "Emirates";
            TestItem.HoursFly = 12;
            //set thisplane to the test data
            AllPlane.ThisPlane = TestItem;
            //add the record
            PrimaryKey = AllPlane.Add();
            //set the primary key of the test data
            TestItem.PlaneID = PrimaryKey;
            //find the record
            AllPlane.ThisPlane.Find(PrimaryKey);
            //delete the record
            AllPlane.Delete();
            //now find the record
            Boolean Found = AllPlane.ThisPlane.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethod()
        {
            //create an instance of a class
            clsPlaneCollection AllPlane = new clsPlaneCollection();
            //create the item of test data
            clsPlane TestItem = new clsPlane();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.LocationID = 2;
            TestItem.PlaneName = "Emirates";
            TestItem.HoursFly = 12;
            //set thisplane to the test data
            AllPlane.ThisPlane = TestItem;
            //add the record
            PrimaryKey = AllPlane.Add();
            //set the primary key of the test data
            TestItem.PlaneID = PrimaryKey;
            //modify the test data
            TestItem.LocationID = 3;
            TestItem.PlaneName = "FlyDubai";
            TestItem.HoursFly = 2;
            //set the record based on the new test data
            AllPlane.ThisPlane = TestItem;
            //update the record
            AllPlane.Update();
            //find the record
            AllPlane.ThisPlane.Find(PrimaryKey);
            //test to see thisplane matches the test data
            Assert.AreEqual(AllPlane.ThisPlane, TestItem);
        }

        [TestMethod]
        public void ReportByPlaneNameMethod()
        {
            //create an instance of the class containing unfiltered results
            clsPlaneCollection AllPlane = new clsPlaneCollection();
            //create an instance of the filtered data
            clsPlaneCollection FilteredPlane = new clsPlaneCollection();
            //apply a blank string (should return all records)
            FilteredPlane.ReportByPlaneName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllPlane.Count, FilteredPlane.Count);
        }

        [TestMethod]
        public void ReportByPlaneNameNoneFoundMethod()
        {
            //create an instance of the class containing unfiltered results
            clsPlaneCollection FilteredPlane = new clsPlaneCollection();
            //apply a plane name that doesnt exist
            FilteredPlane.ReportByPlaneName("XXXX");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredPlane.Count);
        }

        [TestMethod]
        public void ReportByBookingNameTestDataFound()
        {
            //create an instance of the class containing unfiltered results
            clsPlaneCollection FilteredPlane = new clsPlaneCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a plane name that does not exist
            FilteredPlane.ReportByPlaneName("FlyDubaii");
            //check that the correct number of records are found
            if (FilteredPlane.Count == 2)
            {
                //Check that the first record is ID 11
                if (FilteredPlane.PlaneList[0].PlaneID != 11)
                {
                    OK = false;
                }
                //Check that the first record is ID 14
                if (FilteredPlane.PlaneList[1].PlaneID != 14)
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
            clsPlane APlane = new clsPlane();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 PlaneID = 15;
            //invoke the method
            Found = APlane.Find(PlaneID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestPlaneIDFound()
        {
            //create an instance of the class
            clsPlane APlane = new clsPlane();
            //boolean variable to store the result of the search
            Boolean Found = false;
            ////boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PlaneID = 15;
            //imvoke the method
            Found = APlane.Find(PlaneID);
            //check the booking id
            if (APlane.PlaneID != 15)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPlaneNameFound()
        {
            //create an instance of the class
            clsPlane APlane = new clsPlane();
            //boolean variable to store the result of the search
            Boolean Found = false;
            ////boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PlaneID = 15;
            //imvoke the method
            Found = APlane.Find(PlaneID);
            //check the booking id
            if (APlane.PlaneName != "testplane")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHoursFlyFound()
        {
            //create an instance of the class
            clsPlane APlane = new clsPlane();
            //boolean variable to store the result of the search
            Boolean Found = false;
            ////boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PlaneID = 15;
            //imvoke the method
            Found = APlane.Find(PlaneID);
            //check the booking id
            if (APlane.HoursFly != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLocationIDFound()
        {
            //create an instance of the class
            clsPlane APlane = new clsPlane();
            //boolean variable to store the result of the search
            Boolean Found = false;
            ////boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PlaneID = 15;
            //imvoke the method
            Found = APlane.Find(PlaneID);
            //check the booking id
            if (APlane.LocationID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
