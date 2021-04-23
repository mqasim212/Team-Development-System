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
        <asp:ListBox ID="lstStaff" runat="server" style="z-index: 1; left: 367px; top: 75px; position: absolute; height: 279px; width: 417px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 371px; top: 363px; position: absolute" Text="lblError"></asp:Label>
        <asp:Label ID="lblEnterName" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 372px; top: 406px; position: absolute; height: 27px; width: 304px" Text="Please Enter The Staff Name:"></asp:Label>
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 503px; top: 499px; position: absolute; width: 218px; height: 42px; right: 589px" Text=" Display All (Email Address)" OnClick="btnDisplayAll_Click" />
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 370px; top: 442px; position: absolute; height: 33px; width: 342px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 373px; top: 501px; position: absolute; height: 41px; width: 101px" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 372px; top: 573px; position: absolute; height: 42px; width: 92px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 499px; top: 571px; position: absolute; height: 43px; width: 93px" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 628px; top: 571px; position: absolute; height: 44px; width: 131px" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 374px; top: 40px; position: absolute; width: 271px" Text="Full Name | Email Address"></asp:Label>
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 48px; top: 69px; position: absolute; height: 48px; width: 203px; margin-right: 60px;" Text="Staff Page"></asp:Label>
        <asp:Button ID="btnBackCustomer" runat="server" OnClick="btnBackCustomer_Click" style="z-index: 1; left: 48px; top: 438px; position: absolute; height: 48px; width: 146px" Text="Back (Customer)" />
        <asp:Button ID="btnBackStaff" runat="server" style="z-index: 1; left: 46px; top: 510px; position: absolute; height: 45px; width: 146px" Text="Back (Staff)" OnClick="btnBackStaff_Click" />
    </form>
</body>
</html>
