<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerFirstName" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="CustomerFirstName"></asp:Label>
        <asp:TextBox ID="txtCustomerFirstName" runat="server" style="z-index: 1; left: 146px; top: 31px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCustomerLastName" runat="server" style="z-index: 1; left: 11px; top: 70px; position: absolute" Text="CustomerLastName"></asp:Label>
        <p>
            <asp:TextBox ID="txtCustomerLastName" runat="server" style="z-index: 1; left: 145px; top: 69px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerEmail" runat="server" style="z-index: 1; left: 10px; top: 107px; position: absolute; height: 19px" Text="CustomerEmail"></asp:Label>
        <asp:Label ID="lblCustomerPostcode" runat="server" style="z-index: 1; left: 10px; top: 143px; position: absolute" Text="CustomerPostcode"></asp:Label>
        <asp:Label ID="lblCustomerTelNo" runat="server" style="z-index: 1; left: 10px; top: 182px; position: absolute" Text="CustomerTelNo"></asp:Label>
        <asp:TextBox ID="txtCustomerEmail" runat="server" style="z-index: 1; left: 145px; top: 103px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerPostcode" runat="server" style="z-index: 1; left: 146px; top: 139px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtCustomerTelNo" runat="server" style="z-index: 1; left: 147px; top: 179px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 10px; top: 219px; position: absolute"></asp:Label>
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" style="z-index: 1; left: 7px; top: 294px; position: absolute" Text="Submit" />
    </form>
</body>
</html>
