using System;
using System.Collections.Generic;

namespace FlightClasses
{
    public class clsFlightCollection
    {
        //private data member for the list
        List<clsFlight> mFlightList = new List<clsFlight>();
        //private data member for mthisflight
        clsFlight mThisFlight = new clsFlight();


        //public property for Thisflight
        public clsFlight ThisFlight
        {
            get
            {
                //return the private data
                return mThisFlight;
            }
            set
            {
                //set the private data
                mThisFlight = value;
            }
        }

        //public property for the flight List
        public List<clsFlight> FlightList
        {
            get
            {
                //return the private data
                return mFlightList;
            }
            set
            {
                //set the private data
                mFlightList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mFlightList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //constructor for the class
        public clsFlightCollection()
        {                       
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored proceedure
            DB.Execute("sproc_tblFlight_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);           
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisFLIGHT
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proceedure
            DB.AddParameter("@DateOfBirth", mThisFlight.DateOfBirth);
            DB.AddParameter("@Gate", mThisFlight.Gate);
            DB.AddParameter("@DepartureDate", mThisFlight.DepartureDate);
            DB.AddParameter("@TicketID", mThisFlight.TicketID);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblFlight_Insert");
        }

        public void Delete()
        {
            //deletes the record pointd to by thisFLIGHT
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proceedure
            DB.AddParameter("@FlightID", mThisFlight.FlightID);
            //execute the stored proceedure
            DB.Execute("sproc_tblFlight_Delete");
        }

        public void Update()
        {
            //update an existing record basd on the value of thisFlight
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proceedure
            DB.AddParameter("@FlightID", mThisFlight.FlightID);
            DB.AddParameter("@DateOfBirth", mThisFlight.DateOfBirth);
            DB.AddParameter("@Gate", mThisFlight.Gate);
            DB.AddParameter("@DepartureDate", mThisFlight.DepartureDate);
            DB.AddParameter("@TicketID", mThisFlight.TicketID);
            //execute the stored proceedure
            DB.Execute("sproc_tblFlight_Update");
        }

        public void ReportByDateOfBirth(string DateOfBirth)
        {
            //filters the records based on a full or partial date of birth
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the date of birth parameter to the database
            DB.AddParameter("@DateOfBirth", DateOfBirth);
            //execute the stored proceedure
            DB.Execute("sproc_tblFlight_FilterByDateOfBirth");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mFlightList = new List<clsFlight>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank flight
                clsFlight AFlight = new clsFlight();
                //read in the fields from the current record
                AFlight.FlightID = Convert.ToInt32(DB.DataTable.Rows[Index]["FlightID"]);
                AFlight.TicketID = Convert.ToInt32(DB.DataTable.Rows[Index]["TicketID"]);
                AFlight.DateOfBirth = Convert.ToString(DB.DataTable.Rows[Index]["DateOfBirth"]);
                AFlight.Gate = Convert.ToString(DB.DataTable.Rows[Index]["Gate"]);
                AFlight.DepartureDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["DepartureDate"]);
                //add the record to the private data member
                mFlightList.Add(AFlight);
                //point at the next record
                Index++;
            }
        }
    }
}
