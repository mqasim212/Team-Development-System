using System;

namespace FlightClasses
{
    public class clsLocation
    {
        //private data member for the LocationID
        private int mLocationID;
        //private data member for the CountryDeparture
        private string mCountryDeparture;
        //private data member for the CountryDestination
        private string mCountryDestination;
        //private data member for the AirportDeparture
        private string mAirportDeparture;
        //private data member for the airportDestination
        private string mAirportDestination;
        //private data member for the PlaneID
        private int mPlaneID;

        public bool Find(int LocationID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the LocationID to search for
            DB.AddParameter("@LocationID", LocationID);
            //execute the stored proceedure
            DB.Execute("sproc_tblLocation_FilterByLocationID");
            //if one record is found (there should be one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mLocationID = Convert.ToInt32(DB.DataTable.Rows[0]["LocationID"]);
                mCountryDeparture = Convert.ToString(DB.DataTable.Rows[0]["CountryDeparture"]);
                mCountryDestination = Convert.ToString(DB.DataTable.Rows[0]["CountryDestination"]);
                mAirportDeparture = Convert.ToString(DB.DataTable.Rows[0]["AirportDeparture"]);
                mAirportDestination = Convert.ToString(DB.DataTable.Rows[0]["AirportDestination"]);
                mPlaneID = Convert.ToInt32(DB.DataTable.Rows[0]["PlaneID"]);
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


        public string Valid(string someCountryDeparture, string someCountryDestination, string someAirportDeparture, string someAirportDestination)
        {
            //string variable to store the error message
            string Error = "";

            //if the  Country of Departure is more than 40 characters
            if (someCountryDeparture.Length > 40)
            {
                //return an error message
                Error = Error + "The Country of Departure name cannot have more than 40 characters";
            }
            if (someCountryDeparture.Length == 0 | someCountryDeparture.Length < 6)
            {
                //return an error message
                Error = Error + "The Country of Departure may not be blank";
            }


            //if the  Country of Destination is more than 40 characters
            if (someCountryDestination.Length > 40)
            {
                //return an error message
                Error = Error + "The Country of Destination name cannot have more than 40 characters";
            }
            if (someCountryDestination.Length == 0 | someCountryDestination.Length < 6)
            {
                //return an error message
                Error = Error + "The Country of Destination may not be blank";
            }


            //if the  Airport of Departure is more than 40 characters
            if (someAirportDeparture.Length > 40)
            {
                //return an error message
                Error = Error + "The Airport of Departure name cannot have more than 40 characters";
            }
            if (someAirportDeparture.Length == 0 | someAirportDeparture.Length < 6)
            {
                //return an error message
                Error = Error + "The Airport of Departure may not be blank";
            }


            //if the  Airport of Destination is more than 40 characters
            if (someAirportDestination.Length > 40)
            {
                //return an error message
                Error = Error + "The Airport of Destination name cannot have more than 40 characters";
            }
            if (someAirportDestination.Length == 0 | someAirportDestination.Length < 6)
            {
                //return an error message
                Error = Error + "The Airport of Destination may not be blank";
            }

            return Error;
        }

        //public property for the LocationID
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

        //public property for the CountryDeparture
        public string CountryDeparture
        {
            get
            {
                //return the private data
                return mCountryDeparture;
            }
            set
            {
                //set the value of the private data member
                mCountryDeparture = value;
            }
        }

        //public property for the CountryDestination
        public string CountryDestination
        {
            get
            {
                //return the private data
                return mCountryDestination;
            }
            set
            {
                //set the value of the private data member
                mCountryDestination = value;
            }
        }

        //public property for the AirportDeparture
        public string AirportDeparture
        {
            get
            {
                //return the private data
                return mAirportDeparture;
            }
            set
            {
                //set the value of the private data member
                mAirportDeparture = value;
            }
        }

        //public property for the AirportDestination
        public string AirportDestination
        {
            get
            {
                //return the private data
                return mAirportDestination;
            }
            set
            {
                //set the value of the private data member
                mAirportDestination = value;
            }
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


    }
}