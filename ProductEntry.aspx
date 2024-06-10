<<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ProductEntry.aspx.vb" Inherits="_ProductEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
    <form id="form3" runat="server" class="registration">
            <h1 style="margin-top:0">Product Entry</h1>
            <label for="product-id">Product Id</label><br />
            <asp:TextBox ID="ProductIdTextBox" runat="server" placeholder="Enter Product Id" CssClass="textbox" Style="padding:3px; width:50%; margin-top:3px; margin-bottom:2px;"></asp:TextBox><br />
            <label for="description">Product Description</label><br />
            <asp:TextBox ID="DescriptionTextBox" runat="server" placeholder="Enter Product Description" Style="padding:3px; width:50%; margin-top:3px; margin-bottom:2px;" ></asp:TextBox><br />
            <label for="product-finish">Product Finish</label><br />
            <asp:TextBox ID="ProductFinishTextBox" runat="server" placeholder="Enter Product Finish" Style="padding:3px; width:50%; margin-top:3px; margin-bottom:2px;" ></asp:TextBox><br />
            <label for="standard-price">Standard Price</label><br />
            <asp:TextBox ID="StandardPriceTextBox" runat="server" placeholder="Enter Standard Price" Width="100%" Style="padding:3px; width:50%; margin-top:3px; margin-bottom:2px;"></asp:TextBox><br />
            <asp:Button ID="Add" runat="server" Text="Done" Style="padding:8px; background-color:#4a4a48; color:azure; margin-top:6px; border:1px solid #4a4a48; width:100%" /><br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        
    </form>
</body>
</html>