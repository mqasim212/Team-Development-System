<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TicketList.aspx.cs" Inherits="TicketList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstTicket" runat="server" style="z-index: 1; left: 606px; top: 64px; position: absolute; height: 310px; width: 399px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 609px; top: 387px; position: absolute; width: 62px;" Text="lblError"></asp:Label>
        <asp:Label ID="lblEnterTicketNo" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 602px; top: 421px; position: absolute; right: -99px" Text="Please enter your Ticket Number:"></asp:Label>
        <asp:TextBox ID="txtTicketNo" runat="server" style="z-index: 1; left: 600px; top: 453px; position: absolute; height: 30px; width: 366px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 597px; top: 501px; position: absolute; height: 49px; width: 107px; right: 782px" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 735px; top: 501px; position: absolute; height: 49px; width: 142px" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 592px; top: 584px; position: absolute; height: 51px; width: 97px" Text="Add" />
        <p>
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 714px; top: 583px; position: absolute; height: 52px; width: 103px" Text="Edit" OnClick="btnEdit_Click" />
        </p>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 843px; top: 582px; position: absolute; height: 53px; width: 131px; right: 512px;" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 49px; top: 60px; position: absolute; height: 48px; width: 269px; margin-right: 60px; margin-top: 6px;" Text="Ticket Page"></asp:Label>
        <asp:Button ID="btnBackCustomer" runat="server" OnClick="btnBackCustomer_Click" style="z-index: 1; left: 48px; top: 439px; position: absolute; height: 48px; width: 146px" Text="Back (Customer)" />
        <asp:Button ID="btnBackStaff" runat="server" style="z-index: 1; left: 46px; top: 510px; position: absolute; height: 45px; width: 146px" Text="Back (Staff)" OnClick="btnBackStaff_Click" />
    </form>
</body>
</html>
