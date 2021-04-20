<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LocationList.aspx.cs" Inherits="LocationList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstLocation" runat="server" style="z-index: 1; left: 523px; top: 79px; position: absolute; height: 278px; width: 428px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 522px; top: 368px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Label ID="lblEnterCountryDeparture" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 518px; top: 400px; position: absolute; height: 26px" Text="Please enter the Country of Departure:"></asp:Label>
        <asp:TextBox ID="txtCountryDeparture" runat="server" style="z-index: 1; left: 518px; top: 433px; position: absolute; height: 25px; width: 387px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 518px; top: 478px; position: absolute; height: 44px; width: 113px" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 653px; top: 479px; position: absolute; height: 44px; width: 167px" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 522px; top: 545px; position: absolute; height: 48px; width: 98px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 643px; top: 547px; position: absolute; height: 47px; width: 101px" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 768px; top: 546px; position: absolute; height: 47px; width: 132px" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="Large" style="z-index: 1; left: 505px; top: 43px; position: absolute" Text="Country of Departure / Airport of Destination"></asp:Label>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 64px; top: 55px; position: absolute; height: 48px; width: 269px; margin-right: 60px;" Text="Location Page"></asp:Label>
        <asp:Button ID="btnBackCustomer" runat="server" OnClick="btnBackCustomer_Click" style="z-index: 1; left: 48px; top: 439px; position: absolute; height: 48px; width: 146px" Text="Back (Customer)" />
        <asp:Button ID="btnBackStaff" runat="server" style="z-index: 1; left: 47px; top: 509px; position: absolute; height: 45px; width: 146px" Text="Back (Staff)" OnClick="btnBackStaff_Click" />
    </form>
</body>
</html>
