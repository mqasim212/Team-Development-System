<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AFlight.aspx.cs" Inherits="AFlight" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDateOfBirth" runat="server" style="z-index: 1; left: 57px; top: 69px; position: absolute" Text="Date Of Birth"></asp:Label>
        </div>
        <asp:Label ID="lblGate" runat="server" style="z-index: 1; left: 63px; top: 126px; position: absolute; height: 22px; width: 37px" Text="Gate"></asp:Label>
        <asp:Label ID="lblDepartureDate" runat="server" style="z-index: 1; left: 63px; top: 182px; position: absolute" Text="Departure Date"></asp:Label>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 59px; top: 264px; position: absolute" Text="lblError"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 51px; top: 326px; position: absolute; height: 43px; width: 124px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 208px; top: 325px; position: absolute; height: 45px; width: 139px" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 191px; top: 66px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtGate" runat="server" style="z-index: 1; left: 157px; top: 125px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDepartureDate" runat="server" style="z-index: 1; left: 208px; top: 182px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
