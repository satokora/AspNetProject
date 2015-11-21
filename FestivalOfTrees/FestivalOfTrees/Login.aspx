<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FestivalOfTrees.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
     
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="ui middle aligned center aligned grid">
        <div class="column" style="margin-top:100px;">
            <h2 class="ui teal image header">
                <img src="assets/image/Logo_FestTree.png" class="login-image" />
            </h2>
            <asp:Panel ID="MessagePanel" runat="server">
                <div class="ui positive message">
                    <i class="close icon"></i>
                    <div class="header">
                        <asp:Label ID="LblMessageTitle" runat="server" Text="Label">Your signup application is successful</asp:Label>
                    </div>
                    <p>
                        <asp:Label ID="LblDetailMessage" runat="server" Text="Label">Until your request is approved by administrator, you are able to sign in as a public user.</asp:Label>
                    </p>
                </div>
            </asp:Panel>
            <%--<form class="ui large form" id="form1" runat="server">--%>
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

            <%--</form>--%>

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
                    <a href="SignUp.aspx?role=p" class="fluid ui orange button" style="margin-bottom: 5px">Public</a>
                    <a href="SignUp.aspx?role=d" class="fluid ui primary button" style="margin-bottom: 5px">Donator/Designer</a>
                    <a href="SignUp.aspx?role=s" class="fluid ui green button" style="margin-bottom: 5px">Steering Comittee</a>
                    <a href="SignUp.aspx?role=a" class="fluid ui secondary button" style="margin-bottom: 5px">Admin</a>
                </div>
            </div>
        </div>
    </div>

   
</asp:Content>
