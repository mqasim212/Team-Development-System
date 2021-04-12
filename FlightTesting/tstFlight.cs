using System;
using FlightClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlightTesting
{
    [TestClass]
    public class tstFlight
    {
        //good test data
        //create some test data to pass the record
        string SomeDateOfBirth = "2nd April";
        string SomeGate = "12C";
        string SomeDepartureDate = DateTime.Now.Date.ToString();
        
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class
            clsFlight AFlight = new clsFlight();
            //test to see that it exists
            Assert.IsNotNull(AFlight);
        }

        [TestMethod]
        //used to test the Flight ID property of the class
        public void FlightID()
        {
            //create an instance of a class
            clsFlight AFlight = new clsFlight();
            //create some test data to assign to the property
            Int32 FlightID = 1;
            //assign the data to the property
            AFlight.FlightID = FlightID;
            //test to see that the two values are the same
            Assert.AreEqual(AFlight.FlightID, FlightID);
        }

        [TestMethod]
        //used to test the date of birth property of the class
        public void DateOfBirth()
        {
            //create an instance of a class
            clsFlight AFlight = new clsFlight();
            //create some test data to assign to the property
            string SomeDateOfBirth = "1st April 1999";
            //assign the data to the property
            AFlight.DateOfBirth = SomeDateOfBirth;
            //test to see that the two values are the same
            Assert.AreEqual(AFlight.DateOfBirth, SomeDateOfBirth);
        }

        [TestMethod]
        //used to test the gate property of the class
        public void Gate()
        {
            //create an instance of a class
            clsFlight AFlight = new clsFlight();
            //create some test data to assign to the property
            string SomeGate = "12B";
            //assign the data to the property
            AFlight.Gate = SomeGate;
            //test to see that the two values are the same
            Assert.AreEqual(AFlight.Gate, SomeGate);
        }

        [TestMethod]
        //used to test the departure date property of the class
        public void DepartureDate()
        {
            //create an instance of a class
            clsFlight AFlight = new clsFlight();
            //create some test data to assign to the property
            DateTime SomeDepartureDate = DateTime.Now.Date;
            //assign the data to the property
            AFlight.DepartureDate = SomeDepartureDate;
            //test to see that the two values are the same
            Assert.AreEqual(AFlight.DepartureDate, SomeDepartureDate);
        }

        [TestMethod]
        //used to test the ticket ID foreign key property of the class
        public void TicketID()
        {
            //create an instance of a class
            clsFlight AFlight = new clsFlight();
            //create some test data to assign to the property
            Int32 TicketID = 1;
            //assign the data to the property
            AFlight.TicketID = TicketID;
            //test to see that the two values are the same
            Assert.AreEqual(AFlight.TicketID, TicketID);
        }

        [TestMethod]
        //used to test the valid method of the class
        public void ValidMethod()
        {
            //create an instance of a class
            clsFlight AFlight = new clsFlight();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            Error = AFlight.Valid(SomeDateOfBirth, SomeGate, SomeDepartureDate);
            //test to see the result is ok. i.e there was no error mssage returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of a class
            clsFlight AFlight = new clsFlight();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeDateOfBirth = "5th May";
            //invoke the method
            Error = AFlight.Valid(SomeDateOfBirth, SomeGate, SomeDepartureDate);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxPlusOne()
        {
            //create an instance of a class
            clsFlight AFlight = new clsFlight();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeDateOfBirth = "5th September 20000";
            //invoke the method
            Error = AFlight.Valid(SomeDateOfBirth, SomeGate, SomeDepartureDate);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMid()
        {
            //create an instance of a class
            clsFlight AFlight = new clsFlight();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeDateOfBirth = "Augus";
            //invoke the method
            Error = AFlight.Valid(SomeDateOfBirth, SomeGate, SomeDepartureDate);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of a class
            clsFlight AFlight = new clsFlight();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeDateOfBirth = "";
            //pad the string with characters
            SomeDateOfBirth = SomeDateOfBirth.PadRight(30, 'a');
            //invoke the method
            Error = AFlight.Valid(SomeDateOfBirth, SomeGate, SomeDepartureDate);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GateMinLessOne()
        {
            //create an instance of a class
            clsFlight AFlight = new clsFlight();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeGate = "A";
            //invoke the method
            Error = AFlight.Valid(SomeDateOfBirth, SomeGate, SomeDepartureDate);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GatehMaxPlusOne()
        {
            //create an instance of a class
            clsFlight AFlight = new clsFlight();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeGate = "123ASD";
            //invoke the method
            Error = AFlight.Valid(SomeDateOfBirth, SomeGate, SomeDepartureDate);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void GateExtremeMax()
        {
            //create an instance of a class
            clsFlight AFlight = new clsFlight();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeGate = "";
            //pad the string with characters
            SomeGate = SomeGate.PadRight(20, 'a');
            //invoke the method
            Error = AFlight.Valid(SomeDateOfBirth, SomeGate, SomeDepartureDate);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartureDateMinLessOne()
        {
            //create an instance of a class
            clsFlight AFlight = new clsFlight();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the booking date data //set the date to todays date
            DateTime TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string SomeDepartureDate = TestDate.ToString();
            //invoke the method
            Error = AFlight.Valid(SomeDateOfBirth, SomeGate, SomeDepartureDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartureDateExtremeMax()
        {
            //create an instance of a class
            clsFlight AFlight = new clsFlight();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the booking date data  //set the date to todays date
            DateTime TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string SomeDepartureDate = TestDate.ToString();
            //invoke the method
            Error = AFlight.Valid(SomeDateOfBirth, SomeGate, SomeDepartureDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartureDateInvalidData()
        {
            //create an instance of a class
            clsFlight AFlight = new clsFlight();            //string variable to store any error message
            string Error = "";
            //set the date to a non date value
            string SomeDepartureDate = "This is not a date!";
            //invoke the method
            Error = AFlight.Valid(SomeDateOfBirth, SomeGate, SomeDepartureDate);            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
