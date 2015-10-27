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
                    <input type="text" name="shipping[first-name]" placeholder="First Name">
                  </div>
                  <div class="field">
                    <input type="text" name="shipping[last-name]" placeholder="Last Name">
                  </div>
                </div>
              </div>
              <div class="field">
                <label>Address</label>
                <div class="fields">
                  <div class="eight wide field">
                    <input type="text" name="shipping[address]" placeholder="Address1">
                  </div>
                  <div class="eight wide field">
                    <input type="text" name="shipping[address-2]" placeholder="Address2">
                  </div>
                </div>
              </div>
              <div class="two fields">
                <div class="field">
                  <label>State</label>
                  <select class="ui fluid dropdown">
                    <option value="">State</option>
                <option value="AL">Alabama</option>
                <option value="AK">Alaska</option>
                <option value="AZ">Arizona</option>
                <option value="AR">Arkansas</option>
                <option value="CA">California</option>
                <option value="CO">Colorado</option>
                <option value="CT">Connecticut</option>
                <option value="DE">Delaware</option>
                <option value="DC">District Of Columbia</option>
                <option value="FL">Florida</option>
                <option value="GA">Georgia</option>
                <option value="HI">Hawaii</option>
                <option value="ID">Idaho</option>
                <option value="IL">Illinois</option>
                <option value="IN">Indiana</option>
                <option value="IA">Iowa</option>
                <option value="KS">Kansas</option>
                <option value="KY">Kentucky</option>
                <option value="LA">Louisiana</option>
                <option value="ME">Maine</option>
                <option value="MD">Maryland</option>
                <option value="MA">Massachusetts</option>
                <option value="MI">Michigan</option>
                <option value="MN">Minnesota</option>
                <option value="MS">Mississippi</option>
                <option value="MO">Missouri</option>
                <option value="MT">Montana</option>
                <option value="NE">Nebraska</option>
                <option value="NV">Nevada</option>
                <option value="NH">New Hampshire</option>
                <option value="NJ">New Jersey</option>
                <option value="NM">New Mexico</option>
                <option value="NY">New York</option>
                <option value="NC">North Carolina</option>
                <option value="ND">North Dakota</option>
                <option value="OH">Ohio</option>
                <option value="OK">Oklahoma</option>
                <option value="OR">Oregon</option>
                <option value="PA">Pennsylvania</option>
                <option value="RI">Rhode Island</option>
                <option value="SC">South Carolina</option>
                <option value="SD">South Dakota</option>
                <option value="TN">Tennessee</option>
                <option value="TX">Texas</option>
                <option value="UT">Utah</option>
                <option value="VT">Vermont</option>
                <option value="VA">Virginia</option>
                <option value="WA">Washington</option>
                <option value="WV">West Virginia</option>
                <option value="WI">Wisconsin</option>
                <option value="WY">Wyoming</option>
                  </select>
                </div>
                <div class="field">
                  <label>Zip Code / Postal Code</label>
                  <input type="text" name="postal" placeholder="XXXXX-XXXX">
                </div>
              </div>
              <%--<div class="two fields">--%>

              <div class="field">
                <label>Home Phone</label>
                <div class="fields">
                  <div class="eight wide field">
                    <input type="text" name="shipping[address]" placeholder="(XXX)XXXX-XXXX">
                  </div>
                </div>
              </div>
                
               <div class="field">
                <label>Mobile Phone</label>
                <div class="fields">
                  <div class="eight wide field">
                    <input type="text" name="shipping[address]" placeholder="(XXX)XXXX-XXXX">
                  </div>
                  <div class="eight wide field">
                    <div class="ui toggle checkbox">
                        <input type="checkbox" name="gift">
                        <label>Receive text notification</label>
                      </div>
                  </div>
                </div>
              </div>

              <div class="two fields">
                
                <div class="field">
                    <label>Email</label>
                    <input type="email" name="email">
                  </div>
                  <div class="field">
                    <label>Confirm Email</label>                
                    <input type="email" name="confEmail">
                  </div>
              </div>

              <div class="two fields">
                
                <div class="field">
                    <label>Password</label>
                    <input type="password" name="pass1">
                  </div>
                  <div class="field">
                    <label>Confirm Password</label>                
                    <input type="password" name="pass2">
                  </div>
              </div>

               <%--<div class="ui segment">
                <div class="field">
                  <div class="ui toggle checkbox">
                    <input type="checkbox" name="gift" tabindex="0" class="hidden">
                    <label>Approve Terms & Conditions</label>
                  </div>
                </div>
              </div>--%>
              <asp:Button ID="SignUpBtn" runat="server" Text="Button" CssClass="ui fluid large red submit button" OnClick="SignUpBtn_Click" />
            </form>
    </div>
  </div>
    <script src="assets/semantic.min.js"></script>
</body>
</html>
