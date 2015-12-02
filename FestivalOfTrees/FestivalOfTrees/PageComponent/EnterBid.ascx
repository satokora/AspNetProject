<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EnterBid.ascx.cs" Inherits="FestivalOfTrees.PageComponent.EnterBid" %>

<asp:UpdatePanel ID="UpdateBidItemPanel" runat="server" style="margin-top:10px;margin-bottom: 10px">
    <ContentTemplate>
        <h4 class="ui dividing header">Enter Bid</h4>
        <div class="field">
            <label>Item ID</label>
            <div class="two fields">
                <div class="field">
                    <asp:TextBox ID="CloseItemNoTxt" runat="server" OnTextChanged="CloseItemNoTxt_TextChanged" AutoPostBack="true"></asp:TextBox>
                </div>
                <div class="field">
                    <asp:Panel ID="ItemNoPnl" runat="server" Visible="false">
                        <div class="ui compact info message">
                            <div class="header">
                                Item Name:<asp:Label ID="LblItemNo" runat="server" Text="Label"></asp:Label>
                            </div>
                        </div>
                    </asp:Panel>
                </div>
            </div>
        </div>
        <div class="field">
            <label>Bid Number</label>
            <div class="two fields">
                <div class="field">
                    <asp:TextBox ID="BidNumTxt" runat="server" OnTextChanged="BidNumTxt_TextChanged" AutoPostBack="true"></asp:TextBox>
                </div>
                <div class="field">
                    <asp:Panel ID="BidNoPnl" runat="server" Visible="false">
                        <div class="ui compact info message">
                            <div class="header">
                                Name:<asp:Label ID="LblBidNo" runat="server" Text="Label"></asp:Label>
                            </div>
                        </div>
                    </asp:Panel>
                </div>
            </div>
        </div>
        <div class="field">
            <label>Winning Price</label>
            <div class="two fields">
                <div class="field">
                    <asp:TextBox ID="WinPriceTxt" runat="server" OnTextChanged="WinPriceTxt_TextChanged" AutoPostBack="true"></asp:TextBox>
                </div>
                <div class="field">
                </div>
            </div>
        </div>
        <%--<asp:Button ID="BtnUpdateItem" runat="server" Text="Update Item" />
  <div class="ui button" tabindex="0">Submit Order</div>--%>
    </ContentTemplate>
</asp:UpdatePanel>
