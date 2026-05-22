<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductsDemo.aspx.cs" Inherits="ASP_Assignment_1.ProductsDemo" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Demo</title>

    <style>
        body {
            font-family: Arial;
            background-color: #f2f2f2;
        }

        .container {
            width: 400px;
            margin: 30px auto;
            background-color: white;
            padding: 20px;
            border: 1px solid #ccc;
            text-align: center;
        }

        h2 {
            color: blue;
        }

        select, button {
            width: 80%;
            padding: 5px;
            margin-top: 10px;
        }

        img {
            margin-top: 15px;
        }
    </style>

</head>

<body>

<form id="form1" runat="server">

<div class="container">

<h2>Select Product</h2>

<asp:DropDownList ID="ddlProducts" runat="server"
    AutoPostBack="true"
    OnSelectedIndexChanged="ddlProducts_SelectedIndexChanged">
</asp:DropDownList>

<br />

<asp:Image ID="imgProduct" runat="server" Height="150px" />

<br />

<asp:Button ID="btnPrice" runat="server"
    Text="Show Price"
    OnClick="btnPrice_Click" />

<br /><br />

<asp:Label ID="lblPrice" runat="server"></asp:Label>

</div>

</form>

</body>
</html>
