<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            z-index: 1;
            left: 580px;
            top: 132px;
            position: absolute;
        }
        .auto-style2 {
            width: 712px;
            height: 617px;
            z-index: 1;
            left: 301px;
            top: 91px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" style="z-index: 1; left: 317px; top: 28px; position: absolute" Text="Welcome to Qasim's Flight Booking Website"></asp:Label>
        <p>
            &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btnSignUp" runat="server" style="z-index: 1; left: 1145px; top: 34px; position: absolute; height: 53px; width: 114px" Text="Sign Up" />
        <asp:Button ID="btnLogIn" runat="server" style="z-index: 1; left: 1286px; top: 33px; position: absolute; height: 53px; width: 122px" Text="Log In" />
        </p>
    </form>
    <p>
        <img alt="" class="auto-style2" src="Pictures/flight%20system.jpg" /></p>
</body>
</html>
