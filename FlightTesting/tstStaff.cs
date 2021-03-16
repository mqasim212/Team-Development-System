using System;
using FlightClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlightTesting
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        //create some test data to pass to the method
        string SomeEmail = "Staff@outlook.com";
        string SomeName = "Anderson";
        string SomePassword = "1q2w3e4r5t";


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        //used to test the Staff ID property of the class
        public void StaffID()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to property
            Int32 StaffID = 1;
            //assign data to property
            AStaff.StaffID = StaffID;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(AStaff.StaffID, StaffID);
        }

        [TestMethod]
        //used to test the staff Email property of the class
        public void StaffEmail()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to property
            string SomeEmail = "Staff@outlook.com";
            //assign data to property
            AStaff.Email = SomeEmail;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(AStaff.Email, SomeEmail);
        }

        [TestMethod]
        //used to test the staff name property of the class
        public void StaffName()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to property
            string SomeName = "Anderson";
            //assign data to property
            AStaff.Name = SomeName;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(AStaff.Name, SomeName);
        }

        [TestMethod]
        //used to test the  Staff Password property of the class
        public void StaffPassword()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to property
            string SomePassword = "1q2w3e4r5t";
            //assign data to property
            AStaff.Password = SomePassword;
            //check to see the data in the variable and the property are the same
            Assert.AreEqual(AStaff.Password, SomePassword);
        }

        [TestMethod]
        //used to test the valid method of the class
        public void ValidMethod()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            Error = AStaff.Valid(SomeEmail, SomeName, SomePassword);
            //test to see the result is ok. i.e there was no error mssage returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMinLessOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeEmail = "q@a";
            //invoke the method
            Error = AStaff.Valid(SomeEmail, SomeName, SomePassword);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMaxPlusOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeEmail = "andrewsonantonasasa@outlook.com";
            //invoke the method
            Error = AStaff.Valid(SomeEmail, SomeName, SomePassword);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailExtremeMax()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeEmail = "";
            //pad the string with characters
            SomeEmail = SomeEmail.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(SomeEmail, SomeName, SomePassword);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinLessOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeName = "";
            //invoke the method
            Error = AStaff.Valid(SomeEmail, SomeName, SomePassword);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeName = "andrewsonantonas asao";
            //invoke the method
            Error = AStaff.Valid(SomeEmail, SomeName, SomePassword);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameExtremeMax()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomeName = "";
            //pad the string with characters
            SomeName = SomeName.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(SomeEmail, SomeName, SomePassword);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMinLessOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomePassword = "1q2w1";
            //invoke the method
            Error = AStaff.Valid(SomeEmail, SomeName, SomePassword);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMaxPlusOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomePassword = "andr6ews3910tonas6585";
            //invoke the method
            Error = AStaff.Valid(SomeEmail, SomeName, SomePassword);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordExtremeMax()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to test the method
            string SomePassword = "";
            //pad the string with characters
            SomePassword = SomePassword.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(SomeEmail, SomeName, SomePassword);
            //Test to see that the result is not ok. i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
    }
}

