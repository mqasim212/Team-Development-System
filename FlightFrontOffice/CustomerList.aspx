<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomers" runat="server" style="z-index: 1; left: 98px; top: 61px; position: absolute; height: 278px; width: 339px"></asp:ListBox>
        </div>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 100px; top: 410px; position: absolute; height: 27px; width: 335px"></asp:TextBox>
        <asp:Label ID="lblEnterName" runat="server" BorderColor="White" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 103px; top: 369px; position: absolute; width: 330px; height: 34px" Text="Please Enter Your Name:"></asp:Label>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 102px; top: 462px; position: absolute; width: 83px; height: 41px" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 257px; top: 460px; position: absolute; height: 39px; width: 157px" Text="Display All" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 94px; top: 535px; position: absolute; height: 42px; width: 90px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 233px; top: 532px; position: absolute; height: 45px; width: 92px" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 370px; top: 533px; position: absolute; height: 45px; width: 101px" Text="Delete" OnClick="btnDelete_Click" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 95px; top: 623px; position: absolute" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
