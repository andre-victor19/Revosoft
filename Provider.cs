using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Provider
    {
        public int idProvider = 0;
        public string companyName = "";
        public string cnpj = "";
        public string openDate = "";
        public string email = "";
        public int registrationSituation = 1;
        public string dateCreate = "";


        public Provider(){}

        public Provider(int tempIdProvider, string tempCompanyName, string tempCnpj, string tempOpenDate, string tempEmail, int tempSituation)
        {
            idProvider = tempIdProvider;
            companyName = tempCompanyName;
            cnpj = tempCnpj;
            openDate = tempOpenDate;
            email = tempEmail;
            registrationSituation = tempSituation;
        }
    }
}
