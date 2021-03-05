using System;
using FlightClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlightTesting
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create sine test data to pass to the method
        string SomeName = "Abraham";
        string SomePhone = "04855434542";
        string SomeEmail = "OverAchievers@outlook.com";
        string SomeUsername = "Tommy123";
        string SomePassword = "12133hrf43r";
        string SomePaymentID = "123asd";
        string SomePaymentType = "Debit Card";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        //used to test the name property of the class
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
            string SomePhone = "0734642344";
            //assign data to property
            ACustomer.Phone = SomePhone;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(ACustomer.Phone, SomePhone);
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
            string SomeUsername = "Tommy123";
            //assign data to property
            ACustomer.Username = SomeUsername;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(ACustomer.Username, SomeUsername);
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
            Error = ACustomer.Valid(SomeName,SomePhone,SomeEmail,SomeUsername,SomePassword,SomePaymentID, SomePaymentType);
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
            string SomeName = "";
            //invoke the method
            Error = ACustomer.Valid(SomeName, SomePhone, SomeEmail, SomeUsername, SomePassword, SomePaymentID, SomePaymentType);
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
            string SomeName = "adammichealjonathanmb";
            //invoke the method
            Error = ACustomer.Valid(SomeName, SomePhone, SomeEmail, SomeUsername, SomePassword, SomePaymentID, SomePaymentType);
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
            string SomeName = "";
            //pad the string with characters
            SomeName = SomeName.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(SomeName, SomePhone, SomeEmail, SomeUsername, SomePassword, SomePaymentID, SomePaymentType);
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
            string SomePhone = "";
            //invoke the method
            Error = ACustomer.Valid(SomeName, SomePhone, SomeEmail, SomeUsername, SomePassword, SomePaymentID, SomePaymentType);
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
            string SomePhone = "474857374580";
            //invoke the method
            Error = ACustomer.Valid(SomeName, SomePhone, SomeEmail, SomeUsername, SomePassword, SomePaymentID, SomePaymentType);
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
            string SomePhone = "";
            //pad the string with characters
            SomePhone = SomePhone.PadRight(30, 'a');
            //invoke the method
            Error = ACustomer.Valid(SomeName, SomePhone, SomeEmail, SomeUsername, SomePassword, SomePaymentID, SomePaymentType);
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
            string SomeEmail = "a@r";
            //invoke the method
            Error = ACustomer.Valid(SomeName, SomePhone, SomeEmail, SomeUsername, SomePassword, SomePaymentID, SomePaymentType);
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
            string SomeEmail = "Adammichealjonathanmb@gmail.com";
            //invoke the method
            Error = ACustomer.Valid(SomeName, SomePhone, SomeEmail, SomeUsername, SomePassword, SomePaymentID, SomePaymentType);
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
            string SomeEmail = "";
            //pad the string with characters
            SomeEmail = SomeEmail.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(SomeName, SomePhone, SomeEmail, SomeUsername, SomePassword, SomePaymentID, SomePaymentType);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void UsernameMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "asd1";
            //create some test data to test the method
            string SomeUsername = "df34";
            //invoke the method
            Error = ACustomer.Valid(SomeName, SomePhone, SomeEmail, SomeUsername, SomePassword, SomePaymentID, SomePaymentType);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void UsernameMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeUsername = "Adammicheal12345";
            //invoke the method
            Error = ACustomer.Valid(SomeName, SomePhone, SomeEmail, SomeUsername, SomePassword, SomePaymentID, SomePaymentType);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void UsernameExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeUsername = "";
            //pad the string with characters
            SomeUsername = SomeUsername.PadRight(40, 'a');
            //invoke the method
            Error = ACustomer.Valid(SomeName, SomePhone, SomeEmail, SomeUsername, SomePassword, SomePaymentID, SomePaymentType);
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
            string SomePassword = "12345";
            //invoke the method
            Error = ACustomer.Valid(SomeName, SomePhone, SomeEmail, SomeUsername, SomePassword, SomePaymentID, SomePaymentType);
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
            string SomePassword = "Adammichealqazxfvghca";
            //invoke the method
            Error = ACustomer.Valid(SomeName, SomePhone, SomeEmail, SomeUsername, SomePassword, SomePaymentID, SomePaymentType);
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
            string SomePassword = "";
            //pad the string with characters
            SomePassword = SomePassword.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(SomeName, SomePhone, SomeEmail, SomeUsername, SomePassword, SomePaymentID, SomePaymentType);
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
            string SomePaymentID = "";
            //invoke the method
            Error = ACustomer.Valid(SomeName, SomePhone, SomeEmail, SomeUsername, SomePassword, SomePaymentID, SomePaymentType);
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
            string SomePaymentID = "Adamd3dg5g";
            //invoke the method
            Error = ACustomer.Valid(SomeName, SomePhone, SomeEmail, SomeUsername, SomePassword, SomePaymentID, SomePaymentType);
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
            string SomePaymentID = "";
            //pad the string with characters
            SomePaymentID = SomePaymentID.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(SomeName, SomePhone, SomeEmail, SomeUsername, SomePassword, SomePaymentID, SomePaymentType);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void PaymentTypeMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomePaymentType = "credit ca";
            //invoke the method
            Error = ACustomer.Valid(SomeName, SomePhone, SomeEmail, SomeUsername, SomePassword, SomePaymentID, SomePaymentType);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void PaymentTypeMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomePaymentType = "Debit transactio";
            //invoke the method
            Error = ACustomer.Valid(SomeName, SomePhone, SomeEmail, SomeUsername, SomePassword, SomePaymentID, SomePaymentType);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        //test that the customer validation throws an error when customer is blank
        public void PaymentTypeExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomePaymentType = "";
            //pad the string with characters
            SomePaymentType = SomePaymentType.PadRight(40, 'a');
            //invoke the method
            Error = ACustomer.Valid(SomeName, SomePhone, SomeEmail, SomeUsername, SomePassword, SomePaymentID, SomePaymentType);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
    }
}
