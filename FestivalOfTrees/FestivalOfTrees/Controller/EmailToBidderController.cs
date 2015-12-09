using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FestivalOfTrees.Model;
using FestivalOfTrees.Dao;
using System.Net.Mail;
using System.Net.Mime;
using System.Data;

/*
    For Use Case 7: Email invoices/receipts (to successful bidders) 

*/
namespace FestivalOfTrees.Controller
{
    public class EmailToBidderController
    {
        public void sendInvoiceEmail(string email, DataSet ds)
        {
            UserDao dao = new UserDaoImpl();
            User toUser = dao.getUserByEmail(email);

            string toAddress = toUser.Email; // not ", "
            string[] toArray = toAddress.Split(',');

            string newUserId = toUser.UserID.ToString();
            string newUserfName = toUser.FirstName;
            string newUserlName = toUser.LastName;

            string senderEmail = "skora@ilstu.edu";
            string senderName = "The Baby Fold Festival of Trees";

            MailAddress messageFrom = new MailAddress(senderEmail.ToLower(), senderName);
            //                    MailAddress messageTo = new MailAddress(to.Text);
            MailMessage emailMessage = new MailMessage();
            emailMessage.From = messageFrom;
            for (int i = 0; i < toArray.Length; ++i)
            {
                MailAddress messageTo = new MailAddress(toArray[i]);
                emailMessage.To.Add(messageTo.Address);
            }

            string html = @"<html><body><img src=""cid:LogoId""><div>Hello " + newUserfName + " " + newUserlName + ",<br /> Thank you so much for coming to Festival of Trees.<br />"
            + getHtml(ds)
            + "<br />Thank you for your support,"
            + "<br />  Festivel Of Trees Team</body></html>";
            AlternateView altView = AlternateView.CreateAlternateViewFromString(html, null, MediaTypeNames.Text.Html);

            LinkedResource yourPictureRes = new LinkedResource(HttpContext.Current.Server.MapPath("~\\assets\\image\\Email.jpg"), MediaTypeNames.Image.Jpeg);
            yourPictureRes.ContentId = "LogoId";
            altView.LinkedResources.Add(yourPictureRes);


            emailMessage.AlternateViews.Add(altView);

            string messageSubject = "Festival Of Trees: Your Invoice";
            string messageBody = html;
            emailMessage.Subject = messageSubject;
            emailMessage.Body = messageBody;
            SmtpClient mailClient = new SmtpClient("smtp.ilstu.edu");

            mailClient.UseDefaultCredentials = true;
            mailClient.Send(emailMessage);

        }

        public static string getHtml(DataSet dataSet)
        {
            try
            {
                string messageBody = "<font>The following is your invoice: </font><br><br>";

                if (dataSet.Tables[0].Rows.Count == 0)
                    return messageBody;
                string htmlTableStart = "<table style=\"border-collapse:collapse; text-align:center;\" >";
                string htmlTableEnd = "</table>";
                string htmlHeaderRowStart = "<tr style =\"background-color:#6FA1D2; color:#ffffff;\">";
                string htmlHeaderRowEnd = "</tr>";
                string htmlTrStart = "<tr style =\"color:#555555;\">";
                string htmlTrEnd = "</tr>";
                string htmlTdStart = "<td style=\" border-color:#5c87b2; border-style:solid; border-width:thin; padding: 5px;\">";
                string htmlTdEnd = "</td>";

                messageBody += htmlTableStart;
                messageBody += htmlHeaderRowStart;
                messageBody += htmlTdStart + "Item Number" + htmlTdEnd;
                messageBody += htmlTdStart + "Category" + htmlTdEnd;
                messageBody += htmlTdStart + "Description(Designer in Parentheses)" + htmlTdEnd;
                messageBody += htmlTdStart + "Estimated Value" + htmlTdEnd;
                messageBody += htmlTdStart + "Bid" + htmlTdEnd;
                messageBody += htmlTdStart + "Paid?" + htmlTdEnd;
                messageBody += htmlHeaderRowEnd;

                foreach (DataRow Row in dataSet.Tables[0].Rows)
                {
                    messageBody = messageBody + htmlTrStart;
                    messageBody = messageBody + htmlTdStart + Row["CATITEMID"] + htmlTdEnd;
                    messageBody = messageBody + htmlTdStart + Row["CATEGORYNAME"] + htmlTdEnd;
                    messageBody = messageBody + htmlTdStart + Row["DESC"] + htmlTdEnd;
                    messageBody = messageBody + htmlTdStart + Row["ESTVALUE"] + htmlTdEnd;
                    messageBody = messageBody + htmlTdStart + Row["BIDAMOUNT"] + htmlTdEnd;
                    messageBody = messageBody + htmlTdStart + Row["PAID"] + htmlTdEnd;
                    messageBody = messageBody + htmlTrEnd;
                }
                messageBody = messageBody + htmlTableEnd;


                return messageBody;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}