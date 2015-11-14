<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchItems.ascx.cs" Inherits="FestivalOfTrees.Views.SearchItems" %>

<div class="ui conatiner">
    <div class="ui stacked segment" style="min-height: 250px">
        <h3 style="text-align:center">Search Items</h3>
            
         
                <div class="two fields">                 
                    <div class="field">
                        Keyword:
                        <asp:TextBox ID="ItemIDBox" runat="server"></asp:TextBox>
                    </div>
                    <div class="field">
                    </div>
                </div>
                <asp:Button ID="BtnGetItemsByItemId" runat="server" Text="Search for Items" CssClass="ui secondary button" OnClick="BtnGetItemsByItemId_Click"/>

        <br />
        

            <asp:GridView ID="GridViewItemsByItemId" runat="server" CssClass="ui red table center aligned" AutoGenerateColumns="False" DataKeyNames="ITEMID" DataSourceID="SqlDataSource1" style="margin-right: 32px" AllowSorting="True" OnSelectedIndexChanged="GridViewItemsByItemId_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:TemplateField>
                        <HeaderTemplate>
                            Print
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:CheckBox ID="CheckBox2" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="CATEGORYNAME" HeaderText="Category" SortExpression="CATEGORYNAME" />
                    <asp:BoundField DataField="ITEMID" HeaderText="Item ID" ReadOnly="True" SortExpression="ITEMID" />
                    <asp:BoundField DataField="CATEGORYID" HeaderText="Category" SortExpression="CATEGORYID" />
                    <asp:BoundField DataField="USERID" HeaderText="Winner ID" SortExpression="USERID" />
                    <asp:BoundField DataField="ITEMNAME" HeaderText="Name" SortExpression="ITEMNAME" />
                    <asp:BoundField DataField="ITEMVALUE" HeaderText="Value" SortExpression="ITEMVALUE" />
                    <asp:BoundField DataField="ANGELPRICE" HeaderText="Angel Price" SortExpression="ANGELPRICE" />
                    <asp:BoundField DataField="MINBID" HeaderText="Minimum Bid" SortExpression="MINBID" />
                    <asp:CheckBoxField DataField="PAID" HeaderText="Paid" SortExpression="PAID" />
                </Columns>
        </asp:GridView>
           <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:it368_Auction_ProjectConnectionString %>" SelectCommand="SELECT CATEGORYNAME, ITEMID, CATEGORYID, USERID, ITEMNAME, ITEMVALUE, ANGELPRICE, MINBID, PAID FROM CategoryItems WHERE (CATEGORYID LIKE '%' + @KEY + '%') OR (CATEGORYNAME LIKE '%' + @KEY + '%') OR (ITEMNAME LIKE '%' + @KEY + '%') OR (CAST(ITEMID AS VARCHAR(MAX)) LIKE '%' + @KEY + '%')">
               <SelectParameters>
                   <asp:ControlParameter ControlID="ItemIDBox" Name="KEY" PropertyName="Text" />
               </SelectParameters>
        </asp:SqlDataSource>
           <br />
           <asp:LinkButton ID="BtnPrintInvoices" runat="server" CssClass="ui red button" OnClick="BtnPrintInvoices_Click"><i class="print icon"></i>Print Bid Sheets</asp:LinkButton>
    </div>
</div>