<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookingDelete.aspx.cs" Inherits="BookingDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblBookingDelete" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 82px; top: 71px; position: absolute" Text="Are you sure you want to delete this Booking Name?"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 47px; top: 330px; position: absolute; height: 26px" Text="lblError"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 131px; top: 135px; position: absolute; height: 48px; width: 142px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 335px; top: 133px; position: absolute; height: 50px; width: 151px" Text="No" />
    </form>
</body>
</html>
