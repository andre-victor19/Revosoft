using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Provider
    {
        public int idProvider { get; set; }
        public string companyName { get; set; }
        public string cnpj { get; set; }
        public string openDate { get; set; }
        public string email  { get; set; }
        public int registrationSituation { get; set; }
        public string dateCreate  { get; set; }


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
