<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpCustDet.aspx.cs" Inherits="ToyStore.EmpCustDet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
    <style> 
         body {
            background-color: #ccccff;
        }

         #Button1 {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            background-color: DodgerBlue;
            color: white;
            padding: 12px 16px;
            font-size: 16px;
            cursor: pointer;
            border-radius: 12px;
            box-shadow: 0 12px 16px 0 rgba(0,0,0,0.24),0 17px 50px 0 rgba(0,0,0,0.19);
            margin-left: 20px;
        }

            #Button1:active:hover {
                background-color: RoyalBlue;
                border-radius: 12px;
                color: black;
                box-shadow: none;
            }
        

          #Button2 {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            background-color: DodgerBlue;
            color: white;
            padding: 12px 16px;
            font-size: 16px;
            cursor: pointer;
            border-radius: 12px;
            box-shadow: 0 12px 16px 0 rgba(0,0,0,0.24),0 17px 50px 0 rgba(0,0,0,0.19);
            margin-left: 20px;
        }

            #Button2:active:hover {
                background-color: RoyalBlue;
                border-radius: 12px;
                color: black;
                box-shadow: none;
            }

         #ListBox1 {
            margin: auto auto 43px 6px;
            border-radius: 5px;
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
              <button id="Button1" runat="server" onserverclick="Button1_Click" ><i class="fa fa-mail-reply">   Back</i></button>    
            <asp:Button ID="Button2" float="right" runat="server" Text="Logout" OnClick="Button2_Click" />
        </div>
        
    </form>
</body>
</html>
