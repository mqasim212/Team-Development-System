using System;
using FlightClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlightTesting
{
    [TestClass]
    public class tstOrderline
    {
        //good test data
        //create some test data to pass the record
        string SomeBookingNo = "A6543";
        string SomeQuantity = "2";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class
            clsOrderline AOrderline = new clsOrderline();
            //test to see that it exists
            Assert.IsNotNull(AOrderline);
        }

        [TestMethod]
        //used to test the name property of the class
        public void OrderlineID()
        {
            //create an instance of a class
            clsOrderline AOrderline = new clsOrderline();
            //create some test data to assign to proprty
            Int32 OrderlineID = 1;
            //assign data to property
            AOrderline.OrderlineID = OrderlineID;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(AOrderline.OrderlineID, OrderlineID);
        }


        [TestMethod]
        //used to test the name property of the class
        public void BookingNo()
        {
            //create an instance of a class
            clsOrderline AOrderline = new clsOrderline();
            //create some test data to assign to proprty
            string SomeBookingNo = "A6886";
            //assign data to property
            AOrderline.BookingNo = SomeBookingNo;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(AOrderline.BookingNo, SomeBookingNo);
        }

        [TestMethod]
        //used to test the name property of the class
        public void Quantity()
        {
            //create an instance of a class
            clsOrderline AOrderline = new clsOrderline();
            //create some test data to assign to proprty
            Int32 SomeQuantity = 1;
            //assign data to property
            AOrderline.Quantity = SomeQuantity;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(AOrderline.Quantity, SomeQuantity);
        }
        [TestMethod]
        //used to test the name property of the class
        public void BookingID()
        {
            //create an instance of a class
            clsOrderline AOrderline = new clsOrderline();
            //create some test data to assign to proprty
            Int32 BookingID = 3;
            //assign data to property
            AOrderline.BookingID = BookingID;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(AOrderline.BookingID, BookingID);
        }

        [TestMethod]
        //used to test the name property of the class
        public void ValidMethod()
        {
            //create an instance of a class
            clsOrderline AOrderline = new clsOrderline();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            Error = AOrderline.Valid(SomeBookingNo, SomeQuantity);
            //test to see the result is ok. i.e there was no error mssage returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookingNoMinLessOne()
        {
            //create an instance of a class
            clsOrderline AOrderline = new clsOrderline();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeBookingNo = "";
            //invoke the method
            Error = AOrderline.Valid(SomeBookingNo, SomeQuantity);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookingNoMaxPlusOne()
        {
            //create an instance of a class
            clsOrderline AOrderline = new clsOrderline();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeBookingNo = "as1234";
            //invoke the method
            Error = AOrderline.Valid(SomeBookingNo, SomeQuantity);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookingNoExtremeMax()
        {
            //create an instance of the class
            clsOrderline AOrderline = new clsOrderline();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeBookingNo = "";
            //pad the string with characters
            SomeBookingNo = SomeBookingNo.PadRight(10, 'a');
            //invoke the method
            Error = AOrderline.Valid(SomeBookingNo, SomeQuantity);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of a class
            clsOrderline AOrderline = new clsOrderline();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeQuantity = "";
            //invoke the method
            Error = AOrderline.Valid(SomeBookingNo, SomeQuantity);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instance of a class
            clsOrderline AOrderline = new clsOrderline();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeQuantity = "123456";
            //invoke the method
            Error = AOrderline.Valid(SomeBookingNo, SomeQuantity);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            //create an instance of the class
            clsOrderline AOrderline = new clsOrderline();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeQuantity = "";
            //pad the string with characters
            SomeQuantity = SomeQuantity.PadRight(20, 'a');
            //invoke the method
            Error = AOrderline.Valid(SomeBookingNo, SomeQuantity);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
    }
}

