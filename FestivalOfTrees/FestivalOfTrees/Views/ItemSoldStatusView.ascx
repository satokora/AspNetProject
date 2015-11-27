<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ItemSoldStatusView.ascx.cs" Inherits="FestivalOfTrees.Views.ItemSoldStatusView" %>
<div class="ui conatiner">
    <div class="ui stacked segment">
        <h3 style="text-align: center">Item View by Sold Status</h3>
        <%--<asp:ScriptManager ID="ScriptManagerForStatusView" runat="server"></asp:ScriptManager>--%>
        <asp:UpdatePanel ID="UpdatePanelForSoldStatusView" runat="server" style="margin-bottom: 50px">
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
                    <div class="nine wide column bottom aligned right aligned" id="paid">
                        <asp:LinkButton ID="ExportSoldBtn" runat="server" CssClass="ui red button">
                            <i class="file excel outline icon"></i>Export to CSV
                        </asp:LinkButton>
                    </div>
                    <div class="three wide column bottom aligned right aligned">
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
        <div class="ui basic modal center aligned">
            <div class="ui grid">
                <div class="six wide column"></div>
                <div class="four wide column">

                    <div class="header">
                        <h2>Export to Excel</h2>
                    </div>
                    <div class="description">
                        <h4>Select columns to export:</h4>
                    </div>
                    <div class="content">
                        <div class="ui checkbox">
                            <asp:CheckBoxList ID="SoldColumnList" runat="server">
                            </asp:CheckBoxList>
                        </div>
                    </div>
                    <div class="action">
                        <asp:Button ID="SelectSoldColBtn" runat="server" Text="Select" CssClass="ui button" OnClick="SelectSoldColBtn_Click" />
                    </div>
                </div>
            </div>
            <div class="six wide column"></div>
        </div>
    </div>
</div>
