<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SideBarAdmin.ascx.cs" Inherits="FestivalOfTrees.PageComponent.Header" %>

<div class="ui visible sidebar inverted vertical pointing menu">
    <div href="#" class="item">
        <img class="logo" src="assets/image/Logo_FestTree.png" />
    </div>
    <asp:LinkButton ID="BtnViewItems" runat="server" CssClass="item" OnClick="BtnViewItems_Click">View Items by Paid Status</asp:LinkButton>
    <asp:LinkButton ID="BtnViewItemsBySold" runat="server" CssClass="item" OnClick="BtnViewItemsBySold_Click">View Items by Sold Status</asp:LinkButton>
    <asp:LinkButton ID="BtnViewByCategory" runat="server" CssClass="item" OnClick="BtnViewByCategory_Click">View Categories</asp:LinkButton>
    <asp:LinkButton ID="BtnSearchItems" runat="server" CssClass="item" OnClick="BtnSearchItems_Click">Search Items</asp:LinkButton>
    <asp:LinkButton ID="BtnSearchUsers" runat="server" CssClass="item" OnClick="BtnSearchUsers_Click">Search Users</asp:LinkButton>
    <asp:LinkButton ID="BtnEnterItem" runat="server" CssClass="item" OnClick="BtnEnterItem_Click">Enter Item</asp:LinkButton>
    <asp:LinkButton ID="BtnEnterCategory" runat="server" CssClass="item" OnClick="BtnEnterCategory_Click">Enter New Category</asp:LinkButton>
    <asp:LinkButton ID="BtnCloseAuction" runat="server" CssClass="item" OnClick="BtnCloseAuction_Click">Close Auction</asp:LinkButton>
    <asp:LinkButton ID="BtnLogOut" runat="server" CssClass="item" OnClick="BtnLogOut_Click">Log Out</asp:LinkButton>
    <asp:Linkbutton ID="BtnEditProfile" runat="server" CssClass="item" OnClick="BtnEditProfile_Click">Edit Profile</asp:Linkbutton>
</div>


