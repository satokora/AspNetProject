<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="FestivalOfTrees.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign up - Festival of Trees</title>
    <link href="assets/semantic.min.css" rel="stylesheet" />
    <link href="assets/custom_style.css" rel="stylesheet" />
</head>
<body>
  <div class="ui container">
      <div class="ui middle aligned center aligned grid signup">
          <h2 class="ui image header">
            <img src="assets/image/Logo_FestTree.png" class="login-image" />
           </h2>
      </div>
      <div class="ui piled segment signup">
          <form id="form1" runat="server" class="ui form">
              <h3 class="ui dividing header">Sign up for an account</h3>
              <div class="field">
                <label>Name</label>
                <div class="two fields">
                  <div class="field">
                    <asp:TextBox ID="firstName" runat="server"  placeholder="First Name"></asp:TextBox>
                  </div>
                  <div class="field">
                    <asp:TextBox ID="lastName" runat="server"  placeholder="Last Name"></asp:TextBox>
                  </div>
                </div>
              </div>
              <div class="field">
                <label>Address</label>
                <div class="fields">
                  <div class="eight wide field">
                      <asp:TextBox ID="address1" runat="server" placeholder="Address1"></asp:TextBox>
                  </div>
                  <div class="eight wide field">
                    <asp:TextBox ID="address2" runat="server" placeholder="Address1"></asp:TextBox>
                  </div>
                </div>
              </div>
              <div class="two fields">
                <div class="field">
                  <label>State</label>
                  <asp:DropDownList ID="DropDownList1" runat="server" CssClass="ui fluid dropdown">
                      <asp:ListItem Value="">State</asp:ListItem>
                  </asp:DropDownList>
                </div>
                <div class="field">
                  <label>Zip Code / Postal Code</label>
                    <asp:TextBox ID="zipCode" runat="server"  placeholder="XXXXX-XXXX"></asp:TextBox>
                </div>
              </div>
             

              <div class="field">
                <label>Home Phone</label>
                <div class="fields">
                  <div class="eight wide field">
                      <asp:TextBox ID="phone" runat="server" TextMode="Phone" placeholder="(XXX)XXXX-XXXX"></asp:TextBox>
                  </div>
                </div>
              </div>
                
               <div class="field">
                <label>Mobile Phone</label>
                <div class="fields">
                  <div class="eight wide field">
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="Phone" placeholder="(XXX)XXXX-XXXX"></asp:TextBox>
                  </div>
                  <div class="eight wide field">
                    <div class="ui toggle checkbox">
                        <asp:CheckBox ID="checkToText" runat="server" />
                        <label>Receive text notification</label>
                      </div>
                  </div>
                </div>
              </div>

              <div class="two fields">
                
                <div class="field">
                    <label>Email</label>
                    <asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>
                  </div>
                  <div class="field">
                    <label>Confirm Email</label>                
                    <asp:TextBox ID="confEmail" runat="server" TextMode="Email"></asp:TextBox>
                  </div>
              </div>

              <div class="two fields">
                
                <div class="field">
                    <label>Password</label>
                    <asp:TextBox ID="password1" runat="server" TextMode="Password"></asp:TextBox>
                  </div>
                  <div class="field">     
                     <label>Confirm Password</label>         
                    <asp:TextBox ID="password2" runat="server" TextMode="Password"></asp:TextBox>
                  </div>
              </div>
              
              <asp:Button ID="SignUpBtn" runat="server" Text="Send Request" CssClass="ui fluid large red submit button" OnClick="SignUpBtn_Click" />
            </form>
    </div>
  </div>
    <script src="assets/semantic.min.js"></script>
</body>
</html>
