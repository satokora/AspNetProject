<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SideBarDesigner.ascx.cs" Inherits="FestivalOfTrees.PageComponent.SideBarDesigner" %>

<div class="ui visible sidebar inverted vertical pointing menu">
    <div href="#" class="item">
        <img class="logo" src="assets/image/Logo_FestTree.png" />
    </div>
    <asp:LinkButton ID="BtnViewItems" runat="server" CssClass="item">View Items</asp:LinkButton>
    <asp:LinkButton ID="BtnEnterItem" runat="server" CssClass="item">Enter Item</asp:LinkButton>
    <asp:LinkButton ID="BtnViewByCategory" runat="server" CssClass="item">View by Category</asp:LinkButton>
    <asp:LinkButton ID="BtnEnterCategory" runat="server" CssClass="item">Enter Category</asp:LinkButton>
    <asp:LinkButton ID="BtnSearchItems" runat="server" CssClass="item">Search Items</asp:LinkButton>
    <asp:LinkButton ID="BtnSearchUsers" runat="server" CssClass="item">Search Users</asp:LinkButton>
    <asp:LinkButton ID="BtnCloseAuction" runat="server" CssClass="item">Close Auction</asp:LinkButton>
    <asp:LinkButton ID="BtnLogOut" runat="server" CssClass="item">Log Out</asp:LinkButton>
</div>