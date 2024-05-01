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
        public float earnings_while_loggedIn { get; set; }
        public string date_time_login { get; set; }
        public string date_time_logout { get; set; }

        public User()
        {
            this.user_name = "a";
            this.email = "b";
            this.password = "c";
            this.contact_num = "d";
            this.earnings_while_loggedIn = 0;
            this.date_time_login = "f";
            this.date_time_logout = "g";
        }

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

        public Boolean editIUser(string email)
        {
            bool res = false;

            Query query = new Query();
            query.editUser(this, email);

            return res;
        }

        public override string ToString()
        {
            string x = "user_name = " + this.user_name +
                     "\nemail = " + this.email +
                     "\npassword = " + this.password +
                     "\ncontact_num = " + this.contact_num +
                     "\nearnings_while_loggedIn = " + this.earnings_while_loggedIn +
                     "\ndate_time_login = " + this.date_time_login +
                     "\ndate_time_logout = " + this.date_time_logout;

            return x;
        }

    }
}
