<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EnterNewItem.ascx.cs" Inherits="FestivalOfTrees.EnterNewItem" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<div class="ui middle aligned center aligned grid">
    <div class="column"  style="max-width:800px;">
        <div class="ui raised segment">
              <h3>
                  <asp:Label ID="LblTitleItemPage" runat="server">Enter new item</asp:Label>
              </h3>
            <div class="ui stackable grid"> 
                <div class="two column row">
                    <div class="ten wide column">
                        <div class="field">
                            <label>Category</label>
                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="ui fluid dropdown"></asp:DropDownList>
                        </div>
                        <div class="field">
                            <label>Value</label>
                            <div class="ui labeled input">
                              <div class="ui label">$</div>
                                <asp:TextBox ID="TxtValPrice" runat="server" placeholder="Amount"></asp:TextBox>
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
         <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <div class="sixteen wide column">
                    <div class="field">
                        <label>Donor/Designer</label>
                        <div class="ui action input">
                            <asp:TextBox ID="DonorName" runat="server" placeholder="Search..." ></asp:TextBox>
                            <ajaxToolkit:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="DonorName" ServiceMethod="GetCompletionList"></ajaxToolkit:AutoCompleteExtender>
                            <asp:Button ID="SearchDonor" runat="server" Text="Search" CssClass="ui red button" />
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

<div class="ui modal">
  <div class="header">Confirm Item Information</div>
  <div class="content">
    <p></p>
    <p></p>
    <p></p>
      <asp:Button ID="BtnConfirmItem" runat="server" Text="Button" />
  </div>
</div>
