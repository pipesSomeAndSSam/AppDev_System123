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
using AppDev_System.UserControls;
using Guna.UI.WinForms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Crmf;

namespace AppDev_System 
{
    public partial class Dashboard : Form
    {
        public string forms1Email;
        Query q = new Query();

        MySqlConnection con = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem");


        //Controls.Dashboard uc_dashboard = new Controls.Dashboard();

        public Dashboard()
        {
            InitializeComponent();
            gunaLabel8.Text = "₱ ";
            userControl1_Dash1.BringToFront();
            setUpDashBoard_Text();
        }

        private void setUpDashBoard_Text()
        {
            totalBookingsNum.Text = q.get_total_numOfTickets_forToday();
            gunaLabel5.Text = q.get_total_numOfRoutes();
            gunaLabel7.Text = q.get_total_numOfUsers();
            gunaLabel8.Text = "₱ ";
            gunaLabel8.Text += q.get_total_numOfEarnings_forToday();

            totalBookingsNum.BringToFront();
            gunaLabel4.BringToFront();
            gunaLabel5.BringToFront();
            gunaLabel6.BringToFront();
            gunaLabel7.BringToFront();
            gunaLabel8.BringToFront();
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
            //GET TOTAL NUMBER OF CHU2

            

            //GET USERNAME AND EMAIL IN USERS DATABASEL

            try
            {

                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();

                string sql_users = "SELECT * FROM managementsystem.users WHERE email='"+ forms1Email + "';";

                
                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);

                
                MySqlDataReader reader_users = cmd_users.ExecuteReader();


                string emailEx = "";
                string usernameEx = "";
                //string no_of_routes = "";

                while (reader_users.Read())
                {
                     emailEx = (string)reader_users["email"];
                     usernameEx = (string)reader_users["user_name"];

                }
                userName.Text = usernameEx;
                gunaLabel2.Text = emailEx;
                conConn.Close();

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void LOGOUTButt_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            Visible = false;
        }

        private void MulticabsButton_Click(object sender, EventArgs e)                  //MUTICAB BUTTON
        {
           
        }

        private void RoutesButton_Click(object sender, EventArgs e)                  //ROUTES BUTTON
        {
            userControl_Routes.BringToFront();
          //  userControl1_Dash1.Hide();
        }

        private void DashboardButton_Click(object sender, EventArgs e)                  //DASHBOARD BUTTON
        {
            userControl1_Dash1.BringToFront();

            setUpDashBoard_Text();

            // userControl_Routes1.Hide();
        }

        private void BookingsButton_Click(object sender, EventArgs e)                  //TICKETING BUTTON
        {
            userControl_Booking1.BringToFront();
        }
    }
}
