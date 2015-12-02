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
                        <label class="account">Last Name or Phone Number:</label>
                        <asp:TextBox ID="LastNameBox" runat="server"></asp:TextBox>
                    </div>
                </div>
                <asp:Button ID="SearchBuyer" runat="server" Text="Search" CssClass="ui secondary button" OnClick="SearchBuyer_Click" />
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
        <asp:GridView ID="GridViewUsers" runat="server" CssClass="ui red table center aligned" AutoGenerateColumns="False" DataKeyNames="EMAIL" DataSourceID="Users" OnSelectedIndexChanged="GridViewItemsByItemId_SelectedIndexChanged">
            <Columns>
                <asp:TemplateField HeaderText="Print Invoice">
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="USERID" HeaderText="Bid Number" InsertVisible="False" ReadOnly="True" SortExpression="USERID" />
                <asp:BoundField DataField="EMAIL" HeaderText="Email" ReadOnly="True" SortExpression="EMAIL" />
                <asp:BoundField DataField="FIRSTNAME" HeaderText="First Name" SortExpression="FIRSTNAME" />
                <asp:BoundField DataField="LASTNAME" HeaderText="Last Name" SortExpression="LASTNAME" />
                <asp:BoundField DataField="PHONE" HeaderText="Phone" SortExpression="PHONE" />
                <asp:BoundField DataField="CITY" HeaderText="City" SortExpression="CITY" />
                <asp:BoundField DataField="USERSTATE" HeaderText="State" SortExpression="USERSTATE" />
                <asp:CommandField ShowSelectButton="True"  ControlStyle-CssClass="ui button" SelectText="View" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="Users" runat="server" ConnectionString="<%$ ConnectionStrings:it368_Auction_ProjectConnectionString %>" SelectCommand="SELECT [USERID], [EMAIL], [FIRSTNAME], [LASTNAME], [PHONE], [CITY], [USERSTATE] FROM [USERINFO] WHERE (([LASTNAME] LIKE '%' + @LASTNAME + '%') OR ([PHONE] LIKE '%' + @PHONE + '%'))">
            <SelectParameters>
                <asp:ControlParameter ControlID="LastNameBox" Name="LASTNAME" PropertyName="Text" Type="String" />
                <asp:ControlParameter ControlID="LastNameBox" Name="PHONE" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <asp:LinkButton ID="BtnPrintInvoices" runat="server" CssClass="ui red button"><i class="print icon"></i>Print Invoices</asp:LinkButton>
    </div>
</div>

