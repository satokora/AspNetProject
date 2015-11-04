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
                      <asp:ListItem Value="Alabama"></asp:ListItem>
                      <asp:ListItem Value="Alaska"></asp:ListItem>
                      <asp:ListItem Value="Arizona"></asp:ListItem>
                      <asp:ListItem Value="Arkansas"></asp:ListItem>
                      <asp:ListItem Value="California"></asp:ListItem>
                      <asp:ListItem Value="Colorado"></asp:ListItem>
                      <asp:ListItem Value="Connecticut"></asp:ListItem>
                      <asp:ListItem Value="Delaware"></asp:ListItem>
                      <asp:ListItem Value="Florida"></asp:ListItem>
                      <asp:ListItem Value="Georgia"></asp:ListItem>
                      <asp:ListItem Value="Hawaii"></asp:ListItem>
                      <asp:ListItem Value="Idaho"></asp:ListItem>
                      <asp:ListItem Value="Illinois"></asp:ListItem>
                      <asp:ListItem Value="Indiana"></asp:ListItem>
                      <asp:ListItem Value="Iowa"></asp:ListItem>
                      <asp:ListItem Value="Kansas"></asp:ListItem>
                      <asp:ListItem Value="Kentucky"></asp:ListItem>
                      <asp:ListItem Value="Louisiana"></asp:ListItem>
                      <asp:ListItem Value="Maine"></asp:ListItem>
                      <asp:ListItem Value="Maryland"></asp:ListItem>
                      <asp:ListItem Value="Massachuttes"></asp:ListItem>
                      <asp:ListItem Value="Michigan"></asp:ListItem>
                      <asp:ListItem Value="Minnesota"></asp:ListItem>
                      <asp:ListItem Value="Mississippi"></asp:ListItem>
                      <asp:ListItem Value="Missouri"></asp:ListItem>
                      <asp:ListItem Value="Montana"></asp:ListItem>
                      <asp:ListItem Value="Nebraska"></asp:ListItem>
                      <asp:ListItem Value="Nevada"></asp:ListItem>
                      <asp:ListItem Value="New Hampshire"></asp:ListItem>
                      <asp:ListItem Value="New Jersey"></asp:ListItem>
                      <asp:ListItem Value="New Mexico"></asp:ListItem>
                      <asp:ListItem Value="New York"></asp:ListItem>
                      <asp:ListItem Value="North Carolina"></asp:ListItem>
                      <asp:ListItem Value="North Dakota"></asp:ListItem>
                      <asp:ListItem Value="Ohio"></asp:ListItem>
                      <asp:ListItem Value="Oklahoma"></asp:ListItem>
                      <asp:ListItem Value="Oregon"></asp:ListItem>
                      <asp:ListItem Value="Pennsylvania"></asp:ListItem>
                      <asp:ListItem Value="Rhode Island"></asp:ListItem>
                      <asp:ListItem Value="South Carolina"></asp:ListItem>
                      <asp:ListItem Value="South Dakota"></asp:ListItem>
                      <asp:ListItem Value="Tennessee"></asp:ListItem>
                      <asp:ListItem Value="Texas"></asp:ListItem>
                      <asp:ListItem Value="Utah"></asp:ListItem>
                      <asp:ListItem Value="Vermont"></asp:ListItem>
                      <asp:ListItem Value="Virginia"></asp:ListItem>
                      <asp:ListItem Value="Washington"></asp:ListItem>
                      <asp:ListItem Value="West Virginia"></asp:ListItem>
                      <asp:ListItem Value="Wisconsin"></asp:ListItem>
                      <asp:ListItem Value="Wyoming"></asp:ListItem>
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
