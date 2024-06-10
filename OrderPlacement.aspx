<%@ Page Language="VB" AutoEventWireup="false" CodeFile="OrderPlacement.aspx.vb" Inherits="OrderPlacement" %>

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
     <form id="form1" runat="server" class="registration" style="width:40%">
    
    <h1>Place Your Order</h1>
        <div  id="div1" runat="server">
     <asp:RadioButtonList ID="Chklst" runat="server"></asp:RadioButtonList>
         <asp:Button ID="OK" runat="server" Text="Ok" Style="padding:8px; background-color:#4a4a48; color:azure; margin-top:3px; border:1px solid #4a4a48;" />
        
         <div style="display:flex; align-items:center;">
         <label id="l1" runat="server" visible="false">Price:</label><br />
         <asp:TextBox ID="Price" runat="server" Visible="false"></asp:TextBox><br />
         <label id="l2" runat="server" visible="false">Quantity:</label><br />
         <asp:TextBox ID="Quantity" runat="server" Visible="false"></asp:TextBox>
          </div>
        
         <asp:Button ID="Button1" runat="server" Text="Reset" Style="padding:8px; background-color:#4a4a48; color:azure; margin-top:3px; border:1px solid #4a4a48;"/>
         <asp:Button ID="Button2" runat="server" Text="Add To Cart" Visible="false" Style="padding:8px; background-color:#4a4a48; color:azure; margin-top:3px; border:1px solid #4a4a48;" />
        
        </div>
         <asp:Table ID="CartDetails" runat="server"></asp:Table>
         <asp:Button ID="Buy" runat="server" Text="Buy" Visible="false" Style="padding:8px; background-color:#4a4a48; color:azure; margin-top:3px; border:1px solid #4a4a48;" />
         <asp:Label ID="BillText" runat="server" Text=""></asp:Label>
    
     <asp:Label ID="Label1" runat="server"></asp:Label>
        
 </form>
        
</body>
</html>
