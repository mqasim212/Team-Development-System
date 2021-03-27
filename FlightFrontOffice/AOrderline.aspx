<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AOrderline.aspx.cs" Inherits="AOrderline" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblBookingNo" runat="server" style="z-index: 1; left: 23px; top: 53px; position: absolute" Text="Booking Number"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 166px; top: 249px; position: absolute; height: 38px; width: 100px" Text="Cancel" />
        <asp:TextBox ID="txtBookingNo" runat="server" style="z-index: 1; left: 183px; top: 53px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 28px; top: 109px; position: absolute" Text="Quantity"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 158px; top: 110px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 28px; top: 182px; position: absolute" Text="lblError"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 32px; top: 250px; position: absolute; height: 36px; width: 93px" Text="OK" />
    </form>
</body>
</html>
