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
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        //used to test the CustomerID property of the class
        public void CustomerID()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to proprty
            Int32 CustomerID = 1;
            //assign data to property
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
            //create some test data to assign to proprty
            string SomeName = "Tommy";
            //assign data to property
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
            //create some test data to assign to proprty
            Int32 Phone = 0734642344;
            //assign data to property
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
            //create some test data to assign to proprty
            string SomeEmail = "OverAchievers@outlook.com";
            //assign data to property
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
            //create some test data to assign to proprty
            string SomeUserName = "Tommy123";
            //assign data to property
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
            //create some test data to assign to proprty
            string SomePassword = "12133hrf43r";
            //assign data to property
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
            //create some test data to assign to proprty
            string SomePaymentID = "123asd";
            //assign data to property
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
            //create some test data to assign to proprty
            string SomePaymentType = "Debit Card";
            //assign data to property
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
            //create a string variable to store the result of the validaation
            string Error = "";
            //create some test data to test the method
            string SomeCustomer = "Abraham";
            Error = ACustomer.Valid(SomeCustomer);
            //test to see the result is ok. i.e there was no error mssage returned
            Assert.AreEqual(Error, "");
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
        [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void UserNameMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "asd1";
            //create some test data to test the method
            string UserName = "";
            //invoke the method
            Error = ACustomer.Valid(UserName);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void UserNameMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string UserName = "Adammicheal12345";
            //invoke the method
            Error = ACustomer.Valid(UserName);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void UserNameExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string UserName = "";
            //pad the string with characters
            UserName = UserName.PadRight(40, 'a');
            //invoke the method
            Error = ACustomer.Valid(UserName);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void PasswordMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Password = "";
            //invoke the method
            Error = ACustomer.Valid(Password);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Password = "Adammichealqazxfvghc.";
            //invoke the method
            Error = ACustomer.Valid(Password);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void PasswordExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string Password = "";
            //pad the string with characters
            Password = Password.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(Password);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void PaymentIDMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string PaymentID = "";
            //invoke the method
            Error = ACustomer.Valid(PaymentID);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void PaymentIDMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string PaymentID = "Adamd3dg5g";
            //invoke the method
            Error = ACustomer.Valid(PaymentID);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void PaymentIDExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string PaymentID = "";
            //pad the string with characters
            PaymentID = PaymentID.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(PaymentID);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
    }
}
