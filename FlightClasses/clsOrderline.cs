using System;

namespace FlightClasses
{
    public class clsOrderline
    {
        //private data member for the OrderlineID property
        private Int32 mOrderlineID;
        //private data member for the BookingNo property
        private string mBookingNo;
        //private data member for the quantity property
        private Int32 mQuantity;
        //private data member for the bookingID property
        private Int32 mBookingID;


        public bool Find(int OrderlineID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Orderline ID to search for
            DB.AddParameter("@OrderlineID", OrderlineID);
            //execute the stored proceedure
            DB.Execute("sproc_tblOrderline_FilterByOrderlineID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                mOrderlineID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderlineID"]);
                mBookingNo = Convert.ToString(DB.DataTable.Rows[0]["BookingNo"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mBookingID = Convert.ToInt32(DB.DataTable.Rows[0]["BookingID"]);
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


        public string Valid(string someBookingNo, string someQuantity)
        {
            //string variable to store the error message
            string Error = "";

            //if the  BookingNo is more than 30 characters
            if (someBookingNo.Length > 5)
            {
                //return an error message
                Error = Error + "The booking number cannot have more than 5 characters";
            }
            if (someBookingNo.Length == 0 | someBookingNo.Length < 1)
            {
                //return an error message
                Error = Error + "The booking number may not be blank";
            }

            //if the  quantity is more than 30 characters
            if (someQuantity.Length > 5)
            {
                //return an error message
                Error = Error + "The quantity number cannot have more than 5 characters";
            }
            if (someQuantity.Length == 0 | someQuantity.Length < 1)
            {
                //return an error message
                Error = Error + "The quantity number may not be blank";
            }
            return Error;
        }

        //public property for the OrderlineID
        public int OrderlineID
        {
            get
            {
                //return the private data
                return mOrderlineID;
            }
            set
            {
                //set the value of the private data member
                mOrderlineID = value;
            }
        }

        //public property for the BookingNo
        public string BookingNo
        {
            get
            {
                //return the private data
                return mBookingNo;
            }
            set
            {
                //set the value of the private data member
                mBookingNo = value;
            }
        }

        //public property for the Quantity
        public int Quantity
        {
            get
            {
                //return the private data
                return mQuantity;
            }
            set
            {
                //set the value of the private data member
                mQuantity = value;
            }
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
    }
}
