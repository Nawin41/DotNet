<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEditMenu.aspx.cs" Inherits="FoodOrderManagement.AddEditMenu" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">

<h3>Add / Edit Menu</h3>

Item:
<asp:TextBox ID="txtName" runat="server" /><br />

Category:
<asp:TextBox ID="txtCat" runat="server" /><br />

Price:
<asp:TextBox ID="txtPrice" runat="server" /><br />

<asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />

</asp:Content>
