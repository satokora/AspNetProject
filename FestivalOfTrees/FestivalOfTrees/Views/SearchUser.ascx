<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchUser.ascx.cs" Inherits="FestivalOfTrees.Views.SearchItemUser" %>
<div class="ui conatiner">
    <div class="ui stacked segment" style="min-height: 250px">
        <h3 style="text-align:center">Search for Buyers</h3>
<%--        <div class="ui buttons">
            <asp:Button ID="ItemBtn" runat="server" Text="Items" CssClass="ui red button" OnClick="ItemBtn_Click" />
            <div class="or"></div>
            <asp:Button ID="Buyers" runat="server" Text="Buyers" CssClass="ui smoky-brown button" OnClick="Buyers_Click"  />
        </div>--%>
            
         <%--<asp:MultiView ID="SearchView" runat="server">
            <asp:View ID="View1" runat="server">--%>
                <div class="two fields">
                    <div class="field">
                        <label class="account">Buyer's last name</label>
                        <asp:TextBox ID="LastNameBox" runat="server"></asp:TextBox>
                    </div>
                    <div class="field">
                        <label class="account">Buyer's phone #</label>
                        <asp:TextBox ID="PhoneNumBox" runat="server"></asp:TextBox>
                    </div>
                </div>
                <asp:Button ID="SearchBuyer" runat="server" Text="Search for buyers" CssClass="ui secondary button" OnClick="SearchBuyer_Click" />
            <%--</asp:View>
            <asp:View ID="View2" runat="server">
                <div class="two fields">
                    <div class="field">
                        <label class="account">Item ID</label>
                        <asp:TextBox ID="ItemIDBox" runat="server"></asp:TextBox>
                    </div>
                    <div class="field">
                        <label class="account">Category</label>
                        <asp:DropDownList ID="CatList" runat="server" CssClass="ui dropdown">
                            <asp:ListItem Value="" Text="Select Category" Selected="True"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <asp:Button ID="SearchItem" runat="server" Text="Search for Items" CssClass="ui secondary button" OnClick="SearchItem_Click" />
            </asp:View>
           
        </asp:MultiView>--%>
        <br />
        <asp:GridView ID="GridViewUsers" runat="server"></asp:GridView>
        <asp:LinkButton ID="BtnPrintInvoices" runat="server" CssClass="ui red button"><i class="print icon"></i>Print Invoices</asp:LinkButton>
    </div>
</div>

