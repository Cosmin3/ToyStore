<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeOrderNegociate.aspx.cs" Inherits="ToyStore.EmployeeOrderNegociate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #ListBox1 {
            display: inline-block;
            text-align: center;
        }

        table {
            text-align: center;
        }

        .auto-style1 {
            height: 26px;
        }
        #Button2{
            
            float: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table style="width: 100%">
                <tr>
                    <td class="auto-style1">Products</td>
                    <td class="auto-style1" align="right">Product</td>
                    <td class="auto-style1" align="left">Details</td>
                </tr>
                <tr>
                    <th>
                        <asp:ListBox ID="ListBox1" runat="server" Height="130px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>



                    </th>
                    <th align="right">
                        <p>
                            <asp:Label ID="Label1" runat="server" Text="Product Name: "></asp:Label></p>       
                        <p>
                            <asp:Label ID="Label2" runat="server" Text="Price Each: "></asp:Label></p>
                        <p>
                            <asp:Label ID="Label3" runat="server" Text="Quantity ordered: "></asp:Label></p>
                        <p>
                            <asp:Label ID="Label4" runat="server" Text="Quantity in Stock: "></asp:Label></p>
                        

                    </th>
                    <th align="left">
                        
                        <p><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></p>
                        <p><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></p>
                        <p><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></p>
                        <p><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></p>
                        
                    </th>
                </tr>
            </table>
            <asp:Button ID="Button1" runat="server" Text="Modify" OnClick="Button1_Click" />
            <asp:Button ID="Button3" runat="server" Text="Undo" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="Accept" OnClick="Button4_Click" />
        <asp:Button ID="Button2" runat="server" Text="Accept the offer" />
        </div>
        
    </form>
</body>
</html>
