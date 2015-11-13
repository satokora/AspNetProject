<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ViewSingleUser.ascx.cs" Inherits="FestivalOfTrees.Views.ViewSingleUser" %>
<div class="ui center aligned grid">
    <div class="column" style="max-width: 800px">
        <div class="ui raised segment left aligned">
            <h2 style="text-align:center"><asp:Label ID="LblUserName" runat="server" >Satoko Kora</asp:Label></h2>
            <div class="ui middle aligned divided big relaxed list">
              
              <div class="item">
                <i class="home icon"></i>
                <div class="content">
                    <asp:Label ID="LblAddress" runat="server" >300 E Shelbourne Dr Apt 62</asp:Label>
                    ,<asp:Label ID="LblCity" runat="server" >Normal</asp:Label>,<asp:Label ID="LblState" runat="server" >IL</asp:Label>
                </div>
              </div>
              
              <div class="item">
                <i class="tag icon"></i>
                <div class="content">
                  <asp:Label ID="lblZip" runat="server" >61761</asp:Label>
                </div>
              </div>
              <div class="item">
                <i class="phone icon"></i>
                <div class="content">
                  <asp:Label ID="LblHomePhone" runat="server" >(309)310-3740</asp:Label>
                </div>
              </div>
              <div class="item">
                <div class="right floated content">
                  <asp:LinkButton ID="BtnText" runat="server" CssClass="tiny ui primary  button"><i class="mail icon"></i>Text</asp:LinkButton>
                  <asp:LinkButton ID="BtnCall" runat="server" CssClass="tiny ui primary button"><i class="phone icon"></i>Call</asp:LinkButton>
                </div>
                <i class="mobile icon"></i>
                <div class="content">
                  <asp:Label ID="LblMobilePhone" runat="server" >(309)310-3740</asp:Label>
                </div>
              </div>
              <div class="item">
                <div class="right floated content">
                  <asp:LinkButton ID="BtnEmail" runat="server" CssClass="tiny ui red button"><i class="mail icon"></i>Email Invoice</asp:LinkButton>
                  
                </div>
                <i class="mail icon"></i>
                <div class="middle aligned content">
                    <asp:Label ID="LblEmail" runat="server" >jack@semantic-ui.com</asp:Label>
                </div>
              </div>
            </div>


            <h4 class="ui horizontal divider header">
              <i class="shop icon"></i>
              Invoice
            </h4>  
            
            <asp:Table ID="TableInvoice" runat="server" CssClass="ui celled striped table"></asp:Table>
            
            <!-- following table is just an example how it's supposed to look like -->
            <table class="ui celled striped table">
              <thead>
                <tr>
                    <th>Item Number</th>
                    <th>Category</th>
                    <th>Description(Designer in parentheses)</th>
                    <th>Estimated Value</th>
                    <th>Bid</th>
                    <th>Paid?</th>
              </tr></thead>
              <tbody>
                <tr>
                  <td>
                    CP001
                  </td>
                  <td>
                    Celebrity Price
                  </td>
                  <td>X'mas tree (John Doe)</td>
                  <td class="right aligned">30.00</td>
                  <td class="right aligned">25.00</td>
                  <td>Yes</td>
                </tr>
                <tr>
                  <td>
                    GB001
                  </td>
                  <td>GingerBread</td>
                  <td>X'mas Wreath (John Smith)</td>
                  <td class="right aligned">140.00</td>
                  <td class="right aligned">125.00</td>
                  <td>No</td>
                </tr>
                <tr>
                  <td>
                    DI002
                  </td>
                  <td>Designer Item</td>
                  <td>Greeting Card Set (Mary Smith)</td>
                  <td class="right aligned">20.00</td>
                  <td class="right aligned">12.75</td>
                  <td>Yes</td>
                </tr>
                <tr>
                  <td></td>
                  <td></td>
                  <td></td>
                  <td class="right aligned"></td>
                  <td class="right aligned"></td>
                  <td></td>
                </tr>
                <tr>
                  <td></td>
                  <td></td>
                  <td></td>
                  <td class="right aligned"></td>
                  <td class="right aligned"></td>
                  <td></td>
                </tr>
            </tbody>
            <tfoot>
                <tr>
                  <th colspan="4" class="right aligned"><b>Total Amount of Items Bid</b></th>
                  <th class="right aligned"><b>162.75</b></th>
                  <th></th>
                </tr>
                <tr>
                  <th colspan="4" class="right aligned"><b>Total Amount Paid</b></th>
                  <th class="right aligned"><b>37.75</b></th>
                  <th></th>
                </tr>
                <tr>
                  <th colspan="4" class="right aligned"><b>Total Amount Due</b></th>
                  <th class="right aligned"><b>125.00</b></th>
                  <th></th>
                </tr>
              </tfoot>
            </table>
            <asp:LinkButton ID="BtnUpdateStatus" runat="server" CssClass="ui red button"><i class="dollar icon"></i>Update Payment Status</asp:LinkButton>
            <asp:LinkButton ID="BtnPrintInvoice" runat="server" CssClass="ui red button"><i class="file pdf outline icon"></i>Print Invoice</asp:LinkButton>
        </div>
    </div>
</div>