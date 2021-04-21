using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogIn_Click(object sender, EventArgs e)
    {
        //go to sign in page
        Response.Redirect("SignIn.aspx");
    }

    protected void btnSignUp_Click(object sender, EventArgs e)
    {
        //go to sign in page
        Response.Redirect("SignUp.aspx");
    }
}