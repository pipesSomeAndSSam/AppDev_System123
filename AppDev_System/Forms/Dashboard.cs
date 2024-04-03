using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Crmf;

namespace AppDev_System
{
    public partial class Dashboard : Form
    {
        public string forms1Email;

        MySqlConnection con = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem");


        //Controls.Dashboard uc_dashboard = new Controls.Dashboard();

        public Dashboard()
        {
            InitializeComponent();
        }

        public void setforms1Email(string x)
        {
            this.forms1Email = x;
        }

        public string getForms1Email()
        {
            return forms1Email;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //GET USERNAME AND EMAIL IN USERS DATABASEL

            try
            {
                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();

                string sql_users = "SELECT * FROM managementsystem.users WHERE email='"+ forms1Email + "';";

                
                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);

                
                MySqlDataReader reader_users = cmd_users.ExecuteReader();



                while (reader_users.Read())
                {
                    int ctr_users = 0;
                    string emailEx = (string)reader_users["email"];
                    string usernameEx = (string)reader_users["user_name"];

                    userName.Text = usernameEx;
                    gunaLabel2.Text = emailEx;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

            //GET NUMBER OF ROUTES
            MySqlCommand cmd_routes = new MySqlCommand("select id,barangay,multicab_id,cost from routes ", con);

            MySqlDataAdapter adapter_routes = new MySqlDataAdapter();
            DataTable dt_routs = new DataTable();
            
            adapter_routes.SelectCommand = cmd_routes;
            dt_routs.Clear();
            adapter_routes.Fill(dt_routs);

            gunaLabel8.Text = dt_routs.Rows.Count.ToString();
        }

        private void LOGOUTButt_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            Visible = false;
        }

        private void MulticabsButton_Click(object sender, EventArgs e)                  //MUTICAB BUTTON
        {
            Multicabs_forms multicabs_Forms = new Multicabs_forms();
            multicabs_Forms.Show();
            Visible=false;

            /*
            multicabPanel.Show();
            dashboardPanel.Hide();
            routesPanel.Hide();
            */
        }

        private void RoutesButton_Click(object sender, EventArgs e)
        {
            routesPanel.Show();
            //multicabPanel.Hide();
            dashboardPanel.Hide();
            
        }

        
        private void DashboardButton_Click(object sender, EventArgs e)              //USELESS EVENT HANDLER
        {
            dashboardPanel.Show();
           // multicabPanel.Hide();
            routesPanel.Hide();
        }
        

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            AddRouteForm addroutefrm = new AddRouteForm();
            addroutefrm.Show();
        }
    }
}
