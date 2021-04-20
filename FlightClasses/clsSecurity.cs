using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace FlightClasses
{
    
        public class clsSecurity
        {
            //private data members
            private string mUsername = "";
            //indicates if it is an admin

            //constructor
            public clsSecurity()
            {

            }

            //allows access to the username of the current user
            public string Username
            {
                get
                {
                    //return username
                    return mUsername;
                }
            }


            public string SignIn(string Username, string Password)
            {
                //sign in a user based on their username and password
                //if not all attemps are used
                string Error = "";
                //convert plain text password to hash code
                Password = GetHashString(Password + Username);
                //find the matching record
                clsDataConnection UserAccount = new clsDataConnection();
                //add the parameter
                UserAccount.AddParameter("@Username", Username);
                UserAccount.AddParameter("@Password", Password);
                //execute stored procedure
                UserAccount.Execute("sproc_tblCustomer_FilterByUsernameAndPassword");
                //if there is one record found
                if (UserAccount.Count >= 1)
                {
                    Error = "";
                }
                else
                {
                    Error = "There were problems with the sign in";
                }
                return Error;

            }


            private string GetHashString(string SomeText)
            {
                //generates a hash for storing secure data in the database
                if (SomeText != "")//if there is text to process
                {
                    //create an instance of the hash generator
                    SHA256Managed HashGenerator = new SHA256Managed();
                    //var to store the final hash
                    string HashString;
                    //array to store the bytes of the orignal text
                    byte[] TextBytes;
                    //array to store the bytes of the new hash
                    byte[] HashBytes;
                    //convert the text in the string to an array of bytes
                    TextBytes = System.Text.Encoding.UTF8.GetBytes(SomeText);
                    //generate the hash based on the array of bytes
                    HashBytes = HashGenerator.ComputeHash(TextBytes);
                    //generate the hash string replacing blank characters with -
                    HashString = BitConverter.ToString(HashBytes).Replace("-", "");
                    return HashString;
                }
                else   //if there is nothing to process
                {
                    //return a blank string
                    return "";
                }
            }

            public string SignUp(string Name, string Phone, string Email, string Username, string Password, string PasswordConfirm, string PaymentType, string SecurityMsg)
            {
                //var to store error
                String Error = "";
                    //check to see if passwords match
                    if (Password == PasswordConfirm)
                    {
                        //validate the data stored
                        if (Valid(Name, Phone, Email, Username, Password, PaymentType, SecurityMsg) == "")
                        {
                            //hash the password
                            string HashPassword = GetHashString(Password + Username);
                            string HashSecret = GetHashString(SecurityMsg + Username);
                            //connect to DB
                            clsDataConnection DB = new clsDataConnection();
                            //add the parameters
                            DB.AddParameter("@Name", Name);
                            DB.AddParameter("@Phone", Phone);
                            DB.AddParameter("@Email", Email);
                            DB.AddParameter("@Username", Username);
                            DB.AddParameter("@Password", HashPassword);
                            DB.AddParameter("@PaymentType", PaymentType);
                            DB.AddParameter("@SecurityMsg", HashSecret);
                            //executet the stored procedure
                            DB.Execute("sproc_tblCustomer_Insert");
                        }
                        //if there was an error
                        else
                        {
                            //error msg
                            Error = Valid(Name, Phone, Email, Username, Password, PaymentType, SecurityMsg);
                        }
                    }
                    else
                    {
                        Error = Error + "The passwords do not match";
                    }
            return Error;
            }

            private string Valid(string name, string phone, string email, string username, string password, string paymentType, string secretMsg)
            {
            //string variable to store the error message
            string Error = "";

            //if the name of the customer is more than 20 characters
            if (name.Length > 20)
            {
                //return an error message
                Error = Error + "The customer name cannot have more than 20 characters";
            }
            if (name.Length == 0 | name.Length < 1)
            {
                //return an error message
                Error = Error + "The customer name may not be blank";
            }
            //if the  Phone Number is more than 11 characters
            if (phone.Length > 11)
            {
                //return an error message
                Error = Error + "The Phone Number cannot have more than 11 characters";
            }
            if (phone.Length == 0 | phone.Length < 8)
            {
                //return an error message
                Error = Error + "The Phone Number may not be blank";
            }
            //if the Email is more than 30 characters
            if (email.Length > 30)
            {
                //return an error message
                Error = Error + "The email cannot have more than 30 characters";
            }
            if (email.Length == 0 | email.Length < 4)
            {
                //return an error message
                Error = Error + "The Email may not be blank";
            }
            //if the username is more than 15 characters
            if (username.Length > 15)
            {
                //return an error message
                Error = Error + "The UserName cannot have more than 15 characters";
            }
            if (username.Length == 0 | username.Length < 5)
            {
                //return an error message
                Error = Error + "The UserName may not be blank";
            }
            //if the Password is more than 20 characters
            if (password.Length > 20)
            {
                //return an error message
                Error = Error + "The Password cannot have more than 20 characters";
            }
            if (password.Length == 0 | password.Length < 6)
            {
                //return an error message
                Error = Error + "The Password may not be blank";
            }
            //if the PaymentID is more than 9 characters
          
            //if the PaymentType is more than 15 characters
            if (paymentType.Length > 15)
            {
                //return an error message
                Error = Error + "The PaymentType cannot have more than 15 characters";
            }
            if (paymentType.Length == 0 | paymentType.Length < 10)
            {
                //return an error message
                Error = Error + "The PaymentType may not be blank";
            }
            //if the secretMsg is more than 20 characters
            if (secretMsg.Length > 20)
            {
                //return an error message
                Error = Error + "The secretMsg cannot have more than 20 characters";
            }
            if (secretMsg.Length == 0 | secretMsg.Length < 6)
            {
                //return an error message
                Error = Error + "The secretMsg may not be blank";
            }

            return Error;
        }


            private string CheckPassword(string Password)
            {
                //var to store error
                string Error = "";
                //if password has less than 7 characters
                if (Password.Length < 7)
                {
                    //error msg
                    Error = "Password must be at least 7 characters" + "<br />";
                }
                //if the password doesnt contain numbers
                if (ContainsNumber(Password) == false)
                {
                    //error msg
                    Error = Error + "Your password must have numbers in it" + "<br />";
                }
                return Error;
            }

            private Boolean ContainsNumber(string Password)
            {
                //checks to see if a password contains a number
                //var to indicate found
                Boolean Found = false;
                //counter for loop
                int Counter = 0;
                //used to store a single character
                char AChar;
                //while found is false and char less than 9
                while (Found == false & Counter < 9)
                {
                    //set temp to the value of Counter plus 48 to point at the numeric ascii codes
                    int Temp = Counter + 48;
                    //get the char value of the ascii code
                    AChar = (char)Temp;
                    //if the code is in the password
                    if (Password.Contains(AChar) == true)
                    {
                        //set found = true
                        Found = true;
                    }
                    else
                    {
                        //otherwise keep looking
                        Counter += 1;
                    }
                }
                //return the state of found
                return Found;
            }

            public Boolean UsernameTaken(string Username)
            {
                //tests to see if the email address is taken
                //connect to the database and see if it there already
                clsDataConnection DB = new clsDataConnection();
                DB.AddParameter("@Username", Username);
                DB.Execute("sproc_tblCustomer_FilterByUsername");
                //if one record found then it is already gone
                if (DB.Count == 1)
                {
                    //return true
                    return true;
                }
                else
                {
                    //return false
                    return false;
                }
            }


            public string UserChangePassword(string Username, string Password1, string Password2, string SecurityMsg)
            {
                //used to change a users password
                //var to store any errors
                string Message = "";
                //connect to db
                //get hash for secret
                string HashSecret = GetHashString(SecurityMsg + Username);
                clsDataConnection UserAccount = new clsDataConnection();
                UserAccount.AddParameter("@UserName", Username);
                UserAccount.AddParameter("@SecurityMsg", HashSecret);
                //execute the stored procedure
                UserAccount.Execute("sproc_tblCustomer_CheckSecurityMsg");
                if (UserAccount.Count >= -1)
                {
                    //if the passwords match
                    if (Password1 == Password2)
                    {
                        //validate the password
                        Message = CheckPassword(Password1);
                        //if everything is ok
                        if (Message == "")
                        {
                            //get the hash of the password
                            string HashPassword = GetHashString(Password1 + Username);
                            //update the password in db
                            clsDataConnection DB = new clsDataConnection();
                            //add the parameter
                            DB.AddParameter("@Username", Username);
                            DB.AddParameter("@Password", HashPassword);
                            //execute the stored procedure
                            DB.Execute("sproc_tblCustomer_UpdatePassword");
                        }
                    }
                    //if passwords do not match
                    else
                    {
                        //Error Message
                        Message = "The passwords do not match";
                    }
                }
                else
                {
                    //error message
                    Message = "Username or secret are not correct";
                }
                //return the error if there is one
                return Message;
            }
        }
    }

