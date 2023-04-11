using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatchMar23.Interface.SMS
{
    public interface ISMS
    {
        void SendSms(string receiverMobileNo, string smsBody, string sender);
    }
}
