using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class LocationDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 LocationID;

    //event handler for the load object
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be deleted from the session object
        LocationID = Convert.ToInt32(Session["LocationID"]);
    }

    void DeleteLocation()
    {
        //function to delete the selected record

        //create a new instance of the Booking book
        clsLocationCollection LocationBook = new clsLocationCollection();
        //find the record to delete
        LocationBook.ThisLocation.Find(LocationID);
        //delete the record
        LocationBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteLocation();
        //redirect back to the main page
        Response.Redirect("LocationList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("LocationList.aspx");
    }
}