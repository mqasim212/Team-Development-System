using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class TicketDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 TicketID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be deleted from the session object
        TicketID = Convert.ToInt32(Session["TicketID"]);
    }

    void DeleteTicket()
    {
        //function to delete the selected record

        //create a new instance of the Ticket book
        clsTicketCollection TicketBook = new clsTicketCollection();
        //find the record to delete
        TicketBook.ThisTicket.Find(TicketID);
        //delete the record
        TicketBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteTicket();
        //redirect back to the main page
        Response.Redirect("TicketList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("TicketList.aspx");
    }
}