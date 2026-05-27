<%@ Page Language="C#" MasterPageFile="~/Site.Master"
AutoEventWireup="true"
CodeBehind="MenuList.aspx.cs"
Inherits="FoodOrderManagement.MenuList" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">

<h3>Menu Items</h3>

<asp:GridView ID="gvMenu" runat="server" AutoGenerateColumns="false">
    <Columns>

        <asp:BoundField DataField="ItemName" HeaderText="Item" />
        <asp:BoundField DataField="Price" HeaderText="Price" />

        <asp:HyperLinkField Text="View"
            DataNavigateUrlFields="MenuId"
            DataNavigateUrlFormatString="MenuDetails.aspx?MenuId={0}" />

        <asp:HyperLinkField Text="Edit"
            DataNavigateUrlFields="MenuId"
            DataNavigateUrlFormatString="AddEditMenu.aspx?MenuId={0}" />

    </Columns>
</asp:GridView>

<br />

<asp:Label ID="lblCacheMsg" runat="server" />

<br /><br />

<asp:GridView ID="gvStats" runat="server"></asp:GridView>

</asp:Content>