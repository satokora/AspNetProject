<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ItemStatusView.ascx.cs" Inherits="FestivalOfTrees.Views.ItemStatusView" %>
<div class="ui conatiner">
    <div class="ui stacked segment">
        <h3 style="text-align: center">Item Status View</h3>
        <div class="ui buttons" style="margin-bottom:30px">
          <a class="ui red button" href="#SoldView">Items by Sold Status</a>
          <a class="ui smoky-brown button" href="#PaidView">Items by Paid Status</a>
        </div>
        <%--<asp:ScriptManager ID="ScriptManagerForStatusView" runat="server"></asp:ScriptManager>--%>
        <asp:UpdatePanel ID="UpdatePanelForSoldStatusView" runat="server" style="margin-bottom:50px">
            <ContentTemplate>

                <div class="ui grid" id="SoldView">
                    <div class="four wide column">
                        <div class="field">
                            <label>By Sold Status</label>
                            <asp:DropDownList ID="SoldStatusList" runat="server" OnSelectedIndexChanged="SoldStatusList_SelectedIndexChanged" AutoPostBack="True">
                                <asp:ListItem Value="Unsold">Unsold</asp:ListItem>
                                <asp:ListItem Value="Sold">Sold</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="six wide column"></div>
                    <div class="six wide column bottom aligned right aligned">
                        <asp:LinkButton ID="ExportSoldBtn" runat="server" CssClass="ui red button">
                    <i class="file excel outline icon"></i>Export to CSV
                        </asp:LinkButton>
                        <asp:LinkButton ID="BtnPrintSoldInvoices" runat="server" CssClass="ui red button" OnClick="BtnPrintSoldInvoices_Click"><i class="print icon"></i>Print Bid Sheets</asp:LinkButton>
                    </div>
                </div>
                <div class="margin-top-block">
                    <asp:GridView ID="SoldStatusGrid" runat="server" CssClass="ui celled red table center aligned" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" ShowHeaderWhenEmpty="True" OnSelectedIndexChanged="ItemSoldStatusGrid_SelectedIndexChanged">
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    Print
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <div class="ui fitted checkbox">
                                        <asp:CheckBox ID="CheckBox3" runat="server" />
                                        <label></label>
                                    </div>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Status" SortExpression="Status">
                                <ItemTemplate>
                                    <%# (Eval("Status").ToString().Equals("Unsold")) ? 
                                    "<a class='ui grey label'>Unsold</a>": "" %>
                                    <%# (Eval("Status").ToString().Equals("Sold")) ? 
                                    "<a class='ui red label'>Sold</a>": "" %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="CATITEMID" HeaderText="Item ID" SortExpression="CATITEMID" ReadOnly="True" />
                            <asp:BoundField DataField="ITEMNAME" HeaderText="Item Name" SortExpression="ITEMNAME" />
                            <asp:BoundField DataField="Column1" HeaderText="Value" SortExpression="Column1" ReadOnly="True" />
                            <asp:BoundField DataField="Column2" HeaderText="Angel Price" SortExpression="Column2" ReadOnly="True" />
                            <asp:BoundField DataField="Column3" HeaderText="Minimum Bid" SortExpression="Column3" ReadOnly="True" />
                            <asp:BoundField DataField="Buyer" HeaderText="Buyer" ReadOnly="True" SortExpression="Buyer" />
                            <asp:CommandField SelectText="View" ShowSelectButton="True">
                                <ControlStyle CssClass="ui button" />
                            </asp:CommandField>
                        </Columns>
                    </asp:GridView>

                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:it368_Auction_ProjectConnectionString %>" SelectCommand="SELECT [Status], [CATITEMID], [ITEMNAME], '$'  +  CAST([ITEMVALUE] as NVARCHAR(10)),  '$'  +  CAST([ANGELPRICE] as NVARCHAR(10)),  '$'  +  CAST([MINBID] as NVARCHAR(10)), [Buyer] FROM [ItemStatusViewBySold] WHERE ([Status] = @Status)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="SoldStatusList" Name="Status" PropertyName="SelectedValue" DefaultValue="Unsold" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdatePanel ID="UpdatePanelForPaidStatusView" runat="server" style="margin-bottom:50px">
            <ContentTemplate>

                <div class="ui grid"  id="PaidView">
                    <div class="four wide column">
                        <div class="field">
                            <label>By Paid Status</label>
                            <asp:DropDownList ID="PaidStatusList" runat="server" OnSelectedIndexChanged="PaidStatusList_SelectedIndexChanged" AutoPostBack="True">
                                <asp:ListItem Value="Unpaid">Unpaid</asp:ListItem>
                                <asp:ListItem Value="Paid">Paid</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="six wide column"></div>
                    <div class="six wide column bottom aligned right aligned">
                        <asp:LinkButton ID="BtnExportCSV" runat="server" CssClass="ui red button">
                    <i class="file excel outline icon"></i>Export to CSV
                        </asp:LinkButton>
                        <asp:LinkButton ID="BtnPrintPaidInvoices" runat="server" CssClass="ui red button" OnClick="BtnPrintPaidInvoices_Click"><i class="print icon"></i>Print Bid Sheets</asp:LinkButton>
                    </div>
                </div>
                <div class="margin-top-block">
                    <asp:GridView ID="ItemStatusGrid" runat="server" CssClass="ui celled red table center aligned" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" ShowHeaderWhenEmpty="True" OnSelectedIndexChanged="ItemPaidStatusGrid_SelectedIndexChanged">
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    Print
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <div class="ui fitted checkbox">
                                        <asp:CheckBox ID="CheckBox2" runat="server" />
                                        <label></label>
                                    </div>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Status" SortExpression="Status">
                                <ItemTemplate>
                                    <%# (Eval("Status").ToString().Equals("Unpaid")) ? 
                                    "<a class='ui blue label'>Unpaid</a>": "" %>
                                    <%# (Eval("Status").ToString().Equals("Paid")) ? 
                                    "<a class='ui green label'>Paid</a>": "" %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="CATITEMID" HeaderText="Item ID" SortExpression="CATITEMID" ReadOnly="True" />
                            <asp:BoundField DataField="ITEMNAME" HeaderText="Item Name" SortExpression="ITEMNAME" />
                            <asp:BoundField DataField="Column1" HeaderText="Value" SortExpression="Column1" ReadOnly="True" />
                            <asp:BoundField DataField="Column2" HeaderText="Angel Price" SortExpression="Column2" ReadOnly="True" />
                            <asp:BoundField DataField="Column3" HeaderText="Minimum Bid" SortExpression="Column3" ReadOnly="True" />
                            <asp:BoundField DataField="Buyer" HeaderText="Buyer" ReadOnly="True" SortExpression="Buyer" />
                            <asp:CommandField SelectText="View" ShowSelectButton="True">
                                <ControlStyle CssClass="ui button" />
                            </asp:CommandField>
                        </Columns>
                    </asp:GridView>

                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:it368_Auction_ProjectConnectionString %>" SelectCommand="SELECT [Status], [CATITEMID], [ITEMNAME], '$'  +  CAST([ITEMVALUE] as NVARCHAR(10)),  '$'  +  CAST([ANGELPRICE] as NVARCHAR(10)),  '$'  +  CAST([MINBID] as NVARCHAR(10)), [Buyer] FROM [ItemStatusViewByPaid] WHERE ([Status] = @Status)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="PaidStatusList" Name="Status" PropertyName="SelectedValue" DefaultValue="Unpaid" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
        <%-- <table class="ui celled red table center aligned">
          <thead>
            <tr>
            <th>
                <div class="ui checkbox">
                    <asp:CheckBox ID="SelectAll" runat="server" /><label></label>
                </div>
            </th>
            <th>Status</th>
            <th>Image</th>
            <th>Item ID</th>
            <th>Category</th>
            <th>Item Name</th>
            <th>Designer</th>
            <th>Current</th>
            <th>Minimum</th>
            <th>Angel</th>
            <th></th>
          </tr></thead>
          <tbody>
            <tr>
              <td>
                <div class="ui checkbox">
                    <asp:CheckBox ID="CheckBox1" runat="server" /><label></label>
                </div>
              </td>
              <td><div class="ui orange label">Unpaid</div></td>
              <td class="center aligned">
                <img src="../assets/image/wr.jpg"  class="ui mini rounded image"/>
              </td>
              <td>CP0001</td>
              <td>Celebrity Price</td>
              <td>Big ribbon Wreath</td>
              <td>John Doe</td>
              <td class="right aligned">$30.00</td>
              <td class="right aligned">$20.00</td>
              <td class="right aligned">$70.00</td>
              <td><a class="ui button" href="SingleView.aspx?itemId=CP0001">View</a></td>
            </tr>
            <tr>
              <td>
                <div class="ui checkbox">
                    <asp:CheckBox ID="CheckBox2" runat="server" /><label></label>
                </div>
              </td>
              <td><div class="ui red label"> Sold </div></td>
              <td>
                <img src="../assets/image/tree.jpg"  class="ui mini rounded image"/>
              </td>
              <td>DI0125</td>
              <td>Designer Items</td>
              <td>Mary's X'mas Tree</td>
              <td>Mary Doe</td>
              <td class="right aligned">$150.00</td>
              <td class="right aligned">$80.00</td>
              <td class="right aligned">$300.00</td>
              <td><a class="ui button" href="SingleView.aspx?itemId=DI0125">View</a></td>
            </tr>
            <tr>
              <td>
                <div class="ui checkbox">
                    <asp:CheckBox ID="CheckBox3" runat="server" /><label></label>
                </div>
              </td>
              <td><div class="ui blue label">Unsold</div></td>
              <td>
                <img src="../assets/image/sock.jpg"  class="ui mini rounded image"/>
              </td>
              <td>GB0030</td>
              <td>Ginger Bread</td>
              <td>X'mas Family Stockings</td>
              <td>John Doe</td>
              <td class="right aligned">$30.00</td>
              <td class="right aligned">$20.00</td>
              <td class="right aligned">$70.00</td>
              <td><a class="ui button" href="SingleView.aspx?itemId=GB0030">View</a></td>
            </tr>
          </tbody>
          <tfoot>
            <tr><th colspan="11">
              <div class="ui right floated pagination inverted red menu">
                <a class="icon item">
                  <i class="left chevron icon"></i>
                </a>
                <a class="item">1</a>
                <a class="item">2</a>
                <a class="item">3</a>
                <a class="item">4</a>
                <a class="icon item">
                  <i class="right chevron icon"></i>
                </a>
              </div>
            </th>
          </tr></tfoot>
        </table>--%>
    </div>
</div>
