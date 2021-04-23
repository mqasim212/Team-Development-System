using System;

namespace FlightClasses
{
    public class clsFlight
    {
        //private data member for the flight id property
        private int mFlightID;
        //private data member for the date of birth
        private string mDateOfBirth;
        //private data member for the gate
        private string mGate;
        //private data member for the departure date
        private DateTime mDepartureDate;
        //private data member for the ticket id
        private int mTicketID;

        public bool Find(int FlightID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the flight id to search for
            DB.AddParameter("@FlightID", FlightID);
            //execute the stored proceedure
            DB.Execute("sproc_tblFlight_FilterByFlightID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mFlightID = Convert.ToInt32(DB.DataTable.Rows[0]["FlightID"]);
                mDateOfBirth = Convert.ToString(DB.DataTable.Rows[0]["DateOfBirth"]);
                mGate = Convert.ToString(DB.DataTable.Rows[0]["Gate"]);
                mDepartureDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DepartureDate"]);
                mTicketID = Convert.ToInt32(DB.DataTable.Rows[0]["TicketID"]);
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


        public string Valid(string someDateOfBirth, string someGate, string someDepartureDate)
        {
            //string variable to store the error message
            string Error = "";

            //create a temporary variable to store the date values
            DateTime DateTemp;

            //if the  DateOfBirth is more than 18 characters
            if (someDateOfBirth.Length > 18)
            {
                //return an error message
                Error = Error + "The DateOfBirth name cannot have more than 18 characters";
            }
            if (someDateOfBirth.Length == 0 | someDateOfBirth.Length < 8)
            {
                //return an error message
                Error = Error + "The DateOfBirth may not be blank";
            }

            //if the  Gate is more than 5 characters
            if (someGate.Length > 5)
            {
                //return an error message
                Error = Error + "The Gate name cannot have more than 5 characters";
            }
            if (someGate.Length == 0 | someGate.Length < 2)
            {
                //return an error message
                Error = Error + "The Gate may not be blank";
            }

            try
            {
                //copy the ticket purchase date value to the datetemp variable
                DateTemp = Convert.ToDateTime(someDepartureDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    // record the error
                    Error = Error + "The date Cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    // record the error
                    Error = Error + "The date Cannot be in the future : ";
                }
            }
            catch
            {
                // record the error
                Error = Error + "the date was not a valid date : ";
            }

            return Error;
        }

        //public property for the FlightID
        public int FlightID
        {
            get
            {
                //return the private data
                return mFlightID;
            }
            set
            {
                //set the value of the private data member
                mFlightID = value;
            }
        }

        //public property for the DateOfBirth
        public string DateOfBirth
        {
            get
            {
                //return the private data
                return mDateOfBirth;
            }
            set
            {
                //set the value of the private data member
                mDateOfBirth = value;
            }
        }

        //public property for the Gate
        public string Gate
        {
            get
            {
                //return the private data
                return mGate;
            }
            set
            {
                //set the value of the private data member
                mGate = value;
            }
        }

        //public property for the DepartureDate
        public DateTime DepartureDate
        {
            get
            {
                //return the private data
                return mDepartureDate;
            }
            set
            {
                //set the value of the private data member
                mDepartureDate = value;
            }
        }

        //public property for the TicketID
        public int TicketID
        {
            get
            {
                //return the private data
                return mTicketID;
            }
            set
            {
                //set the value of the private data member
                mTicketID = value;
            }
        }


    }
}