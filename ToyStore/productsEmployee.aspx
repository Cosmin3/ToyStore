<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productsEmployee.aspx.cs" Inherits="ToyStore.productsEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
    <style>
        body {
            background-color: #ccccff;
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
            margin-left: 27px;
        }

            #Button3:active:hover {
                background-color: RoyalBlue;
                border-radius: 12px;
                color: black;
                box-shadow: none;
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
            margin-left: 1272px;
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

        #Button6 {
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
            margin-left: 0px;
            margin-right: 0px;
        }

            #Button6:active:hover {
                background-color: RoyalBlue;
                border-radius: 5px;
                color: black;
                box-shadow: none;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <p>
                <asp:Label ID="Label4" runat="server" Text="Welcome: "></asp:Label>

            </p>
            <p>
                <asp:Button ID="Button6" class="topButton" runat="server" Text="Pending Orders" OnClick="Button6_Click" />
                <asp:Button ID="Button5" class="topButton" runat="server" Text="My Customers" OnClick="Button5_Click" />
            </p>
            <asp:Label ID="Label3" runat="server" Text="Search"></asp:Label>
            <p>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem Value="productName">Name</asp:ListItem>
                    <asp:ListItem Value="buyPrice">Price</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                    <asp:ListItem Value="True">Ascendent</asp:ListItem>
                    <asp:ListItem Value="False">Descendent</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="DropDownList3" runat="server" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged"></asp:DropDownList>

                <button id="Button3" runat="server" onserverclick="Button3_Click"><i class="fa fa-search">Search</i></button>

                <button id="Button1" runat="server" onserverclick="Button1_Click"><i class="fa fa-plus">Add</i></button>
                <button id="Button2" runat="server" onserverclick="Button2_Click" onclientclick="return confirm('Are you sure?')" style="margin-left: 19px"><i class="fa fa-trash">Remove</i></button>
            </p>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                <asp:Label ID="Label2" runat="server" Text="Price"></asp:Label>
            </p>
            <asp:ListBox ID="ListBox1" runat="server" Height="130px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="True" Width="333px"></asp:ListBox>



        </div>
        <button id="Button4" runat="server" onserverclick="Button4_Click"><i class="fa fa-sign-out">Logout</i></button>
    </form>
</body>
</html>
