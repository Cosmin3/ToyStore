<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StartPage.aspx.cs" Inherits="ToyStore.StartPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to the Toystore</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <style>
       h1{
            background-color: #b2fe01;
    padding: 20px;
    text-align: center;
    font-size: 35px;
    color: black;   
       }
       p{
           padding:5px;
           text-align:left;
            width: 718px;
        }
       body{
           background-color: #b2fe01;
       }
       #Button1{
            background-color:firebrick;
            padding:10px;
       }
       #Button2{
           background-color:firebrick;
           padding:10px;
       }
       }
       #Label1{
           padding-right:22px;
       }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome to the Toystore</h1>
        </div>
        <p>
        <asp:Label ID="Label1" runat="server" Text="Telephone:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="99px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Width="99px"></asp:TextBox>
        </p>
        <p>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Selected="True">Customer</asp:ListItem>
                <asp:ListItem>Employee</asp:ListItem>
                <asp:ListItem>Admin</asp:ListItem>
            </asp:DropDownList>
        </p>
        <asp:Button ID="Button1" runat="server" Text="login" Width="84px" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Proceed as guest" Width="117px" />
    </form>
</body>
</html>
