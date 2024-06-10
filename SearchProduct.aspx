<%@ Page Language="VB" AutoEventWireup="false" CodeFile="SearchProduct.aspx.vb" Inherits="SearchProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="styles3.css">
</head>
<body>
        <div id="navbar">

    <a href="CustomerReg.aspx">Customer Registration</a>
    <a href="MyCart.aspx">My Cart</a>
    <a href="OrderPlacement.aspx">Place Order</a>
    <a href="Payement.html">Payement</a>
    <a href="ProductEntry.aspx">Product Entry</a>
    <a href="SearchProduct.aspx">Search Product</a>   
</div>
   
     <form id="form1" runat="server" class="registration">
            <h1>Search Product</h1><br />
            <asp:DropDownList ID="inventoryDropDown" runat="server" DataTextField="product-description" DataValueField="standard-price" Style="padding:4px; width:52%;margin-bottom:2px;">
                <asp:ListItem Text="Select Items" id="list" runat="server" Value="" />
            </asp:DropDownList><br /></br>
             
            <asp:Button ID="Button1" runat="server" Text="See Details" Width="20%" Style="padding:8px; background-color:#4a4a48; color:azure; margin-top:2px;margin-bottom:2px; border:1px solid #4a4a48; border-radius:3px;" /><br />
           <div id="details" runat="server" visible="false">
         <asp:Label ID="Price" runat="server" Style="margin-top:2px;"  ></asp:Label><br />
            <asp:Label ID="Finish" runat="server" Style="margin-top:2px;"></asp:Label><br /></div> 
         <br /> <asp:Label runat="server" id="Label1"></asp:Label>
       
    </form>
</body>
</html>