<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="StaffList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaff" runat="server" style="z-index: 1; left: 103px; top: 77px; position: absolute; height: 279px; width: 417px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 108px; top: 365px; position: absolute" Text="lblError"></asp:Label>
        <asp:Label ID="lblEnterName" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 109px; top: 406px; position: absolute; height: 27px; width: 304px" Text="Please Enter The Staff Name:"></asp:Label>
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 283px; top: 499px; position: absolute; width: 145px; height: 42px; right: 444px" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 108px; top: 442px; position: absolute; height: 33px; width: 342px"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 105px; top: 45px; position: absolute; width: 271px;" Text="Full Name | Email Address" Font-Underline="True"></asp:Label>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 113px; top: 573px; position: absolute; height: 42px; width: 92px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 252px; top: 572px; position: absolute; height: 43px; width: 93px" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 386px; top: 571px; position: absolute; height: 44px; width: 96px" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="X-Large" Font-Underline="True" style="z-index: 1; left: 673px; top: 196px; position: absolute; height: 45px; width: 143px" Text="Staff Page"></asp:Label>
    </form>
</body>
</html>
