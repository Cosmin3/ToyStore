<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StartPage.aspx.cs" Inherits="ToyStore.StartPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to the Toystore</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <style>
        h1 {
            background-color: #ccccff;
            padding: 20px;
            text-align: center;
            font-family: 'Times New Roman';
            font-size: 35px;
            color: black;
        }

        div {
            text-align: center;
            align-content: center;
            margin: auto;
        }

        p {
            margin: auto;
            padding: 5px;
            text-align: left;
            width: 344px;
        }

        body {
            background-color: #ccccff;
        }

        #Button1 {
            background-color: darkblue;
            border: 2px solid darkblue;
            color: white;
            padding: 12px 16px;
            font-size: 16px;
            cursor: pointer;
            border-radius: 12px;
            box-shadow: 0 12px 16px 0 rgba(0,0,0,0.24),0 17px 50px 0 rgba(0,0,0,0.19);
        }

            #Button1:active:hover {
                color: black;
                background-color: blue;
                border: 2px solid blue;
                border-radius: 12px;
                box-shadow: none;
            }

        #Button2 {
            background-color: darkblue;
            border: 2px solid darkblue;
            color: white;
            padding: 12px 16px;
            font-size: 16px;
            cursor: pointer;
            border-radius: 12px;
            box-shadow: 0 12px 16px 0 rgba(0,0,0,0.24),0 17px 50px 0 rgba(0,0,0,0.19);
            margin-left: 65px;
        }

            #Button2:active:hover {
                color: black;
                background-color: blue;
                border: 2px solid blue;
                border-radius: 12px;
                box-shadow: none;
            }

        #TextBox1 {
            margin: auto auto auto 6px;
            border-radius: 10px;
        }

        #TextBox2 {
            border-radius: 10px;
            margin: auto auto auto 10px;
        }

        #DropDownList1 {
            background-color: cornflowerblue;
            border: 2px solid cornflowerblue;
            color: darkblue;
            font-size: 16px;
            cursor: pointer;
            border-radius: 12px;
            margin-left: 110px;
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
                <asp:TextBox ID="TextBox2" runat="server" Width="150px" type="password"> </asp:TextBox>
            </p>
            <p>
                <asp:CheckBox ID="CheckBox1" runat="server" onclick="myFunction()" class="fa fa-fw fa-eye" Text="Show password"  />
                <script>
                    function myFunction() {
                        var x = document.getElementById("TextBox2");
                        if (x.type === "password") {
                            x.type = "text";
                        } else {
                            x.type = "password";
                        }
                    }
                </script>
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
                <asp:Button ID="Button2" runat="server" Text="Proceed as guest" Width="164px" OnClick="Button2_Click" />
            </p>
        </div>
    </form>
</body>
</html>
