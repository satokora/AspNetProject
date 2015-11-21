<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EnterNewItem.ascx.cs" Inherits="FestivalOfTrees.EnterNewItem" %>


<div class="ui middle aligned center aligned grid">
    <div class="column"  style="max-width:800px;">
        <div class="ui raised segment">
              <h3>
                  <asp:Label ID="LblTitleItemPage" runat="server">Enter new item</asp:Label>
              </h3>
            <div class="ui stackable grid"> 
                <div class="two column row">
                    <div class="ten wide column">
                        
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
                            <img src="../assets/image/noimage.png" alt="No Image" class="upload-image" id="myUploadedImg" />
                        </div>
                        <div>
                            <input type="file" id="File1">                            
                        </div>
                   </div>
                </div>
         
                <div class="sixteen wide column">
                    
                    
                    <div class="field">
                        <label>Item Name</label>
                        <asp:TextBox ID="ItemName" runat="server" ></asp:TextBox>
                    </div>
                    <div class="field">
                        <label>Item Description (Optional)</label>
                        <asp:TextBox ID="Description" runat="server" TextMode="MultiLine" Rows="4"></asp:TextBox>
                    </div>
                    <div class="field" id="designer-srch">
                        <label>Donor/Designer</label>
                        <div class="ui action input">
                            <asp:ListBox ID="DesignerList" runat="server" DataSourceID="SqlDataSource2"  DataTextField="FULLNAME" DataValueField="EMAIL" SelectionMode="Multiple" Height="100" Font-Size="Large"  OnDataBound="DesignerList_DataBound" >
                                <asp:ListItem Value="" Text="Select Designer/Donor..."></asp:ListItem>
                            </asp:ListBox>
                            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:it368_Auction_ProjectConnectionString %>" SelectCommand="SELECT EMAIL, (LASTNAME + ', ' + FIRSTNAME) AS FULLNAME FROM USERINFO WHERE DONOR=1 ORDER BY LASTNAME"></asp:SqlDataSource>
                        </div>
                    </div>
                    <div class="field">
                        <asp:Button ID="AddItem" runat="server" Text="Add Item"  CssClass="ui fluid large red button" OnClick="AddItem_Click" />
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

<%--<script>
    function sendFile(file) {

        var formData = new FormData();
        formData.append('file', $('#File1')[0].files[0]);
        $.ajax({
            type: 'post',
            url: 'fileUploader.ashx',
            data: formData,
            success: function (status) {
                if (status != 'error') {
                    var my_path = "MediaUploader/" + status;
                    $("#myUploadedImg").attr("src", my_path);
                }
            },
            processData: false,
            contentType: false,
            error: function () {
                alert("Whoops something went wrong!");
            }
        });
    }
</script>
--%>

