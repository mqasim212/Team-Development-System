using System;
using FlightClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlightTesting
{
    [TestClass]
    public class tstBooking
    {
        //good test data
        //create some test data to pass the record
        string SomeBookingName = "Florin";
        string SomeBookingDate = DateTime.Now.Date.ToString();
        string SomeBookingValidity = "30";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class
            clsBooking ABooking = new clsBooking();
            //test to see that it exists
            Assert.IsNotNull(ABooking);
        }

        [TestMethod]
        //used to test the Booking ID property of the class
        public void BookingID()
        {
            //create an instance of a class
            clsBooking ABooking = new clsBooking();
            //create some test data to assign to property
            Int32 BookingID = 1;
            //assign data to property
            ABooking.BookingID = BookingID;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(ABooking.BookingID, BookingID);
        }

        [TestMethod]
        //used to test the booking name property of the class
        public void BookingName()
        {
            //create an instance of a class
            clsBooking ABooking = new clsBooking();
            //create some test data to assign to property
            string SomeBookingName = "Florin";
            //assign data to property
            ABooking.BookingName = SomeBookingName;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(ABooking.BookingName, SomeBookingName);
        }

        [TestMethod]
        //used to test the booking date property of the class
        public void BookingDate()
        {
            //create an instance of a class
            clsBooking ABooking = new clsBooking();
            //create some test data to assign to property
            DateTime SomeBookingDate = DateTime.Now.Date;
            //assign data to property
            ABooking.BookingDate = SomeBookingDate;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(ABooking.BookingDate, SomeBookingDate);
        }

        [TestMethod]
        //used to test the Booking validity property of the class
        public void BookingValidity()
        {
            //create an instance of a class
            clsBooking ABooking = new clsBooking();
            //create some test data to assign to property
            Int32 SomeBookingValidity = 1;
            //assign data to property
            ABooking.BookingValidity = SomeBookingValidity;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(ABooking.BookingValidity, SomeBookingValidity);
        }

        [TestMethod]
        //used to test the Customer ID foreign key property of the class
        public void CustomerID()
        {
            //create an instance of a class
            clsBooking ABooking = new clsBooking();
            //create some test data to assign to property
            Int32 CustomerID = 2;
            //assign data to property
            ABooking.CustomerID = CustomerID;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(ABooking.CustomerID, CustomerID);
        }

        [TestMethod]
        //used to test the Staff ID foreign key property of the class
        public void StaffID()
        {
            //create an instance of a class
            clsBooking ABooking = new clsBooking();
            //create some test data to assign to property
            Int32 StaffID = 3;
            //assign data to property
            ABooking.StaffID = StaffID;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(ABooking.StaffID, StaffID);
        }

        [TestMethod]
        //used to test the Flight ID foreign key property of the class
        public void FlightID()
        {
            //create an instance of a class
            clsBooking ABooking = new clsBooking();
            //create some test data to assign to property
            Int32 FlightID = 4;
            //assign data to property
            ABooking.FlightID = FlightID;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(ABooking.FlightID, FlightID);
        }

        [TestMethod]
        //used to test the valid method of the class
        public void ValidMethod()
        {
            //create an instance of a class
            clsBooking ABooking = new clsBooking();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            Error = ABooking.Valid(SomeBookingName, SomeBookingDate, SomeBookingValidity);
            //test to see the result is ok. i.e there was no error mssage returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookingNameMinLessOne()
        {
            //create an instance of a class
            clsBooking ABooking = new clsBooking();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeBookingName = "";
            //invoke the method
            Error = ABooking.Valid(SomeBookingName, SomeBookingDate, SomeBookingValidity);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookingNameMaxPlusOne()
        {
            //create an instance of a class
            clsBooking ABooking = new clsBooking();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeBookingName = "Joeeyyyyyybarthmellow";
            //invoke the method
            Error = ABooking.Valid(SomeBookingName, SomeBookingDate, SomeBookingValidity);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookingNameExtremeMax()
        {
            //create an instance of a class
            clsBooking ABooking = new clsBooking();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeBookingName = "";
            //pad the string with characters
            SomeBookingName = SomeBookingName.PadRight(50, 'a');
            //invoke the method
            Error = ABooking.Valid(SomeBookingName, SomeBookingDate, SomeBookingValidity);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookingDateMinLessOne()
        {
            //create an instance of a class
            clsBooking ABooking = new clsBooking();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the booking date data //set the date to todays date
            DateTime TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string SomeBookingDate = TestDate.ToString();
            //invoke the method
            Error = ABooking.Valid(SomeBookingName, SomeBookingDate, SomeBookingValidity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookingDateExtremeMax()
        {
            //create an instance of a class
            clsBooking ABooking = new clsBooking();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the booking date data  //set the date to todays date
            DateTime TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string SomeBookingDate = TestDate.ToString();
            //invoke the method
            Error = ABooking.Valid(SomeBookingName, SomeBookingDate, SomeBookingValidity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookingDateInvalidData()
        {
            //create an instance of a class
            clsBooking ABooking = new clsBooking();
            //string variable to store any error message
            string Error = "";
            //set the date to a non date value
            string SomeBookingDate = "This is not a date!";
            //invoke the method
            Error = ABooking.Valid(SomeBookingName, SomeBookingDate, SomeBookingValidity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookingValidityMinLessOne()
        {
            //create an instance of a class
            clsBooking ABooking = new clsBooking();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeBookingValidity = "";
            //invoke the method
            Error = ABooking.Valid(SomeBookingName, SomeBookingDate, SomeBookingValidity);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookingValidityMaxPlusOne()
        {
            //create an instance of a class
            clsBooking ABooking = new clsBooking();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeBookingValidity = "123456";
            //invoke the method
            Error = ABooking.Valid(SomeBookingName, SomeBookingDate, SomeBookingValidity);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookingValidityExtremeMax()
        {
            //create an instance of a class
            clsBooking ABooking = new clsBooking();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeBookingName = "";
            //pad the string with characters
            SomeBookingValidity = SomeBookingValidity.PadRight(20, 'a');
            //invoke the method
            Error = ABooking.Valid(SomeBookingName, SomeBookingDate, SomeBookingValidity);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
    }
}