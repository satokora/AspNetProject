<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EnterNewItem.ascx.cs" Inherits="FestivalOfTrees.EnterNewItem" %>
<%--<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>--%>

<div class="ui middle aligned center aligned grid">
    <div class="column"  style="max-width:800px;">
        <div class="ui raised segment">
              <h3>
                  <asp:Label ID="LblTitleItemPage" runat="server">Enter new item</asp:Label>
              </h3>
            <div class="ui stackable grid"> 
                <div class="two column row">
                    <div class="ten wide column">
                        <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                        <div class="field">
                            <label>Category</label>
                                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="ui fluid dropdown" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="CATEGORYNAME" DataValueField="CATEGORYID" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:it368_Auction_ProjectConnectionString %>" SelectCommand="SELECT * FROM [CATEGORY] WHERE ([AUCTIONID] = @AUCTIONID)">
                                            <SelectParameters>
                                                <asp:SessionParameter Name="AUCTIONID" SessionField="Auction" Type="Int32" />
                                            </SelectParameters>
                                        </asp:SqlDataSource>
                        </div>
                                </ContentTemplate>
                                <Triggers> 
                                    <asp:AsyncPostBackTrigger ControlID="DropDownList1" EventName="SelectedIndexChanged" /> 
                                </Triggers>
                            </asp:UpdatePanel>
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                        <div class="field">
                            <label>Value</label>
                            <div class="ui labeled input">
                              <div class="ui label">$</div>
                                        <asp:TextBox ID="TxtValPrice" runat="server" placeholder="Amount" OnKeyUp="TxtValPrice_TextChanged"  OnTextChanged="TxtValPrice_TextChanged" AutoPostBack="True"></asp:TextBox>
                            </div>
                        </div>
                        <div class="field">
                            <label>Minimum Bid</label>
                            <div class="ui labeled input">
                              <div class="ui label">$</div>
                                <asp:TextBox ID="TxtMinBid" runat="server" placeholder="Amount"></asp:TextBox>
                            </div>
                           
                        </div>
                        <div class="field">
                            <label>Angel Price</label>
                            <div class="ui labeled input">
                              <div class="ui label">$</div>
                                <asp:TextBox ID="TxtAngPrice" runat="server" placeholder="Amount"></asp:TextBox>
                            </div>
                        </div>
                            </ContentTemplate>
                            <Triggers> 
                                    <asp:AsyncPostBackTrigger ControlID="TxtValPrice" EventName="TextChanged" /> 
                                </Triggers>
                        </asp:UpdatePanel>
                    </div>
                    <div class="six wide column">
                        <div>
                            <img src="../assets/image/noimage.png" alt="No Image" class="upload-image" />
                        </div>
                        <div>
                            <input type="file" id="File1">                            
                        </div>
                   </div>
                </div>
         
                <div class="sixteen wide column">
                    <div class="field" id="designer-srch">
                        <label>Donor/Designer</label>
                        <div class="ui action input">
                            <asp:TextBox ID="DonorName" runat="server" placeholder="Search..." ></asp:TextBox>
                            <%--<ajaxToolkit:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="DonorName" ServiceMethod="GetCompletionList"></ajaxToolkit:AutoCompleteExtender>--%>
                            <a class="ui red button">Search</a>
                        </div>
                    </div>
                    <div class="field">
                        <label>Sponsor Name (Optional)</label>
                        <asp:TextBox ID="SponsorName" runat="server" ></asp:TextBox>
                    </div>
                    <div class="field">
                        <label>Sponsor Link (Optional)</label>
                        <div class="ui left icon input">
                            <asp:TextBox ID="SponsorLink" runat="server" placeholder="Link to sponsor page" ></asp:TextBox>
                            <i class="world icon"></i>
                        </div>
                    </div>
                    <div class="field">
                        <label>Item Name</label>
                        <asp:TextBox ID="ItemName" runat="server" ></asp:TextBox>
                    </div>
                    <div class="field">
                        <label>Item Description (Optional)</label>
                        <asp:TextBox ID="Description" runat="server" TextMode="MultiLine" Rows="4"></asp:TextBox>
                    </div>
                    <div class="field">
                        <asp:Button ID="AddItem" runat="server" Text="Add Item"  CssClass="ui fluid large red button" />
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>

<div class="ui modal" id="ConfirmUpdateMsg">
  <div class="header">Confirm Item Information</div>
  <div class="content">
    <p></p>
    <p></p>
    <p></p>
      <asp:Button ID="BtnConfirmItem" runat="server" Text="Button" />
  </div>
</div>

<div class="ui modal designer">
  <div class="header">Select Designer/Donor</div>
  <div class="content">
      <div class="ui form">
          <div class="field">
              <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple" CssClass="ui fluid dropdown" DataSourceID="SqlDataSource2"  DataTextField="LASTNAME" DataValueField="USERID" Rows="3"></asp:ListBox>
      <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:it368_Auction_ProjectConnectionString %>" SelectCommand="Select USERID, FIRSTNAME, LASTNAME from USERINFO where DONOR=1"></asp:SqlDataSource>
    <p></p>
    <p></p>
          </div></div>
      <asp:Button ID="Button1" runat="server" Text="Button" />
  </div>
</div>

