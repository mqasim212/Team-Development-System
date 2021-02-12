using System;
using FlightClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlightTesting
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstantiationOk()
        {
            //create an instance of a class
            clsCustomer ACustomer = new clsCustomer();
        }
    }
}
