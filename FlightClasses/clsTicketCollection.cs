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
            //object fo the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored proceedure
            DB.Execute("sproc_tblTicket_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);

        }

        public int Add()
        {
            //adds a new record to the database based on the values of mthisticket
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proceedure
            DB.AddParameter("@TicketPurchaseDate", mThisTicket.TicketPurchaseDate);
            DB.AddParameter("@TicketNo", mThisTicket.TicketNo);
            DB.AddParameter("@FlightNo", mThisTicket.FlightNo);
            DB.AddParameter("@SeatNo", mThisTicket.SeatNo);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblTicket_Insert");
        }

        public void Delete()
        {
            //deletes the record pointd to by thisTicket
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proceedure
            DB.AddParameter("@TicketID", mThisTicket.TicketID);
            //execute the stored proceedure
            DB.Execute("sproc_tblTicket_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisTicket
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proceedure
            DB.AddParameter("@TicketID", mThisTicket.TicketID);
            DB.AddParameter("@TicketPurchaseDate", mThisTicket.TicketPurchaseDate);
            DB.AddParameter("@TicketNo", mThisTicket.TicketNo);
            DB.AddParameter("@FlightNo", mThisTicket.FlightNo);
            DB.AddParameter("@SeatNo", mThisTicket.SeatNo);
            //execute the stored proceedure
            DB.Execute("sproc_tblTicket_Update");
        }

        public void ReportByTicketNo(string TicketNo)
        {
            //filters the records based on a full or partial ticket no
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the ticket no parameter to the database
            DB.AddParameter("@TicketNo", TicketNo);
            //execute the stored proceedure
            DB.Execute("sproc_tblTicket_FilterByTicketNo");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mTicketList = new List<clsTicket>();
            //while there are records to process
             while (Index < RecordCount)
            {
                //create a blank ticket
                clsTicket ATicket = new clsTicket();
                //read in the fields from the current record
                ATicket.TicketID = Convert.ToInt32(DB.DataTable.Rows[Index]["TicketID"]);
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