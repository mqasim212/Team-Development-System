using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class AFlight : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 FlightID;

    //This function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the flight to be processed
        FlightID = Convert.ToInt32(Session["FlightID"]);
        if (IsPostBack == false)
        {
            //populate the list of flights
            DisplayFlight();
            //if this is not a new record
            if (FlightID != -1)
            {
                //display the current data for the record
                DisplayFlight();
            }
        }
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (FlightID == -1)
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
        Response.Redirect("FlightList.aspx");
    }

    //function for adding new records
    void Add()
    {
        //create an instance of the flight Book
        clsFlightCollection FlightBook = new clsFlightCollection();
        //validate the data on the web form
        string Error = FlightBook.ThisFlight.Valid(txtDateOfBirth.Text, txtGate.Text, txtDepartureDate.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            FlightBook.ThisFlight.DateOfBirth = txtDateOfBirth.Text;
            FlightBook.ThisFlight.Gate = txtGate.Text;
            FlightBook.ThisFlight.DepartureDate = Convert.ToDateTime(txtDepartureDate.Text);
            //add the record
            FlightBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("FlightList.aspx");
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
        clsFlightCollection FlightBook = new clsFlightCollection();
        //validate the data on the web form
        string Error = FlightBook.ThisFlight.Valid(txtDateOfBirth.Text, txtGate.Text, txtDepartureDate.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            FlightBook.ThisFlight.DateOfBirth = txtDateOfBirth.Text;
            FlightBook.ThisFlight.Gate = txtGate.Text;
            FlightBook.ThisFlight.DepartureDate = Convert.ToDateTime(txtDepartureDate.Text);
            //update the record
            FlightBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("FlightList.aspx");
        }
        else
        {
            //report the error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    void DisplayFlight()
    {
        //create an instance of the flight book
        clsFlightCollection FlightBook = new clsFlightCollection();
        //find the record to update
        FlightBook.ThisFlight.Find(FlightID);
        //display the data for this record
        txtDateOfBirth.Text = FlightBook.ThisFlight.DateOfBirth;
        txtGate.Text = FlightBook.ThisFlight.Gate;
        txtDepartureDate.Text = FlightBook.ThisFlight.DepartureDate.ToString();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the viewer page
        Response.Redirect("FlightList.aspx");
    }
}