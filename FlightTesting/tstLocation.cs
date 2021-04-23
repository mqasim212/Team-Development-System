using System;
using FlightClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlightTesting
{
    [TestClass]
    public class tstLocation
    {
        //good test data
        //create some test data to pass the record
        string SomeCountryDeparture = "Albania";
        string SomeCountryDestination = "Argentina";
        string SomeAirportDeparture = "Kukes Airport";
        string SomeAirportDestination = "Ministro Pistarini";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class
            clsLocation ALocation = new clsLocation();
            //test to see that it exists
            Assert.IsNotNull(ALocation);
        }

        [TestMethod]
        //used to test the Location ID property of the class
        public void LocationID()
        {
            //create an instance of a class
            clsLocation ALocation = new clsLocation();
            //create some test data to assign to the property
            Int32 LocationID = 1;
            //assign the data to the property
            ALocation.LocationID = LocationID;
            //test to see that the two values are the same
            Assert.AreEqual(ALocation.LocationID, LocationID);
        }

        [TestMethod]
        //used to test the Country Departure property of the class
        public void CountryDeparture()
        {
            //create an instance of a class
            clsLocation ALocation = new clsLocation();
            //create some test data to assign to the property
            string SomeCountryDeparture = "Albania";
            //assign the data to the property
            ALocation.CountryDeparture = SomeCountryDeparture;
            //test to see that the two values are the same
            Assert.AreEqual(ALocation.CountryDeparture, SomeCountryDeparture);
        }

        [TestMethod]
        //used to test the Country Destination property of the class
        public void CountryDestination()
        {
            //create an instance of a class
            clsLocation ALocation = new clsLocation();
            //create some test data to assign to the property
            string SomeCountryDestination = "Dubai";
            //assign the data to the property
            ALocation.CountryDestination = SomeCountryDestination;
            //test to see that the two values are the same
            Assert.AreEqual(ALocation.CountryDestination, SomeCountryDestination);
        }
        [TestMethod]
        //used to test the Airport Departure property of the class
        public void AirportDeparture()
        {
            //create an instance of a class
            clsLocation ALocation = new clsLocation();
            //create some test data to assign to the property
            string SomeAirportDeparture = "Heathrow";
            //assign the data to the property
            ALocation.AirportDeparture = SomeAirportDeparture;
            //test to see that the two values are the same
            Assert.AreEqual(ALocation.AirportDeparture, SomeAirportDeparture);
        }

        [TestMethod]
        //used to test the Airport Destination property of the class
        public void AirportDestination()
        {
            //create an instance of a class
            clsLocation ALocation = new clsLocation();
            //create some test data to assign to the property
            string SomeAirportDestination = "Islamabad";
            //assign the data to the property
            ALocation.AirportDestination = SomeAirportDestination;
            //test to see that the two values are the same
            Assert.AreEqual(ALocation.AirportDestination, SomeAirportDestination);
        }

        [TestMethod]
        //used to test the Plane ID property of the class
        public void PlaneID()
        {
            //create an instance of a class
            clsLocation ALocation = new clsLocation();
            //create some test data to assign to the property
            Int32 PlaneID = 1;
            //assign the data to the property
            ALocation.PlaneID = PlaneID;
            //test to see that the two values are the same
            Assert.AreEqual(ALocation.PlaneID, PlaneID);
        }

        [TestMethod]
        //used to test the valid method of the class
        public void ValidMethod()
        {
            //create an instance of a class
            clsLocation ALocation = new clsLocation();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            Error = ALocation.Valid(SomeCountryDeparture, SomeCountryDestination, SomeAirportDeparture, SomeAirportDestination);
            //test to see the result is ok. i.e there was no error mssage returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountryDepartureMinLessOne()
        {
            //create an instance of a class
            clsLocation ALocation = new clsLocation();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeCountryDeparture = "Alban";
            //invoke the method
            Error = ALocation.Valid(SomeCountryDeparture, SomeCountryDestination, SomeAirportDeparture, SomeAirportDestination);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CountryDepartureMaxPlusOne()
        {
            //create an instance of a class
            clsLocation ALocation = new clsLocation();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeCountryDeparture = "abcndefghijklmnopqrstuvwyzabcdefgdsasdfgh";
            //invoke the method
            Error = ALocation.Valid(SomeCountryDeparture, SomeCountryDestination, SomeAirportDeparture, SomeAirportDestination);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CountryDepartureExtremeMax()
        {
            //create an instance of a class
            clsLocation ALocation = new clsLocation();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeCountryDeparture = "";
            //pad the string with characters
            SomeCountryDeparture = SomeCountryDeparture.PadRight(60, 'a');
            //invoke the method
            Error = ALocation.Valid(SomeCountryDeparture, SomeCountryDestination, SomeAirportDeparture, SomeAirportDestination);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CountryDestinationMinLessOne()
        {
            //create an instance of a class
            clsLocation ALocation = new clsLocation();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeCountryDestination = "Afric";
            //invoke the method
            Error = ALocation.Valid(SomeCountryDeparture, SomeCountryDestination, SomeAirportDeparture, SomeAirportDestination);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CountryDestinationMaxPlusOne()
        {
            //create an instance of a class
            clsLocation ALocation = new clsLocation();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeCountryDestination = "abcndefghijklmnopqrstuvwyzabcdefgdsasdfgh";
            //invoke the method
            Error = ALocation.Valid(SomeCountryDeparture, SomeCountryDestination, SomeAirportDeparture, SomeAirportDestination);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CountryDestinationExtremeMax()
        {
            //create an instance of a class
            clsLocation ALocation = new clsLocation();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeCountryDestination = "";
            //pad the string with characters
            SomeCountryDestination = SomeCountryDestination.PadRight(60, 'a');
            //invoke the method
            Error = ALocation.Valid(SomeCountryDeparture, SomeCountryDestination, SomeAirportDeparture, SomeAirportDestination);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AirportDepartureMinLessOne()
        {
            //create an instance of a class
            clsLocation ALocation = new clsLocation();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeCountryDestination = "Heath";
            //invoke the method
            Error = ALocation.Valid(SomeCountryDeparture, SomeCountryDestination, SomeAirportDeparture, SomeAirportDestination);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AirportDepartureMaxPlusOne()
        {
            //create an instance of a class
            clsLocation ALocation = new clsLocation();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeAirportDeparture = "abcndefghijklmnopqrstuvwyzabcdefgdsasdfgh";
            //invoke the method
            Error = ALocation.Valid(SomeCountryDeparture, SomeCountryDestination, SomeAirportDeparture, SomeAirportDestination);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AirportDepartureExtremeMax()
        {
            //create an instance of a class
            clsLocation ALocation = new clsLocation();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeAirportDeparture = "";
            //pad the string with characters
            SomeAirportDeparture = SomeAirportDeparture.PadRight(60, 'a');
            //invoke the method
            Error = ALocation.Valid(SomeCountryDeparture, SomeCountryDestination, SomeAirportDeparture, SomeAirportDestination);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AirportDestinationMinLessOne()
        {
            //create an instance of a class
            clsLocation ALocation = new clsLocation();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeAirportDestination = "gatew";
            //invoke the method
            Error = ALocation.Valid(SomeCountryDeparture, SomeCountryDestination, SomeAirportDeparture, SomeAirportDestination);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AirportDestinationMaxPlusOne()
        {
            //create an instance of a class
            clsLocation ALocation = new clsLocation();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeAirportDestination = "abcndefghijklmnopqrstuvwyzabcdefgdsasdfgh";
            //invoke the method
            Error = ALocation.Valid(SomeCountryDeparture, SomeCountryDestination, SomeAirportDeparture, SomeAirportDestination);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AirportDestinationExtremeMax()
        {
            //create an instance of a class
            clsLocation ALocation = new clsLocation();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeAirportDestination = "";
            //pad the string with characters
            SomeAirportDestination = SomeAirportDestination.PadRight(60, 'a');
            //invoke the method
            Error = ALocation.Valid(SomeCountryDeparture, SomeCountryDestination, SomeAirportDeparture, SomeAirportDestination);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
    }
}
