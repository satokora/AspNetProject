<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="SingleView.aspx.cs" Inherits="FestivalOfTrees.SingleView1" %>
<%@ Register Src="~/Views/ViewSingleUser.ascx" TagPrefix="uc" TagName="ViewSingleUser" %>
<%@ Register Src="~/Views/ViewSingleItem.ascx" TagPrefix="uc" TagName="ViewSingleItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ui container" id="main-content">

        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                <uc:viewsingleitem runat="server" id="ViewSingleItem" />
            </asp:View>
            <asp:View ID="View2" runat="server">
                <uc:viewsingleuser runat="server" id="ViewSingleUser" />
            </asp:View>
        </asp:MultiView>

        <div>
        </div>

    </div>
</asp:Content>
