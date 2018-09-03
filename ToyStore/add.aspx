<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="ToyStore.add" %>

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
                 #TextBox5 {
            margin: auto auto auto 6px;
            border-radius: 5px;
        }
                  #TextBox6 {
            margin: auto auto auto 6px;
            border-radius: 5px;
        }
                   #TextBox7 {
            margin: auto auto auto 6px;
            border-radius: 5px;
        }
                    #TextBox8 {
            margin: auto auto auto 6px;
            border-radius: 5px;
        }
                     #TextBox9 {
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
            margin-left: 50px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Code"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 38px"></asp:TextBox>
            </p>
            <p>
                 <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 34px"></asp:TextBox>
            </p>
            <p>
                 <asp:Label ID="Label3" runat="server" Text="Line"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" Height="25px" Width="145px">
                 </asp:DropDownList>
            </p>
            <p>
                 <asp:Label ID="Label4" runat="server" Text="Scale"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 37px"></asp:TextBox>
            </p>
            <p>
                 <asp:Label ID="Label5" runat="server" Text="Vendor"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 25px"></asp:TextBox>
            </p>

            <p>
                 <asp:Label ID="Label7" runat="server" Text="Quantity"></asp:Label>
                <asp:TextBox ID="TextBox7" runat="server" style="margin-left: 17px"></asp:TextBox>
            </p>
            <p>
                 <asp:Label ID="Label8" runat="server" Text="Price"></asp:Label>
                <asp:TextBox ID="TextBox8" runat="server" style="margin-left: 40px"></asp:TextBox>
            </p>
            <p>
                 <asp:Label ID="Label9" runat="server" Text="MSRP"></asp:Label>
                <asp:TextBox ID="TextBox9" runat="server" style="margin-left: 30px"></asp:TextBox>
            </p>
            <p>
<asp:Label ID="Label6" runat="server" Text="Description"></asp:Label>            </p>
            <p>
                 
                <asp:TextBox ID="TextBox6" TextMode="multiline" style="resize:both" runat="server" Width="199px" Height="84px"></asp:TextBox>
                
            </p>
            <asp:Button ID="Button1" runat="server" Text="Add Product" OnClick="Button1_Click" OnClientClick="return confirm('Are you sure?')"/>
             <button id="Button2" runat="server" onserverclick="Button2_Click" style="margin-left: 40px"><i class="fa fa-mail-reply">   Back</i></button>
            
        </div>
    </form>
</body>
</html>
