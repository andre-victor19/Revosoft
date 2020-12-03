using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Client
    {
        public int idClient { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }

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
