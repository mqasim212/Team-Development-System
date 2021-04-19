using System;
using FlightClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlightTesting
{
    [TestClass]
    public class tstPlane
    {
        //good test data
        //create some test data to pass the record
        string SomePlaneName = "Emirates";
        string SomeHoursFly = "12";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class
            clsPlane APlane = new clsPlane();
            //test to see that it exists
            Assert.IsNotNull(APlane);
        }

        [TestMethod]
        //used to test the Plane ID property of the class
        public void PlaneID()
        {
            //create an instance of a class
            clsPlane APlane = new clsPlane();
            //create some test data to assign to the property
            Int32 PlaneID = 1;
            //assign the data to the property
            APlane.PlaneID = PlaneID;
            //test to see that the two values are the same
            Assert.AreEqual(APlane.PlaneID, PlaneID);
        }

        [TestMethod]
        //used to test the Plane name property of the class
        public void PlaneName()
        {
            //create an instance of a class
            clsPlane APlane = new clsPlane();
            //create some test data to assign to the property
            string SomePlaneName = "Emirates";
            //assign the data to the property
            APlane.PlaneName = SomePlaneName;
            //test to see that the two values are the same
            Assert.AreEqual(APlane.PlaneName, SomePlaneName);
        }

        [TestMethod]
        //used to test the HoursFly property of the class
        public void HoursFly()
        {
            //create an instance of a class
            clsPlane APlane = new clsPlane();
            //create some test data to assign to the property
            Int32 SomeHoursFly = 12;
            //assign the data to the property
            APlane.HoursFly = SomeHoursFly;
            //test to see that the two values are the same
            Assert.AreEqual(APlane.HoursFly, SomeHoursFly);
        }

        [TestMethod]
        //used to test the LocationID property of the class
        public void LocationID()
        {
            //create an instance of a class
            clsPlane APlane = new clsPlane();
            //create some test data to assign to the property
            Int32 LocationID = 2;
            //assign the data to the property
            APlane.LocationID = LocationID;
            //test to see that the two values are the same
            Assert.AreEqual(APlane.LocationID, LocationID);
        }

        [TestMethod]
        //used to test the valid method of the class
        public void ValidMethod()
        {
            //create an instance of a class
            clsPlane APlane = new clsPlane();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            Error = APlane.Valid(SomePlaneName, SomeHoursFly);
            //test to see the result is ok. i.e there was no error mssage returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PlaneNameMinLessOne()
        {
            //create an instance of a class
            clsPlane APlane = new clsPlane();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomePlaneName = "Emi";
            //invoke the method
            Error = APlane.Valid(SomePlaneName, SomeHoursFly);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PlaneNameMaxPlusOne()
        {
            //create an instance of a class
            clsPlane APlane = new clsPlane();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomePlaneName = "Fly Emirates Emirates flyf";
            //invoke the method
            Error = APlane.Valid(SomePlaneName, SomeHoursFly);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PlaneNameExtremeMax()
        {
            //create an instance of a class
            clsPlane APlane = new clsPlane();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomePlaneName = "";
            //pad the string with characters
            SomePlaneName = SomePlaneName.PadRight(50, 'a');
            //invoke the method
            Error = APlane.Valid(SomePlaneName, SomeHoursFly);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HoursFlyMinLessOne()
        {
            //create an instance of a class
            clsPlane APlane = new clsPlane();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeHoursFly = "";
            //invoke the method
            Error = APlane.Valid(SomePlaneName, SomeHoursFly);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HoursFlyMaxPlusOne()
        {
            //create an instance of a class
            clsPlane APlane = new clsPlane();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeHoursFly = "12345";
            //invoke the method
            Error = APlane.Valid(SomePlaneName, SomeHoursFly);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HoursFlyExtremeMax()
        {
            //create an instance of a class
            clsPlane APlane = new clsPlane();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeHoursFly = "";
            //pad the string with characters
            SomeHoursFly = SomePlaneName.PadRight(10, 'a');
            //invoke the method
            Error = APlane.Valid(SomeHoursFly, SomeHoursFly);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
    }
}
