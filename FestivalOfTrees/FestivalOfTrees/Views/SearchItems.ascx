<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchItems.ascx.cs" Inherits="FestivalOfTrees.Views.SearchItems" %>

<div class="ui conatiner">
    <div class="ui stacked segment" style="min-height: 250px">
        <h3 style="text-align:center">Search for items by Item ID</h3>
            
         
                <div class="two fields">                 
                    <div class="field">
                        <label class="account">Item ID</label>
                        <asp:TextBox ID="ItemIDBox" runat="server"></asp:TextBox>
                    </div>
                    <div class="field">
                    </div>
                </div>
                <asp:Button ID="BtnGetItemsByItemId" runat="server" Text="Search for Items" CssClass="ui secondary button"/>

        <br />
        

            <asp:GridView ID="GridViewItemsByItemId" runat="server" CssClass="ui red table center aligned"></asp:GridView>
           <asp:LinkButton ID="BtnPrintInvoices" runat="server" CssClass="ui red button"><i class="print icon"></i>Print Bid Sheets</asp:LinkButton>
    </div>
</div>