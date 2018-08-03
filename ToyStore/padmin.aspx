<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="padmin.aspx.cs" Inherits="ToyStore.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label3" runat="server" Text="Search"></asp:Label>
            <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:DropDownList ID="DropDownList1" runat="server">
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
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Remove" />
            </p>
            <p>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Price"></asp:Label>
           </p>
       <asp:ListBox ID="ListBox1" runat="server" Height="130px" Width="286px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="True" ></asp:ListBox>
       
    </form>
</body>
</html>
