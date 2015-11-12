<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Auction.aspx.cs" Inherits="FestivalOfTrees.Auction" %>

<%@ Register Src="~/Views/EnterNewItem.ascx" TagPrefix="uc" TagName="EnterNewItem" %>
<%@ Register Src="~/Views/ItemStatusView.ascx" TagPrefix="uc" TagName="ItemStatusView" %>
<%@ Register Src="~/Views/SearchItemUser.ascx" TagPrefix="uc" TagName="SearchItemUser" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ui container" id="main-content">
        <asp:MultiView ID="MainContentMultiView" runat="server">
            <asp:View ID="View1" runat="server">
                <uc:ItemStatusView runat="server" id="ItemStatusView" />
            </asp:View>
            <asp:View ID="View2" runat="server">
                <uc:EnterNewItem runat="server" id="EnterNewItem" />
            </asp:View>
            <asp:View ID="View3" runat="server">
                <%--<uc:SearchItemUser runat="server" id="SearchItemUser" />--%>
            </asp:View>
            <asp:View ID="View4" runat="server">
                <%--<uc:SearchItemUser runat="server" id="SearchItemUser" />--%>
            </asp:View>
            <asp:View ID="View5" runat="server">
                <uc:SearchItemUser runat="server" id="SearchItemUser" />
            </asp:View>
            <asp:View ID="View6" runat="server">
                <%--<uc:SearchItemUser runat="server" id="SearchItemUser" />--%>
            </asp:View>
            <asp:View ID="View7" runat="server">
                <%--<uc:SearchItemUser runat="server" id="SearchItemUser" />--%>
            </asp:View>
        </asp:MultiView>

    </div>
</asp:Content>
