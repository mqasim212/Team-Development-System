using System;

namespace FlightClasses
{
    public class clsCustomer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PaymentID { get; set; }
        public string PaymentType { get; set; }

        public string Valid(string Customer)
        {
            //string variable to store the error message
            string Error = "";
            //if the name of the customer is more than 20 characters
            if (Customer.Length > 20)
            {
                //return an error message
                Error = "The customer name cannot have more than 20 characters";
            }
            if (Customer.Length == 0)
            {
                //return an error message
                Error = "The customer name may not be blank";
            }
            return Error;
        }
    }
}