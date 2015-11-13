<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ViewByCategory.ascx.cs" Inherits="FestivalOfTrees.Views.ViewByCategory" %>
<div class="ui conatiner">
    <div class="ui stacked segment" style="min-height: 250px">
        <h3 style="text-align:center">View Items By Category</h3>
            
         
                <div class="two fields">                 
                    <div class="field">
                        <label class="account">Category</label>
                        <asp:DropDownList ID="CatList" runat="server" CssClass="ui dropdown">
                            <asp:ListItem Value="" Text="Select Category" Selected="True"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="field">
                    </div>
                </div>
                <asp:Button ID="BtnGetItemsByCategory" runat="server" Text="Search for Items" CssClass="ui secondary button"/>

        <br />
        <%--<div class="ui icon right floated buttons">
            <asp:LinkButton ID="TableViewBtn" runat="server" CssClass="ui button" OnClick="TableViewBtn_Click"><i class='table icon'></i></asp:LinkButton>
            <asp:LinkButton ID="CardViewIcon" runat="server" CssClass="ui button" OnClick="CardViewBtn_Click"><i class='block layout icon'></i></asp:LinkButton>
        </div>--%>
        <%--<asp:MultiView ID="SearchResultView" runat="server">
            <asp:View ID="View3" runat="server">--%>

            <asp:GridView ID="GridViewItemsByCategory" runat="server" CssClass="ui red table center aligned"></asp:GridView>
            <%--</asp:View>
            <asp:View ID="View4" runat="server">
                <div class="ui special cards">
                  <div class="card">
                    <div class="blurring dimmable image">
                        <div class="ui dimmer">
                            <div class="content">
                                <div class="center">
                                <a class="ui inverted button" href="SingleView.aspx?item=CS001">View Item</a>
                                </div>
                            </div>
                        </div>
                        <div class="ui fluid image">
                            <a class="ui green ribbon large label">Sold</a>
                            <img src="../assets/image/sock.jpg" />
                        </div>
                        
                    </div>
                    <div class="content">
                      <div class="header">X'mas Family socks</div>
                      <div class="meta">
                        <a>Friends</a>
                      </div>
                      <div class="description">
                        Matthew is an interior designer living in New York.
                      </div>
                    </div>
                    <div class="extra content">
                      <span class="right floated">
                        Joined in 2013
                      </span>
                      <span>
                        <i class="user icon"></i>
                        75 Friends
                      </span>
                    </div>
                  </div>
                  <div class="card">
                    <div class="blurring dimmable image">
                        <div class="ui dimmer">
                            <div class="content">
                                <div class="center">
                                <a class="ui inverted button" href="SingleView.aspx?item=CS001">View Item</a>
                                </div>
                            </div>
                        </div>
                        <div class="ui fluid image">
                            <a class="ui gray ribbon large label">Unsold</a>
                            <img src="../assets/image/tree.jpg" />
                        </div>
                    </div>
                    <div class="content">
                      <div class="header">Molly</div>
                      <div class="meta">
                        <span class="date">Coworker</span>
                      </div>
                      <div class="description">
                        Molly is a personal assistant living in Paris.
                      </div>
                    </div>
                    <div class="extra content">
                      <span class="right floated">
                        Joined in 2011
                      </span>
                      <span>
                        <i class="user icon"></i>
                        35 Friends
                      </span>
                    </div>
                  </div>
                  <div class="card">
                    <div class="blurring dimmable image">
                        <div class="ui dimmer">
                            <div class="content">
                                <div class="center">
                                <a class="ui inverted button" href="SingleView.aspx?item=CS001">View Item</a>
                                </div>
                            </div>
                        </div>
                        <div class="ui fluid image">
                            <a class="ui yellow ribbon large label">Unpaid</a>
                            <img src="../assets/image/wr.jpg"/>
                        </div>
                    </div>
                    <div class="content">
                      <div class="header">Elyse</div>
                      <div class="meta">
                        <a>Coworker</a>
                      </div>
                      <div class="description">
                        Elyse is a copywriter working in New York.
                      </div>
                    </div>
                    <div class="extra content">
                      <span class="right floated">
                        Joined in 2014
                      </span>
                      <span>
                        <i class="user icon"></i>
                        151 Friends
                      </span>
                    </div>
                  </div>
                </div>
            </asp:View>
        </asp:MultiView>--%>
    </div>
</div>