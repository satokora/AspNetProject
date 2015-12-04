<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CloseAuction.ascx.cs" Inherits="FestivalOfTrees.Views.CloseAuction" %>
<%@ Register Src="~/PageComponent/EnterBid.ascx" TagPrefix="uc1" TagName="EnterBid" %>


<div class="ui middle aligned center aligned grid">
    <div class="column" style="max-width: 1000px;">
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
            <h4>Unsold Item List</h4>
            <asp:GridView ID="CloseItemView" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" AllowSorting="True" OnSelectedIndexChanged="CloseItemView_SelectedIndexChanged" CssClass="ui red table center aligned">
                <Columns>
                    <asp:BoundField DataField="CATITEMID" HeaderText="Item ID" ReadOnly="True" SortExpression="CATITEMID" />
                    <asp:BoundField DataField="ITEMNAME" HeaderText="Item Name" SortExpression="ITEMNAME" />
                    <asp:BoundField DataField="CURVALUE" HeaderText="Current Value" SortExpression="CURVALUE" ItemStyle-CssClass="right aligned" />
                    <asp:TemplateField HeaderText="Bid Number">
                        <ItemTemplate>
                            <asp:TextBox ID="BidTextBox" runat="server"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Winning Value">
                        <ItemTemplate>
                            <asp:TextBox ID="WinValTextBox" runat="server"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField SelectText="Close Item" ShowSelectButton="True">
                        <ControlStyle CssClass="ui secondary button" />
                    </asp:CommandField>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:it368_Auction_ProjectConnectionString %>" SelectCommand="SELECT [CATITEMID], [ITEMNAME], '$'  +  CAST([ITEMVALUE] as NVARCHAR(10)) as [CURVALUE]  FROM [ItemStatusViewBySold] WHERE ([Status] = @Status)">
                <SelectParameters>
                    <asp:QueryStringParameter Name="Status" QueryStringField="Unsold" Type="String" DefaultValue="Unsold" />
                </SelectParameters>
            </asp:SqlDataSource>
 <%--             <uc1:EnterBid runat="server" ID="EnterBid1" />
          <uc1:EnterBid runat="server" ID="EnterBid2" />
            <uc1:EnterBid runat="server" ID="EnterBid3" />
            <uc1:EnterBid runat="server" ID="EnterBid4" />
            <uc1:EnterBid runat="server" ID="EnterBid5" />
            <asp:Button ID="Button1" runat="server" Text="Update Items" CssClass="ui red button" OnClick="Button1_Click" />--%>
        </div>
    </div>
</div>
