using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class FlightList : System.Web.UI.Page
{ 
    //This function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayFlight();
        }


        void DisplayFlight()
        {
            //create an instance of the collection class
            clsFlightCollection Flight = new clsFlightCollection();
            //set the data source to the list of flights in the collection
            lstFlight.DataSource = Flight.FlightList;
            //set the name of the primary key
            lstFlight.DataValueField = "FlightID";
            //set the data field to display
            lstFlight.DataTextField = "DateOfBirth";
            //bind the data to the list
            lstFlight.DataBind();
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["FlightID"] = -1;
        //redirect to the data entry page
        Response.Redirect("AFlight.aspx");
    }


    //event handler for the delete button
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 FlightID;
        //if a record has been selected from the list
        if (lstFlight.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            FlightID = Convert.ToInt32(lstFlight.SelectedValue);
            //store the data in the session object
            Session["FlightID"] = FlightID;
            //redirect to the delete page
            Response.Redirect("FlightDelete.aspx");
        }
        //if no record has been selected
        else
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    //event handler for the edit button
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 FlightID;
        //if a record has been selected from the list
        if (lstFlight.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            FlightID = Convert.ToInt32(lstFlight.SelectedValue);
            //store the data in the session object
            Session["FlightID"] = FlightID;
            //redirect to the edit page
            Response.Redirect("AFlight.aspx");
        }
        //if no record has been selected
        else
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //display all orderlines
        DisplayFlight("");
    }

    Int32 DisplayFlight(string DateOfBirthFilter)
    {
        //var to store the Dateofbirth
        string DateOfBirth;
        //create an instance of the Orderline collection class
        clsFlightCollection Flight = new clsFlightCollection();
        Flight.ReportByDateOfBirth(DateOfBirthFilter);
        //var to store the count of records
        Int32 RecordCount;
        //var to store the index for the loop
        Int32 Index = 0;
        //get the count of records
        RecordCount = Flight.Count;
        //clear the list box
        lstFlight.Items.Clear();
        //while there are records 
        while (Index < RecordCount)
        {
            //get the Dateofbirth
            DateOfBirth = Flight.FlightList[Index].DateOfBirth;
            //create a new entry for the list box
            ListItem NewEntry = new ListItem(DateOfBirth + " ".ToString());
            //add the staff to the list
            lstFlight.Items.Add(NewEntry);
            //move the index to the next record
            Index++;
        }
        //return to the count of records found
        return RecordCount;
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        Int32 RecordCount;
        RecordCount = DisplayFlight(txtDateOfBirth.Text);
        lblError.Text = RecordCount + " Record Found";
    }
}


