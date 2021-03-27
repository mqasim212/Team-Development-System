<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderlineDelete.aspx.cs" Inherits="OrderlineDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDeleteBooking" runat="server" Font-Bold="True" Font-Size="Larger" style="z-index: 1; left: 132px; top: 110px; position: absolute" Text="Are you sure you want to delete this Booking?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 181px; top: 206px; position: absolute; height: 47px; width: 146px" Text="Yes" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 398px; top: 205px; position: absolute; height: 50px; width: 156px" Text="No" OnClick="btnNo_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 33px; top: 395px; position: absolute" Text="lblError"></asp:Label>
    </form>
</body>
</html>
