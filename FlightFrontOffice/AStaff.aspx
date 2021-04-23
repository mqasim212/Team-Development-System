<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="AStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="StaffEmail" runat="server" style="z-index: 1; left: 48px; top: 65px; position: absolute" Text="Email"></asp:Label>
        <asp:Label ID="StaffName" runat="server" style="z-index: 1; left: 48px; top: 114px; position: absolute; height: 26px; width: 54px" Text="Name"></asp:Label>
        <asp:Label ID="StaffPassword" runat="server" style="z-index: 1; left: 36px; top: 162px; position: absolute; height: 22px" Text="Password"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 46px; top: 233px; position: absolute" Text="lblError"></asp:Label>
        <asp:TextBox ID="txtStaffEmail" runat="server" style="z-index: 1; left: 132px; top: 64px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 138px; top: 114px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStaffPassword" runat="server" style="z-index: 1; left: 138px; top: 162px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 42px; top: 299px; position: absolute; height: 41px; width: 83px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 165px; top: 298px; position: absolute; height: 42px; width: 96px" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
