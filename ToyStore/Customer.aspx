<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="ToyStore.Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
    <title></title>
   <style>
        #Button1 {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            background-color: DodgerBlue;
            color: white;
            padding: 12px 16px;
            font-size: 16px;
            cursor: pointer;
            border-radius: 12px;
            box-shadow: 0 12px 16px 0 rgba(0,0,0,0.24),0 17px 50px 0 rgba(0,0,0,0.19);
            margin-left: 20px;
        }

            #Button1:active:hover {
                background-color: RoyalBlue;
                border-radius: 12px;
                color: black;
                box-shadow: none;
            }

        #Button4{
            
            float: right;
        }
        #ListBox1{
           display:inline-block;
           text-align:center;
        }
        .topButton{
            float: right;

        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        
        <div>
            <p> <asp:Label ID="Label4" runat="server" Text="Welcome: "></asp:Label>
                
            </p>
            <p><asp:Button ID="Button6" class="topButton" runat="server" Text="Cart" OnClick="Button6_Click" />
                </p>
             <asp:Label ID="Label3" runat="server" Text="Search"></asp:Label>
            <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="productName">Name</asp:ListItem>
                <asp:ListItem Value="buyPrice">Price</asp:ListItem>
                </asp:DropDownList>
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem Value="True">Ascendent</asp:ListItem>
                <asp:ListItem Value="False">Descendent</asp:ListItem>
                </asp:DropDownList>
            <asp:DropDownList ID="DropDownList3" runat="server" ></asp:DropDownList>   
            <asp:Button ID="Button3" runat="server" Text="search" OnClick="Button3_Click" />
            </p>
            <p>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Price"></asp:Label>
           </p>
       <asp:ListBox ID="ListBox1" runat="server" Height="130px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="True" ></asp:ListBox>
       
            
       
             <asp:Label ID="Label5" runat="server" Text="quantity:"></asp:Label>
       
            
       
             <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 25px" Width="72px"></asp:TextBox>
            <asp:Label ID="Label6" runat="server" Text="price:"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 23px" Width="76px"></asp:TextBox>
            <button id="Button1" runat="server" onserverclick="Button1_Click"><i class="fa fa-shopping-cart">Add to cart</i></button>
            
            
       
        </div>
        <asp:Button ID="Button4" runat="server" Text="LogOut" OnClick="Button4_Click" />
    </form>
</body>
</html>
