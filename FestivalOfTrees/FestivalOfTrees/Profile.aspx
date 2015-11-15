<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="FestivalOfTrees.Profile" %>

<%--<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>--%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ui container">
        <div class="ui middle aligned center aligned grid">
            <div class="column" style="margin-top: 100px;">
                <h2 class="ui teal image header">
                    <img src="assets/image/Logo_FestTree.png" class="login-image" />
                </h2>
                <br />
                <h1 class="ui header" style="color: #fff">Welcome,
                    <asp:Label ID="LblUserName" runat="server">Administrator</asp:Label></h1>

                <div class="ui grid">
                    <div class="four wide column">
                        <div class="ui vertical fluid pointing menu">
                            <a class="active item" data-tab="first">Select Auctions
                            </a>
                            <a class="item" data-tab="second">User Request
                            </a>
                        </div>
                    </div>
                    <div class="twelve wide stretched column">
                        <div class="ui tab segment active left aligned" data-tab="first">
                            <h1>Select Auction</h1>
                            <asp:GridView ID="AuctionGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="AUCTIONID" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="AuctionGridView_SelectedIndexChanged">
                                <Columns>
                                    <asp:CommandField ShowSelectButton="True" />
                                    <asp:BoundField DataField="AUCTIONNAME" HeaderText="AUCTIONNAME" SortExpression="AUCTIONNAME" />
                                    <asp:BoundField DataField="AUCTIONDATE" HeaderText="AUCTIONDATE" SortExpression="AUCTIONDATE" />
                                    <asp:BoundField DataField="AUCTIONID" HeaderText="AUCTIONID" ReadOnly="True" SortExpression="AUCTIONID" />
                                </Columns>
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:it368_Auction_ProjectConnectionString %>" SelectCommand="SELECT [AUCTIONNAME], [AUCTIONDATE], [AUCTIONID] FROM [AUCTION]"></asp:SqlDataSource>
                            <div class="two fields">
                                <div class="field">
                                    <asp:DropDownList ID="AuctionList" runat="server" CssClass="ui dropdown">
                                        <asp:ListItem Value="">Select Auction</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="field">
                                    <div class="ui right labeled button">
                                        <asp:LinkButton ID="BtnGoAuction" runat="server" CssClass="ui red button" OnClick="BtnGoAuction_Click">Go to Auction Page<i class="pointing right icon"></i></asp:LinkButton>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="ui tab segment left aligned" data-tab="second">
                            <h1>New User Request</h1>
                            <asp:GridView ID="UserRequestGrid" runat="server"></asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
