<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeCust.aspx.cs" Inherits="ToyStore.EmployeeCust" %>

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
            <p>
            <asp:Label ID="Label1" runat="server" Text="Customers: "></asp:Label>
            </p>
       <asp:ListBox ID="ListBox1" runat="server" Height="130px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="True" ></asp:ListBox>
       
            
       
        </div>
                <asp:Button ID="Button5" runat="server" Text="Back" OnClick="Button5_Click" />
                <asp:Button ID="Button4" runat="server" Text="LogOut" OnClick="Button4_Click" />

        <p>
            &nbsp;</p>

    </form>
</body>
</html>
