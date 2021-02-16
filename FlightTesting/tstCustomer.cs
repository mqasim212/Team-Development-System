using System;
using FlightClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlightTesting
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstantiationOk()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
        }
        [TestMethod]
        //used to test the CustomerID property of the class
        public void CustomerID()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a variable to store the ID of a customer
            Int32 CustomerID;
            //assign a value to the variable
            CustomerID = 1;
            //try to send some data to the CustomerID property
            ACustomer.CustomerID = CustomerID;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(ACustomer.CustomerID, CustomerID);
        }
        [TestMethod]
        //used to test the name property of the class
        public void Name()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a variable to store the name of the person
            string SomeName;
            //assign a name to the variable
            SomeName = "Tommy";
            //try to send some data to the name property
            ACustomer.Name = SomeName;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(ACustomer.Name, SomeName);
        }
        [TestMethod]
        //used to test the phone property of the class
        public void Phone()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a variable to store the phone of a person
            Int32 Phone;
            //assign a value to the variable
            Phone = 0734642344;
            //try to send some data to the phone property
            ACustomer.Phone = Phone;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(ACustomer.Phone, Phone);
        }
        [TestMethod]
        //used to test the Email property of the class
        public void Email()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a variable to store the email of the person
            string SomeEmail;
            //assign a email to the variable
            SomeEmail = "OverAchievers@outlook.com";
            //try to send some data to the email property
            ACustomer.Email = SomeEmail;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(ACustomer.Email, SomeEmail);
        }
        [TestMethod]
        //used to test the UserName property of the class
        public void UserName()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a variable to store the username of the person
            string SomeUserName;
            //assign a username to the variable
            SomeUserName = "Tommy123";
            //try to send some data to the username property
            ACustomer.UserName = SomeUserName;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(ACustomer.UserName, SomeUserName);
        }
        [TestMethod]
        //used to test the Password property of the class
        public void Password()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a variable to store the name of the person
            string SomePassword;
            //assign a name to the variable
            SomePassword = "12133hrf43r";
            //try to send some data to the name property
            ACustomer.Password = SomePassword;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(ACustomer.Password, SomePassword);
        }
        [TestMethod]
        //used to test the PaymentID property of the class
        public void PaymentID()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a variable to store the PaymentID of the person
            string SomePaymentID;
            //assign a PaymentID to the variable
            SomePaymentID = "123asd";
            //try to send some data to the PaymentID property
            ACustomer.PaymentID = SomePaymentID;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(ACustomer.PaymentID, SomePaymentID);
        }
        [TestMethod]
        //used to test the PaymentType property of the class
        public void PaymentType()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a variable to store the PaymentType of the person
            string SomePaymentType;
            //assign a PaymentID to the variable
            SomePaymentType = "Debit Card";
            //try to send some data to the PaymentType property
            ACustomer.PaymentType = SomePaymentType;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(ACustomer.PaymentType, SomePaymentType);
        }
        [TestMethod]
        //used to test the PaymentID property of the class
        public void Valid()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //test to see if the valid method exists
            ACustomer.Valid("Abraham");
        }
        [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void NameMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Name = "";
            //invoke the method
            Error = ACustomer.Valid(Name);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void NameMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Name = "adammichealjonathanmb";
            //invoke the method
            Error = ACustomer.Valid(Name);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void NameExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Name = "";
            //pad the string with characters
            Name = Name.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(Name);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void PhoneMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Phone = "";
            //invoke the method
            Error = ACustomer.Valid(Phone);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void PhoneMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Phone = "67890776787978883";
            //invoke the method
            Error = ACustomer.Valid(Phone);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void PhoneExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Phone = "";
            //pad the string with characters
            Phone = Phone.PadRight(30, 'a');
            //invoke the method
            Error = ACustomer.Valid(Phone);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
         [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void EmailMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Email = "";
            //invoke the method
            Error = ACustomer.Valid(Email);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void EmailMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Email = "Adammichealjonathanmb@gmail.com";
            //invoke the method
            Error = ACustomer.Valid(Email);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void EmailExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Email = "";
            //pad the string with characters
            Email = Email.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(Email);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
    }
}
