using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FestivalOfTrees.Model
{
    public class Credentials
    {

        private string email;
        private string password;
        private string question;
        private string answer;
    

        public Credentials() { }

        public Credentials(string email, string password, string question, string answer)
        {
            this.email = email;
            this.password = password;
            this.question = question;
            this.answer = answer;
        }

        public Credentials(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public override string ToString()
        {
            return "Email: " + email
                + "<br/>Password: " + password
                + "<br/>Question: " + question
                + "<br/>Answer: " + answer;
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Question
        {
            get
            {
                return question;
            }

            set
            {
                question = value;
            }
        }

        public string Answer
        {
            get
            {
                return answer;
            }

            set
            {
                answer = value;
            }
        }
    }
}