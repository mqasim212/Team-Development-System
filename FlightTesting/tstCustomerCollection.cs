using System;
using FlightClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace FlightTesting
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerList()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.Name = "Tommy";
            TestItem.Phone = "0734642344";
            TestItem.Email = "OverAchievers@outlook.com";
            TestItem.Username = "Tommy123";
            TestItem.Password = "12133hrf43r";
            TestItem.PaymentID = "123asd";
            TestItem.PaymentType = "Debit Card";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerProperty()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.CustomerID = 1;
            TestCustomer.Name = "Tommy";
            TestCustomer.Phone = "0734642344";
            TestCustomer.Email = "OverAchievers@outlook.com";
            TestCustomer.Username = "Tommy123";
            TestCustomer.Password = "12133hrf43r";
            TestCustomer.PaymentID = "123asd";
            TestCustomer.PaymentType = "Debit Card";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void ListAndCount()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.Name = "Tommy";
            TestItem.Phone = "0734642344";
            TestItem.Email = "OverAchievers@outlook.com";
            TestItem.Username = "Tommy123";
            TestItem.Password = "12133hrf43r";
            TestItem.PaymentID = "123asd";
            TestItem.PaymentType = "Debit Card";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethod()
        {
            //create and instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.Name = "Tommy";
            TestItem.Phone = "0734642344";
            TestItem.Email = "OverAchievers@outlook.com";
            TestItem.Username = "Tommy123";
            TestItem.Password = "12133hrf43r";
            TestItem.PaymentID = "123asd";
            TestItem.PaymentType = "Debit Card";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void DeleteMethod()
        {
            //create and instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.Name = "Tommy";
            TestItem.Phone = "0734642344";
            TestItem.Email = "OverAchievers@outlook.com";
            TestItem.Username = "Tommy123";
            TestItem.Password = "12133hrf43r";
            TestItem.PaymentID = "123asd";
            TestItem.PaymentType = "Debit Card";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethod()
        {
            //create and instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Name = "Tommy";
            TestItem.Phone = "0734642344";
            TestItem.Email = "OverAchievers@outlook.com";
            TestItem.Username = "Tommy123";
            TestItem.Password = "12133hrf43r";
            TestItem.PaymentID = "123asd";
            TestItem.PaymentType = "Debit Card";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            TestItem.Name = "Tommy Luke";
            TestItem.Phone = "0734642355";
            TestItem.Email = "OverAchiever@outlook.com";
            TestItem.Username = "Tommy145";
            TestItem.Password = "12188hrf43r";
            TestItem.PaymentID = "123ssc";
            TestItem.PaymentType = "Credit Card";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see thisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void ReportByNameMethod()
        {
            //create and instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredCustomers.ReportByName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportByNameNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a name that doesnt exist
            FilteredCustomers.ReportByName("XXXXX");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a name that does not exist
            FilteredCustomers.ReportByName("Gabriel");
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //Check that the first record is ID 46
                if (FilteredCustomers.CustomerList[0].CustomerID != 46)
                {
                    OK = false;
                }
                //Check that the first record is ID 48
                if (FilteredCustomers.CustomerList[1].CustomerID != 48)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no record
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FindMethod()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 87;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see that the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 87;
            //ivoke the method
            Found = ACustomer.Find(CustomerID);
            //Check the Customer ID
            if (ACustomer.CustomerID != 87)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 87;
            //ivoke the method
            Found = ACustomer.Find(CustomerID);
            //Check the Customer ID
            if (ACustomer.Name != "test")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 87;
            //ivoke the method
            Found = ACustomer.Find(CustomerID);
            //Check the Customer ID
            if (ACustomer.Phone != "444555444")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 87;
            //ivoke the method
            Found = ACustomer.Find(CustomerID);
            //Check the Customer ID
            if (ACustomer.Email != "test")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUsernameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 87;
            //ivoke the method
            Found = ACustomer.Find(CustomerID);
            //Check the Customer ID
            if (ACustomer.Username != "test12")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 87;
            //ivoke the method
            Found = ACustomer.Find(CustomerID);
            //Check the Customer ID
            if (ACustomer.Password != "test12")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 87;
            //ivoke the method
            Found = ACustomer.Find(CustomerID);
            //Check the Customer ID
            if (ACustomer.PaymentID != "test12")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentTypeFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 87;
            //ivoke the method
            Found = ACustomer.Find(CustomerID);
            //Check the Customer ID
            if (ACustomer.PaymentType != "test card")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}


