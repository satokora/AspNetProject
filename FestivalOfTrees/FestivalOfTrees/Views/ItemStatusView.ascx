<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ItemStatusView.ascx.cs" Inherits="FestivalOfTrees.Views.ItemStatusView" %>
<div class="ui conatiner">
    <div class="ui stacked segment">
        <h3 style="text-align:center">Quick Item View</h3>
        <div class="ui grid">
            <div class="four wide column">
                <div class="field">
                  <label>Status</label>
                  <select class="ui fluid dropdown">
                    <option value="">Select status</option>
                    <option value="p">Paid</option>
                    <option value="up">Unpaid</option>
                    <option value="s">Sold</option>
                    <option value="us">Unsold</option>
                  </select>
                </div>
            </div>
            <div class="nine wide column"></div>
            <div class="three wide column bottom aligned right aligned">
                <asp:LinkButton ID="LinkButton1" runat="server" CssClass="ui red button">
                    <i class="file excel outline icon"></i>Export to CSV
                </asp:LinkButton>
            </div>
        </div>
        <table class="ui celled red table center aligned">
          <thead>
            <tr>
            <th>Status</th>
            <th>Image</th>
            <th>Item ID</th>
            <th>Category</th>
            <th>Item Name</th>
            <th>Designer</th>
            <th>Current</th>
            <th>Minimum</th>
            <th>Angel</th>
            <th>Buyer</th>
          </tr></thead>
          <tbody>
            <tr>
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
              <td>-</td>
            </tr>
            <tr>
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
              <td>John Smith</td>
            </tr>
            <tr>
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
              <td>-</td>
            </tr>
          </tbody>
          <tfoot>
            <tr><th colspan="10">
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