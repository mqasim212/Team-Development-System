<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomers" runat="server" style="z-index: 1; left: 530px; top: 97px; position: absolute; height: 275px; width: 410px"></asp:ListBox>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 536px; top: 57px; position: absolute" Text="Name | Username" Font-Underline="True"></asp:Label>
        </div>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 527px; top: 455px; position: absolute; height: 37px; width: 371px"></asp:TextBox>
        <asp:Label ID="lblEnterName" runat="server" BorderColor="White" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 526px; top: 423px; position: absolute; width: 355px; height: 34px" Text="Please Enter the Customer Name:"></asp:Label>
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 667px; top: 517px; position: absolute; height: 40px; width: 193px" Text=" Display All (Username)" OnClick="btnDisplayAll_Click" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 524px; top: 597px; position: absolute; height: 47px; width: 90px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 771px; top: 594px; position: absolute; height: 49px; width: 126px" Text="Delete" OnClick="btnDelete_Click" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 533px; top: 381px; position: absolute" Text="lblError"></asp:Label>
        </p>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 647px; top: 595px; position: absolute; height: 49px; width: 93px" Text="Edit" />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 64px; top: 55px; position: absolute; height: 48px; width: 269px; margin-right: 60px;" Text="Customer Page"></asp:Label>
        <p>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 527px; top: 517px; position: absolute; height: 40px; width: 95px; bottom: 77px;" Text="Apply" />
        </p>
        <asp:Button ID="btnBackCustomer" runat="server" OnClick="btnBackCustomer_Click" style="z-index: 1; left: 48px; top: 439px; position: absolute; height: 48px; width: 146px" Text="Back (Customer)" />
        <p>
            <asp:Button ID="btnBackStaff" runat="server" OnClick="btnBackStaff_Click" style="z-index: 1; left: 47px; top: 509px; position: absolute; height: 45px; width: 146px" Text="Back (Staff)" />
        </p>
    </form>
</body>
</html>
