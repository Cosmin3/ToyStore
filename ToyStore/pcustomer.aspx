<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pcustomer.aspx.cs" Inherits="ToyStore.WebForm2" %>

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

        #TextBox1 {
            margin: auto auto auto 6px;
            border-radius: 5px;
        }

        #DropDownList1 {
            background-color: skyblue;
            border: 2px solid cornflowerblue;
            color: darkblue;
            font-size: 16px;
            cursor: pointer;
            border-radius: 5px;
            margin-left: 110px;
        }

        #DropDownList2 {
            background-color: skyblue;
            border: 2px solid cornflowerblue;
            color: darkblue;
            font-size: 16px;
            cursor: pointer;
            border-radius: 5px;
            margin-left: 110px;
        }

        #DropDownList3 {
            background-color: skyblue;
            border: 2px solid cornflowerblue;
            color: darkblue;
            font-size: 16px;
            cursor: pointer;
            border-radius: 5px;
            margin-left: 110px;
        }


        #ListBox1 {
            margin: auto auto auto 6px;
            border-radius: 5px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <p>
            <asp:Label ID="Label4" runat="server" Text="Welcome! "></asp:Label>

        </p>
        <asp:Label ID="Label3" runat="server" Text="Search"></asp:Label>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:DropDownList ID="DropDownList1" runat="server" Style="margin-left: 35px">
                <asp:ListItem Value="productName">Name</asp:ListItem>
                <asp:ListItem Value="buyPrice">Price</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Style="margin-left: 38px" Height="19px">
                <asp:ListItem Value="True">Ascendent</asp:ListItem>
                <asp:ListItem Value="False">Descendent</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList3" runat="server" Height="21px" Style="margin-left: 37px; margin-right: 0px" Width="108px"></asp:DropDownList>
            <button id="Button3" runat="server" onserverclick="Button3_Click"><i class="fa fa-search">Search</i></button>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Price"></asp:Label>
        </p>
        <asp:ListBox ID="ListBox1" runat="server" Height="130px" Width="286px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
        <p>
             <button id="Button4" runat="server" onserverclick="Button4_Click" ><i class="fa fa-mail-reply">   Back</i></button>
            
        </p>
    </form>
</body>
</html>
