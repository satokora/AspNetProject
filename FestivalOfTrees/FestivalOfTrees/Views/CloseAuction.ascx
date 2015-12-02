<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CloseAuction.ascx.cs" Inherits="FestivalOfTrees.Views.CloseAuction" %>
<%@ Register Src="~/PageComponent/EnterBid.ascx" TagPrefix="uc1" TagName="EnterBid" %>


<div class="ui middle aligned center aligned grid">
    <div class="column" style="max-width: 800px;">
        <div class="ui raised segment left aligned">
            <h3 style="text-align: center;">Close Auction</h3>
            <asp:Panel ID="MsgPanel" runat="server">
                <div class="ui negative message">
                    <i class="close icon"></i>
                    <div class="header">
                        Update error
                    </div>
                    <p>
                        <asp:Label ID="ErrorNumsLbl" runat="server" Text=""></asp:Label>
                        fail(s) to update. Please try again.
                    </p>
                </div>
            </asp:Panel>
            <asp:Panel ID="SuccessPanel" runat="server">
                <div class="ui positive message">
                    <div class="header">
                        Update Successful
                    </div>
                </div>
            </asp:Panel>
            <uc1:EnterBid runat="server" ID="EnterBid1" />
            <uc1:EnterBid runat="server" ID="EnterBid2" />
            <uc1:EnterBid runat="server" ID="EnterBid3" />
            <uc1:EnterBid runat="server" ID="EnterBid4" />
            <uc1:EnterBid runat="server" ID="EnterBid5" />
            <asp:Button ID="Button1" runat="server" Text="Update Items" CssClass="ui red button" OnClick="Button1_Click" />
        </div>
    </div>
</div>
