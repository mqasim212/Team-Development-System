using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class PlaneList : System.Web.UI.Page
{
    //this function handles the load object for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayPlane();
        }


        void DisplayPlane()
        {
            //create an instance of the plane collection
            clsPlaneCollection Plane = new clsPlaneCollection();
            //set the data source to the list of bookings in the collection
            lstPlane.DataSource = Plane.PlaneList;
            //set the name of the primary key
            lstPlane.DataValueField = "PlaneID";
            //set the data field to display
            lstPlane.DataTextField = "PlaneName";
            //bind the data source to the list
            lstPlane.DataBind();
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["PlaneID"] = -1;
        //redirect to the data entry page
        Response.Redirect("APlane.aspx");
    }

    //event handler for the delete button
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 PlaneID;
        //if a record has been selected from the list
        if (lstPlane.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            PlaneID = Convert.ToInt32(lstPlane.SelectedValue);
            //store the data in the session object
            Session["PlaneID"] = PlaneID;
            //redirect to the delete page
            Response.Redirect("PlaneDelete.aspx");
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
        //var to store the primary key value of the record to be edited
        Int32 PlaneID;
        //if a record has been selected from the list
        if (lstPlane.SelectedIndex != -1)
        {
            //get the primary key value of the record to edited
            PlaneID = Convert.ToInt32(lstPlane.SelectedValue);
            //store the data in the session object
            Session["PlaneID"] = PlaneID;
            //redirect to the edit page
            Response.Redirect("APlane.aspx");
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
        //display all names
        DisplayPlane("");
    }

    Int32 DisplayPlane(string PlaneNameFilter)
    {
        //var to store the PlaneName
        string PlaneName;
        //create an instance of customer collection class
        clsPlaneCollection Plane = new clsPlaneCollection();
        Plane.ReportByPlaneName(PlaneNameFilter);
        //var to store the count of records
        Int32 RecordCount;
        //var to store the index for the loop
        Int32 Index = 0;
        //get the count of records
        RecordCount = Plane.Count;
        //clear the list box
        lstPlane.Items.Clear();
        //while there are records 
        while (Index < RecordCount)
        {
            //get the username
            PlaneName = Plane.PlaneList[Index].PlaneName;
            //create a new entry for th list box
            ListItem NewEntry = new ListItem(PlaneName + " ".ToString());
            //add the plane to the list
            lstPlane.Items.Add(NewEntry);
            //move the index to the next record
            Index++;
        }
        //return to the count of records found
        return RecordCount;
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        Int32 RecordCount;
        RecordCount = DisplayPlane(txtPlaneName.Text);
        lblError.Text = RecordCount + " Record Found";
    }
}

