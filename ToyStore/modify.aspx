﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modify.aspx.cs" Inherits="ToyStore.modify" %>
<%@ PreviousPageType VirtualPath="~/padmin.aspx"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Code"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Enabled="False" style="margin-left: 62px"></asp:TextBox>
            </p>
            <p>
                 <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 56px"></asp:TextBox>
            </p>
            <p>
                 <asp:Label ID="Label3" runat="server" Text="Line"></asp:Label>
                 <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="170px" style="margin-left: 66px">
                 </asp:DropDownList>
            </p>
            <p>
                 <asp:Label ID="Label4" runat="server" Text="Scale"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 54px"></asp:TextBox>
            </p>
            <p>
                 <asp:Label ID="Label5" runat="server" Text="Vendor"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 37px"></asp:TextBox>
            </p>
            <p>
                 <asp:Label ID="Label6" runat="server" Text="Description"></asp:Label>
                <asp:TextBox ID="TextBox6" runat="server" style="margin-left: 2px"></asp:TextBox>
            </p>
            <p>
                 <asp:Label ID="Label7" runat="server" Text="Quantity"></asp:Label>
                <asp:TextBox ID="TextBox7" runat="server" style="margin-left: 31px"></asp:TextBox>
            </p>
            <p>
                 <asp:Label ID="Label8" runat="server" Text="Price"></asp:Label>
                <asp:TextBox ID="TextBox8" runat="server" style="margin-left: 53px"></asp:TextBox>
            </p>
            <p>
                 <asp:Label ID="Label9" runat="server" Text="MSRP"></asp:Label>
                <asp:TextBox ID="TextBox9" runat="server" style="margin-left: 44px"></asp:TextBox>
            </p>
            <asp:Button ID="Button1" runat="server" Text="modify product" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
