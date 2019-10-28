using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3SPZ
{
//    • додати процес у вибраний комп’ютер;
//    • видалити процес з вибраного комп’ютера;
//    • змінити процес на вибраному комп’ютері;
//    • змінити параметри вибраного комп’ютера.
    class ComputerManager
    {
        private string admin;
        private string password;

        ComputerManager(string admName,string pass)
        {
            admin = admName;
            password = pass;
        }
        public bool login(string pass)
        {
            return (pass == password) ? true : false;
        }
    }
}
