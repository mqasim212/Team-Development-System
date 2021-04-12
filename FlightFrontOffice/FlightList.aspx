<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FlightList.aspx.cs" Inherits="FlightList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstFlight" runat="server" style="z-index: 1; left: 104px; top: 66px; position: absolute; height: 285px; width: 397px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 105px; top: 364px; position: absolute; height: 23px" Text="lblError"></asp:Label>
        <asp:Label ID="lblEnterDateOfBirth" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 105px; top: 409px; position: absolute" Text="Please enter your Date Of Birth:"></asp:Label>
        <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 106px; top: 450px; position: absolute; height: 31px; width: 384px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 111px; top: 510px; position: absolute; height: 46px; width: 117px; right: 620px" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 253px; top: 509px; position: absolute; height: 46px; width: 158px" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 110px; top: 587px; position: absolute; height: 48px; width: 107px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 231px; top: 586px; position: absolute; height: 48px; width: 108px" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 356px; top: 586px; position: absolute; height: 47px; width: 137px" Text="Delete" OnClick="btnDelete_Click" />
    </form>
</body>
</html>
