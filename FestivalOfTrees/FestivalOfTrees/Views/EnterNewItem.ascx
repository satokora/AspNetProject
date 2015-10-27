<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EnterNewItem.ascx.cs" Inherits="FestivalOfTrees.EnterNewItem" %>

<div class="ui middle aligned center aligned grid">
    <div class="column"  style="max-width:800px;">
        <div class="ui raised segment">
              <h3>Enter new item</h3>
            <div class="ui stackable grid"> 
                <div class="two column row">
                    <div class="ten wide column">
                        <div class="field">
                            <label>Category</label>
                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="ui fluid dropdown"></asp:DropDownList>
                        </div>
                        <div class="field">
                            <label>Minimun Bid</label>
                            <div class="ui labeled input">
                              <div class="ui label">$</div>
                                <asp:TextBox ID="TextBox1" runat="server" placeholder="Amount"></asp:TextBox>
                            </div>
                        </div>
                        <div class="field">
                            <label>Angel Price</label>
                            <div class="ui labeled input">
                              <div class="ui label">$</div>
                                <asp:TextBox ID="TextBox2" runat="server" placeholder="Amount"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="six wide column">
                        <div>
                            <img src="../assets/image/noimage.png" alt="No Image" class="upload-image" />
                        </div>
                        <div>
                            <input type="file" id="File1">
                            <%--<label for="file" class="ui icon secondary button">
                                <i class="file icon"></i>
                                Choose Image</label>--%>
                            <%--<input type="file" id="File1" style="display:none; margin-left:-50px">--%>
                        </div>
                   </div>
                </div>
         
                <div class="sixteen wide column">
                    <div class="field">
                        <label>Donor/Designer</label>
                        <div class="ui action input">
                            <asp:TextBox ID="DonorName" runat="server" placeholder="Search..." ></asp:TextBox>
                            <asp:Button ID="SearchDonor" runat="server" Text="Search" CssClass="ui red button" />
                        </div>
                    </div>
                    <div class="field">
                        <label>Item Name</label>
                        <asp:TextBox ID="ItemName" runat="server" ></asp:TextBox>
                    </div>
                    <div class="field">
                        <asp:Button ID="AddItem" runat="server" Text="Add Item"  CssClass="ui fluid large red button" />
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>
