using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23.Interface.SMS
{
    public class AirtelSmsProvider : ISMS
    {
        public void SendSms(string receiverMobileNo, string smsBody, string sender)
        {
            // write a code to connect JIO Service and call their method to send SMS 
            // airtelservice.com/sendsms
        }
    }
}
