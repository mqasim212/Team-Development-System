using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class APlane : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 PlaneID;

    //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the plane to be processed
        PlaneID = Convert.ToInt32(Session["PlaneID"]);
        if (IsPostBack == false)
        {
            //populate the list of planes
            DisplayPlane();
            //if this is not a new record
            if (PlaneID != -1)
            {
                //display the current data for the record
                DisplayPlane();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (PlaneID == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }
        //all done so redirect back to the main page
        Response.Redirect("PlaneList.aspx");
    }

    //function for adding new records
    void Add()
    {
        //create an instance of a class
        clsPlaneCollection PlaneBook = new clsPlaneCollection();
        //validate the data on the web form
        string Error = PlaneBook.ThisPlane.Valid(txtPlaneName.Text, txtHoursFly.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            PlaneBook.ThisPlane.PlaneName = txtPlaneName.Text;
            PlaneBook.ThisPlane.HoursFly = Convert.ToInt32(txtHoursFly.Text);
            //add the record
            PlaneBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("PlaneList.aspx");
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
        //create an instance of a class
        clsPlaneCollection PlaneBook = new clsPlaneCollection();
        //validate the data on the web form
        string Error = PlaneBook.ThisPlane.Valid(txtPlaneName.Text, txtHoursFly.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //find the record to update
            PlaneBook.ThisPlane.Find(PlaneID);
            //get the data entered by the user
            PlaneBook.ThisPlane.PlaneName = txtPlaneName.Text;
            PlaneBook.ThisPlane.HoursFly = Convert.ToInt32(txtHoursFly.Text);
            //Update the record
            PlaneBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("PlaneList.aspx");
        }
        else
        {
            //report the error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    void DisplayPlane()
    {
        //create an instance of the plane book
        clsPlaneCollection PlaneBook = new clsPlaneCollection();
        //find the record to update
        PlaneBook.ThisPlane.Find(PlaneID);
        //display the data for this record
        txtPlaneName.Text = PlaneBook.ThisPlane.PlaneName;
        txtHoursFly.Text = PlaneBook.ThisPlane.HoursFly.ToString();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //all done so redirect back to the main page
        Response.Redirect("PlaneList.aspx");
    }
}