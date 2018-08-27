<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="ToyStore.Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <style>
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
       
            
       
             <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 25px" Width="72px" ></asp:TextBox>
            <asp:Label ID="Label6" runat="server" Text="price:"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 23px" Width="76px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Add to cart" style="margin-left: 7px" OnClick="Button1_Click" />
       
            
       
        </div>
        <asp:Button ID="Button4" runat="server" Text="LogOut" OnClick="Button4_Click" />
    </form>
</body>
</html>
