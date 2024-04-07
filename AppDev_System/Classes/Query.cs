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
            catch
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
            catch
            {
                MessageBox.Show("There was an Error");
            }
            con.Close();

            return res;
        }
        public Boolean editRoute_New(string barangay_name, float distance, float regular_fare_new, float special_fare_new, float regular_fare_old, float special_fare_old, int routeID)
        {
            var dateString2 = DateTime.Now.ToString("yyyy-MM-dd");
            bool res = false;
            try
            {
                /*using (MySqlConnection con1 = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem"))
                {
                    using (MySqlCommand cmd_edit_route = new MySqlCommand("UPDATE routes SET barangay_name = '" + barangay_name +
                              "', distance =  '" + distance + "', regular_fare_new = '" + regular_fare_new +
                              "', special_fare_new = '" + special_fare_new + "', regular_fare_old = '" + regular_fare_old +
                              "', special_fare_old = '" + special_fare_old +
                              "', date_fare_changed = '" + dateString2 + "' WHERE barangay_name = '" + routes.barangayName +
                              "'AND distance =  '" + routes.distance + "'AND regular_fare_new = '" + routes.regularFareNew +
                              "'AND special_fare_new = '" + routes.specialFareNew + "'", con1))
                    {
                        con1.Open();
                        cmd_edit_route.ExecuteNonQuery();
                        MessageBox.Show("Update Successful");
                        con1.Close();
                    }
                }*/
                con.Open();
               // MessageBox.Show(routes.barangayName + "," + routes.distance + "," + routes.regularFareNew + "," + routes.specialFareNew + "asd");
                MySqlCommand comToCheck = new MySqlCommand("SELECT barangay_name, distance, regular_fare_new, special_fare_new FROM routes WHERE id = '" + routeID + "'", con);
                
                MySqlDataAdapter sd = new MySqlDataAdapter(comToCheck);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                string I4D = "";
                string Name = "";
                string FamilyName = "";
                string FamilyNamexx = "";
                foreach (DataRow row in dt.Rows)
                {
                     I4D = row["barangay_name"].ToString();
                     Name = row["distance"].ToString();
                     FamilyName = row["regular_fare_new"].ToString();
                     FamilyNamexx = row["special_fare_new"].ToString();
                }

                if (dt.Rows.Count > 0)
                {
                    string updt = "UPDATE routes SET barangay_name = '" + barangay_name +
                             "', distance =  '" + distance + "', regular_fare_new = '" + regular_fare_new +
                             "', special_fare_new = '" + special_fare_new + "', regular_fare_old = '" + regular_fare_old +
                             "', special_fare_old = '" + special_fare_old +
                             "', date_fare_changed = '" + dateString2 + "' WHERE id = '" + routeID + "'";

                    MySqlCommand command_update = new MySqlCommand(updt, con);

                    command_update.ExecuteNonQuery();
                    MessageBox.Show("Update Successful");

                    res = true;
                }
                else
                {
                    MessageBox.Show("IT DOES NOT EXIST EXISTS");
                }
            }
            catch
            {
                MessageBox.Show("mali ka duy");
            }
           // MessageBox.Show("eraafffGGGi");
            con.Close();

            return res;
        }
        public Boolean editRoute(string barangay_name, float distance, float regular_fare_new, float special_fare_new, int rowNumber, float regular_fare_old, float special_fare_old)
        {
            bool res = false;

         //   float regular_fare_old = 0;
          //  float special_fare_old = 0;

            try
            {
                con.Open();

                 
                var dateString2 = DateTime.Now.ToString("yyyy-MM-dd");

                string updt = "UPDATE routes SET barangay_name = '" + barangay_name +
                              "', distance =  '" + distance + "', regular_fare_new = '" + regular_fare_new +
                              "', special_fare_new = '" + special_fare_new + "', regular_fare_old = '" + regular_fare_old +
                              "', special_fare_old = '" + special_fare_old +
                              "', date_fare_changed = '" + dateString2 + "' WHERE id = '" + rowNumber + "'";

                MySqlCommand command_update = new MySqlCommand(updt, con);

                command_update.ExecuteNonQuery();
                MessageBox.Show("Update Successful");

            }
            catch
            {
                MessageBox.Show("There was an Error");
            }
            con.Close();

            return res;
        }

        public Boolean deleteRow()
        {
            bool res = false;

            //query shit nasad thiz lez fucking GOOOOOOOOO

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
