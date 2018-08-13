<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pcustomer.aspx.cs" Inherits="ToyStore.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #Button4{
            
            float: right;
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <p> <asp:Label ID="Label4" runat="server" Text="Welcome! "></asp:Label>
                
            </p>
        <asp:Label ID="Label3" runat="server" Text="Search"></asp:Label>
            <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:DropDownList ID="DropDownList1" runat="server" style="margin-left: 35px">
                <asp:ListItem Value="productName">Name</asp:ListItem>
                <asp:ListItem Value="buyPrice">Price</asp:ListItem>
                </asp:DropDownList>
            <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" style="margin-left: 38px" Height="19px">
                <asp:ListItem Value="True">Ascendent</asp:ListItem>
                <asp:ListItem Value="False">Descendent</asp:ListItem>
                </asp:DropDownList>
            <asp:DropDownList ID="DropDownList3" runat="server" Height="21px" style="margin-left: 37px; margin-right: 0px" Width="108px"></asp:DropDownList>   
            <asp:Button ID="Button3" runat="server" Text="search" OnClick="Button3_Click" style="margin-left: 36px" />
            </p>
            <p>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Price"></asp:Label>
           </p>
       <asp:ListBox ID="ListBox1" runat="server" Height="130px" Width="286px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="True" ></asp:ListBox>
         <p>
             <asp:Button ID="Button4" runat="server" Text="Back" OnClick="Button4_Click" />
         </p>
    </form>
</body>
</html>
