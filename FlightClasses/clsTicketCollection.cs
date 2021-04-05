using System;
using System.Collections.Generic;

namespace FlightClasses
{
    public class clsTicketCollection
    {
        //private data member for the list
        List<clsTicket> mTicketList = new List<clsTicket>();
        //private data member for ThisTicket
        clsTicket mThisTicket = new clsTicket();

        //public property for Thisticket
        public clsTicket ThisTicket
        {
            get
            {
                //return the private data
                return mThisTicket;
            }
            set
            {
                //set the private data
                mThisTicket = value;
            }
        }

        //public property for the ticket List
        public List<clsTicket> TicketList
        {
            get
            {
                //return the private data
                return mTicketList;
            }
            set
            {
                //set the private data
                mTicketList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mTicketList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //constructor for the class
        public clsTicketCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object fo the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored proceedure
            DB.Execute("sproc_tblTicket_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank ticket
                clsTicket ATicket = new clsTicket();
                //read in the fields from the current record
                ATicket.TicketID = Convert.ToInt32(DB.DataTable.Rows[Index]["TicketID"]);
                ATicket.FlightID = Convert.ToInt32(DB.DataTable.Rows[Index]["FlightID"]);
                ATicket.TicketPurchaseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["TicketPurchaseDate"]);
                ATicket.TicketNo = Convert.ToString(DB.DataTable.Rows[Index]["TicketNo"]);
                ATicket.FlightNo = Convert.ToInt32(DB.DataTable.Rows[Index]["FlightNo"]);
                ATicket.SeatNo = Convert.ToString(DB.DataTable.Rows[Index]["SeatNo"]);
                //add the record to the private data member
                mTicketList.Add(ATicket);
                //point at the next record
                Index++;
            }
           
        }
    }
}