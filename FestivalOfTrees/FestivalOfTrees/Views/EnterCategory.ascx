<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EnterCategory.ascx.cs" Inherits="FestivalOfTrees.Views.EnterCategory" %>

<div class="ui middle aligned center aligned grid">
    <div class="column" style="max-width: 800px;">
        <div class="ui raised segment left aligned">
            <h3 style="text-align: center">
                <asp:Label ID="LblTitleItemPage" runat="server">Enter new category</asp:Label>
            </h3>
            <h3>Current Category List:</h3>
            <asp:GridView ID="AllCatGridView" runat="server"></asp:GridView>
            <h3>Add New Category:</h3>
            <h4>Auction Name:
                <asp:Label ID="Label1" runat="server" Text="Festival of Trees"></asp:Label></h4>
            <div class="fields">
                <div class="four wide field">
                    <div class="field">
                        <label>New Category ID</label>
                        <asp:TextBox ID="TxtNewCatId" runat="server" placeholder="new category ID"></asp:TextBox>
                    </div>
                </div>
                <div class="twelve wide field">
                    <div class="field">
                        <label>New Category Name</label>
                        <asp:TextBox ID="TxtNewCatName" runat="server" placeholder="New category ID"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="field">
                    <label>Sponsor Information</label>
                    <div class="fields">
                        <div class="four wide field">
                            <div class="ui toggle checkbox">
                                <asp:CheckBox ID="ChkSponsored" runat="server" />
                                <label>Sponsored</label>
                            </div>
                        </div>
                        <div class="twelve wide field">
                            <asp:TextBox ID="TxtSponsorName" runat="server" placeholder="Sponsor Name"></asp:TextBox>
                        </div>
                    </div>
                </div>
            <div class="field">
                    <label>Sub Category</label>
                    <div class="fields">
                        <div class="four wide field">
                            <div class="ui toggle checkbox">
                                <asp:CheckBox ID="ChkSubCategory" runat="server" />
                                <label>Sub Category</label>
                            </div>
                        </div>
                        <div class="twelve wide field">
                            <asp:DropDownList ID="ParentCatList" runat="server">
                                <asp:ListItem Value="">Select Parent Category...</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
            
            <div class="field">
                        <asp:Button ID="BtnAddCategory" runat="server" Text="Add Category"  CssClass="ui fluid large red button" />
                    </div>
        </div>
</div>
</div>
