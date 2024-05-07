using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AppDev_System
{
    public class Routes
    {

        public string barangayName {  get; set; }
        public float distance { get; set; }

        public float regularFareNew { get; set; }
        public float specialFareNew { get; set; }


        public Routes(string barangay, float distance, float regularFareNew, float specialFareNew) 
        {
            this.barangayName = barangay;
            this.distance = distance;
            this.regularFareNew = regularFareNew;
            this.specialFareNew = specialFareNew;
        }

        public Boolean createRoute()
        {
            bool res = false;
            Query q = new Query();
            try 
            {
                res = q.insertRoute( this.barangayName , this.distance, this.regularFareNew, this.specialFareNew);
            }
            catch (Exception ex) 
            {
                return res;
            }
            return res;
        }

        public Boolean editRoute(string barangay, float distance, float regularFareNew, float specialFareNew, int routeID)
        {
            bool res = false;

            float regular_fare_old = 0;
            float special_fare_old = 0;

            try
            {
                using (MySqlConnection con1 = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem"))
                {
                    con1.Open();
                    using (MySqlCommand cmd_routes = new MySqlCommand("SELECT * FROM routes WHERE id = '" + routeID + "'", con1))
                    {
                        MySqlDataReader reader_routes = cmd_routes.ExecuteReader();
                        while (reader_routes.Read())
                        {
                            regular_fare_old = (float)reader_routes["regular_fare_new"];
                            special_fare_old = (float)reader_routes["special_fare_new"];
                        }
                        con1.Close();
                    }
                }
                /*
                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();
                
                string command_get_oldFare = "SELECT * FROM routes WHERE id='" + id + "'";
                MySqlCommand cmd_routes = new MySqlCommand(command_get_oldFare, conConn);

                MySqlDataReader reader_routes = cmd_routes.ExecuteReader();
                while (reader_routes.Read())
                {
                    regular_fare_old = (float)reader_routes["regular_fare_new"];
                }
                conConn.Close();*/
            }
            catch
            {
                MessageBox.Show("error lodi");
            }
            this.barangayName = barangay;
            this.distance = distance;
            this.regularFareNew = regularFareNew;
            this.specialFareNew = specialFareNew;

            Query q = new Query();
            try
            {
                EditRouteForm edrtf = new EditRouteForm();
                q.editRoute_New(this.barangayName, this.distance, this.regularFareNew, this.specialFareNew, regular_fare_old, special_fare_old, routeID);
                //q.editRoute();
            }
            catch (Exception ex)
            {
                return res;
            }
            return res;
        }
    }
}
