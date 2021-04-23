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
        <asp:ListBox ID="lstFlight" runat="server" style="z-index: 1; left: 562px; top: 52px; position: absolute; height: 285px; width: 397px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 564px; top: 348px; position: absolute; height: 23px" Text="lblError"></asp:Label>
        <asp:Label ID="lblEnterDateOfBirth" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 563px; top: 385px; position: absolute" Text="Please enter Date Of Birth:"></asp:Label>
        <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 560px; top: 420px; position: absolute; height: 31px; width: 384px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 562px; top: 473px; position: absolute; height: 46px; width: 117px; right: 807px" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 713px; top: 474px; position: absolute; height: 46px; width: 158px" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 563px; top: 543px; position: absolute; height: 48px; width: 107px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 689px; top: 544px; position: absolute; height: 48px; width: 108px" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 818px; top: 545px; position: absolute; height: 47px; width: 137px" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 51px; top: 103px; position: absolute; height: 48px; width: 269px; margin-right: 60px;" Text="Flight Page"></asp:Label>
        <asp:Button ID="btnBackCustomer" runat="server" OnClick="btnBackCustomer_Click" style="z-index: 1; left: 48px; top: 439px; position: absolute; height: 48px; width: 146px" Text="Back (Customer)" />
        <asp:Button ID="btnBackStaff" runat="server" style="z-index: 1; left: 46px; top: 510px; position: absolute; height: 45px; width: 146px" Text="Back (Staff)" OnClick="btnBackStaff_Click" />
    </form>
</body>
</html>
