using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class FlightDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 FlightID;

    //event handler for the load object
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be deleted from the session object
        FlightID = Convert.ToInt32(Session["FlightID"]);
    }

    void DeleteFlight()
    {
        //function to delete the selected record

        //create a new instance of the Booking book
        clsFlightCollection FlightBook = new clsFlightCollection();
        //find the record to delete
        FlightBook.ThisFlight.Find(FlightID);
        //delete the record
        FlightBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteFlight();
        //redirect back to the main page
        Response.Redirect("FlightList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("FlightList.aspx");
    }
}