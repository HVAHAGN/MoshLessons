using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Clients;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace SMSSender
{
    class Program
    {
        static void Main(string[] args)
        {

            // Find your Account Sid and Auth Token at twilio.com/user/account
            string AccountSid = "{{ account_sid }}";
            string AuthToken = "{{ auth_token }}";

            var twilio = new TwilioRestClient(AccountSid, AuthToken);
            var to = new PhoneNumber("+37493133151");
            var from = new PhoneNumber("+37491133171");
            var message = MessageResource.Create(to, pathAccountSid:null, from, "This text message was sent with code!");

            Console.WriteLine(message.Sid);
        }
    }
    
}
