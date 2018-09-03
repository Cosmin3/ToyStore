<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeOrderNegociate.aspx.cs" Inherits="ToyStore.EmployeeOrderNegociate" %>

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
                 float: right;
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
            margin-left: 20px;
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
            margin-left: 20px;
        }

            #Button4:active:hover {
                background-color: RoyalBlue;
                border-radius: 12px;
                color: black;
                box-shadow: none;
            }

            #Button5{
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

            #Button5:active:hover {
                background-color: RoyalBlue;
                border-radius: 12px;
                color: black;
                box-shadow: none;
            }


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
        
        .auto-style2 {
            margin-left: 51px;
            margin-right: 0px;
        }

         #ListBox1 {
            margin: auto auto auto -100px;
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
        #TextBox4 {
            margin: auto auto auto 6px;
            border-radius: 5px;
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
                        <asp:ListBox ID="ListBox1" runat="server" Height="130px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="True" CssClass="auto-style2" Width="300px"></asp:ListBox>



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
                        
                        <p><asp:TextBox ID="TextBox1" runat="server" Width="230px"></asp:TextBox></p>
                        <p><asp:TextBox ID="TextBox2" runat="server" Width="230px"></asp:TextBox></p>
                        <p><asp:TextBox ID="TextBox3" runat="server" Width="230px"></asp:TextBox></p>
                        <p><asp:TextBox ID="TextBox4" runat="server" Width="230px"></asp:TextBox></p>
                        
                    </th>
                </tr>
            </table>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Modify" OnClick="Button1_Click" />
            <asp:Button ID="Button3" runat="server" Text="Undo" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="Accept" OnClick="Button4_Click" OnClientClick="return confirm('Are you sure?')" />
        <asp:Button ID="Button2" runat="server" Text="Accept the offer" OnClick="Button2_Click" OnClientClick="return confirm('Are you sure?')" />
        </div>
            
        <p><asp:Button ID="Button5" runat="server" Text="Cancel" OnClick="Button5_Click" OnClientClick="return confirm('Are you sure?')"/></p>
    </form>
</body>
</html>
