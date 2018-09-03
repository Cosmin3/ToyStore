<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpPendingOrders.aspx.cs" Inherits="ToyStore.EmpPendingOrders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
    <style>
        body {
            background-color: #ccccff;
        }
             #Button4 {
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
            margin-left: 1158px;
        }

            #Button4:active:hover {
                background-color: RoyalBlue;
                border-radius: 5px;
                color: black;
                box-shadow: none;
            }

        #Button5 {
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
            margin-left: 5px;
            margin-right: 21px;
        }

            #Button5:active:hover {
                background-color: RoyalBlue;
                border-radius: 5px;
                color: black;
                box-shadow: none;
            }
            #ListBox1 {
            margin: auto auto auto 6px;
            border-radius: 5px;
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
            <asp:Label ID="Label1" runat="server" Text="Pending Orders: "></asp:Label>
            </p>
       <asp:ListBox ID="ListBox1" runat="server" Height="130px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="True" Width="420px" ></asp:ListBox>
       
            
       
        </div>
          <br />
          <button id="Button5" runat="server" onserverclick="Button5_Click" style="margin-left: 40px"><i class="fa fa-mail-reply">   Back</i></button>
        <button id="Button4" runat="server" onserverclick="Button4_Click"><i class="fa fa-sign-out">  Logout</i></button>

        
    </form>
</body>
</html>
