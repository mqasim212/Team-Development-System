using System;

namespace FlightClasses
{
    public class clsPlane
    {
        //private data member for the plan id property
        private int mPlaneID;
        //private data member for the plane name
        private string mPlaneName;
        //private data member for the hours fly
        private int mHoursFly;
        //private data member for the locationid
        private int mLocationID;


        public bool Find(int PlaneID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the PlaneID to search for
            DB.AddParameter("@PlaneID", PlaneID);
            //execute the stored proceedure
            DB.Execute("sproc_tblPlane_FilterByPlaneID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                mPlaneID = Convert.ToInt32(DB.DataTable.Rows[0]["PlaneID"]);
                mPlaneName = Convert.ToString(DB.DataTable.Rows[0]["PlaneName"]);
                mHoursFly = Convert.ToInt32(DB.DataTable.Rows[0]["HoursFly"]);
                mLocationID = Convert.ToInt32(DB.DataTable.Rows[0]["LocationID"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found 
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    


        public string Valid(string somePlaneName, string someHoursFly)
        {
            //string variable to store the error message
            string Error = "";

            //if the  Plane Name is more than 25 characters
            if (somePlaneName.Length > 25)
            {
                //return an error message
                Error = Error + "The Plane Name name cannot have more than 25 characters";
            }
            if (somePlaneName.Length == 0 | somePlaneName.Length < 4)
            {
                //return an error message
                Error = Error + "The Plane Name may not be blank";
            }

            //if the  Hours Fly is more than 4 characters
            if (someHoursFly.Length > 4)
            {
                //return an error message
                Error = Error + "The Hours Fly name cannot have more than 4 characters";
            }
            if (someHoursFly.Length == 0 | someHoursFly.Length < 1)
            {
                //return an error message
                Error = Error + "The Hours Fly may not be blank";
            }

            return Error;
        }

        //public property for the PlaneID
        public int PlaneID
        {
            get
            {
                //return the private data
                return mPlaneID;
            }
            set
            {
                //set the value of the private data member
                mPlaneID = value;
            }
        }

        //public property for the PlaneName
        public string PlaneName
        {
            get
            {
                //return the private data
                return mPlaneName;
            }
            set
            {
                //set the value of the private data member
                mPlaneName = value;
            }
        }

        //public property for the HoursFly
        public int HoursFly
        {
            get
            {
                //return the private data
                return mHoursFly;
            }
            set
            {
                //set the value of the private data member
                mHoursFly = value;
            }
        }

        //public property for the HoursFly
        public int LocationID
        {
            get
            {
                //return the private data
                return mLocationID;
            }
            set
            {
                //set the value of the private data member
                mLocationID = value;
            }
        }


    }
}