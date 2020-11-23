using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Client
    {
        public int idClient = 0;
        public string name = "";
        public string surname = "";
        public string cpf = "";
        public string email = "";

        public Client() { }

        public Client(int tempIdClient, string tempName, string tempSurname, string tempCpf, string tempEmail)
        {
            idClient = tempIdClient;
            name = tempName;
            surname = tempSurname;
            cpf = tempCpf;
            email = tempEmail;
        }
    }
}
