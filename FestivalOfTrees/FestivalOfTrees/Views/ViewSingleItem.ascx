<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ViewSingleItem.ascx.cs" Inherits="FestivalOfTrees.Views.ViewSingleItem" %>
<div class="ui center aligned grid">
    <div class="column" style="max-width: 800px">
        <div class="ui raised segment left aligned">
            <h2>
                <asp:Label ID="ItemID" runat="server" Text="CS001: "></asp:Label>
                <asp:Label ID="ItemName" runat="server" Text="Item Name"></asp:Label>
            </h2>
            
            <div class="ui items">
                <div class="item">
                    <div class="ui round image">
                        <a class="ui green ribbon big label">Sold</a>
                        <img src="../assets/image/wr.jpg" />
                    </div>
                    <div class="content">

                        <div class="meta">

                            <div class="ui small statistic">
                                <div class="value">
                                    $
                      <asp:Label ID="lblCurrentPrice" runat="server" Text="Label">
                         23
                      </asp:Label>
                                </div>
                                <div class="label">
                                    Current Price
                                </div>
                            </div>
                            <div class="ui small statistic">
                                <div class="value">
                                    $
                      <asp:Label ID="lblMinPrice" runat="server" Text="Label">
                         15
                      </asp:Label>
                                </div>
                                <div class="label">
                                    Minimum Price
                                </div>
                            </div>
                            <div class="ui small statistic">
                                <div class="value">
                                    $
                      <asp:Label ID="lblAngelPrice" runat="server" Text="Label">
                         50
                      </asp:Label>
                                </div>
                                <div class="label">
                                    Angel price
                                </div>
                            </div>
                            <div>
                                <span>Donated/designed by
                                    <asp:Label ID="DesignerName" runat="server" Text="John Doe"></asp:Label>
                                    <br />
                                    Sponsored by
                                    <asp:Label ID="SponsorName" runat="server" Text="XXX Organization"></asp:Label></span>
                            </div>
                        </div>
                        <div class="description">
                            <p>
                                <asp:Label ID="ItemDesc" runat="server">
                                This item is designed by.... blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah
                                blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah
                                blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah
                                blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah
                                blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah
                                </asp:Label>
                            </p>
                            <h4>Buyer:</h4>
                            <div class="ui list">
                                <div class="item">
                                    <i class="user icon"></i>
                                    <div class="content">
                                        <asp:Label ID="BuyerName" runat="server" Text="Label">Satoko Kora</asp:Label>
                                    </div>
                                </div>
                                <div class="item">
                                    <i class="phone icon"></i>
                                    <div class="content">
                                        <asp:HyperLink ID="BuyerPhone" runat="server">(309)123-4567</asp:HyperLink>
                                    </div>
                                </div>
                                <div class="item">
                                    <i class="mail icon"></i>
                                    <div class="content">
                                        <asp:HyperLink ID="BuyerEmail" runat="server">satokorambxl@gmail.com</asp:HyperLink>
                                    </div>
                                </div>
                            </div>
                            <asp:LinkButton ID="LinkButton1" runat="server" CssClass="ui floated primary button">
                              Edit buyer
                              <i class="right chevron icon"></i>
                            </asp:LinkButton>
                            <asp:LinkButton ID="BtnPrintBid" runat="server" CssClass="ui right floated red button">
                                <i class="right print icon"></i>  
                                Print Bid Sheet
                            </asp:LinkButton>
                            <asp:LinkButton ID="BtnEditItem" runat="server" CssClass="ui right floated secondary button">
                                <i class="right edit icon"></i>  
                                Edit Item                    
                            </asp:LinkButton>
                        </div>


                        <div class="extra">
                            
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
