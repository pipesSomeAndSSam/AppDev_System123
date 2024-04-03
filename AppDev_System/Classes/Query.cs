using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AppDev_System
{
    public class Query
    {
        MySqlConnection con = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem");

        
        public Boolean insertUser(string user_name, string email, string password, string contact_num)
        {
            bool res = false;
            try
            { 
                con.Open();
                MySqlCommand comToCheck = new MySqlCommand("select email from users where email='" + email + "'", con);
                MySqlDataAdapter sd = new MySqlDataAdapter(comToCheck);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Email already exists");
                }
                else
                {
                    string query = "insert into users(user_name,email,password,contact_num) value('" + user_name + "','" + email + "','" + password + "','" + contact_num + "')";
                    MySqlCommand cmd = new MySqlCommand(query, con);


                    int i = cmd.ExecuteNonQuery();
                    if (i > -1)
                    {
                        MessageBox.Show("Successfully registered");
                    }

                    res = true;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("There was an Error");
            }
            return res;
        }

        public Boolean insertRoute(string barangay, int multicab_id, int cost)
        {
            bool res = false;
            try
            {
                con.Open();
                string query = "insert into routes(barangay,multicab_id,cost) value('" + barangay + "','" + multicab_id + "','" + cost + "')";
                MySqlCommand cmd = new MySqlCommand(query, con);

                int i = cmd.ExecuteNonQuery();
                if (i > -1)
                {
                    MessageBox.Show("Successfully registered");
                }
                res = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an Error");
            }
            return res;
        }

        

    }
}
