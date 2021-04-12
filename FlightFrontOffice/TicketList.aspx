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
        <asp:ListBox ID="lstTicket" runat="server" style="z-index: 1; left: 95px; top: 69px; position: absolute; height: 310px; width: 399px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 98px; top: 394px; position: absolute" Text="lblError"></asp:Label>
        <asp:Label ID="lblEnterTicketNo" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 97px; top: 436px; position: absolute; right: 406px" Text="Please enter your Ticket Number:"></asp:Label>
        <asp:TextBox ID="txtTicketNo" runat="server" style="z-index: 1; left: 97px; top: 479px; position: absolute; height: 30px; width: 366px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 99px; top: 530px; position: absolute; height: 49px; width: 107px; right: 674px" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 239px; top: 530px; position: absolute; height: 49px; width: 142px" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 100px; top: 614px; position: absolute; height: 51px; width: 97px" Text="Add" />
        <p>
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 231px; top: 612px; position: absolute; height: 52px; width: 103px" Text="Edit" OnClick="btnEdit_Click" />
        </p>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 359px; top: 611px; position: absolute; height: 53px; width: 131px" Text="Delete" OnClick="btnDelete_Click" />
    </form>
</body>
</html>
