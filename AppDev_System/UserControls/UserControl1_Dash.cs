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

namespace AppDev_System.UserControls
{
    public partial class UserControl1_Dash : UserControl
    {
        Query q = new Query();
        MySqlConnection con = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem");

        public UserControl1_Dash()
        {
            InitializeComponent();
            get_lastOnline();
        }
        private void get_lastOnline()
        {
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
                    if (!reader_mult.IsDBNull(7))
                    {
                        DateTime d = reader_mult.GetDateTime(7);
                        string x = "Last Online: ";
                       // x += "\n";
                        x += d.ToString("yyyy-MM-dd, h:mm:ss tt");
                        lastOnline.Text = x;
                    }
                    else
                    {
                        string x = "Last Online: ";
                      //  x += "\n";
                        x += DateTime.Now.ToString("yyyy-MM-dd, h:mm:ss tt");
                        lastOnline.Text = x;
                    }
                }
                conConn.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        

    }
}
