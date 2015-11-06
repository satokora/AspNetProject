<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FestivalOfTrees.Home" %>

<%@ Register Src="~/Views/EnterNewItem.ascx" TagPrefix="uc" TagName="EnterNewItem" %>
<%@ Register Src="~/Views/Search.ascx" TagPrefix="uc" TagName="Search" %>
<%@ Register Src="~/Views/ViewSingleItem.ascx" TagPrefix="uc" TagName="ViewSingleItem" %>
<%@ Register Src="~/Views/ViewSingleUser.ascx" TagPrefix="uc" TagName="ViewSingleUser" %>
<%@ Register Src="~/Views/ItemStatusView.ascx" TagPrefix="uc" TagName="ItemStatusView" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome Home</title>
    <link href="assets/semantic.min.css" rel="stylesheet" />
    <link href="assets/custom_style.css" rel="stylesheet" />
</head>
<body class="home-bg">
    <form id="form1" runat="server" class="ui form">
     <div class="ui fixed inverted menu">
        <div class="ui container">
          <div href="#" class="header item">
              <img class="logo"  src="assets/image/Logo_FestTree.png" />
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
    <div class="ui container"  id="main-content">
    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="View1" runat="server">
            <uc:ItemStatusView runat="server" id="ItemStatusView" />
        </asp:View>
        <asp:View ID="View2" runat="server">
            <uc:EnterNewItem runat="server" ID="EnterNewItem" />
        </asp:View>
        <asp:View ID="View3" runat="server">
            <uc:Search runat="server" ID="Search" />
        </asp:View>
        <asp:View ID="View4" runat="server">
            <uc:ViewSingleItem runat="server" ID="ViewSingleItem" />
        </asp:View>
        <asp:View ID="View5" runat="server">
            <uc:ViewSingleUser runat="server" ID="ViewSingleUser" />
        </asp:View>
    </asp:MultiView>
    </div>
<<<<<<< HEAD
    </form>
    <script src="assets/semantic.min.js"></script>
    </body>
=======
</form>
</body>
>>>>>>> refs/remotes/origin/newStuff
</html>
