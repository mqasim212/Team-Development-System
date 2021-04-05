using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class TicketList : System.Web.UI.Page
{
    //This function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayTicket();
        }
    }

    void DisplayTicket()
    {
        //create an instance of a class
        clsTicketCollection Ticket = new clsTicketCollection();
        //set the data source to the list of tickets in the collection
        lstTicket.DataSource = Ticket.TicketList;
        //set the name of the primary key
        lstTicket.DataValueField = "TicketID";
        //set the data field to display
        lstTicket.DataTextField = "TicketNo";
        //bind the data to the list
        lstTicket.DataBind();
    }
}
