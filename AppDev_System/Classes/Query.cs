using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDev_System.UserControls;
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
            con.Close();

            return res;
        }

        public Boolean insertRoute(string barangay_name, float distance, float regular_fare_new, float special_fare_new)
        {
            bool res = false;
            try
            {
                con.Open();
                MySqlCommand comToCheck = new MySqlCommand("select * from routes where barangay_name ='" + barangay_name + "' and distance=  '" + distance + "' and regular_fare_new = '" + regular_fare_new + "' and special_fare_new = '" + special_fare_new + "'",con);
                MySqlDataAdapter sd = new MySqlDataAdapter(comToCheck);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Route already exists");
                }
                else
                {
                    string query = "insert into routes(barangay_name,distance,regular_fare_new,special_fare_new) value('" + barangay_name + "','" + distance + "','" + regular_fare_new + "','" + special_fare_new + "')";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    int i = cmd.ExecuteNonQuery();
                    if (i > -1)
                    {
                        MessageBox.Show("Successful input in Database");
                    }
                    res = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an Error");
            }
            con.Close();

            return res;
        }

        public string get_total_numOfRoutes()
        {
            string numOfRoutes;

            MySqlCommand cmd_routes = new MySqlCommand("select id,barangay_name,distance,regular_fare_new,special_fare_new,regular_fare_old,special_fare_old from routes ", con);

            MySqlDataAdapter adapter_routes = new MySqlDataAdapter();
            DataTable dt_routs = new DataTable();

            adapter_routes.SelectCommand = cmd_routes;
            dt_routs.Clear();
            adapter_routes.Fill(dt_routs);

            numOfRoutes = dt_routs.Rows.Count.ToString();
            return numOfRoutes;
        }

        public string get_total_numOfUsers()
        {
            string numOfUsers;

            MySqlCommand cmd_routes = new MySqlCommand("select id from users ", con);

            MySqlDataAdapter adapter_users = new MySqlDataAdapter();
            DataTable dt_users = new DataTable();

            adapter_users.SelectCommand = cmd_routes;
            //dt_users.Clear();
            adapter_users.Fill(dt_users);

            numOfUsers = dt_users.Rows.Count.ToString();
            return numOfUsers;
        }

        

    }
}
