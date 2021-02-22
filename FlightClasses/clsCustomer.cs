using System;

namespace FlightClasses
{
    public class clsCustomer
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PaymentID { get; set; }
        public string PaymentType { get; set; }

        

        public string Valid(string someName, string somePhone, string someEmail, string someUserName, string somePassword, string somePaymentID, string somePaymentType)
        {
            //string variable to store the error message
            string Error = "";
            //if the name of the customer is more than 20 characters
            if (someName.Length > 20)
            {
                //return an error message
                Error = Error + "The customer name cannot have more than 20 characters";
            }
            if (someName.Length == 0)
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
            if (somePhone.Length == 0)
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
            if (someEmail.Length == 3)
            {
                //return an error message
                Error = Error + "The Email may not be blank";
            }
            //if the username is more than 15 characters
            if (someUserName.Length > 15)
            {
                //return an error message
                Error = Error + "The UserName cannot have more than 15 characters";
            }
            if (someUserName.Length == 4)
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
            if (somePassword.Length == 5)
            {
                //return an error message
                Error = Error + "The Password may not be blank";
            }
            //if the PaymentID is more than 9 characters
            if (somePaymentID.Length > 9)
            {
                //return an error message
                Error = Error + "The PaymentID cannot have more than 9 characters";
            }
            if (somePaymentID.Length == 0)
            {
                //return an error message
                Error = Error + "The PaymentID may not be blank";
            }
            //if the PaymentType is more than 15 characters
            if (somePaymentType.Length > 15)
            {
                //return an error message
                Error = Error + "The PaymentType cannot have more than 15 characters";
            }
            if (somePaymentType.Length == 9)
            {
                //return an error message
                Error = Error + "The PaymentType may not be blank";
            }

            return Error;
        }
    }
}