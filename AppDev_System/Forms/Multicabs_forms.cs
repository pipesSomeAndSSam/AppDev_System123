using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AppDev_System
{
    public partial class Multicabs_forms : Form
    {
        MySqlConnection con = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem");
        public Multicabs_forms()
        {
            InitializeComponent();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            Visible = false;
        }

        private void Multicabs_forms_Load(object sender, EventArgs e)
        {
            //GET USERNAME AND EMAIL IN USERS DATABASEL
            try
            {
                Dashboard dashboard1 = new Dashboard();

                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();

                string sql_users = "SELECT * FROM managementsystem.users WHERE email='" + dashboard1.getForms1Email() + "';";


                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);


                MySqlDataReader reader_users = cmd_users.ExecuteReader();



                while (reader_users.Read())
                {
                    int ctr_users = 0;
                    string emailEx = (string)reader_users["email"];
                    string usernameEx = (string)reader_users["user_name"];

                    userName1.Text = usernameEx;
                    gunaLabel21.Text = emailEx;
                }
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
            this.Hide();
        }
    }
}
