using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class PlaneDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 PlaneID;

    //event handler for the load object
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be deleted from the session object
        PlaneID = Convert.ToInt32(Session["PlaneID"]);
    }

    void DeletePlane()
    {
        //function to delete the selected record

        //create a new instance of the Booking book
        clsPlaneCollection PlaneBook = new clsPlaneCollection();
        //find the record to delete
        PlaneBook.ThisPlane.Find(PlaneID);
        //delete the record
        PlaneBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeletePlane();
        //redirect back to the main page
        Response.Redirect("PlaneList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("PlaneList.aspx");
    }
}