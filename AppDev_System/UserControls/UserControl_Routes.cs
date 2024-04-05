using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using MySql.Data.MySqlClient;

namespace AppDev_System.UserControls
{
    public partial class UserControl_Routes : UserControl
    {
        MySqlConnection con = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem");

        public UserControl_Routes()
        {
            InitializeComponent();



            con.Open();

            string query = "SELECT * FROM routes";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, con);
            DataTable dt_users = new DataTable();
            dataAdapter.Fill(dt_users);
            gunaDataGridView2.DataSource = dt_users;

            con.Close();

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            AddRouteForm addroutefrm = new AddRouteForm();
            addroutefrm.Show();
        }
    }
}
