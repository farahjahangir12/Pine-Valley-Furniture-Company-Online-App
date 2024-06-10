<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
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
    
    <form id="form2" runat="server" class="registration">
            <h1>PineValley Furniture Company</h1>
       
            <label for="name">Name</label><br>
        <asp:TextBox ID="ntext" runat="server"  CssClass="textbox" Style="padding:3px; width:50%; margin-top:3px; margin-bottom:2px;"></asp:TextBox><br />
          
        
            <label for="address">Address</label><br>
         <asp:TextBox ID="atext" runat="server" CssClass="textbox" Style="padding:3px; width:50%; margin-top:3px; margin-bottom:2px;"></asp:TextBox><br />
        
       
            <label for="city">City</label><br>
        <asp:DropDownList ID="DropDownList1" runat="server" DataMember="Select City"  CssClass="textbox" Style="padding:4px; width:52%;margin-top:3px;margin-bottom:2px;">
            <asp:ListItem>Select City</asp:ListItem>
        </asp:DropDownList><br />
        
            <label for="state">State</label><br>
        <asp:DropDownList ID="DropDownList2" runat="server" Style="padding:4px; width:52%; margin-top:3px;margin-bottom:2px;">
            <asp:ListItem>Select State</asp:ListItem>
        </asp:DropDownList><br />
       
            <label for="postal code">Postal Code</label><br>
            <asp:TextBox ID="ptext" runat="server"  CssClass="textbox" Style="padding:3px; width:50%; margin-top:3px; margin-bottom:2px;"></asp:TextBox><br /><br />
       
        <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="button" Width="100%" Style="padding:8px; background-color:#4a4a48; color:azure; margin-top:3px; border:1px solid #4a4a48;"/><br />
        <asp:Label ID="Label1" runat="server" Text="" Style="margin-top:3px;"></asp:Label>
        </form>
    
    </body>
    </html>