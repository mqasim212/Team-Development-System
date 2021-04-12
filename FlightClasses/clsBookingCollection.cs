using System;
using System.Collections.Generic;

namespace FlightClasses
{
    public class clsBookingCollection
    {
        //private data member for the list
        List<clsBooking> mBookingList = new List<clsBooking>();
        //private data member for ThisBooking 
        clsBooking mThisBooking = new clsBooking();


        //public property for ThisBooking
        public clsBooking ThisBooking
        {
            get
            {
                //return the private data
                return mThisBooking;
            }
            set
            {
                //set the private data
                mThisBooking = value;
            }
        }

        //public property for the booking List
        public List<clsBooking> BookingList
        {
            get
            {
                //return the private data
                return mBookingList;
            }
            set
            {
                //set the private data
                mBookingList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mBookingList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //constructor for the class
        public clsBookingCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored proceedure
            DB.Execute("sproc_tblBooking_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);          
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mthisbooking
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proceedure
            DB.AddParameter("@BookingName", mThisBooking.BookingName);
            DB.AddParameter("@BookingDate", mThisBooking.BookingDate);
            DB.AddParameter("@BookingValidity", mThisBooking.BookingValidity);
            DB.AddParameter("@CustomerID", mThisBooking.CustomerID);
            DB.AddParameter("@StaffID", mThisBooking.StaffID);
            DB.AddParameter("@FlightID", mThisBooking.FlightID);
            //execute the stored proceedure
            return DB.Execute("sproc_tblBooking_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisbooking
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proceedure
            DB.AddParameter("@BookingID", mThisBooking.BookingID);
            //execute the stored proceedure
            DB.Execute("sproc_tblBooking_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisbooking
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proceedure
            DB.AddParameter("@BookingID", mThisBooking.BookingID);
            DB.AddParameter("@BookingName", mThisBooking.BookingName);
            DB.AddParameter("@BookingDate", mThisBooking.BookingDate);
            DB.AddParameter("@BookingValidity", mThisBooking.BookingValidity);
            DB.AddParameter("@CustomerID", mThisBooking.CustomerID);
            DB.AddParameter("@StaffID", mThisBooking.StaffID);
            DB.AddParameter("@FlightID", mThisBooking.FlightID);
            //execute the stored proceedure
            DB.Execute("sproc_tblBooking_Update");
        }

        public void ReportByBookingName(string BookingName)
        {
            //filters the records based on a full or partial booking name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the booking name parameter to the database
            DB.AddParameter("@BookingName", BookingName);
            //execute the stored proceedure
            DB.Execute("sproc_tblBooking_FilterByBookingName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter db
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of the records
            RecordCount = DB.Count;
            //clear the private array list
            mBookingList = new List<clsBooking>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank booking
                clsBooking ABooking = new clsBooking();
                //read in the fields from the current record
                ABooking.BookingID = Convert.ToInt32(DB.DataTable.Rows[Index]["BookingID"]);
                ABooking.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ABooking.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                ABooking.FlightID = Convert.ToInt32(DB.DataTable.Rows[Index]["FlightID"]);
                ABooking.BookingName = Convert.ToString(DB.DataTable.Rows[Index]["BookingName"]);
                ABooking.BookingDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["BookingDate"]);
                ABooking.BookingValidity = Convert.ToInt32(DB.DataTable.Rows[Index]["BookingValidity"]);
                //add the record to the private data member
                mBookingList.Add(ABooking);
                //point at the next record
                Index++;
            }
        }
    }
}