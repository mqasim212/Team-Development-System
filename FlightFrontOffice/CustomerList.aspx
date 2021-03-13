<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomers" runat="server" style="z-index: 1; left: 98px; top: 61px; position: absolute; height: 275px; width: 410px"></asp:ListBox>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 103px; top: 29px; position: absolute" Text="Name | Username" Font-Underline="True"></asp:Label>
        </div>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 100px; top: 418px; position: absolute; height: 27px; width: 335px"></asp:TextBox>
        <asp:Label ID="lblEnterName" runat="server" BorderColor="White" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 103px; top: 379px; position: absolute; width: 355px; height: 34px" Text="Please Enter the Customer Name:"></asp:Label>
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 256px; top: 473px; position: absolute; height: 39px; width: 157px" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 94px; top: 544px; position: absolute; height: 42px; width: 90px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 370px; top: 540px; position: absolute; height: 45px; width: 101px" Text="Delete" OnClick="btnDelete_Click" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 102px; top: 339px; position: absolute" Text="[lblError]"></asp:Label>
        </p>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 231px; top: 539px; position: absolute; height: 49px; width: 93px" Text="Edit" />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 71px; top: 470px; position: absolute; height: 39px; width: 96px" Text="Apply" />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" Font-Underline="True" style="z-index: 1; left: 658px; top: 167px; position: absolute; height: 48px; width: 217px" Text="Customer Page"></asp:Label>
    </form>
</body>
</html>
