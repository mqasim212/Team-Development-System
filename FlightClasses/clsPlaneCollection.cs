using System;
using System.Collections.Generic;

namespace FlightClasses
{
    public class clsPlaneCollection
    {
        //private data member for the list
        List<clsPlane> mPlaneList = new List<clsPlane>();
        //private data member for this plane
        clsPlane mThisPlane = new clsPlane();


        //public property for ThisPlane
        public clsPlane ThisPlane
        {
            get
            {
                //return the private data
                return mThisPlane;
            }
            set
            {
                //set the private data
                mThisPlane = value;
            }
        }

        //public property for the Plane List
        public List<clsPlane> PlaneList
        {
            get
            {
                //return the private data
                return mPlaneList;
            }
            set
            {
                //set the private data
                mPlaneList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mPlaneList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //constructor for the class
        public clsPlaneCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored proceedure
            DB.Execute("sproc_tblPlane_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisplane
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proceedure
            DB.AddParameter("@PlaneName", mThisPlane.PlaneName);
            DB.AddParameter("@HoursFly", mThisPlane.HoursFly);
            DB.AddParameter("@LocationID", mThisPlane.LocationID);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblPlane_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisplan
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proceedure
            DB.AddParameter("@PlaneID", mThisPlane.PlaneID);
            //execute the stored proceedure
            DB.Execute("sproc_tblPlane_Delete");
        }

        public void Update()
        {
            //update ab existing record based on the values of thisplane
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proceedure
            DB.AddParameter("@PlaneID", mThisPlane.PlaneID);
            DB.AddParameter("@LocationID", mThisPlane.LocationID);
            DB.AddParameter("@PlaneName", mThisPlane.PlaneName);
            DB.AddParameter("@HoursFly", mThisPlane.HoursFly);
            //execute the stored proceedure
            DB.Execute("sproc_tblPlane_Update");
        }

        public void ReportByPlaneName(string PlaneName)
        {
            //filters the records based on a partial or full plane name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the plane name parameter to the database
            DB.AddParameter("@PlaneName", PlaneName);
            //Execute the stored proceedure
            DB.Execute("sproc_tblPlane_FilterByPlaneName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            // populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mPlaneList = new List<clsPlane>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank plane
                clsPlane APlane = new clsPlane();
                //read in the fields from the current record
                APlane.PlaneID = Convert.ToInt32(DB.DataTable.Rows[Index]["PlaneID"]);
                APlane.LocationID = Convert.ToInt32(DB.DataTable.Rows[Index]["LocationID"]);
                APlane.PlaneName = Convert.ToString(DB.DataTable.Rows[Index]["PlaneName"]);
                APlane.HoursFly = Convert.ToInt32(DB.DataTable.Rows[Index]["HoursFly"]);
                //add the record to the private data member
                mPlaneList.Add(APlane);
                //point at the next record
                Index++;
            }
        }
    }
}
            


       

