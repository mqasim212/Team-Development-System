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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["TicketID"] = -1;
        //redirect to the data entry page
        Response.Redirect("ATicket.aspx");
    }

    //event handler for the delete button
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the pariamry key value of the record to be deleted
        Int32 TicketID;
        //if a record has been selected from the list
        if (lstTicket.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            TicketID = Convert.ToInt32(lstTicket.SelectedValue);
            //store the data in the session object
            Session["TicketID"] = TicketID;
            //redirect to the delete page
            Response.Redirect("TicketDelete.aspx");
        }
        //if no record has been selected
        else
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the pariamry key value of the record to be deleted
        Int32 TicketID;
        //if a record has been selected from the list
        if (lstTicket.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            TicketID = Convert.ToInt32(lstTicket.SelectedValue);
            //store the data in the session object
            Session["TicketID"] = TicketID;
            //redirect to the edit page
            Response.Redirect("ATicket.aspx");
        }
        //if no record has been selected
        else
        {
            //display an error
            lblError.Text = "Please select a record to update from the list";
        }
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {

        //display all orderlines
        DisplayTicket("");
    }

    Int32 DisplayTicket(string TicketNoFilter)
    {
        //var to store the TicketNo
        string TicketNo;
        //create an instance of the Orderline collection class
        clsTicketCollection Ticket = new clsTicketCollection();
        Ticket.ReportByTicketNo(TicketNoFilter);
        //var to store the count of records
        Int32 RecordCount;
        //var to store the index for the loop
        Int32 Index = 0;
        //get the count of records
        RecordCount = Ticket.Count;
        //clear the list box
        lstTicket.Items.Clear();
        //while there are records 
        while (Index < RecordCount)
        {
            //get the Ticket no
            TicketNo = Ticket.TicketList[Index].TicketNo;
            //create a new entry for the list box
            ListItem NewEntry = new ListItem(TicketNo + " ".ToString());
            //add the staff to the list
            lstTicket.Items.Add(NewEntry);
            //move the index to the next record
            Index++;
        }
        //return to the count of records found
        return RecordCount;
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        Int32 RecordCount;
        RecordCount = DisplayTicket(txtTicketNo.Text);
        lblError.Text = RecordCount + " Record Found";
    }
}


