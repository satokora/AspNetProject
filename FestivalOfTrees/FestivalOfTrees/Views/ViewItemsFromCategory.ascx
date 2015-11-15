<%@ Control Language="C#" %>

<div class="ui conatiner">
    <div class="ui stacked segment" style="min-height: 250px">
        <h3 style="text-align:center">Items</h3>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ITEMID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="ITEMID" HeaderText="ITEMID" InsertVisible="False" ReadOnly="True" SortExpression="ITEMID" />
                <asp:BoundField DataField="CATEGORYID" HeaderText="CATEGORYID" SortExpression="CATEGORYID" />
                <asp:BoundField DataField="USERID" HeaderText="USERID" SortExpression="USERID" />
                <asp:BoundField DataField="ITEMNAME" HeaderText="ITEMNAME" SortExpression="ITEMNAME" />
                <asp:BoundField DataField="ITEMVALUE" HeaderText="ITEMVALUE" SortExpression="ITEMVALUE" />
                <asp:BoundField DataField="ANGELPRICE" HeaderText="ANGELPRICE" SortExpression="ANGELPRICE" />
                <asp:BoundField DataField="MINBID" HeaderText="MINBID" SortExpression="MINBID" />
                <asp:CheckBoxField DataField="PAID" HeaderText="PAID" SortExpression="PAID" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:it368_Auction_ProjectConnectionString %>" SelectCommand="SELECT * FROM [ITEM] WHERE ([CATEGORYID] = @CATEGORYID)">
            <SelectParameters>
                <asp:SessionParameter Name="CATEGORYID" SessionField="Category" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
</div>