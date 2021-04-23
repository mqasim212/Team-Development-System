using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class ATicket : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 TicketID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the booking to be processed
        TicketID = Convert.ToInt32(Session["TicketID"]);
        if (IsPostBack == false)
        {
            //populate the list of customers
            DisplayTicket();
            //if this is not a new record
            if (TicketID != -1)
            {
                //display the current data for the record
                DisplayTicket();
            }

        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (TicketID == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }

        //all done so redirect to main page
        Response.Redirect("TicketList.aspx");
    }

    //function for adding new records
    void Add()
    {
        //create an instance of the Ticket Book
        clsTicketCollection TicketBook = new clsTicketCollection();
        //validate the data on the web form
        string Error = TicketBook.ThisTicket.Valid(txtTicketPurchaseDate.Text, txtTicketNo.Text, txtFlightNo.Text, txtSeatNo.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            TicketBook.ThisTicket.TicketPurchaseDate = Convert.ToDateTime(txtTicketPurchaseDate.Text);
            TicketBook.ThisTicket.TicketNo = txtTicketNo.Text;
            TicketBook.ThisTicket.FlightNo = Convert.ToInt32(txtFlightNo.Text);
            TicketBook.ThisTicket.SeatNo = txtSeatNo.Text;
            //add the record
            TicketBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("TicketList.aspx");
        }
        else
        {
            //report the error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    //function for updating new records
    void Update()
    {
        //create an instance of the Ticket Book
        clsTicketCollection TicketBook = new clsTicketCollection();
        //validate the data on the web form
        string Error = TicketBook.ThisTicket.Valid(txtTicketPurchaseDate.Text, txtTicketNo.Text, txtFlightNo.Text, txtSeatNo.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //find the record to update
            TicketBook.ThisTicket.Find(TicketID);
            //get the data entered by the user
            TicketBook.ThisTicket.TicketPurchaseDate = Convert.ToDateTime(txtTicketPurchaseDate.Text);
            TicketBook.ThisTicket.TicketNo = txtTicketNo.Text;
            TicketBook.ThisTicket.FlightNo = Convert.ToInt32(txtFlightNo.Text);
            TicketBook.ThisTicket.SeatNo = txtSeatNo.Text;
            //update the record
            TicketBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("TicketList.aspx");
        }
        else
        {
            //report the error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    void DisplayTicket()
    {
        //create an instance of the Ticket Book
        clsTicketCollection TicketBook = new clsTicketCollection();
        //find the record to update
        TicketBook.ThisTicket.Find(TicketID);
        //display the data for the this record
        txtTicketPurchaseDate.Text = TicketBook.ThisTicket.TicketPurchaseDate.ToString();
        txtTicketNo.Text = TicketBook.ThisTicket.TicketNo;
        txtFlightNo.Text = TicketBook.ThisTicket.FlightNo.ToString();
        txtSeatNo.Text = TicketBook.ThisTicket.SeatNo;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //all done so redirect back to the main page
        Response.Redirect("TicketList.aspx");
    }
}