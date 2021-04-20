using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlightClasses
{
    public class clsCustomer
    {
        //private data member for the CustomerID property
        private Int32 mCustomerID;
        //private data member for the Name property
        private string mName;
        //private data member for the Phone property
        private string mPhone;
        //private data member for the Email property
        private string mEmail;
        //private data member for the Username property
        private string mUsername;
        //private data member for the Password property
        private string mPassword;
        //private data member for the PaymentID property
        private string mPaymentID;
        //private data member for the PaymentType property
        private string mPaymentType;

        public bool Find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the CustomerID to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored proceedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mPhone = Convert.ToString(DB.DataTable.Rows[0]["Phone"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mPaymentID = Convert.ToString(DB.DataTable.Rows[0]["PaymentID"]);
                mPaymentType = Convert.ToString(DB.DataTable.Rows[0]["PaymentType"]);
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




        public string Valid(string someName, string somePhone, string someEmail, string someUsername, string somePassword, string somePaymentID, string somePaymentType)
        {
            //string variable to store the error message
            string Error = "";

            //if the name of the customer is more than 20 characters
            if (someName.Length > 20)
            {
                //return an error message
                Error = Error + "The customer name cannot have more than 20 characters";
            }
            if (someName.Length == 0 | someName.Length < 1)
            {
                //return an error message
                Error = Error + "The customer name may not be blank";
            }
            //if the  Phone Number is more than 11 characters
            if (somePhone.Length > 11)
            {
                //return an error message
                Error = Error + "The Phone Number cannot have more than 11 characters";
            }
            if (somePhone.Length == 0 | somePhone.Length <8)
            {
                //return an error message
                Error = Error + "The Phone Number may not be blank";
            }
            //if the Email is more than 30 characters
            if (someEmail.Length > 30)
            {
                //return an error message
                Error = Error + "The email cannot have more than 30 characters";
            }
            if (someEmail.Length == 0 | someEmail.Length < 4)
            {
                //return an error message
                Error = Error + "The Email may not be blank";
            }
            //if the username is more than 15 characters
            if (someUsername.Length > 15)
            {
                //return an error message
                Error = Error + "The UserName cannot have more than 15 characters";
            }
            if (someUsername.Length == 0 | someUsername.Length < 5)
            {
                //return an error message
                Error = Error + "The UserName may not be blank";
            }
            //if the Password is more than 20 characters
            if (somePassword.Length > 20)
            {
                //return an error message
                Error = Error + "The Password cannot have more than 20 characters";
            }
            if (somePassword.Length == 0 | somePassword.Length < 6)
            {
                //return an error message
                Error = Error + "The Password may not be blank";
            }
            
            //if the PaymentType is more than 15 characters
            if (somePaymentType.Length > 15)
            {
                //return an error message
                Error = Error + "The PaymentType cannot have more than 15 characters";
            }
            if (somePaymentType.Length == 0 | somePaymentType.Length < 10)
            {
                //return an error message
                Error = Error + "The PaymentType may not be blank";
            }


            return Error;
        }

        //public property for the customerID
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

        //public property for the name
        public string Name
        {
            get
            {
                //return the private data
                return mName;
            }
            set
            {
                //set the value of the private data member
                mName = value;
            }
        }

        //public property for the phone
        public string Phone
        {
            get
            {
                //return the private data
                return mPhone;
            }
            set
            {
                //set the value of the private data member
                mPhone = value;
            }
        }

        //public property for the Email
        public string Email
        {
            get
            {
                //return the private data
                return mEmail;
            }
            set
            {
                //set the value of the private data member
                mEmail = value;
            }
        }

        //public property for the username
        public string Username
        {
            get
            {
                //return the private data
                return mUsername;
            }
            set
            {
                //set the value of the private data member
                mUsername = value;
            }
        }

        //public property for the password
        public string Password
        {
            get
            {
                //return the private data
                return mPassword;
            }
            set
            {
                //set the value of the private data member
                mPassword = value;
            }
        }

        //public property for the paymentID
        public string PaymentID
        {
            get
            {
                //return the private data
                return mPaymentID;
            }
            set
            {
                //set the value of the private data member
                mPaymentID = value;
            }
        }

        //public property for the payment tYPE
        public string PaymentType
        {
            get
            {
                //return the private data
                return mPaymentType;
            }
            set
            {
                //set the value of the private data member
                mPaymentType = value;
            }
        }
    }
}
