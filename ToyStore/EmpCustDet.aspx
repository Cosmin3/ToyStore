<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpCustDet.aspx.cs" Inherits="ToyStore.EmpCustDet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style> 
        #ListBox1{
           display:inline-block;
           text-align:center;
           
        }
        table{
            text-align: center;
        }

        .auto-style1 {
            height: 26px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <table style="width:100%">
                <tr>
                    <td class="auto-style1"></td>
                    <td class="auto-style1">Customer Details</td>
                    <td class="auto-style1">Customer Orders</td>
                </tr>
                <tr>
                <th align="right">

            <asp:Label ID="Label1" runat="server" Text="Customer Number: "></asp:Label>

            <p>
            <asp:Label ID="Label3" runat="server" Text="Customer Name: "></asp:Label>
           </p>
            <p>
            <asp:Label ID="Label5" runat="server" Text="Contact Last Name: "></asp:Label>
           </p>
            <p>
            <asp:Label ID="Label7" runat="server" Text="Contact First Name: "></asp:Label>
           </p>
            <p>
            <asp:Label ID="Label9" runat="server" Text="Phone: "></asp:Label>
           </p>
            <p>
            <asp:Label ID="Label11" runat="server" Text="Address 1: "></asp:Label>
           </p>
            <p>
            <asp:Label ID="Label13" runat="server" Text="Address 2: "></asp:Label>
           </p>
            <p>
            <asp:Label ID="Label15" runat="server" Text="City: "></asp:Label>
           </p>
            <p>
            <asp:Label ID="Label17" runat="server" Text="State: "></asp:Label>
           </p>
            <p>
            <asp:Label ID="Label19" runat="server" Text="Postal Code: "></asp:Label>
           </p>
            <p>
            <asp:Label ID="Label21" runat="server" Text="Country: "></asp:Label>
           </p>
            <p>
            <asp:Label ID="Label23" runat="server" Text="Credit Limit: "></asp:Label>
           </p>
                </th>
                    <th>
                                    <p><asp:Label ID="Label2" runat="server" Text=""></asp:Label></p>
                                    <p><asp:Label ID="Label4" runat="server" Text=""></asp:Label></p>
                                    <p><asp:Label ID="Label6" runat="server" Text=""></asp:Label></p>
                                    <p><asp:Label ID="Label8" runat="server" Text=""></asp:Label></p>
                                    <p><asp:Label ID="Label10" runat="server" Text=""></asp:Label></p>
                                    <p><asp:Label ID="Label12" runat="server" Text=""></asp:Label></p>
                                    <p><asp:Label ID="Label14" runat="server" Text=""></asp:Label></p>
                                    <p><asp:Label ID="Label16" runat="server" Text=""></asp:Label></p>
                                    <p><asp:Label ID="Label18" runat="server" Text=""></asp:Label></p>
                                    <p><asp:Label ID="Label20" runat="server" Text=""></asp:Label></p>
                                    <p><asp:Label ID="Label22" runat="server" Text=""></asp:Label></p>
                                    <p><asp:Label ID="Label24" runat="server" Text=""></asp:Label></p>
                                              
                    </th>
                <th>
                <asp:ListBox ID="ListBox1" runat="server" Height="130px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="True" ></asp:ListBox>

                </th>
                    </tr>
            </table>
            <asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" />
            <asp:Button ID="Button2" float="right" runat="server" Text="Logout" OnClick="Button2_Click" />
        </div>
        
    </form>
</body>
</html>
