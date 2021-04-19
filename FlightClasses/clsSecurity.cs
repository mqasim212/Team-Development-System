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
        private string mAdminUsername = "";
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


        //allows access to the username of the current user
        public string AdminUsername
        {
            get
            {
                //return username
                return mAdminUsername;
            }
        }






    }
}
