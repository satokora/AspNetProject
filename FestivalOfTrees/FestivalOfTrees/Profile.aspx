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
                            <a class="item" id="UserRequest" runat="server" data-tab="second" visible="false">User Request
                            </a>
                            <asp:LinkButton ID="LinkButton2" runat="server" CssClass="item" OnClick="LogOut_Click">Log Out</asp:LinkButton>
                        </div>
                    </div>
                    <div class="twelve wide stretched column">
                        <div class="ui tab segment active left aligned" data-tab="first">
                            <h1>Select Auction</h1>
                            <%--<asp:GridView ID="AuctionGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="AUCTIONID" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="AuctionGridView_SelectedIndexChanged">
                                <Columns>
                                    <asp:CommandField ShowSelectButton="True" />
                                    <asp:BoundField DataField="AUCTIONNAME" HeaderText="AUCTIONNAME" SortExpression="AUCTIONNAME" />
                                    <asp:BoundField DataField="AUCTIONDATE" HeaderText="AUCTIONDATE" SortExpression="AUCTIONDATE" />
                                    <asp:BoundField DataField="AUCTIONID" HeaderText="AUCTIONID" ReadOnly="True" SortExpression="AUCTIONID" />
                                </Columns>
                            </asp:GridView>--%>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:it368_Auction_ProjectConnectionString %>" SelectCommand="SELECT [AUCTIONNAME], [AUCTIONDATE], [AUCTIONID] FROM [AUCTION]"></asp:SqlDataSource>
                            

                            <asp:ListView ID="AuctionListView" runat="server" 
                                DataSourceID="SqlDataSource1" ItemPlaceholderID="EventContainer" OnItemCommand="SelectAuctionBtn_Click">
                                <LayoutTemplate>
                                   
                                    <div class="ui three column grid">
                                        <div class="column" id="EventContainer" runat="server"></div>
                                    </div>
                                    
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <div class="column">
                                    <div class="ui fluid card">
                                        <div class="content">
                                            <div class="header">
                                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("AUCTIONNAME") %>'></asp:Label>
                                            </div>
                                            <div class="description">
                                                Auction ID: <asp:Label ID="Label3" runat="server" Text='<%#Eval("AUCTIONID") %>'></asp:Label><br />
                                                Date: <asp:Label ID="Label2" runat="server" Text='<%#Eval("AUCTIONDATE") %>'></asp:Label>
                                            </div>
                                        </div>
                                        <asp:LinkButton ID="LinkButton1" CssClass="ui bottom attached right labeled icon red button" runat="server" CommandName="sel" CommandArgument='<%#Eval("AUCTIONID") %>' >
                                            <i class="sign out icon"></i>
                                            Select
                                        </asp:LinkButton>
                                       
                                    </div>
                                    </div>
                                </ItemTemplate>
                            </asp:ListView>
                           
                        </div>
                        <div class="ui tab segment left aligned" data-tab="second">
                            <h1>New User Request</h1>
                            <asp:GridView ID="UserRequestGrid" runat="server"  class="ui grey table" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource2">
                                <Columns>
                                    <asp:TemplateField HeaderText="Approve">
                                        <ItemTemplate>
                                            <asp:CheckBox ID="CheckBox1" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="EMAIL" HeaderText="EMAIL" SortExpression="EMAIL" />
                                    <asp:CheckBoxField DataField="ADMINREQ" HeaderText="ADMINREQ" SortExpression="ADMINREQ" />
                                    <asp:CheckBoxField DataField="COMMITTEE" HeaderText="COMMITTEE" SortExpression="COMMITTEE" />
                                    <asp:CheckBoxField DataField="DONOR" HeaderText="DONOR" SortExpression="DONOR" />
                                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                                </Columns>
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:it368_Auction_ProjectConnectionString %>" SelectCommand="SELECT [EMAIL], [ADMINREQ], [COMMITTEE], [DONOR], [Id] FROM [REQUEST] WHERE ([APPROVED] = @APPROVED)">
                                <SelectParameters>
                                    <asp:Parameter DefaultValue="False" Name="APPROVED" Type="Boolean" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                            <br />
                            <asp:LinkButton ID="BtnAccept" runat="server" CssClass="ui teal button" OnClick="BtnAccept_Click"><i class="thumbs up icon"></i>Accept selected requests</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
