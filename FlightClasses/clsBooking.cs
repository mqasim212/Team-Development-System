using System;

namespace FlightClasses
{
    public class clsBooking
    {
        //private data member for the booking id property
        private Int32 mBookingID;
        //private data member for the booking number property
        private string mBookingName;
        //private data member for the booking date
        private DateTime mBookingDate;
        //private data member for the booking validity
        private Int32 mBookingValidity;
        //private data member for the customer id property
        private Int32 mCustomerID;
        //private data member for the staff id property
        private Int32 mStaffID;
        //private data member for the flight id property
        private Int32 mFlightID;

        public bool Find(int BookingID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the booking id to search for
            DB.AddParameter("@BookingID", BookingID);
            //execute the stored proceedure
            DB.Execute("sproc_tblBooking_FilterByBookingID");
            //if one record is found (there should be one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mBookingID = Convert.ToInt32(DB.DataTable.Rows[0]["BookingID"]);
                mBookingName = Convert.ToString(DB.DataTable.Rows[0]["BookingName"]);
                mBookingDate = Convert.ToDateTime(DB.DataTable.Rows[0]["BookingDate"]);
                mBookingValidity = Convert.ToInt32(DB.DataTable.Rows[0]["BookingValidity"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mFlightID = Convert.ToInt32(DB.DataTable.Rows[0]["FlightID"]);
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


        public string Valid(string someBookingName, string someBookingDate, string someBookingValidity)
        {
            //string variable to store the error message
            string Error = "";

            //create a temporary variable to store the date values
            DateTime DateTemp;

            //if the  BookingName is more than 20 characters
            if (someBookingName.Length > 20)
            {
                //return an error message
                Error = Error + "The Booking name cannot have more than 20 characters";
            }
            if (someBookingName.Length == 0 | someBookingName.Length < 1)
            {
                //return an error message
                Error = Error + "The booking name may not be blank";
            }


            try
            {
                //copy the booking date value to the datetemp variable
                DateTemp = Convert.ToDateTime(someBookingDate);
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

            //if the  Bookingvalidity is more than 5 characters
            if (someBookingValidity.Length > 5)
            {
                //return an error message
                Error = Error + "The Booking name cannot have more than 5 characters";
            }
            if (someBookingValidity.Length == 0 | someBookingValidity.Length < 1)
            {
                //return an error message
                Error = Error + "The booking name may not be blank";
            }

            //return any error messages
            return Error;
        }

        //public property for the BookingID
        public int BookingID
        {
            get
            {
                //return the private data
                return mBookingID;
            }
            set
            {
                //set the value of the private data member
                mBookingID = value;
            }
        }

        //public property for the Booking name
        public string BookingName
        {
            get
            {
                //return the private data
                return mBookingName;
            }
            set
            {
                //set the value of the private data member
                mBookingName = value;
            }
        }

        //public property for the Booking Date
        public DateTime BookingDate
        {
            get
            {
                //return the private data
                return mBookingDate;
            }
            set
            {
                //set the value of the private data member
                mBookingDate = value;
            }
        }

        //public property for the Booking validity
        public int BookingValidity
        {
            get
            {
                //return the private data
                return mBookingValidity;
            }
            set
            {
                //set the value of the private data member
                mBookingValidity = value;
            }
        }

        //public property for the customerid
        public int CustomerID
        {
            get
            {
                //return the private data
                return mCustomerID;
            }
            set
            {
                //set the value of the private data member
                mCustomerID = value;
            }
        }

        //public property for the staffid
        public int StaffID
        {
            get
            {
                //return the private data
                return mStaffID;
            }
            set
            {
                //set the value of the private data member
                mStaffID = value;
            }
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
    }
}
