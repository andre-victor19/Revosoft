using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PhoneClient
    {
        public int idPhone { get; set; }
        public string type { get; set; }
        public string code { get; set; }
        public string number { get; set; }
        public int idClient { get; set; }

        public PhoneClient() { }

        public PhoneClient(int tempIdPhone, string tempType, string tempCode, string tempNumber, int tempIdClient)
        {
            idPhone = tempIdPhone;
            type = tempType;
            code = tempCode;
            number = tempNumber;
            idClient = tempIdClient;
        }
    }
}
