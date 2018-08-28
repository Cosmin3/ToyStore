<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forDesign.aspx.cs" Inherits="ToyStore.forDesign" %>



<!DOCTYPE html >

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />

    <meta name="viewport" content="width=device-width, initial-scale=1" />


    <style>
        body {
            font-family: Arial, Helvetica, sans-serif;
        }

        #Button1 {
            background-color: #4CAF50;
            color: white;
            border-radius: 12px;
            padding: 10px;
            border: 2px solid #4CAF50;
        }

            #Button1:hover {
                background-color: white;
                color: black;
                box-shadow: 0 12px 16px 0 rgba(0,0,0,0.24),0 17px 50px 0 rgba(0,0,0,0.19);
                padding: 10px;
                border-radius: 12px;
            }

        #Button2 {
            display: inline-block;
            border-radius: 4px;
            background-color: #f4511e;
            border: none;
            color: #FFFFFF;
            text-align: center;
            font-size: 28px;
            padding: 20px;
            width: 200px;
            transition: all 0.5s;
            cursor: pointer;
            margin: 5px;
        }

            #Button2 span {
                cursor: pointer;
                display: inline-block;
                position: relative;
                transition: 0.5s;
            }

                #Button2 span:after {
                    content: '\00bb';
                    position: absolute;
                    opacity: 0;
                    top: 0;
                    right: -20px;
                    transition: 0.5s;
                }

            #Button2:hover span {
                padding-right: 25px;
            }

                #Button2:hover span:after {
                    opacity: 1;
                    right: 0;
                }



        #Button3 {
            position: relative;
            background-color: #4CAF50;
            border: none;
            font-size: 28px;
            color: #FFFFFF;
            padding: 20px;
            width: 200px;
            text-align: center;
            -webkit-transition-duration: 0.4s; /* Safari */
            transition-duration: 0.4s;
            text-decoration: none;
            overflow: hidden;
            cursor: pointer;
        }

            #Button3:after {
                content: "";
                background: #f1f1f1;
                display: block;
                position: absolute;
                padding-top: 300%;
                padding-left: 350%;
                margin-left: -20px !important;
                margin-top: -120%;
                opacity: 0;
                transition: all 0.8s
            }

            #Button3:active:after {
                padding: 0;
                margin: 0;
                opacity: 1;
                transition: 0s
            }

        #Button4 {
            background-color: orangered;
            border: 2px solid orangered;
            color: white;
            padding: 12px 16px;
            font-size: 16px;
            cursor: pointer;
            border-radius: 12px;
            box-shadow: 0 12px 16px 0 rgba(0,0,0,0.24),0 17px 50px 0 rgba(0,0,0,0.19);
        }

            #Button4:active:hover {
                color: black;
                background-color: red;
                border-radius: 12px;
                box-shadow: none;
            }

        #Button5 {
            background-color: DodgerBlue;
            border: none;
            color: white;
            padding: 12px 16px;
            font-size: 16px;
            cursor: pointer;
            border-radius: 12px;
            box-shadow: 0 12px 16px 0 rgba(0,0,0,0.24),0 17px 50px 0 rgba(0,0,0,0.19);
        }

            #Button5:hover {
                background-color: RoyalBlue;
                border-radius: 12px;
                color: black;
                box-shadow: none;
            }

        #Button6 {
            background-color: DodgerBlue;
            border: none;
            color: white;
            padding: 12px 16px;
            font-size: 16px;
            cursor: pointer;
            border-radius: 12px;
            box-shadow: 0 12px 16px 0 rgba(0,0,0,0.24),0 17px 50px 0 rgba(0,0,0,0.19);
        }

            #Button6:hover {
                background-color: RoyalBlue;
                border-radius: 12px;
                color: black;
                box-shadow: none;
            }



        #field-icon {
            float: right;
            margin-left: -25px;
            margin-top: -25px;
            position: relative;
            z-index: 2;
        }

        .Button7 {
            background-color: DodgerBlue;
            box-shadow: 0 12px 16px 0 rgba(0,0,0,0.24),0 17px 50px 0 rgba(0,0,0,0.19);
            color: white;
            text-decoration: none;
            padding: 15px 26px;
            position: relative;
            display: inline-block;
            border-radius: 5px;
        }

            .Button7:hover {
                background: red;
            }

            .Button7:active:hover {
                background-color: RoyalBlue;
                color:black;
                box-shadow:none;
            }

            .Button7 .badge {
                position: absolute;
                top: -10px;
                right: -10px;
                padding: 5px 10px;
                border-radius: 50%;
                background-color: red;
                color: white;
            }
    </style>

</head>
<body>

    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <p>
            <button id="Button2" runat="server"><span>Click</span></button>
            /*onserverclick="Button2_Click"*/
        </p>
        <asp:Button ID="Button3" runat="server" Text="Button" />
        <p>
            <button id="Button4" runat="server"><i class="fa fa-trash">Remove</i></button>

        </p>
        <button id="Button5" runat="server"><i class="fa fa-search">Search</i></button>
        <p>
            <button id="Button6" runat="server"><i class="fa fa-save">Save</i> </button>
        </p>
        <button  id="Button7" class="Button7" runat="server"><span><i class="fa fa-save">Save</i></span><span class="badge">6</span></button>
        

        <p>
        </p>
        <p>
            <input id="Password1" type="password" class="form-control" name="password" />
            <span data-toggle="#Password1" class="fa fa-fw fa-eye "></span>

        </p>
        <p>
            Password:
            <input type="password" value="FakePSW" id="myEye"><br>
            <br>
            <span class="fa fa-fw fa-eye " onclick="myFunction()"></span>Show Password

            <script>
                function myFunction() {
                    var x = document.getElementById("myEye");
                    if (x.type == "password") {
                        x.type = "text";
                        <span class="fa fa-fw fa-eye "> </span>;
                    } else {
                        x.type = "password";
                        <span class="fa-eye fa-eye-slash "> </span>

                    }
                }
            </script>
        </p>

    </form>
</body>
</html>
