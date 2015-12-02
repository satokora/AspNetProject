using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FestivalOfTrees.Dao;
using FestivalOfTrees.Model;


/*
    For Use Case 11: Text or call successful bidders

*/
namespace FestivalOfTrees.Controller
{
    public class TextCallController
    {
        public void sendText(string phoneNo, string msg)
        {
            ServiceReference1.SUSMSClient isuService = new ServiceReference1.SUSMSClient();
            
            
            UserDao dao = new UserDaoImpl();
            User u = dao.getUserByPhone(phoneNo);

            if (u!=null)
            {
                if(u.Text)
                {
                    try
                    {
                        string response = isuService.sendSMS(u.Carrier, u.Phone, msg);
                        Console.Write(response);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    
                }
                
            }
        }
    }
}