<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FestivalOfTrees.Home" %>

<%@ Register Src="~/Views/EnterNewItem.ascx" TagPrefix="uc" TagName="EnterNewItem" %>
<%@ Register Src="~/Views/ItemStatusView.ascx" TagPrefix="uc" TagName="ItemStatusView" %>
<%@ Register Src="~/PageComponent/FooterCtrl.ascx" TagPrefix="uc" TagName="FooterCtrl" %>
<%@ Register Src="~/PageComponent/HeaderCtrl.ascx" TagPrefix="uc" TagName="HeaderCtrl" %>
<%@ Register Src="~/Views/SearchItemUser.ascx" TagPrefix="uc" TagName="SearchItemUser" %>


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
    
    <form id="form1" runat="server" class="ui form">
        <div id="wrap">
        <div id="main">
        <uc:HeaderCtrl runat="server" ID="HeaderCtrl" />
        <div class="ui container" id="main-content">
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="View1" runat="server">
                    <uc:ItemStatusView runat="server" ID="ItemStatusView" />
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <uc:EnterNewItem runat="server" ID="EnterNewItem" />
                </asp:View>
                <asp:View ID="View3" runat="server">
                    <uc:SearchItemUser runat="server" id="SearchItemUser" />
                </asp:View>


            </asp:MultiView>
            
        </div>
            <div class="clearfooter"></div>
        </div>
        </div>
        <uc:FooterCtrl runat="server" ID="FooterCtrl" />
    </form>
    <script src="assets/semantic.min.js"></script>
    <script>
        $('.special.cards .image').dimmer({
            on: 'hover'
        });
    </script>
</body>
</html>
