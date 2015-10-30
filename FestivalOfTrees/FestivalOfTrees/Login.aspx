<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FestivalOfTrees.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login - Festival Of Trees</title>
    <link href="assets/semantic.min.css" rel="stylesheet" />
    <link href="assets/custom_style.css" rel="stylesheet" />
    <script src="assets/jquery-1.11.3.min.js"></script>
<style type="text/css">
    
    body > .grid {
      height: 100%;
    }
    .image {
      margin-top: -100px;
    }
    .column {
      max-width: 450px;
    }
  </style>
  <script>
  $(document)
    .ready(function() {
      $('.ui.form')
        .form({
          fields: {
            email: {
                identifier: 'userEmailTxt',
              rules: [
                {
                  type   : 'empty',
                  prompt : 'Please enter your e-mail'
                },
                {
                    type: 'email',
                  prompt : 'Please enter a valid e-mail'
                }
              ]
            },
            password: {
              identifier  : 'password',
              rules: [
                {
                  type   : 'empty',
                  prompt : 'Please enter your password'
                },
                {
                  type   : 'length[6]',
                  prompt : 'Your password must be at least 6 characters'
                }
              ]
            }
          }
        })
        ;
      $("#sign-up a").click(function () {
          $('.ui.modal')
          .modal('show')
          ;
      });

    })
  ;
  </script>
</head>
<body>

<div class="ui middle aligned center aligned grid">
  <div class="column">
    <h2 class="ui teal image header">
        <img src="assets/image/Logo_FestTree.png" class="login-image" />
    </h2>
    <form class="ui large form" id="form1" runat="server">
      <div class="ui stacked segment">
        <div class="field">
          <div class="ui left icon input">
            <i class="user icon"></i>
              <asp:TextBox ID="userEmailTxt" runat="server" placeholder="E-mail address" TextMode="Email"></asp:TextBox>
          </div>
        </div>
        <div class="field">
          <div class="ui left icon input">
            <i class="lock icon"></i>
            <asp:TextBox ID="password" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
          </div>
        </div>
        <asp:Button ID="LoginBtn" runat="server" Text="Log in" CssClass="ui fluid large red submit button" OnClick="LoginBtn_Click" />
      </div>

      <div class="ui error message"></div>

    </form>

    <div class="ui message" id="sign-up">
      New to us? <a href="#">Sign Up</a>
    </div>
  </div>
</div>


    <div class="ui modal">
      <div class="header">Sign up as a....</div>
      <div class="content">
        <div class="ui center aligned grid">
        <div class="row">
        <%--<div class="ui buttons">--%>
            <a href="SignUp.aspx?role=p"  class="fluid ui orange button" style="margin-bottom: 5px">Public</a>
          <%--<button class="ui green button">Public</button>--%>
          <%--<div class="or"></div>--%>
            <a href="SignUp.aspx?role=d"  class="fluid ui primary button" style="margin-bottom: 5px">Donator/Designer</a>
          <%--<button class="ui primary button">Donator/Designer</button>--%>
           <%--<div class="or"></div>--%>
            <a href="SignUp.aspx?role=s"  class="fluid ui green button" style="margin-bottom: 5px">Steering Comittee</a>
          <%--<button class="ui secondary button">Steering Comittee</button>--%>
             <%--<div class="or"></div>--%>
            <a href="SignUp.aspx?role=a"  class="fluid ui secondary button" style="margin-bottom: 5px">Admin</a>
        <%--</div>--%>
        </div>
        </div>
      </div>
    </div>
    <script src="assets/semantic.min.js"></script>

</body>
</html>
