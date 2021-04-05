using System;
using FlightClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlightTesting
{

    [TestClass]
    public class tstTicket
    {
        //good test data
        //create some test data to pass the record
        string SomeTicketPurchaseDate = DateTime.Now.Date.ToString();
        string SomeTicketNo = "2AAFF68B";
        string SomeFlightNo = "535";
        string SomeSeatNo = "2B";


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //test to see that it exists
            Assert.IsNotNull(ATicket);
        }

        [TestMethod]
        //used to test the Ticket ID property of the class
        public void TicketID()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //create some test data to assign to the property
            Int32 TicketID = 1;
            //assign the data to the property
            ATicket.TicketID = TicketID;
            //test to see that the two values are the same
            Assert.AreEqual(ATicket.TicketID, TicketID);
        }

        [TestMethod]
        //used to test the Ticket purchase date property of the class
        public void TicketPurchaseDate()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //create some test data to assign to the property
            DateTime SomeTicketPurchaseDate = DateTime.Now.Date;
            //assign the data to the property
            ATicket.TicketPurchaseDate = SomeTicketPurchaseDate;
            //test to see that the two values are the same
            Assert.AreEqual(ATicket.TicketPurchaseDate, SomeTicketPurchaseDate);
        }

        [TestMethod]
        //used to test the TicketNo property of the class
        public void TicketNo()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //create some test data to assign to the property
            string SomeTicketNo = "2AAFF68B";
            //assign the data to the property
            ATicket.TicketNo = SomeTicketNo;
            //test to see that the two values are the same
            Assert.AreEqual(ATicket.TicketNo, SomeTicketNo);
        }

        [TestMethod]
        //used to test the FlightNo property of the class
        public void FlightNo()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //create some test data to assign to the property
            Int32 SomeFlightNo = 535;
            //assign the data to the property
            ATicket.FlightNo = SomeFlightNo;
            //test to see that the two values are the same
            Assert.AreEqual(ATicket.FlightNo, SomeFlightNo);
        }

        [TestMethod]
        //used to test the SeatNo property of the class
        public void SeatNo()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //create some test data to assign to the property
            string SomeSeatNo = "2A";
            //assign the data to the property
            ATicket.SeatNo = SomeSeatNo;
            //test to see that the two values are the same
            Assert.AreEqual(ATicket.SeatNo, SomeSeatNo);
        }

        [TestMethod]
        //used to test the FlightID property of the class
        public void FlightID()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //create some test data to assign to the property
            Int32 FlightID = 2;
            //assign the data to the property
            ATicket.FlightID = FlightID;
            //test to see that the two values are the same
            Assert.AreEqual(ATicket.FlightID, FlightID);
        }

        [TestMethod]
        //used to test the valid method of the class
        public void ValidMethod()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            Error = ATicket.Valid(SomeTicketPurchaseDate, SomeTicketNo, SomeFlightNo, SomeSeatNo);
            //test to see the result is ok. i.e there was no error mssage returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TicketPurchaseDateMinLessOne()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the booking date data //set the date to todays date
            DateTime TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string SomeTicketPurchaseDate = TestDate.ToString();
            //invoke the method
            Error = ATicket.Valid(SomeTicketPurchaseDate, SomeTicketNo, SomeFlightNo, SomeSeatNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TicketPurchaseDateExtremeMax()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the booking date data  //set the date to todays date
            DateTime TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string SomeTicketPurchaseDate = TestDate.ToString();
            //invoke the method
            Error = ATicket.Valid(SomeTicketPurchaseDate, SomeTicketNo, SomeFlightNo, SomeSeatNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TicketPurchaseDateInvalidData()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //string variable to store any error message
            string Error = "";
            //set the date to a non date value
            string SomeTicketPurchaseDate = "This is not a date!";
            //invoke the method
            Error = ATicket.Valid(SomeTicketPurchaseDate, SomeTicketNo, SomeFlightNo, SomeSeatNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TicketNoMinLessOne()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeTicketNo = "AS3";
            //invoke the method
            Error = ATicket.Valid(SomeTicketPurchaseDate, SomeTicketNo, SomeFlightNo, SomeSeatNo);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TicketNoMaxPlusOne()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeTicketNo = "T8ck4t123";
            //invoke the method
            Error = ATicket.Valid(SomeTicketPurchaseDate, SomeTicketNo, SomeFlightNo, SomeSeatNo);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TicketNoExtremeMax()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeTicketNo = "";
            //pad the string with characters
            SomeTicketNo = SomeTicketNo.PadRight(20, 'a');
            //invoke the method
            Error = ATicket.Valid(SomeTicketPurchaseDate, SomeTicketNo, SomeFlightNo, SomeSeatNo);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FlightNoMinLessOne()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeFlightNo = "";
            //invoke the method
            Error = ATicket.Valid(SomeTicketPurchaseDate, SomeTicketNo, SomeFlightNo, SomeSeatNo);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FlightNoMaxPlusOne()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeFlightNo = "123456";
            //invoke the method
            Error = ATicket.Valid(SomeTicketPurchaseDate, SomeTicketNo, SomeFlightNo, SomeSeatNo);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FlightNoExtremeMax()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeFlightNo = "";
            //pad the string with characters
            SomeFlightNo = SomeFlightNo.PadRight(10, 'a');
            //invoke the method
            Error = ATicket.Valid(SomeTicketPurchaseDate, SomeTicketNo, SomeFlightNo, SomeSeatNo);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SeatNoMinLessOne()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeSeatNo = "4";
            //invoke the method
            Error = ATicket.Valid(SomeTicketPurchaseDate, SomeTicketNo, SomeFlightNo, SomeSeatNo);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SeatNoMaxPlusOne()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeSeatNo = "1234cd";
            //invoke the method
            Error = ATicket.Valid(SomeTicketPurchaseDate, SomeTicketNo, SomeFlightNo, SomeSeatNo);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SeatNoExtremeMax()
        {
            //create an instance of a class
            clsTicket ATicket = new clsTicket();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeSeatNo = "";
            //pad the string with characters
            SomeSeatNo = SomeSeatNo.PadRight(20, 'a');
            //invoke the method
            Error = ATicket.Valid(SomeTicketPurchaseDate, SomeTicketNo, SomeFlightNo, SomeSeatNo);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
    }
}
