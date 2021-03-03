using System;
using System.Collections.Generic;

namespace FlightClasses
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        //public property for ThisCustomer
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        //constructor for the class




        //public property for the Customer List
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        //constructor for the class
        public clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record amount
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored proceedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                ACustomer.Phone = Convert.ToString(DB.DataTable.Rows[Index]["Phone"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.UserName = Convert.ToString(DB.DataTable.Rows[Index]["UserName"]);
                ACustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                ACustomer.PaymentID = Convert.ToString(DB.DataTable.Rows[Index]["PaymentID"]);
                ACustomer.PaymentType = Convert.ToString(DB.DataTable.Rows[Index]["PaymentType"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }

        }

        public int Add()
        {
            //adds a new record to the database based on the values of thiscustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored poceedure
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Phone", mThisCustomer.Phone);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@UserName", mThisCustomer.UserName);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@PaymentID", mThisCustomer.PaymentID);
            DB.AddParameter("@PaymentType", mThisCustomer.PaymentType);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");

        }

        public void Delete()
        {
            //deletes the record pointed to by ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proceedure
            DB.AddParameter("CustomerID", mThisCustomer.CustomerID);
            //execute the stored proceedure
            DB.Execute("sproc_tblCustomer_Delete");
        }
    }
}