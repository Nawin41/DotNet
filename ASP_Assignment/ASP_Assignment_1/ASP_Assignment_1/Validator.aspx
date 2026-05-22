<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="ASP_Assignment_1.Validator" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validation Page</title>

    <style>
        body {
            font-family: Arial;
            background-color: #f2f2f2;
        }

        form {
            width: 400px;
            margin: 30px auto;
            background-color: white;
            padding: 20px;
            border: 1px solid #ccc;
        }

        h2 {
            text-align: center;
            color: blue;
        }

        input {
            width: 95%;
            padding: 5px;
            margin-bottom: 10px;
        }

        .error {
            color: red;
            font-size: 12px;
        }

        .success {
            color: green;
            font-weight: bold;
        }
    </style>

</head>

<body>

<form id="form1" runat="server">

<h2>User Validation Form</h2>

Name:
<asp:TextBox ID="txtName" runat="server" />
<asp:RequiredFieldValidator ControlToValidate="txtName" runat="server"
    ErrorMessage="Required" CssClass="error" /><br />

Family Name:
<asp:TextBox ID="txtFamily" runat="server" />
<asp:RequiredFieldValidator ControlToValidate="txtFamily" runat="server"
    ErrorMessage="Required" CssClass="error" /><br />

Address:
<asp:TextBox ID="txtAddress" runat="server" />
<asp:RegularExpressionValidator ControlToValidate="txtAddress"
    ValidationExpression=".{2,}"
    ErrorMessage="Min 2 letters"
    CssClass="error" runat="server" /><br />

City:
<asp:TextBox ID="txtCity" runat="server" />
<asp:RegularExpressionValidator ControlToValidate="txtCity"
    ValidationExpression=".{2,}"
    ErrorMessage="Min 2 letters"
    CssClass="error" runat="server" /><br />

Zip Code:
<asp:TextBox ID="txtZip" runat="server" />
<asp:RegularExpressionValidator ControlToValidate="txtZip"
    ValidationExpression="^\d{5}$"
    ErrorMessage="5 digits only"
    CssClass="error" runat="server"/><br />

Phone:
<asp:TextBox ID="txtPhone" runat="server" />
<asp:RegularExpressionValidator ControlToValidate="txtPhone"
    ValidationExpression="^(\d{2}-\d{7}|\d{10})$"
    ErrorMessage="Format: XX-XXXXXXX or XXXXXXXXXX"
    CssClass="error" runat="server"/><br />

Email:
<asp:TextBox ID="txtEmail" runat="server" />
<asp:RegularExpressionValidator ControlToValidate="txtEmail"
    ValidationExpression="^\w+@\w+\.\w+$"
    ErrorMessage="Invalid Email"
    CssClass="error" runat="server" /><br />

<br />

<asp:Button ID="btnCheck" runat="server" Text="Check" OnClick="btnCheck_Click" />

<br /><br />

<asp:Label ID="lblMessage" runat="server" CssClass="success"></asp:Label>

</form>

</body>
</html>