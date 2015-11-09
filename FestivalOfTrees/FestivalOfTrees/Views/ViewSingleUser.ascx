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
            
            <table class="ui celled striped table">
              <thead>
                <tr>
                    <th class="three wide">Item ID</th>
                    <th class="ten wide">Description</th>
                    <th class="three wide">Price</th>
              </tr></thead>
              <tbody>
                <tr>
                  <td>
                    CS001
                  </td>
                  <td>X'mas tree</td>
                  <td class="right aligned">25.00</td>
                </tr>
                <tr>
                  <td>
                    GB001
                  </td>
                  <td>X'mas Wreath</td>
                  <td class="right aligned">125.00</td>
                </tr>
                <tr>
                  <td>
                    DI002
                  </td>
                  <td>Greeting Card Set</td>
                  <td class="right aligned">12.75</td>
                </tr>
                <tr>
                  <td></td>
                  <td></td>
                  <td class="right aligned"></td>
                </tr>
                <tr>
                  <td></td>
                  <td></td>
                  <td class="right aligned"></td>
                </tr>
            </tbody>
            <tfoot>
                <tr>
                  <th colspan="2" class="right aligned"><a class="ui teal label">Unpaid</a>  <b>Total</b></th>
                  <th class="right aligned"><b>162.75</b></th>
                </tr>
              </tfoot>
            </table>
            <asp:LinkButton ID="BtnUpdateStatus" runat="server" CssClass="ui red button"><i class="dollar icon"></i>Update Payment Status</asp:LinkButton>
            <asp:LinkButton ID="BtnPrintInvoice" runat="server" CssClass="ui red button"><i class="file pdf outline icon"></i>Print Invoice</asp:LinkButton>
        </div>
    </div>
</div>