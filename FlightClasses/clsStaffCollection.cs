using System;
using System.Collections.Generic;

namespace FlightClasses
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisStaff
        clsStaff mThisStaff = new clsStaff();


        //public property for ThisStaff
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        //public property for the Staff List
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //constructor for the class
        public clsStaffCollection()
        {

            clsDataConnection DB = new clsDataConnection();
            //execute the stored proceedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisstaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proceedure
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@Password", mThisStaff.Password);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proceedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            //execute the stored proceedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            //Update a new record to the database based on the values of thiscustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored poceedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@Password", mThisStaff.Password);
            //execute the stored proceedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public void ReportByName(string Name)
        {
            //filters the record based on a full or partial name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the name parameter to the database
            DB.AddParameter("@Name", Name);
            //execute the stored proceedure
            DB.Execute("sproc_tblStaff_FilterByName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AStaff.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AStaff.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        }
    }
}