<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TicketDelete.aspx.cs" Inherits="TicketDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblDeleteTicketNo" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 92px; top: 91px; position: absolute" Text="Are you sure you want to delete this Ticket Number?"></asp:Label>
        </p>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 135px; top: 175px; position: absolute; height: 54px; width: 158px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 345px; top: 176px; position: absolute; height: 54px; width: 170px" Text="No" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 26px; top: 361px; position: absolute" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
