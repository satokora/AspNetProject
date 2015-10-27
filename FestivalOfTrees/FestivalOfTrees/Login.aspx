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
              identifier  : 'email',
              rules: [
                {
                  type   : 'empty',
                  prompt : 'Please enter your e-mail'
                },
                {
                  type   : 'email',
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
            <input type="text" name="email" placeholder="E-mail address">
          </div>
        </div>
        <div class="field">
          <div class="ui left icon input">
            <i class="lock icon"></i>
            <input type="password" name="password" placeholder="Password">
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
        <div class="ui buttons">
          <button class="ui green button">Steering Comittee</button>
          <div class="or"></div>
          <button class="ui primary button">Donator</button>
           <div class="or"></div>
          <button class="ui secondary button">Bidder</button>
        </div>
      </div>
    </div>
    <script src="assets/semantic.min.js"></script>

</body>
</html>
