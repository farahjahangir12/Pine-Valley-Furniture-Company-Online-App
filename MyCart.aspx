<%@ Page Language="VB" AutoEventWireup="false" CodeFile="MyCart.aspx.vb" Inherits="_MyCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Cart</title>
    <link rel="stylesheet" href="styles3.css"/>
</head>
<body>
     <div id="navbar">

     <a href="CustomerReg.aspx">Customer Registration</a>
     <a href="MyCart.aspx">My Cart</a>
     <a href="OrderPlacement.aspx">Place Order</a>
     <a href="Payement.aspx">Payement</a>
     <a href="ProductEntry.aspx">Product Entry</a>
     <a href="SearchProduct.aspx">Search Product</a>   
 </div>
    <form id="form1" runat="server" class="registration">
        <asp:Table ID="Cart" runat="server"></asp:Table>
        
        <div>
            <asp:Button ID="Order" runat="server" Text="Confirm" Style="padding:8px; background-color:#4a4a48; color:azure; margin-top:3px; border:1px solid #4a4a48;"/>
            <asp:Button ID="Pay" runat="server" Text="Pay" PostBackUrl="~/Payement.aspx" Style="padding:8px; background-color:#4a4a48; color:azure; margin-top:3px; border:1px solid #4a4a48;"/>
        </div>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <asp:Label ID="BillText" runat="server" Text="" Style="background-color:#4a4a48"></asp:Label>
    </form>
</body>
</html>
