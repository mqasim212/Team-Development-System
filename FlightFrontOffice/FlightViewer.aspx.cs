using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class FlightViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create an instance of a class
        clsFlight AFlight = new clsFlight();
        //get the data from the session object
        AFlight = (clsFlight)Session["AFlight"];
        //display the date of birth for this entry
        Response.Write(AFlight.DateOfBirth);
        //display the gate
        Response.Write(AFlight.Gate);
        //display the departure date
        Response.Write(AFlight.DepartureDate);
    }
}