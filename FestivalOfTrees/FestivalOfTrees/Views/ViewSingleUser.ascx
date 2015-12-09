<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ViewSingleUser.ascx.cs" Inherits="FestivalOfTrees.Views.ViewSingleUser" %>
<div class="ui center aligned grid">
    <div class="column" style="max-width: 1000px">
        <div class="ui raised segment left aligned">
            <h2 style="text-align: center">
                <asp:Label ID="LblUserName" runat="server">Satoko Kora</asp:Label></h2>
            <div class="ui middle aligned divided big relaxed list">

                <div class="item">
                    <i class="home icon"></i>
                    <div class="content">
                        <asp:Label ID="LblAddress" runat="server">300 E Shelbourne Dr Apt 62</asp:Label>
                        ,<asp:Label ID="LblCity" runat="server">Normal</asp:Label>,<asp:Label ID="LblState" runat="server">IL</asp:Label>
                    </div>
                </div>

                <div class="item">
                    <i class="tag icon"></i>
                    <div class="content">
                        <asp:Label ID="lblZip" runat="server">61761</asp:Label>
                    </div>
                </div>
                <div class="item">
                    <i class="phone icon"></i>
                    <div class="content">
                        <asp:Label ID="LblHomePhone" runat="server">(309)310-3740</asp:Label>
                    </div>
                </div>
                <div class="item">
                    
                    
                    <div class="right floated content">
                        
                        <asp:LinkButton ID="BtnText" runat="server" CssClass="tiny ui primary  button" OnClick="BtnText_Click"><i class="mail icon"></i>Send</asp:LinkButton>
                        <%--<asp:LinkButton ID="BtnCall" runat="server" CssClass="tiny ui primary button"><i class="phone icon"></i>Call</asp:LinkButton>--%>
                        </div>
                    
                    <div class="content">
                        <i class="mobile icon"></i><asp:Label ID="LblMobilePhone" runat="server">(309)310-3740</asp:Label>
                        <asp:Label ID="MessageSent" runat="server" Text="Label" ForeColor="Red">Message Sent</asp:Label>
                    
                    <div class="field">
                            <asp:TextBox ID="SMSMessage" runat="server" TextMode="MultiLine" placeholder="Enter message" Rows="3"></asp:TextBox>
                          </div>
                        </div>
                </div>
                <div class="item">
                    <div class="right floated content">
                        <asp:LinkButton ID="BtnEmail" runat="server" CssClass="tiny ui red button"><i class="mail icon"></i>Email Invoice</asp:LinkButton>

                    </div>
                    <i class="mail icon"></i>
                    <div class="middle aligned content">
                        <asp:Label ID="LblEmail" runat="server">jack@semantic-ui.com</asp:Label>
                    </div>
                </div>
            </div>


            <h4 class="ui horizontal divider header">
                <i class="shop icon"></i>
                Invoice
            </h4>

            <asp:GridView ID="InvoiceView" runat="server" CssClass="ui celled striped table" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" GridLines="None" ShowHeaderWhenEmpty="True" HeaderStyle-CssClass="center aligned" OnSelectedIndexChanged="InvoiceView_SelectedIndexChanged">
                <Columns>
                    <%--<asp:TemplateField HeaderText="Update" ItemStyle-CssClass="center aligned">
                        <ItemTemplate>
                            <asp:Button ID="Button1" runat="server" Text=<%# (Eval("PAID").Equals("YES")) ? "UnPaid" : "Paid" %> CssClass=<%# (Eval("PAID").Equals("YES")) ? "ui button" : "ui orange button" %> visible=<%# String.IsNullOrEmpty(Eval("PAID").ToString()) ? false : true %>/>
                        </ItemTemplate>
                    </asp:TemplateField>--%>
                    
                    <%--<asp:CommandField SelectText=<%# (Eval("PAID").Equals("YES")) ? "UnPaid" : "Paid" %> ShowSelectButton="<%# String.IsNullOrEmpty(Eval("PAID").ToString()) ? False : True %>">
                        <ControlStyle CssClass=<%# (Eval("PAID").Equals("YES")) ? "ui button" : "ui orange button" %> />
                    </asp:CommandField>--%>
                    <asp:BoundField DataField="CATITEMID" HeaderText="Item Number" ReadOnly="True" SortExpression="CATITEMID" />
                    <asp:BoundField DataField="CATEGORYNAME" HeaderText="Category" SortExpression="CATEGORYNAME" />
                    <asp:BoundField DataField="DESC" HeaderText="Description(Designer in Parentheses)" ReadOnly="True" SortExpression="DESC" />
                    <asp:BoundField DataField="ESTVALUE" HeaderText="Estimated Value" SortExpression="ESTVALUE" ItemStyle-CssClass="right aligned" >
<ItemStyle CssClass="right aligned"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="BIDAMOUNT" HeaderText="Bid" SortExpression="BIDAMOUNT" ItemStyle-CssClass="right aligned" >
<ItemStyle CssClass="right aligned"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="PAID" HeaderText="Paid?" ReadOnly="True" SortExpression="PAID" />
                    <asp:CommandField HeaderText="Paid Status" ShowSelectButton="True" SelectText="Change" ControlStyle-CssClass="ui button center aligned middle aligned" />
                    <%--<asp:TemplateField HeaderText="Update" ItemStyle-CssClass="center aligned">
                        <ItemTemplate>
                            <asp:Button ID="Button1" runat="server" Text=<%# (Eval("PAID").Equals("YES")) ? "UnPaid" : "Paid" %> CssClass=<%# (Eval("PAID").Equals("YES")) ? "ui button" : "ui orange button" %> visible=<%# String.IsNullOrEmpty(Eval("PAID").ToString()) ? false : true %>/>
                        </ItemTemplate>
                    </asp:TemplateField>--%>
                </Columns>
                <HeaderStyle BackColor="#F9FAFB" CssClass="ui celled stripe table center aligned" />
            </asp:GridView>



            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:it368_Auction_ProjectConnectionString %>" SelectCommand="getInvoiceByUserID" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:QueryStringParameter DefaultValue="0" Name="userID" QueryStringField="userId" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>

            <asp:LinkButton ID="BtnPrintInvoice" runat="server" CssClass="ui red button"><i class="file pdf outline icon"></i>Print Invoice</asp:LinkButton>
        </div>
    </div>
</div>
