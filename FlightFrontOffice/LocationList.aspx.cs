using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class LocationList : System.Web.UI.Page
{
    //this function handles the load object for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayLocation();
        }

        void DisplayLocation()
        {
            //create an instance of the Location collection
            clsLocationCollection Location = new clsLocationCollection();
            //set the data source to the list of Locations in the collection
            lstLocation.DataSource = Location.LocationList;
            //set the name of the primary key
            lstLocation.DataValueField = "LocationID";
            //set the data field to display
            lstLocation.DataTextField = "CountryDeparture";
            //bind the data source to the list
            lstLocation.DataBind();
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["LocationID"] = -1;
        //redirect to the data entry page
        Response.Redirect("ALocation.aspx");
    }


    //event handler for the delete button
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 LocationID;
        //if a record has been selected from the list
        if (lstLocation.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            LocationID = Convert.ToInt32(lstLocation.SelectedValue);
            //store the data in the session object
            Session["LocationID"] = LocationID;
            //redirect to the delete page
            Response.Redirect("LocationDelete.aspx");
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
        //var to store the primary key value of the record to be deleted
        Int32 LocationID;
        //if a record has been selected from the list
        if (lstLocation.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            LocationID = Convert.ToInt32(lstLocation.SelectedValue);
            //store the data in the session object
            Session["LocationID"] = LocationID;
            //redirect to the edit page
            Response.Redirect("ALocation.aspx");
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
        //display all names
        DisplayLocation("");
    }

    Int32 DisplayLocation(string CountryDepartureFilter)
    {
        //var to store the CountryDeparture
        string CountryDeparture;
        //var to store the AirportDestination
        string AirportDestination;
        //create an instance of location collection class
        clsLocationCollection Location = new clsLocationCollection();
        Location.ReportByCountryDeparture(CountryDepartureFilter);
        //var to store the count of records
        Int32 RecordCount;
        //var to store the index for the loop
        Int32 Index = 0;
        //get the count of records
        RecordCount = Location.Count;
        //clear the list box
        lstLocation.Items.Clear();
        //while there are records 
        while (Index < RecordCount)
        {
            //get the CountryDeparture
            CountryDeparture = Location.LocationList[Index].CountryDeparture;
            //get the AirportDestination
            AirportDestination = Location.LocationList[Index].AirportDestination;
            //create a new entry for th list box
            ListItem NewEntry = new ListItem(CountryDeparture + " " + AirportDestination.ToString());
            //add the customer to the list
            lstLocation.Items.Add(NewEntry);
            //move the index to the next record
            Index++;
        }
        //return to the count of records found
        return RecordCount;
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        Int32 RecordCount;
        RecordCount = DisplayLocation(txtCountryDeparture.Text);
        lblError.Text = RecordCount + " Record Found";
    }

    protected void btnBackCustomer_Click(object sender, EventArgs e)
    {
        //Redirect to the customer page
        Response.Redirect("MyCustomerAccount.aspx");
    }

    protected void btnBackStaff_Click(object sender, EventArgs e)
    {
        //Redirect to the staff page
        Response.Redirect("MyStaffAccount.aspx");
    }
}
