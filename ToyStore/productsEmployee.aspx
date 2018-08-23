<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productsEmployee.aspx.cs" Inherits="ToyStore.productsEmployee" %>

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
    <form id="form1" runat="server">
        
        <div>
            <p> <asp:Label ID="Label4" runat="server" Text="Welcome: "></asp:Label>
                
            </p>
            <p><asp:Button ID="Button6" class="topButton" runat="server" Text="Pending Orders" OnClick="Button6_Click" />
                <asp:Button ID="Button5" class="topButton" runat="server" Text="My Customers" OnClick="Button5_Click" />
                </p>
             <asp:Label ID="Label3" runat="server" Text="Search"></asp:Label>
            <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="productName">Name</asp:ListItem>
                <asp:ListItem Value="buyPrice">Price</asp:ListItem>
                </asp:DropDownList>
            <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                <asp:ListItem Value="True">Ascendent</asp:ListItem>
                <asp:ListItem Value="False">Descendent</asp:ListItem>
                </asp:DropDownList>
            <asp:DropDownList ID="DropDownList3" runat="server" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged"></asp:DropDownList>   
            <asp:Button ID="Button3" runat="server" Text="search" OnClick="Button3_Click" />
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Remove" OnClientClick="return confirm('Are you sure?')"/>
            </p>
            <p>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Price"></asp:Label>
           </p>
       <asp:ListBox ID="ListBox1" runat="server" Height="130px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="True" ></asp:ListBox>
       
            
       
        </div>
        <asp:Button ID="Button4" runat="server" Text="LogOut" OnClick="Button4_Click" />
    </form>
</body>
</html>
