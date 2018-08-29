<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="ToyStore.Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title></title>
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
            margin-left: 1065px;
            margin-top: 11px;
            margin-bottom: 0px;
        }

            #Button2:active:hover {
                background-color: RoyalBlue;
                border-radius: 12px;
                color: black;
                box-shadow: none;
            }
        #Button3 {
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
            margin-left: 36px;
        }

            #Button3:active:hover {
                background-color: RoyalBlue;
                border-radius: 12px;
                color: black;
                box-shadow: none;
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
            margin-left: 519px;
        }

            #Button4:active:hover {
                background-color: RoyalBlue;
                border-radius: 12px;
                color: black;
                box-shadow: none;
            }

        #DropDownList1 {
            background-color: skyblue;
            border: 2px solid cornflowerblue;
            color: darkblue;
            font-size: 16px;
            cursor: pointer;
            border-radius: 5px;
            margin-left: 57px;
        }

        #DropDownList2 {
            background-color: skyblue;
            border: 2px solid cornflowerblue;
            color: darkblue;
            font-size: 16px;
            cursor: pointer;
            border-radius: 5px;
            margin-left: 37px;
        }

        #DropDownList3 {
            background-color: skyblue;
            border: 2px solid cornflowerblue;
            color: darkblue;
            font-size: 16px;
            cursor: pointer;
            border-radius: 5px;
            margin-left: 31px;
        }

        .topButton {
            float: right;
            margin-left: 37px;
        }

        #ListBox1 {
            margin: auto auto auto 6px;
            border-radius: 5px;
        }

        #TextBox1 {
            margin: auto auto auto 6px;
            border-radius: 5px;
        }

        #TextBox2 {
            margin: auto auto auto 6px;
            border-radius: 5px;
        }

        #TextBox3 {
            margin: auto auto auto 6px;
            border-radius: 5px;
        }

        .topButton {
            float: right;
        }
        #Button6 {
            background-color: DodgerBlue;
            box-shadow: 0 12px 16px 0 rgba(0,0,0,0.24),0 17px 50px 0 rgba(0,0,0,0.19);
            color: white;
            text-decoration: none;
            padding: 15px 26px;
            position: relative;
            display: inline-block;
            border-radius: 5px;
            margin-left: 1100px;
        }

            #Button6:hover {
                background: red;
            }

            #Button6:active:hover {
                background-color: RoyalBlue;
                color: black;
                box-shadow: none;
            }

            

        #ButtonNote {
                position: absolute;
                border-radius: 12px;
                background-color: red;
                color: white;
                border: 2px solid red;
            }
        .auto-style1 {
            background-color: DodgerBlue;
            box-shadow: 0 12px 16px 0 rgba(0,0,0,0.24),0 17px 50px 0 rgba(0,0,0,0.19);
            color: white;
            text-decoration: none;
            padding: 15px 26px;
            position: relative;
            display: inline-block;
            border-radius: 5px;
            margin-left: 945px;
        }
        .auto-style2 {
            left: 1189px;
            top: 40px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">

        <div>
            <p>
                <asp:Label ID="Label4" runat="server" Text="Welcome: "></asp:Label>

            </p>
            <button id="Button6" class="auto-style1" runat="server" onserverclick="Button6_Click">
                <span><i class="fa fa-shopping-cart">  Cart</i></span>
                
            </button>

            <asp:Button id="ButtonNote" runat="server"  CssClass="auto-style2"  Visible="false"/>

            <asp:Button ID="Button2" runat="server" Text="Notifications" OnClick="Button2_Click" />
            <p>
                <asp:Label ID="Label3" runat="server" Text="Search"></asp:Label>
            </p>
            <p>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:DropDownList ID="DropDownList1" runat="server" Style="margin-left: 14px">
                    <asp:ListItem Value="productName">Name</asp:ListItem>
                    <asp:ListItem Value="buyPrice">Price</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="DropDownList2" runat="server" Style="margin-left: 15px">
                    <asp:ListItem Value="True">Ascendent</asp:ListItem>
                    <asp:ListItem Value="False">Descendent</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="DropDownList3" runat="server" Style="margin-left: 16px"></asp:DropDownList>
                <button id="Button3" runat="server" onserverclick="Button3_Click"><i class="fa fa-search">  Search</i></button>
            </p>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                <asp:Label ID="Label2" runat="server" Text="Price"></asp:Label>
            </p>
            <asp:ListBox ID="ListBox1" runat="server" Height="130px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>

            <asp:Label ID="Label5" runat="server" Text="Quantity:"></asp:Label>


            <asp:TextBox ID="TextBox2" runat="server" Style="margin-left: 25px" Width="72px"></asp:TextBox>
            <asp:Label ID="Label6" runat="server" Text="Price:"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Style="margin-left: 23px" Width="76px"></asp:TextBox>
            <button id="Button1" runat="server" onserverclick="Button1_Click" ><i class="fa fa-cart-arrow-down">  Add to cart</i></button>
            <button id="Button4" runat="server" onserverclick="Button4_Click"><i class="fa fa-sign-out">  Logout</i></button>

        </div>
    </form>
</body>
</html>
