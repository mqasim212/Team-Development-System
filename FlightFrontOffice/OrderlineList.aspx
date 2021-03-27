<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderlineList.aspx.cs" Inherits="OrderlineList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderline" runat="server" style="z-index: 1; left: 100px; top: 66px; position: absolute; height: 280px; width: 398px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 105px; top: 355px; position: absolute" Text="lblError"></asp:Label>
        <asp:Label ID="lblEnterBookingNumber" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 105px; top: 394px; position: absolute" Text="Please enter the Booking Number:"></asp:Label>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 210px; top: 492px; position: absolute; height: 47px; width: 118px" Text="Apply" />
        <asp:TextBox ID="txtBookingNo" runat="server" style="z-index: 1; left: 102px; top: 436px; position: absolute; height: 37px; width: 372px"></asp:TextBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 107px; top: 560px; position: absolute; height: 47px; width: 108px" Text="Add" OnClick="btnAdd_Click" />
        </p>
        <asp:Button ID="Edit" runat="server" style="z-index: 1; left: 246px; top: 559px; position: absolute; height: 47px; width: 109px" Text="Edit" OnClick="Edit_Click" />
        <asp:Button ID="Delete" runat="server" style="z-index: 1; left: 389px; top: 557px; position: absolute; height: 48px; width: 116px" Text="Delete" OnClick="Delete_Click" />
    </form>
</body>
</html>
