<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modify.aspx.cs" Inherits="ToyStore.modify" %>
<%@ PreviousPageType VirtualPath="~/padmin.aspx"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #Button2{
            float: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Code"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Enabled="False" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            </p>
            <p>
                 <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            <p>
                 <asp:Label ID="Label3" runat="server" Text="Line"></asp:Label>
                 <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="145px">
                 </asp:DropDownList>
            </p>
            <p>
                 <asp:Label ID="Label4" runat="server" Text="Scale"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </p>
            <p>
                 <asp:Label ID="Label5" runat="server" Text="Vendor"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </p>
            
            <p>
                 <asp:Label ID="Label7" runat="server" Text="Quantity"></asp:Label>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </p>
            <p>
                 <asp:Label ID="Label8" runat="server" Text="Price"></asp:Label>
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            </p>
            <p>
                 <asp:Label ID="Label9" runat="server" Text="MSRP"></asp:Label>
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            </p>
            <p>
<asp:Label ID="Label6" runat="server" Text="Description"></asp:Label>            </p>
            <p>
                 
                <asp:TextBox ID="TextBox6" TextMode="multiline" style="resize:both" runat="server" Width="199px" Height="84px"></asp:TextBox>
                
            </p>
            <asp:Button ID="Button1" runat="server" Text="modify product" OnClick="Button1_Click" OnClientClick="return confirm('Are you sure?')"/>
            <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
