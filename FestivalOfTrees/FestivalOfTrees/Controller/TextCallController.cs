using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FestivalOfTrees.CEAAPI_v2;


/*
    For Use Case 11: Text or call successful bidders

*/
namespace FestivalOfTrees.Controller
{
    public class TextCallController
    {
        //public void SendText(int phoneNo)
        //{
        //    var p = new CEAAPI_v2 { Url = "http://staging-api.call-em-all.com/Webservices/CEAAPI_v2.asmx" };

        //    var myRequest = new ExtCreateBroadcastRequestType();

        //    myRequest.username = "satokora";
        //    myRequest.pin = "368485";

        //    myRequest.broadcastName = string.Format("SMS-Broadcast {0} {1}",
        //                                            DateTime.Now.ToShortDateString(),
        //                                            DateTime.Now.ToShortTimeString());
        //    // 3=SMS
        //    // 1-Voice
        //    // 2-Voice Survey
        //    // 4-Combo SMS to Opt-ins, Voice to remainder
        //    // 5-Combo SMS to opt-ins, Voice to ALL  
        //    //
        //    myRequest.broadcastType = "3";

        //    // 3-commaDelimitedPhonenumbers
        //    // 1-Saved list (provide ListID)
        //    // 2-CSV (provide phoneNumberCSV) 
        //    myRequest.phoneNumberSource = "3";

        //    myRequest.smsMsg = "text";
        //    myRequest.commaDelimitedPhoneNumbers = phoneNo;

        //    try
        //    {
        //        var myResponse = p.ExtCreateBroadcast(myRequest);
        //        if (myResponse.errorCode != 0)
        //        {
        //            //MessageBox.Show(string.Format("An error was thrown : {0}  Message : {1}",
        //            //                              myResponse.errorCode,
        //            //                              myResponse.errorMessage));
        //        }
        //        else
        //        {
        //            //MessageBox.Show(string.Format("Process Completed : {0}", myResponse.errorCode));
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //MessageBox.Show(string.Format("An exception was thrown : {0}", ex.Message));
        //    }
        //}
    }
}