using System;

namespace FlightClasses
{
    public class clsTicket
    {
        public int TicketID { get; set; }
        public DateTime TicketPurchaseDate { get; set; }
        public string TicketNo { get; set; }
        public int FlightNo { get; set; }
        public string SeatNo { get; set; }
        public int FlightID { get; set; }

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
    }
}