<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderStats.aspx.cs" Inherits="FoodOrderManagement.OrderStats" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">

<h3>Order Statistics</h3>

<asp:Label ID="lblTotal" runat="server" /><br />
<asp:Label ID="lblActive" runat="server" />

</asp:Content>