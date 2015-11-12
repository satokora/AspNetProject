<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SideBarAdmin.ascx.cs" Inherits="FestivalOfTrees.PageComponent.Header" %>
<%--<div class="ui fixed inverted menu">
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
               
                <asp:LinkButton ID="LogoutBtn" runat="server" CssClass="ui inverted primary button">Log Out</asp:LinkButton>
            </div>
        </div>
    </div>
</div>--%>
<div class="ui visible sidebar inverted vertical pointing menu">
    <div href="#" class="item">
        <img class="logo" src="assets/image/Logo_FestTree.png" />
    </div>
    <asp:LinkButton ID="BtnViewItems" runat="server" CssClass="item" OnClick="BtnViewItems_Click">View Items</asp:LinkButton>
    <asp:LinkButton ID="BtnEnterItem" runat="server" CssClass="item" OnClick="BtnEnterItem_Click">Enter Item</asp:LinkButton>
    <asp:LinkButton ID="BtnViewByCategory" runat="server" CssClass="item" OnClick="BtnViewByCategory_Click">View by Category</asp:LinkButton>
    <asp:LinkButton ID="BtnEnterCategory" runat="server" CssClass="item" OnClick="BtnEnterCategory_Click">Enter Category</asp:LinkButton>
    <asp:LinkButton ID="BtnSearchItems" runat="server" CssClass="item" OnClick="BtnSearchItems_Click">Search Items</asp:LinkButton>
    <asp:LinkButton ID="BtnSearchUsers" runat="server" CssClass="item" OnClick="BtnSearchUsers_Click">Search Users</asp:LinkButton>
    <asp:LinkButton ID="BtnCloseAuction" runat="server" CssClass="item" OnClick="BtnCloseAuction_Click">Close Auction</asp:LinkButton>
    <asp:LinkButton ID="BtnLogOut" runat="server" CssClass="item" OnClick="BtnLogOut_Click">Log Out</asp:LinkButton>
</div>
  
    <!-- Site content !-->

