<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FoodOrderManagement.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>

    <style>
        body {
            font-family: Arial;
            background-color: #f4f4f4;
        }

        .box {
            width: 300px;
            margin: 120px auto;
            padding: 20px;
            background: white;
            border: 1px solid #ccc;
            text-align: center;
        }

        h2 {
            color: blue;
        }

        input {
            width: 90%;
            padding: 5px;
            margin: 8px 0;
        }

        .btn {
            background-color: #0078d7;
            color: white;
            border: none;
            padding: 6px 15px;
        }

        .error {
            color: red;
        }
    </style>
</head>

<body>
<form id="form1" runat="server">

<div class="box">

    <h2>Admin Login</h2>

    Username:<br />
    <asp:TextBox ID="txtUser" runat="server" /><br />

    Password:<br />
    <asp:TextBox ID="txtPass" runat="server" TextMode="Password" /><br />

    <asp:Button ID="btnLogin" runat="server"
        Text="Login"
        CssClass="btn"
        OnClick="btnLogin_Click" />

    <br /><br />

    <asp:Label ID="lblMsg" runat="server" CssClass="error" />

</div>

</form>
</body>
</html>
