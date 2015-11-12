<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ItemStatusView.ascx.cs" Inherits="FestivalOfTrees.Views.ItemStatusView" %>
<div class="ui conatiner">
    <div class="ui stacked segment">
        <h3 style="text-align:center">Quick Item View</h3>
        <div class="ui grid">
            <div class="four wide column">
                <div class="field">
                  <label>Status</label>
                    <asp:DropDownList ID="StatusList" runat="server">
                        <asp:ListItem Value="us">Unsold</asp:ListItem>
                        <asp:ListItem Value="sd">Sold</asp:ListItem>
                        <asp:ListItem Value="up">Unpaid</asp:ListItem>
                        <asp:ListItem Value="pd">Paid</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="nine wide column"></div>
            <div class="three wide column bottom aligned right aligned">
                <asp:LinkButton ID="BtnExportCSV" runat="server" CssClass="ui red button">
                    <i class="file excel outline icon"></i>Export to CSV
                </asp:LinkButton>
            </div>
        </div>
        <asp:Table ID="ItemStatusTable" runat="server" CssClass="ui celled red table center aligned"></asp:Table>
        <table class="ui celled red table center aligned">
          <thead>
            <tr>
            <th>
                <div class="ui checkbox">
                    <asp:CheckBox ID="SelectAll" runat="server" /><label></label>
                </div>
            </th>
            <th>Status</th>
            <th>Image</th>
            <th>Item ID</th>
            <th>Category</th>
            <th>Item Name</th>
            <th>Designer</th>
            <th>Current</th>
            <th>Minimum</th>
            <th>Angel</th>
            <th></th>
          </tr></thead>
          <tbody>
            <tr>
              <td>
                <div class="ui checkbox">
                    <asp:CheckBox ID="CheckBox1" runat="server" /><label></label>
                </div>
              </td>
              <td><div class="ui orange label">Unpaid</div></td>
              <td class="center aligned">
                <img src="../assets/image/wr.jpg"  class="ui mini rounded image"/>
              </td>
              <td>CP0001</td>
              <td>Celebrity Price</td>
              <td>Big ribbon Wreath</td>
              <td>John Doe</td>
              <td class="right aligned">$30.00</td>
              <td class="right aligned">$20.00</td>
              <td class="right aligned">$70.00</td>
              <td><a class="ui button" href="SingleView.aspx?itemId=CP0001">View</a></td>
            </tr>
            <tr>
              <td>
                <div class="ui checkbox">
                    <asp:CheckBox ID="CheckBox2" runat="server" /><label></label>
                </div>
              </td>
              <td><div class="ui red label"> Sold </div></td>
              <td>
                <img src="../assets/image/tree.jpg"  class="ui mini rounded image"/>
              </td>
              <td>DI0125</td>
              <td>Designer Items</td>
              <td>Mary's X'mas Tree</td>
              <td>Mary Doe</td>
              <td class="right aligned">$150.00</td>
              <td class="right aligned">$80.00</td>
              <td class="right aligned">$300.00</td>
              <td><a class="ui button" href="SingleView.aspx?itemId=DI0125">View</a></td>
            </tr>
            <tr>
              <td>
                <div class="ui checkbox">
                    <asp:CheckBox ID="CheckBox3" runat="server" /><label></label>
                </div>
              </td>
              <td><div class="ui blue label">Unsold</div></td>
              <td>
                <img src="../assets/image/sock.jpg"  class="ui mini rounded image"/>
              </td>
              <td>GB0030</td>
              <td>Ginger Bread</td>
              <td>X'mas Family Stockings</td>
              <td>John Doe</td>
              <td class="right aligned">$30.00</td>
              <td class="right aligned">$20.00</td>
              <td class="right aligned">$70.00</td>
              <td><a class="ui button" href="SingleView.aspx?itemId=GB0030">View</a></td>
            </tr>
          </tbody>
          <tfoot>
            <tr><th colspan="11">
              <div class="ui right floated pagination inverted red menu">
                <a class="icon item">
                  <i class="left chevron icon"></i>
                </a>
                <a class="item">1</a>
                <a class="item">2</a>
                <a class="item">3</a>
                <a class="item">4</a>
                <a class="icon item">
                  <i class="right chevron icon"></i>
                </a>
              </div>
            </th>
          </tr></tfoot>
        </table>
    </div>
</div>