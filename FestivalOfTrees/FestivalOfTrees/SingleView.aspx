<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SingleView.aspx.cs" Inherits="FestivalOfTrees.SingleView" %>

<%@ Register Src="~/Views/ViewSingleUser.ascx" TagPrefix="uc" TagName="ViewSingleUser" %>
<%@ Register Src="~/Views/ViewSingleItem.ascx" TagPrefix="uc" TagName="ViewSingleItem" %>
<%@ Register Src="~/PageComponent/Header.ascx" TagPrefix="uc" TagName="Header" %>
<%@ Register Src="~/PageComponent/Footer.ascx" TagPrefix="uc" TagName="Footer" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome Home</title>
    <link href="assets/semantic.min.css" rel="stylesheet" />
    <link href="assets/custom_style.css" rel="stylesheet" />
    <script src="assets/jquery-1.11.3.min.js"></script>
    <script src="assets/semantic.min.js"></script>
    <link href="assets/stickyfooter.css" rel="stylesheet" />
</head>
<body class="home-bg">
    <form id="form1" runat="server">
        <div id="wrap">
        <div id="main">
        <uc:Header runat="server" id="Header" />
        <div class="ui container" id="main-content">

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
        </div>
        </div>
        <uc:Footer runat="server" id="Footer" />
    </form>
</body>
</html>
