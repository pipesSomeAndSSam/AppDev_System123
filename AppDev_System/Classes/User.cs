using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AppDev_System
{
    public class User 
    {
        public string user_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string contact_num { get; set; }

        public User(string user_name, string email, string password, string contact_num)
        {
            this.user_name = user_name;
            this.email = email;
            this.password = password;
            this.contact_num = contact_num;
        }

        public Boolean createUser()
        {
            bool res = false;
            Query q = new Query();
            res = q.insertUser(this.user_name, this.email, this.password, this.contact_num);
            return res;
        }

    }
}
