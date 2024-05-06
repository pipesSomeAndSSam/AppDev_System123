using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
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
        public Boolean insertMulticab(Multicab multicab)
        {
            bool res = false;
            try
            {
                con.Open();
                MySqlCommand comToCheck = new MySqlCommand("SELECT * FROM multicabs_table WHERE multicab_plate ='" + multicab.plateNumber_id + "'", con);
                MySqlDataAdapter sd = new MySqlDataAdapter(comToCheck);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Multicab already exists");
                }
                else
                {
                    //CultureInfo culture = new CultureInfo("en-US");
                   // DateTime t = Convert.ToDateTime(multicab.arrival_time, culture);

                    //DateTime t = DateTime.Parse(multicab.arrival_time);  

                    //string query1 = "insert into multicabs_table(dateTime_of_arrival) value('" + multicab.arrival_time.ToString("h:mm:ss") + "')";
                    string query = "insert into multicabs_table(multicab_plate,name_of_driver,dateTime_of_arrival,date_day,date_added_to_database,isInQueue) value('" + multicab.plateNumber_id + "','" + multicab.nameOfDriver + "','" + multicab.arrival_time + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + 0 + "')";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    //MessageBox.Show("multicab_plate : " + multicab.plateNumber_id + "\nname_of_driver : " + multicab.nameOfDriver + "\ndateTime_of_arrival : " + t.ToString("yyyy-MM-dd h:mm:ss") + "\nseats : " + multicab.seatsTotal + "\ndate_day : " + DateTime.Now.ToString("yyyy-MM-dd"));
                    int i = cmd.ExecuteNonQuery();
                    if (i > -1)
                    {
                        MessageBox.Show("Successful input in DataBase");
                        res = true;
                    }
                }
            }
            catch
            { 
                MessageBox.Show("There was an Error");
            }
            con.Close();

            return res;
        }

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
                    string query = "insert into users(user_name,email,password,contact_num,loggedIn,earnings_while_loggedIn,totalTickets_while_loggedIn) value('" + user_name + "','" + email + "','" + password + "','" + contact_num + "','" + 0 + "','" + 0 + "','" + 0 + "')";
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
            float erningMonthly = 0;
            try
            {
                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();

                string sql_users = "SELECT * FROM managementsystem.users WHERE loggedIn ='" + 1 + "';";

                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);
                MySqlDataReader reader_mult = cmd_users.ExecuteReader();

                while (reader_mult.Read())
                {
                    erningMonthly = reader_mult.GetFloat(reader_mult.GetOrdinal("earnings_while_loggedIn"));
                }
                conConn.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            int num = 0;
            try
            {
                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();

                string sql_users = "SELECT * FROM managementsystem.users WHERE loggedIn ='" + 1 + "';";

                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);
                MySqlDataReader reader_mult = cmd_users.ExecuteReader();

                while (reader_mult.Read())
                {
                    num = reader_mult.GetInt32(reader_mult.GetOrdinal("totalTickets_while_loggedIn"));
                }
                conConn.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            num++;

            bool res = false;

            try
            {
                con.Open();
                string query = "insert into bookings(passenger_name,time_ticketed,amount,route_id,date,if_seated,monthlyEarnings,yearly_earnings) value('" + bookig.passenger_name + "','" + bookig.date_time.ToString("yyyy-MM-dd H:mm:ss") + "','" + bookig.amount + "','" + bookig.destination + "','" + bookig.date.ToString("yyyy-MM-dd") + "','" + 0 + "','" + DateTime.Now.ToString("MM") + "','" + DateTime.Now.ToString("yyyy") + "')";
                MySqlCommand cmd = new MySqlCommand(query, con);

                int i = cmd.ExecuteNonQuery();
                if (i > -1)
                {
                    //MessageBox.Show("Successful input in Database");
                }
                res = true;
            }
            catch
            {
                MessageBox.Show("There was an Error");
            }
            con.Close();

            try
            {
                con.Open();

                erningMonthly += bookig.amount;
                string updt = "UPDATE users SET earnings_while_loggedIn = '" + erningMonthly + "', totalTickets_while_loggedIn = '" + num + "' WHERE loggedIn = '"+1+ "'";

                MySqlCommand command_update = new MySqlCommand(updt, con);


                command_update.ExecuteNonQuery();
                //MessageBox.Show("Queue Successful");

                res = true;
            }
            catch
            {

                MessageBox.Show("asdas");
            }

            con.Clone();
            return res;
        }














        //EDIT
        public Boolean editEarningsUser(float n)
        {
            bool res = false;

            string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
            MySqlConnection conConn = new MySqlConnection(conne);
            conConn.Open();

            float erningMonthly = 0;
            try
            {
                
                

                string sql_users = "SELECT * FROM managementsystem.users WHERE loggedIn ='" + 1 + "';";

                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);
                MySqlDataReader reader_mult = cmd_users.ExecuteReader();

                while (reader_mult.Read())
                {
                    erningMonthly = reader_mult.GetFloat(reader_mult.GetOrdinal("earnings_while_loggedIn"));
                }
                
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            conConn.Close();

            erningMonthly -= n;

            conConn.Open();
            try
            {
               // con.Open();



                MySqlCommand comToCheck = new MySqlCommand("SELECT * FROM users WHERE loggedIn = '" + 1 + "'", conConn);

                MySqlDataAdapter sd = new MySqlDataAdapter(comToCheck);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string updt = "UPDATE users SET earnings_while_loggedIn = '" + erningMonthly + "'  WHERE loggedIn = '" + 1 + "'";

                    MySqlCommand command_update = new MySqlCommand(updt, conConn);

                    command_update.ExecuteNonQuery();
                    //MessageBox.Show("Queue Successful");

                    res = true;
                }
                else
                {
                    //MessageBox.Show("IT DOES NOT EXIST EXISTS");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conConn.Close();

            int num = 0;
            try
            {
                conConn.Open();

                string sql_users = "SELECT * FROM managementsystem.users WHERE loggedIn ='" + 1 + "';";

                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);
                MySqlDataReader reader_mult = cmd_users.ExecuteReader();

                while (reader_mult.Read())
                {
                    num = reader_mult.GetInt32(reader_mult.GetOrdinal("totalTickets_while_loggedIn"));
                }
                conConn.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            num--;

            if (num < 0)
                num = 0;

            conConn.Open();
            try
            {
                // con.Open();



                MySqlCommand comToCheck = new MySqlCommand("SELECT * FROM users WHERE loggedIn = '" + 1 + "'", conConn);

                MySqlDataAdapter sd = new MySqlDataAdapter(comToCheck);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string updt = "UPDATE users SET totalTickets_while_loggedIn = '" + num + "'  WHERE loggedIn = '" + 1 + "'";

                    MySqlCommand command_update = new MySqlCommand(updt, conConn);

                    command_update.ExecuteNonQuery();
                    //MessageBox.Show("Queue Successful");

                    res = true;
                }
                else
                {
                    //MessageBox.Show("IT DOES NOT EXIST EXISTS");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conConn.Close();

            return res;
        }

        public Boolean editUser_logout(string email)
        {
            bool res = false;

            try
            {
                con.Open();



                MySqlCommand comToCheck = new MySqlCommand("SELECT * FROM users WHERE email = '" + email + "'", con);

                MySqlDataAdapter sd = new MySqlDataAdapter(comToCheck);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string updt = "UPDATE users SET loggedIn = '" + 0 + "', date_time_logout = '" + DateTime.Now.ToString("yyyy-MM-dd H:m:s")+ "', lastOnline_month = '" + DateTime.Now.ToString("MM")+ "'  WHERE email = '" + email +"'";

                    MySqlCommand command_update = new MySqlCommand(updt, con);

                    command_update.ExecuteNonQuery();
                    //MessageBox.Show("Queue Successful");

                    res = true;
                }
                else
                {
                    //MessageBox.Show("IT DOES NOT EXIST EXISTS");
                }
            }
            catch
            {
                MessageBox.Show("mali kay duy");
            }

            return res;
        }

        public Boolean editUser_login(string email)
        {
            bool res = false;

            try
            {
                con.Open();



                MySqlCommand comToCheck = new MySqlCommand("SELECT * FROM users WHERE email = '" + email + "'", con);

                MySqlDataAdapter sd = new MySqlDataAdapter(comToCheck);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string updt = "UPDATE users SET loggedIn = '" + 1 + "', date_time_login = '" +DateTime.Now.ToString("yyyy-MM-dd H:m:s")+ "'  WHERE email = '" + email + "'";

                    MySqlCommand command_update = new MySqlCommand(updt, con);

                    command_update.ExecuteNonQuery();
                    //MessageBox.Show("Queue Successful");

                    res = true;
                }
                else
                {
                    MessageBox.Show("IT DOES NOT EXIST EXISTS");
                }
            }
            catch
            {
                MessageBox.Show("mali kay duy");
            }



            return res;
        }

        public Boolean editUser(User user, string email)
        {
            bool res = false;

            try
            {
                con.Open();



                MySqlCommand comToCheck = new MySqlCommand("SELECT * FROM users WHERE email = '" + email + "'", con);

                MySqlDataAdapter sd = new MySqlDataAdapter(comToCheck);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string updt = "UPDATE users SET user_name = '" + user.user_name + "', email = '" + user.email + "', password = '" + user.password + "', contact_num = '" + user.contact_num + "' WHERE  email = '" + email + "'";

                    MySqlCommand command_update = new MySqlCommand(updt, con);

                    command_update.ExecuteNonQuery();
                    //MessageBox.Show("Queue Successful");

                    res = true;
                }
                else
                {
                    MessageBox.Show("IT DOES NOT EXIST EXISTS");
                }
            }
            catch
            {
                MessageBox.Show("mali kay duy");
            }

            return res;
        }

        public Boolean editMulticab_dequeue(int id)
        {
            bool res = false;

            try
            {
                con.Open();

                MySqlCommand comToCheck = new MySqlCommand("SELECT * FROM multicabs_table WHERE multicab_id = '" + id + "'", con);

                MySqlDataAdapter sd = new MySqlDataAdapter(comToCheck);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                
                if (dt.Rows.Count > 0)
                {
                    string updt = "UPDATE multicabs_table SET isInQueue = '" + 0 + "' WHERE  multicab_id = '" + id + "'";

                    MySqlCommand command_update = new MySqlCommand(updt, con);

                    command_update.ExecuteNonQuery();
                    //MessageBox.Show("Queue Successful");

                    res = true;
                }
                else
                {
                    MessageBox.Show("IT DOES NOT EXIST EXISTS");
                }
            }
            catch
            {
                MessageBox.Show("mali kay duy");
            }

            return res;
        }

        public Boolean editMulticab_isIn(string plate)
        {
            bool res = false;

            try
            {
                con.Open();



                MySqlCommand comToCheck = new MySqlCommand("SELECT * FROM multicabs_table WHERE multicab_plate = '" + plate + "'", con);

                MySqlDataAdapter sd = new MySqlDataAdapter(comToCheck);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                
                if (dt.Rows.Count > 0)
                {
                    string updt = "UPDATE multicabs_table SET isInQueue = '" + 1 + "', date_queued = '" +DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "' WHERE  multicab_plate = '" + plate + "'";

                    MySqlCommand command_update = new MySqlCommand(updt, con);

                    command_update.ExecuteNonQuery();
                    //MessageBox.Show("Queue Successful");

                    res = true;
                }
                else
                {
                    MessageBox.Show("IT DOES NOT EXIST EXISTS");
                }
            }
            catch
            {
                MessageBox.Show("mali kay duy");
            }

            return res;
        }

        public Boolean editMulticab(Multicab multicab)
        {
            bool res = false;

            try
            {
                con.Open();

                

                MySqlCommand comToCheck = new MySqlCommand("SELECT * FROM multicabs_table WHERE multicab_id = '" + multicab.dataBaseId + "'", con);

                MySqlDataAdapter sd = new MySqlDataAdapter(comToCheck);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                /*
                string name_of_driver = "";
                string multicab_plate = "";
                DateTime dateTime_of_arrival;
                DateTime date_day;
                int seats = 0;

                foreach (DataRow row in dt.Rows)
                {
                    name_of_driver = row["name_of_driver"].ToString();
                    multicab_plate = row["multicab_plate"].ToString();
                    seats = (int)row["seats"];
                    dateTime_of_arrival = Convert.ToDateTime(row["dateTime_of_arrival"]);       //get dateTime from database in dataGridView row
                    date_day = Convert.ToDateTime(row["date_day"]);
                }
                */

                //MessageBox.Show("multicab_plate : " + multicab.plateNumber_id + "\nname_of_driver : " + multicab.nameOfDriver + "\ndateTime_of_arrival : " + t.ToString("yyyy-MM-dd h:mm:ss") + "\nseats : " + multicab.seatsTotal + "\ndate_day : " + DateTime.Now.ToString("yyyy-MM-dd"));

                if (dt.Rows.Count > 0)
                {
                    string updt = "UPDATE multicabs_table SET name_of_driver = '" + multicab.nameOfDriver +
                             "', multicab_plate =  '" + multicab.plateNumber_id +
                             "', dateTime_of_arrival = '" + multicab.time_dateTime_.ToString("yyyy-MM-dd h:mm:ss") +
                             "', date_queued = '" + multicab.date_queued.ToString("yyyy-MM-dd H:mm:ss") +
                             "' WHERE multicab_id = '" + multicab.dataBaseId + "'";
                    /*
                    MessageBox.Show("UPDATE multicabs_table SET name_of_driver = '" + multicab.nameOfDriver +
                             "', \nmulticab_plate =  '" + multicab.plateNumber_id +
                             "', \ndateTime_of_arrival = '" + multicab.time_dateTime_.ToString("yyyy-MM-dd h:mm:ss") +
                             "', \ndate_queued = '" + multicab.date_queued.ToString("yyyy-MM-dd H:mm:ss") +
                             "' \nWHERE multicab_id = '" + multicab.dataBaseId + "'");*/

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
                MessageBox.Show("mali kay duy22");
            }

            return res;
        }

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
            con.Close();

            return res;
        }















        //GET TOTAL NUMBER
        public string getMonthlytickets()
        {
            int num = 0;
            try
            {
                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();

                string sql_users = "SELECT * FROM managementsystem.users WHERE loggedIn ='" + 1 + "';";

                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);
                MySqlDataReader reader_mult = cmd_users.ExecuteReader();

                while (reader_mult.Read())
                {
                    num = reader_mult.GetInt32(reader_mult.GetOrdinal("totalTickets_while_loggedIn"));
                }
                conConn.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            if (num < 0)
                num = 0;

            string x = num.ToString();
            return x;
        }

        public string getMonthlyEarnings()
        {
            float sum = 0;
            string numOfEarnings_today;

            MySqlCommand cmd_routes = new MySqlCommand("select * from bookings where monthlyEarnings = '" + DateTime.Now.ToString("MM") + "'", con);

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
        public string get_total_numOfMulticabs()
        {
            string numOfUsers;

            MySqlCommand cmd_routes = new MySqlCommand("select * from multicabs_table ", con);

            MySqlDataAdapter adapter_users = new MySqlDataAdapter();
            DataTable dt_users = new DataTable();

            adapter_users.SelectCommand = cmd_routes;
            //dt_users.Clear();
            adapter_users.Fill(dt_users);

            numOfUsers = dt_users.Rows.Count.ToString();
            return numOfUsers;
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

        public string get_total_multicabsToday(string date)
        {
            string numOfUsers;

            MySqlCommand cmd_routes = new MySqlCommand("select * from multicabs_table where date_day = '" + date + "'", con);

            MySqlDataAdapter adapter_users = new MySqlDataAdapter();
            DataTable dt_users = new DataTable();

            adapter_users.SelectCommand = cmd_routes;
            //dt_users.Clear();
            adapter_users.Fill(dt_users);

            numOfUsers = dt_users.Rows.Count.ToString();
            return numOfUsers;
        }

        public string get_total_multicabsToday()
        {
            string numOfUsers;

            MySqlCommand cmd_routes = new MySqlCommand("select * from multicabs_table where date_day = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND isInQueue = '" +1+ "'", con);

            MySqlDataAdapter adapter_users = new MySqlDataAdapter();
            DataTable dt_users = new DataTable();

            adapter_users.SelectCommand = cmd_routes;
            //dt_users.Clear();
            adapter_users.Fill(dt_users);

            numOfUsers = dt_users.Rows.Count.ToString();
            return numOfUsers;
        }
        public string get_total_multicabsInQueue()
        {
            string numOfUsers;

            MySqlCommand cmd_routes = new MySqlCommand("select * from multicabs_table where isInQueue = '" + 1 + "'", con);

            MySqlDataAdapter adapter_users = new MySqlDataAdapter();
            DataTable dt_users = new DataTable();

            adapter_users.SelectCommand = cmd_routes;
            //dt_users.Clear();
            adapter_users.Fill(dt_users);

            numOfUsers = dt_users.Rows.Count.ToString();
            return numOfUsers;
        }











        //OTHERS
        public Boolean if_multicabExists(string plateNumber_id)
        {
            bool res = false;
            try
            {
                con.Open();
                MySqlCommand comToCheck = new MySqlCommand("SELECT * FROM multicabs_table WHERE multicab_plate ='" + plateNumber_id + "'", con);
                MySqlDataAdapter sd = new MySqlDataAdapter(comToCheck);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    res = true;
                }
                else
                {
                    MessageBox.Show("Multicab does not exist");
                }
                return res;
            }
            catch
            {
                MessageBox.Show("There was an Error");
            }
            con.Close();

            return res;
        }











        //LIST GETTERS
        
        public List<Multicab> showGridDataBasedOnDriverName(string name)
        {
            List<Multicab> multicab_list = new List<Multicab>();

            int multicab_id = 0;
            string name_of_driver = "";
            string dateTime_of_arrival = "";
            string date_day = "";
            string added_to_database = "";
            string multicab_plate = "";

            try
            {
                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();

                string sql_users = "SELECT * FROM managementsystem.multicabs_table WHERE name_of_driver = '" +name+ "';";

                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);
                MySqlDataReader reader_mult = cmd_users.ExecuteReader();

                while (reader_mult.Read())
                {
                    multicab_id = reader_mult.GetInt32(reader_mult.GetOrdinal("multicab_id"));
                    name_of_driver = (string)reader_mult["name_of_driver"];

                    DateTime d = reader_mult.GetDateTime(2);
                    dateTime_of_arrival = d.ToString("yyyy-MM-dd HH:mm:ss tt");

                    DateTime d2 = reader_mult.GetDateTime(3);
                    date_day = d2.ToString("yyyy-MM-dd");

                    multicab_plate = (string)reader_mult["multicab_plate"];

                    DateTime d3 = reader_mult.GetDateTime(5);
                    added_to_database = d3.ToString("yyyy-MM-dd");

                    //ADD TO LIST
                    Multicab multicab = new Multicab(multicab_plate, name_of_driver, dateTime_of_arrival);

                    multicab.dataBaseId_(multicab_id);
                    multicab.setDay_Date(date_day);
                    multicab.added_to_database = added_to_database;

                    multicab_list.Add(multicab);
                }
                conConn.Close();
            }
            catch
            {
                MessageBox.Show("There was an Error REIPOH");
            }
            return multicab_list;
        }


        public List<Multicab> getMulticabList()
        {
            List<Multicab> multicab_list = new List<Multicab>();

            int multicab_id = 0;
            string name_of_driver = "";
            string dateTime_of_arrival = "";
            string date_day = "";
            string added_to_database = "";
            string multicab_plate = "";

            try
            {
                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();

                string sql_users = "SELECT * FROM managementsystem.multicabs_table;";

                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);
                MySqlDataReader reader_mult = cmd_users.ExecuteReader();

                while (reader_mult.Read())
                {
                    multicab_id = reader_mult.GetInt32(reader_mult.GetOrdinal("multicab_id"));
                    name_of_driver = (string)reader_mult["name_of_driver"];

                    DateTime d = reader_mult.GetDateTime(2);
                    dateTime_of_arrival = d.ToString("yyyy-MM-dd HH:mm:ss tt");

                    DateTime d2 = reader_mult.GetDateTime(3);
                    date_day = d2.ToString("yyyy-MM-dd");

                    multicab_plate = (string)reader_mult["multicab_plate"];

                    DateTime d3 = reader_mult.GetDateTime(5);
                    added_to_database = d3.ToString("yyyy-MM-dd");

                    //ADD TO LIST
                    Multicab multicab = new Multicab(multicab_plate, name_of_driver, dateTime_of_arrival);

                    multicab.dataBaseId_(multicab_id);
                    multicab.setDay_Date(date_day);
                    multicab.added_to_database = added_to_database;

                    multicab_list.Add(multicab);
                }
                conConn.Close();
            }
            catch
            {
                MessageBox.Show("There was an Error REIPOH");
            }
            return multicab_list;
        }


        public User get_userDetails(string email)
        {
            User user = null;
            try
            {
                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();

                string sql_users = "SELECT * FROM managementsystem.users WHERE email = '" + email + "';";

                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);
                MySqlDataReader reader_mult = cmd_users.ExecuteReader();

                while (reader_mult.Read())
                {
                    user = new User((string)reader_mult["user_name"], email, (string)reader_mult["password"], (string)reader_mult["contact_num"]);
                    
                    
                    if (!reader_mult.IsDBNull(5)) // Assuming the FLOAT column is at index 0
                    {
                        user.earnings_while_loggedIn = reader_mult.GetFloat(reader_mult.GetOrdinal("earnings_while_loggedIn"));
                    }
                    else
                    {
                        user.earnings_while_loggedIn = 0;
                    }

                    if (!reader_mult.IsDBNull(6)) // Assuming the FLOAT column is at index 0
                    {
                        DateTime d = reader_mult.GetDateTime(6);
                        user.date_time_login = d.ToString("yyyy-MM-dd H:mm:ss tt");
                    }
                    else
                    {
                        user.date_time_login = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss tt");
                    }

                    if (!reader_mult.IsDBNull(7)) // Assuming the FLOAT column is at index 0
                    {
                        DateTime d1 = reader_mult.GetDateTime(7);
                        user.date_time_logout = d1.ToString("yyyy-MM-dd H:mm:ss tt");
                    }
                    else
                    {
                        user.date_time_logout = "N/A";
                    }

                }
                conConn.Close();
            }
            catch
            {
                MessageBox.Show("There was an Error REIPOH");
            }

            return user;
        }
        public List<Multicab> getMulticab_isIn()
        {
            List<Multicab> multicab_list = new List<Multicab>();
            int multicab_id = 0;
            string name_of_driver = "";
            string dateTime_of_arrival = "";
            string date_day = "";
            string multicab_plate = "";

            try
            {
                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();

                string sql_users = "SELECT * FROM managementsystem.multicabs_table WHERE isInQueue = '"+1+ "';";

                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);
                MySqlDataReader reader_mult = cmd_users.ExecuteReader();

                while (reader_mult.Read())
                {
                    multicab_id = reader_mult.GetInt32(reader_mult.GetOrdinal("multicab_id"));
                    name_of_driver = (string)reader_mult["name_of_driver"];

                    DateTime d = reader_mult.GetDateTime(2);
                    dateTime_of_arrival = d.ToString("yyyy-MM-dd H:mm:ss ");

                    DateTime d2 = reader_mult.GetDateTime(3);
                    date_day = d2.ToString("yyyy-MM-dd");

                    DateTime d3 = reader_mult.GetDateTime(7);


                    multicab_plate = (string)reader_mult["multicab_plate"];

                    //ADD TO LIST
                    Multicab multicab = new Multicab(multicab_plate, name_of_driver, dateTime_of_arrival);

                    multicab.isIn = true;
                    multicab.dataBaseId_(multicab_id);
                    multicab.setDay_Date(date_day);
                    multicab.date_queued = d3;
                    multicab.date_queued_string = d3.ToString("yyyy-MM-dd H:mm:ss");

                    multicab_list.Add(multicab);
                }
                
                    /*
                MessageBox.Show("multicab_plate = " + multicab_id +
                                "\nname_of_driver = " + name_of_driver +
                                "\ndateTime_of_arrival = " + dateTime_of_arrival +
                                "\ndate_day = " + date_day +
                                "\nmulticab_plate =" + multicab_plate);
                    */

                conConn.Close();

                multicab_list = multicab_list.OrderBy(item => item.date_queued).ToList();
            }
            catch
            {
                MessageBox.Show("There was an Error REIPOH");
            }

            return multicab_list;
        }

        public List<Multicab> getMulticab_COMBOBOX()
        {
            List<Multicab> multicab_list = new List<Multicab>();
            int multicab_id = 0;
            string name_of_driver = "";
            string dateTime_of_arrival = "";
            string date_day = "";
            string multicab_plate = "";

            try
            {
                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();

                string sql_users = "SELECT * FROM managementsystem.multicabs_table WHERE isInQueue = '" +0+ "';";

                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);
                MySqlDataReader reader_mult = cmd_users.ExecuteReader();

                while (reader_mult.Read())
                {
                    multicab_id = reader_mult.GetInt32(reader_mult.GetOrdinal("multicab_id"));
                    name_of_driver = (string)reader_mult["name_of_driver"];

                    DateTime d = reader_mult.GetDateTime(2);

                    dateTime_of_arrival = d.ToString("yyyy-MM-dd HH:mm:ss tt");



                    DateTime d2 = reader_mult.GetDateTime(3);
                    date_day = d2.ToString("yyyy-MM-dd");

                    multicab_plate = (string)reader_mult["multicab_plate"];

                    //ADD TO LIST
                    Multicab multicab = new Multicab(multicab_plate, name_of_driver, dateTime_of_arrival);

                    multicab.dataBaseId_(multicab_id);
                    multicab.setDay_Date(date_day);

                    if (multicab.isIn == false)
                        multicab_list.Add(multicab);
                }
                conConn.Close();
            }
            catch
            {
                MessageBox.Show("There was an Error REIPOH");
            }

            return multicab_list;
        }

        public List<Multicab> getMulticab_multicabPlate(string plate)
        {
            List<Multicab> multicab_list = new List<Multicab>();
            int multicab_id = 0;
            string name_of_driver = "";
            string dateTime_of_arrival = "";
            string date_day = "";
            string multicab_plate = "";

            try
            {
                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();

                string sql_users = "SELECT * FROM managementsystem.multicabs_table WHERE multicab_plate = '" + plate + "';";

                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);
                MySqlDataReader reader_mult = cmd_users.ExecuteReader();

                while (reader_mult.Read())
                {
                    multicab_id = reader_mult.GetInt32(reader_mult.GetOrdinal("multicab_id"));
                    name_of_driver = (string)reader_mult["name_of_driver"];

                    DateTime d = reader_mult.GetDateTime(2);

                    dateTime_of_arrival = d.ToString("yyyy-MM-dd HH:mm:ss tt");



                    DateTime d2 = reader_mult.GetDateTime(3);
                    date_day = d2.ToString("yyyy-MM-dd");

                    multicab_plate = (string)reader_mult["multicab_plate"];

                    //ADD TO LIST
                    Multicab multicab = new Multicab(multicab_plate, name_of_driver, dateTime_of_arrival);

                    multicab.dataBaseId_(multicab_id);
                    multicab.setDay_Date(date_day);

                    if (multicab.isIn == false)
                        multicab_list.Add(multicab);
                }
                conConn.Close();
            }
            catch
            {
                MessageBox.Show("There was an Error REIPOH");
            }

            return multicab_list;
        }


        public List<Multicab> getMulticab_withDATE(string DATE)
        {
            List<Multicab> multicab_list = new List<Multicab>();

            int multicab_id = 0;
            string name_of_driver = "";
            string dateTime_of_arrival = "";
            string date_day = "";
            string multicab_plate = "";

            try
            {
                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();

                string sql_users = "SELECT * FROM managementsystem.multicabs_table WHERE date_day ='" + DATE + "';";

                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);
                MySqlDataReader reader_mult = cmd_users.ExecuteReader();

                while (reader_mult.Read())
                {
                    multicab_id = reader_mult.GetInt32(reader_mult.GetOrdinal("multicab_id"));
                    name_of_driver = (string)reader_mult["name_of_driver"];

                    DateTime d = reader_mult.GetDateTime(2);
                    dateTime_of_arrival = d.ToString("yyyy-MM-dd HH:mm:ss tt");

                    DateTime d2 = reader_mult.GetDateTime(3);
                    date_day = d2.ToString("yyyy-MM-dd");

                    multicab_plate = (string)reader_mult["multicab_plate"];


                    //ADD TO LIST
                    Multicab multicab = new Multicab(multicab_plate, name_of_driver, dateTime_of_arrival);

                    multicab.dataBaseId_(multicab_id);
                    multicab.setDay_Date(date_day);

                    multicab_list.Add(multicab);
                }

                /*
                MessageBox.Show("multicab_plate = " + multicab_id +
                                "\nname_of_driver = " + name_of_driver +
                                "\ndateTime_of_arrival = " + dateTime_of_arrival +
                                "\ndate_day = " + date_day +
                                "\nmulticab_plate =" + multicab_plate);
                */
                

                conConn.Close();

            }
            catch
            {
                MessageBox.Show("There was an Error REIPOH");
            }

            return multicab_list;
        }

        public List<Multicab> getMulticab_withDATE_ifCabIsIn(string DATE)
        {
            List<Multicab> multicab_list = new List<Multicab>();

            int multicab_id = 0;
            string name_of_driver = "";
            string dateTime_of_arrival = "";
            string date_day = "";
            string multicab_plate = "";

            try
            {
                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();

                string sql_users = "SELECT * FROM managementsystem.multicabs_table WHERE date_day ='" + DATE + "';";

                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);
                MySqlDataReader reader_mult = cmd_users.ExecuteReader();

                while (reader_mult.Read())
                {
                    multicab_id = reader_mult.GetInt32(reader_mult.GetOrdinal("multicab_id"));
                    name_of_driver = (string)reader_mult["name_of_driver"];

                    DateTime d = reader_mult.GetDateTime(2);
                    dateTime_of_arrival = d.ToString("yyyy-MM-dd HH:mm:ss tt");

                    DateTime d2 = reader_mult.GetDateTime(3);
                    date_day = d2.ToString("yyyy-MM-dd");

                    multicab_plate = (string)reader_mult["multicab_plate"];


                    //ADD TO LIST
                    Multicab multicab = new Multicab(multicab_plate, name_of_driver, dateTime_of_arrival);

                    multicab.dataBaseId_(multicab_id);
                    multicab.setDay_Date(date_day);

                    if (multicab.isIn == false)
                        multicab_list.Add(multicab);
                }

                /*
                MessageBox.Show("multicab_plate = " + multicab_id +
                                "\nname_of_driver = " + name_of_driver +
                                "\ndateTime_of_arrival = " + dateTime_of_arrival +
                                "\ndate_day = " + date_day +
                                "\nmulticab_plate =" + multicab_plate);
                */
                

                conConn.Close();

            }
            catch
            {
                MessageBox.Show("There was an Error REIPOH");
            }

            return multicab_list;
        }

        public List<Multicab> getMulticab_withDATE_withDriverName(string DATE, string NAME)
        {
            List<Multicab> multicab_list = new List<Multicab>();

            int multicab_id = 0;
            string name_of_driver = "";
            string dateTime_of_arrival = "";
            string date_day = "";
            string multicab_plate = "";

            try
            {
                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();

                string sql_users = "SELECT * FROM managementsystem.multicabs_table WHERE date_day ='" + DATE + "' AND name_of_driver = '" + NAME + "';";

                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);
                MySqlDataReader reader_mult = cmd_users.ExecuteReader();

                while (reader_mult.Read())
                {
                    multicab_id = reader_mult.GetInt32(reader_mult.GetOrdinal("multicab_id"));
                    name_of_driver = (string)reader_mult["name_of_driver"];

                    DateTime d = reader_mult.GetDateTime(2);
                    dateTime_of_arrival = d.ToString("yyyy-MM-dd HH:mm:ss tt");

                    DateTime d2 = reader_mult.GetDateTime(3);
                    date_day = d2.ToString("yyyy-MM-dd");

                    multicab_plate = (string)reader_mult["multicab_plate"];


                    //ADD TO LIST
                    Multicab multicab = new Multicab(multicab_plate, name_of_driver, dateTime_of_arrival);

                    multicab.dataBaseId_(multicab_id);
                    multicab.setDay_Date(date_day);

                    multicab_list.Add(multicab);
                }

                /*
                MessageBox.Show("multicab_plate = " + multicab_id +
                                "\nname_of_driver = " + name_of_driver +
                                "\ndateTime_of_arrival = " + dateTime_of_arrival +
                                "\ndate_day = " + date_day +
                                "\nmulticab_plate =" + multicab_plate);
                */


                conConn.Close();

            }
            catch
            {
                MessageBox.Show("There was an Error REIPOH");
            }

            return multicab_list;
        }

        public List<Multicab> getMulticab_withDriverName( string NAME)
        {
            List<Multicab> multicab_list = new List<Multicab>();

            int multicab_id = 0;
            string name_of_driver = "";
            string dateTime_of_arrival = "";
            string date_day = "";
            string multicab_plate = "";

            try
            {
                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();

                string sql_users = "SELECT * FROM managementsystem.multicabs_table WHERE name_of_driver = '" + NAME + "';";

                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);
                MySqlDataReader reader_mult = cmd_users.ExecuteReader();

                while (reader_mult.Read())
                {
                    multicab_id = reader_mult.GetInt32(reader_mult.GetOrdinal("multicab_id"));
                    name_of_driver = (string)reader_mult["name_of_driver"];

                    DateTime d = reader_mult.GetDateTime(2);
                    dateTime_of_arrival = d.ToString("yyyy-MM-dd HH:mm:ss tt");

                    DateTime d2 = reader_mult.GetDateTime(3);
                    date_day = d2.ToString("yyyy-MM-dd");

                    multicab_plate = (string)reader_mult["multicab_plate"];


                    //ADD TO LIST
                    Multicab multicab = new Multicab(multicab_plate, name_of_driver, dateTime_of_arrival);

                    multicab.dataBaseId_(multicab_id);
                    multicab.setDay_Date(date_day);

                    multicab_list.Add(multicab);
                }

                /*
                MessageBox.Show("multicab_plate = " + multicab_id +
                                "\nname_of_driver = " + name_of_driver +
                                "\ndateTime_of_arrival = " + dateTime_of_arrival +
                                "\ndate_day = " + date_day +
                                "\nmulticab_plate =" + multicab_plate);
                */


                conConn.Close();

            }
            catch
            {
                MessageBox.Show("There was an Error REIPOH");
            }

            return multicab_list;
        }
    }
}
