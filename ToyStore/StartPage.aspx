<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StartPage.aspx.cs" Inherits="ToyStore.StartPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to the Toystore</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <style>
       h1{
            background-color: #ccccff;
    padding: 20px;
    text-align: center;
    font-family:'Times New Roman';
    font-size: 35px;
    color: black;   
       }
       div{
           text-align:center;
           align-content:center;
           margin:auto;
       }
       p{
           margin:auto;
           padding:5px;
           text-align:left;
            width: 300px;
        }
       body{
           background-color: #ccccff;
       }
       #Button1{
            background-color:firebrick;
            padding:10px;
            margin-right:60px;
       }
       #Button2{
           background-color:firebrick;
           padding:10px;
           
       }
       
       #TextBox1{
           margin:auto;
       }
       #TextBox2{
           margin:auto;
       }
       #DropDownList1{
           margin-left:110px;
       }
    </style>
</head>
<body>
    <form id="form1" runat="server">
            <h1>Welcome to the Toystore</h1>
        <div>
        <p>
        <asp:Label ID="Label1" runat="server" Text="Telephone:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="150px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Width="150px"></asp:TextBox>
        </p>
        <p>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Selected="True">Customer</asp:ListItem>
                <asp:ListItem>Employee</asp:ListItem>
                <asp:ListItem>Admin</asp:ListItem>
            </asp:DropDownList>
        </p>
            <p>
        <asp:Button ID="Button1" runat="server" Text="login" Width="107px" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Proceed as guest" Width="131px" OnClick="Button2_Click" />
                </p>
            </div>
    </form>
</body>
</html>
