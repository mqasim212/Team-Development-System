<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignIn.aspx.cs" Inherits="SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 421px; top: 44px; position: absolute; height: 48px; width: 269px; margin-right: 60px;" Text="Sign In Page"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" Font-Size="Large" style="z-index: 1; left: 326px; top: 132px; position: absolute" Text="UserName"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" Font-Size="Large" style="z-index: 1; left: 342px; top: 186px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 486px; top: 131px; position: absolute; width: 322px"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 485px; top: 184px; position: absolute; width: 320px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 340px; top: 266px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 469px; top: 332px; position: absolute; height: 48px; width: 129px" Text="Cancel" />
        <asp:Button ID="btnForgotPassword" runat="server" OnClick="btnForgotPassword_Click" style="z-index: 1; left: 623px; top: 331px; position: absolute; height: 49px; width: 140px" Text="Forgot Password" />
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 142px; top: 333px; position: absolute; height: 50px; width: 143px" Text="Login (Customer)" />
        <asp:Button ID="btnloginStaff" runat="server" OnClick="btnloginStaff_Click" style="z-index: 1; left: 305px; top: 333px; position: absolute; height: 51px; width: 140px" Text="Login (Staff)" />
    </form>
</body>
</html>
