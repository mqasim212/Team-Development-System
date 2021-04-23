<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ATicket.aspx.cs" Inherits="ATicket" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtTicketPurchaseDate" runat="server" style="z-index: 1; left: 236px; top: 59px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="lblTicketPurchaseDate" runat="server" style="z-index: 1; left: 55px; top: 59px; position: absolute" Text="Ticket Purchase Date"></asp:Label>
        <asp:Label ID="lblTicketNo" runat="server" style="z-index: 1; left: 57px; top: 111px; position: absolute" Text="Ticket No"></asp:Label>
        <asp:Label ID="lblFlightNo" runat="server" style="z-index: 1; left: 61px; top: 164px; position: absolute" Text="Flight No"></asp:Label>
        <asp:Label ID="lblSeatNo" runat="server" style="z-index: 1; left: 63px; top: 218px; position: absolute" Text="Seat No"></asp:Label>
        <asp:TextBox ID="txtTicketNo" runat="server" style="z-index: 1; left: 159px; top: 110px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtFlightNo" runat="server" style="z-index: 1; left: 160px; top: 162px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtSeatNo" runat="server" style="z-index: 1; left: 154px; top: 217px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 64px; top: 275px; position: absolute" Text="lblError"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 61px; top: 331px; position: absolute; height: 47px; width: 112px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 200px; top: 330px; position: absolute; height: 48px; width: 121px" Text="Cancel" />
    </form>
</body>
</html>
