using System;
using System.Collections.Generic;

namespace FlightClasses
{
    public class clsLocationCollection
    {
        //private data member for the list
        List<clsLocation> mLocationList = new List<clsLocation>();
        //private data member for thislocation
        clsLocation mThisLocation = new clsLocation();


        //public property for ThisLocation
        public clsLocation ThisLocation
        {
            get
            {
                //return the private data
                return mThisLocation;
            }
            set
            {
                //set the private data
                mThisLocation = value;
            }
        }

        //public property for the location List
        public List<clsLocation> LocationList
        {
            get
            {
                //return the private data
                return mLocationList;
            }
            set
            {
                //set the private data
                mLocationList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mLocationList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //constructor for the class
        public clsLocationCollection()
        {           
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored proceedure
            DB.Execute("sproc_tblLocation_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
            
        }

        public int Add()
        {
            //adds a new record to the database based on the value of thislocation
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proceedure
            DB.AddParameter("@CountryDeparture", mThisLocation.CountryDeparture);
            DB.AddParameter("@CountryDestination", mThisLocation.CountryDestination);
            DB.AddParameter("@AirportDeparture", mThisLocation.AirportDeparture);
            DB.AddParameter("@AirportDestination", mThisLocation.AirportDestination);
            DB.AddParameter("@PlaneID", mThisLocation.PlaneID);
            //execute the stored proceedure
            return DB.Execute("sproc_tblLocation_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thislocation
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proceedure
            DB.AddParameter("@LocationID", mThisLocation.LocationID);
            //execute the stored proceedure 
            DB.Execute("sproc_tblLocation_Delete");
        }

        public void Update()
        {
            //updates an existing record based on the value of thislocation
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proceedure
            DB.AddParameter("@LocationID", mThisLocation.LocationID);
            DB.AddParameter("@CountryDeparture", mThisLocation.CountryDeparture);
            DB.AddParameter("@CountryDestination", mThisLocation.CountryDestination);
            DB.AddParameter("@AirportDeparture", mThisLocation.AirportDeparture);
            DB.AddParameter("@AirportDestination", mThisLocation.AirportDestination);
            DB.AddParameter("@PlaneID", mThisLocation.PlaneID);
            //execute the stored proceedure
            DB.Execute("sproc_tblLocation_Update");
        }

        public void ReportByCountryDeparture(string CountryDeparture)
        {
            //filters the records based on a full or partial country of departure
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the country of departure parameter to the database
            DB.AddParameter("@CountryDeparture", CountryDeparture);
            //execute the stored proceedure
            DB.Execute("sproc_tblLocation_FilterByCountryDeparture");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            // var for the index 
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of the records
            RecordCount = DB.Count;
            //clear the private array list
            mLocationList = new List<clsLocation>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank location
                clsLocation ALocation = new clsLocation();
                //read in the fields from the current record
                ALocation.LocationID = Convert.ToInt32(DB.DataTable.Rows[Index]["LocationID"]);
                ALocation.PlaneID = Convert.ToInt32(DB.DataTable.Rows[Index]["PlaneID"]);
                ALocation.CountryDeparture = Convert.ToString(DB.DataTable.Rows[Index]["CountryDeparture"]);
                ALocation.CountryDestination = Convert.ToString(DB.DataTable.Rows[Index]["CountryDestination"]);
                ALocation.AirportDeparture = Convert.ToString(DB.DataTable.Rows[Index]["AirportDeparture"]);
                ALocation.AirportDestination = Convert.ToString(DB.DataTable.Rows[Index]["AirportDestination"]);
                //add the record to the private data member
                mLocationList.Add(ALocation);
                //point at the next record
                Index++;
            }
        }
    }
}