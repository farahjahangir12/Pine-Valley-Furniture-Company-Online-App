<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Payement.aspx.vb" Inherits="Payement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="styles3.css"/>
</head>
<body>
    <div id="navbar">

        <a href="CustomerReg.aspx">Customer Registration</a>
        <a href="CustomerSegmentation.aspx">My Cart</a>
        <a href="OrderPlacement.aspx">Place Order</a>
        <a href="Payement.html">Payement</a>
        <a href="ProductEntry.aspx">Product Entry</a>
        <a href="SearchProduct.aspx">Search Product</a>   
    </div>
   <form id="payement" class="registration" runat="server" style="margin-bottom:0px; width:30%;">
        <h1>Payment</h1><br>
        <label for="card-number">Card Number</label><br>
       <asp:TextBox ID="CardNum" runat="server" style="padding:3px; width:50%; margin-top:3px; margin-bottom:4px;"></asp:TextBox><br />
        <label for="expiry">Expiry Date</label><br>
       <asp:TextBox ID="Date" runat="server" style="padding:3px; width:50%; margin-top:3px; margin-bottom:4px;"></asp:TextBox><br />
        <label for="cvv">CVV</label><br>
         <asp:TextBox ID="Cvv" runat="server" style="padding:3px; width:50%; margin-top:3px; margin-bottom:4px;"></asp:TextBox><br />
        <label for="state">State</label><br>
       <asp:DropDownList ID="ddl" runat="server" style="padding:3px; width:52%; margin-top:3px;"></asp:DropDownList><br /><br />
       <asp:Button ID="Button1" runat="server" Text="Confirm" Style="padding:8px; background-color:#4a4a48; color:azure; margin-top:6px; border:1px solid #4a4a48; width:100%;"/>
       <asp:Label ID="Label1" runat="server"></asp:Label>
       </form>
</body>
</html>
