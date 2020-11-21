using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ClassUser
    {
        public string user = "";
        public string password = "";

        public bool sendLoginAccess()
        {
            if(user != "" && password != "")
            {
                return true;
            }
            return false;
        }
    }
}
