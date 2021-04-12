using System;

namespace FlightClasses
{
    public class clsTicket
    {
        //private data member for the TicketID property
        private int mTicketID;
        //private data member for the ticket purchase date
        private DateTime mTicketPurchaseDate;
        ////private data member for the ticket no
        private string mTicketNo;
        ////private data member for the flight no
        private int mFlightNo;
        ////private data member for the seat no
        private string mSeatNo;


        public bool Find(int TicketID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the ticket id to search for
            DB.AddParameter("@TicketID", TicketID);
            //execute the stored proceedure
            DB.Execute("sproc_tblTicket_FilterByTicketID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mTicketID = Convert.ToInt32(DB.DataTable.Rows[0]["TicketID"]);
                mTicketPurchaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["TicketPurchaseDate"]);
                mTicketNo = Convert.ToString(DB.DataTable.Rows[0]["TicketNo"]);
                mFlightNo = Convert.ToInt32(DB.DataTable.Rows[0]["FlightNo"]);
                mSeatNo = Convert.ToString(DB.DataTable.Rows[0]["SeatNo"]);
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


        public string Valid(string someTicketPurchaseDate, string someTicketNo, string someFlightNo, string someSeatNo)
        {
            //string variable to store the error message
            string Error = "";

            //create a temporary variable to store the date values
            DateTime DateTemp;

            //if the  ticket no is more than 8 characters
            if (someTicketNo.Length > 8)
            {
                //return an error message
                Error = Error + "The Ticket No name cannot have more than 8 characters";
            }
            if (someTicketNo.Length == 0 | someTicketNo.Length < 4)
            {
                //return an error message
                Error = Error + "The Ticket No may not be blank";
            }

            //if the  Flight no is more than 5 characters
            if (someFlightNo.Length > 5)
            {
                //return an error message
                Error = Error + "The Flight No name cannot have more than 5 characters";
            }
            if (someFlightNo.Length == 0 | someFlightNo.Length < 1)
            {
                //return an error message
                Error = Error + "The Flight No may not be blank";
            }

            //if the  Seat no is more than 5 characters
            if (someSeatNo.Length > 5)
            {
                //return an error message
                Error = Error + "The Seat No name cannot have more than 5 characters";
            }
            if (someSeatNo.Length == 0 | someSeatNo.Length < 2)
            {
                //return an error message
                Error = Error + "The Seat No may not be blank";
            }

            try
            {
                //copy the ticket purchase date value to the datetemp variable
                DateTemp = Convert.ToDateTime(someTicketPurchaseDate);
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

            //return any error messages
            return Error;
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

        //public property for the TicketPurchaseDate
        public DateTime TicketPurchaseDate
        {
            get
            {
                //return the private data
                return mTicketPurchaseDate;
            }
            set
            {
                //set the value of the private data member
                mTicketPurchaseDate = value;
            }
        }

        //public property for the TicketNo
        public string TicketNo
        {
            get
            {
                //return the private data
                return mTicketNo;
            }
            set
            {
                //set the value of the private data member
                mTicketNo = value;
            }
        }

        //public property for the FlightNo
        public int FlightNo
        {
            get
            {
                //return the private data
                return mFlightNo;
            }
            set
            {
                //set the value of the private data member
                mFlightNo = value;
            }
        }


        //public property for the SeatNo
        public string SeatNo
        {
            get
            {
                //return the private data
                return mSeatNo;
            }
            set
            {
                //set the value of the private data member
                mSeatNo = value;
            }
        }
    }
}