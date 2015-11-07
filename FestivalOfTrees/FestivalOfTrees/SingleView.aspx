<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SingleView.aspx.cs" Inherits="FestivalOfTrees.SingleView" %>
<%@ Register Src="~/Views/ViewSingleUser.ascx" TagPrefix="uc" TagName="ViewSingleUser" %>
<%@ Register Src="~/Views/ViewSingleItem.ascx" TagPrefix="uc" TagName="ViewSingleItem" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome Home</title>
    <link href="assets/semantic.min.css" rel="stylesheet" />
    <link href="assets/custom_style.css" rel="stylesheet" />
    <script src="assets/jquery-1.11.3.min.js"></script>
    <script src="assets/semantic.min.js"></script>
</head>
<body class="home-bg">
    <form id="form1" runat="server">
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
                <uc:ViewSingleItem runat="server" ID="ViewSingleItem" />
            </asp:View>
            <asp:View ID="View2" runat="server">
                <uc:ViewSingleUser runat="server" ID="ViewSingleUser" />
            </asp:View>
        </asp:MultiView>

    <div>
    
    </div>
    
    </div>
    </form>
</body>
</html>
