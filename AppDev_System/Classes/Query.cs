using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDev_System.Classes;
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
        private DateTime time_ticketed;
        private DateTime date;

        //INSERT

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

        public Boolean insertBooking(Booking bookig)
        {
            bool res = false;

            try
            {
                con.Open();
                string query = "insert into bookings(passenger_name,time_ticketed,amount,route_id,date) value('" + bookig.passenger_name + "','" + bookig.date_time.ToString("yyyy-MM-dd H:mm:ss") + "','" + bookig.amount + "','" + bookig.destination + "','" + bookig.date.ToString("yyyy-MM-dd") + "')";
                MySqlCommand cmd = new MySqlCommand(query, con);

                int i = cmd.ExecuteNonQuery();
                if (i > -1)
                {
                    MessageBox.Show("Successful input in Database");
                }
                res = true;
            }
            catch
            {
                MessageBox.Show("There was an Error");
            }
            con.Close();

            return res;
        }



        //EDIT

        public Boolean editTicket(Booking ticket, int rowId)
        {
            bool res = false;

            try
            {
                con.Open();

                MySqlCommand comToCheck = new MySqlCommand("SELECT passenger_name, route_id, amount, time_ticketed, date FROM bookings WHERE id = '" + rowId + "'", con);

                MySqlDataAdapter sd = new MySqlDataAdapter(comToCheck);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                string passenger_name = "";
                string route_id = "";
                float amount = 0;
                
                foreach (DataRow row in dt.Rows)
                {
                    passenger_name = row["passenger_name"].ToString();
                    route_id = row["route_id"].ToString();
                    amount = (float)row["amount"];
                    time_ticketed = Convert.ToDateTime(row["time_ticketed"]);       //get dateTime from database in dataGridView row
                    date = Convert.ToDateTime(row["date"]);
                }

                if (dt.Rows.Count > 0)
                {
                    string updt = "UPDATE bookings SET passenger_name = '" + ticket.passenger_name +
                             "', route_id =  '" + ticket.destination + "', amount = '" + ticket.amount +
                             "', time_ticketed = '" + DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "', date = '" + DateTime.Now.ToString("yyyy-MM-dd") +
                             "' WHERE id = '" + rowId + "'";

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
            con.Close();

            return res;
        }
        
       




        //GET TOTAL NUMBER

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

        public string get_total_numOfTickets_forToday()
        {
            string numOfTicketsToday;

            MySqlCommand cmd_routes = new MySqlCommand("select * from bookings where date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'", con);

            MySqlDataAdapter adapter_tickts = new MySqlDataAdapter();
            DataTable dt_tcks = new DataTable();

            adapter_tickts.SelectCommand = cmd_routes;
            //dt_tcks.Clear();
            adapter_tickts.Fill(dt_tcks);

            numOfTicketsToday = dt_tcks.Rows.Count.ToString();
            return numOfTicketsToday;
        }

        public string get_total_numOfTickets_forToday(string date)
        {
            string numOfTicketsToday;

            MySqlCommand cmd_routes = new MySqlCommand("select * from bookings where date = '" + date + "'", con);

            MySqlDataAdapter adapter_tickts = new MySqlDataAdapter();
            DataTable dt_tcks = new DataTable();

            adapter_tickts.SelectCommand = cmd_routes;
            //dt_tcks.Clear();
            adapter_tickts.Fill(dt_tcks);

            numOfTicketsToday = dt_tcks.Rows.Count.ToString();
            return numOfTicketsToday;
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

        public string get_total_numOfEarnings_forToday()
        {
            float sum = 0;
            string numOfEarnings_today;

            MySqlCommand cmd_routes = new MySqlCommand("select * from bookings where date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'", con);

            MySqlDataAdapter adapter_tickts = new MySqlDataAdapter();
            DataTable dt_tcks = new DataTable();

            adapter_tickts.SelectCommand = cmd_routes;
            //dt_tcks.Clear();
            adapter_tickts.Fill(dt_tcks);

            foreach (DataRow row in dt_tcks.Rows)
            {
                sum += float.Parse(row["amount"].ToString());
            }

            numOfEarnings_today = sum.ToString();

            return numOfEarnings_today;
        }

        public string get_total_multicabsToday()
        {
            string numOfUsers;

            MySqlCommand cmd_routes = new MySqlCommand("select * from multicabs_table where date_day = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'", con);

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
