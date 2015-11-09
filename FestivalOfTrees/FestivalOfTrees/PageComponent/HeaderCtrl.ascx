<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HeaderCtrl.ascx.cs" Inherits="FestivalOfTrees.PageComponent.Header" %>
<div class="ui fixed inverted menu">
    <div class="ui container">
        <div href="#" class="header item">
            <img class="logo" src="assets/image/Logo_FestTree.png" />
        </div>
        <asp:LinkButton ID="Menu1" runat="server" CssClass="item" OnClick="Menu1_Click">Quick Item View</asp:LinkButton>
        <asp:LinkButton ID="Menu2" runat="server" CssClass="item" OnClick="Menu2_Click">Enter new item</asp:LinkButton>
        <asp:LinkButton ID="Menu3" runat="server" CssClass="item" OnClick="Menu3_Click">Search Items/Users</asp:LinkButton>
        <div class="right menu">
            <div class="item">
                <asp:LinkButton ID="AdminDash" CssClass="ui inverted green basic button" runat="server"><i class="settings icon"></i>Admin</asp:LinkButton>
            </div>
            <div class="item">
                <a class="ui inverted primary button">Log in</a>
            </div>
        </div>
    </div>
</div>
