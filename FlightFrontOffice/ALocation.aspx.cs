using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class ALocation : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 LocationID;

    //This function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the locations to be processed
        LocationID = Convert.ToInt32(Session["LocationID"]);
        if (IsPostBack == false)
        {
            //populate the list of locations
            DisplayLocation();
            //if this is not a new record
            if (LocationID != -1)
            {
                //display the current data for the record
                DisplayLocation();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (LocationID == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }
        //redirect to the viewer page
        Response.Redirect("LocationList.aspx");
    }

    //function for adding new records
    void Add()
    {
        //create an instance of the Location Book
        clsLocationCollection LocationBook = new clsLocationCollection();
        //validate the data on the web form
        string Error = LocationBook.ThisLocation.Valid(txtCountryDeparture.Text, txtCountryDestination.Text, txtAirportDeparture.Text, txtAirportDestination.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            LocationBook.ThisLocation.CountryDeparture = txtCountryDeparture.Text;
            LocationBook.ThisLocation.CountryDestination = txtCountryDestination.Text;
            LocationBook.ThisLocation.AirportDeparture = txtAirportDeparture.Text;
            LocationBook.ThisLocation.AirportDestination = txtAirportDestination.Text;
            //add the record
            LocationBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("LocationList.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There are problems with the data entered " + Error;
        }
    }

    //function for updating new records
    void Update()
    {
        //create an instance of the Location Book
        clsLocationCollection LocationBook = new clsLocationCollection();
        //validate the data on the web form
        string Error = LocationBook.ThisLocation.Valid(txtCountryDeparture.Text, txtCountryDestination.Text, txtAirportDeparture.Text, txtAirportDestination.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            LocationBook.ThisLocation.CountryDeparture = txtCountryDeparture.Text;
            LocationBook.ThisLocation.CountryDestination = txtCountryDestination.Text;
            LocationBook.ThisLocation.AirportDeparture = txtAirportDeparture.Text;
            LocationBook.ThisLocation.AirportDestination = txtAirportDestination.Text;
            //update the record
            LocationBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("LocationList.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There are problems with the data entered " + Error;
        }
    }

    void DisplayLocation()
    {
        //create an instance of a class
        clsLocationCollection LocationBook = new clsLocationCollection();
        //find the record to update
        LocationBook.ThisLocation.Find(LocationID);
        //display the record for this record
        txtCountryDeparture.Text = LocationBook.ThisLocation.CountryDeparture;
        txtCountryDestination.Text = LocationBook.ThisLocation.CountryDestination;
        txtAirportDeparture.Text = LocationBook.ThisLocation.AirportDeparture;
        txtAirportDestination.Text = LocationBook.ThisLocation.AirportDestination;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the edit page
        Response.Redirect("LocationList.aspx");
    }
}