using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightClasses;

public partial class StaffList : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        //create an instance of the customer collection
        clsStaffCollection Staff = new clsStaffCollection();
        //set the data source to the list of customers in the collection
        lstStaff.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaff.DataValueField = "StaffID";
        //set the data field to display
        lstStaff.DataTextField = "Name";
        //bind the data to the list
        lstStaff.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffID"] = -1;
        //redirect to the data entry page
        Response.Redirect("AStaff.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the pariamry key value of the record to be deleted
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaff.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StaffID = Convert.ToInt32(lstStaff.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the delete page
            Response.Redirect("StaffDelete.aspx");
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
        //var to store the pariamry key value of the record to be edited
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaff.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffID = Convert.ToInt32(lstStaff.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the edit page
            Response.Redirect("AStaff.aspx");
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
        DisplayStaff("");
    }

    Int32 DisplayStaff(string NameFilter)
    {
        //var to store the Email
        string Email;
        //var to store the name
        string Name;
        //create an instance of the staff collection class
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByName(NameFilter);
        //var to store the count of records
        Int32 RecordCount;
        //var to store the index for the loop
        Int32 Index = 0;
        //get the count of records
        RecordCount = Staff.Count;
        //clear the list box
        lstStaff.Items.Clear();
        //while there are records 
        while (Index < RecordCount)
        {
            //get the email
            Email = Staff.StaffList[Index].Email;
            //get the name
            Name = Staff.StaffList[Index].Name;
            //create a new entry for th list box
            ListItem NewEntry = new ListItem(Name + " " + Email.ToString());
            //add the staff to the list
            lstStaff.Items.Add(NewEntry);
            //move the index to the next record
            Index++;
        }
        //return to the count of records found
        return RecordCount;
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        Int32 RecordCount;
        RecordCount = DisplayStaff(txtName.Text);
        lblError.Text = RecordCount + " Record Found";
    }
}
    


