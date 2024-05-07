using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDev_System.Classes;
using AppDev_System.UserControls;
using Guna.UI.WinForms;
using MySql.Data.MySqlClient;

namespace AppDev_System.Forms
{
    public partial class AddMulticab : Form
    {
        private int dataBaseId;
        private int seatsAvailable_forClass;
        private float earnings;
        private DateTime date_day;
        private bool isIn;
        public string driver_plate_existing { get; set; }
        public string driver_name_existing { get; set; }
        public int driver_seats_existing { get; set; }
        public string timestamp {  get; set; }

        private int where = 0;
        MySqlConnection con = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem");
        public AddMulticab()
        {
            InitializeComponent();

            SetDateArrival_existing.Text = DateTime.Now.ToString("yyyy-MM-dd H:m:s");
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void searchMulticab_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchMulticab_ID.SelectedIndex > -1)
            {
                this.driver_plate_existing = searchMulticab_ID.GetItemText(searchMulticab_ID.SelectedItem);
                //MessageBox.Show(this.driver_plate_existing + " " + this.driver_name_existing + " " + this.dataBaseId);
                try
                {
                    string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                    MySqlConnection conConn = new MySqlConnection(conne);
                    conConn.Open();
                    string sql_users = "SELECT * FROM managementsystem.multicabs_table WHERE multicab_plate ='" + this.driver_plate_existing + "';";
                    MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);
                    MySqlDataReader reader_users = cmd_users.ExecuteReader();
                    while (reader_users.Read())
                    {
                        this.driver_name_existing = (string)reader_users["name_of_driver"];
                        this.dataBaseId = reader_users.GetInt32(reader_users.GetOrdinal("multicab_id"));

                        //MessageBox.Show(this.driver_plate_existing + " " + this.driver_name_existing + " " + this.dataBaseId);
                    }
                    Driver_name_comboBox.Text = this.driver_name_existing;

                    conConn.Close();
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }
        private void getDataToComboBox_Multicab()
        {
            searchMulticab_ID.DropDownStyle = ComboBoxStyle.DropDownList;
            try
            {
                /*
                MySqlDataAdapter adapter;
                DataTable dt;
                con.Open();
                adapter = new MySqlDataAdapter("SELECT * FROM multicabs_table", con);
                dt = new DataTable();
                adapter.Fill(dt);
                searchMulticab_ID.ValueMember = "multicab_id";
                searchMulticab_ID.DisplayMember = "multicab_plate";
                searchMulticab_ID.DataSource = dt;

                con.Close();*/

                Query q = new Query();

               // searchMulticab_ID.ValueMember = "multicab_id";
                //searchMulticab_ID.DisplayMember = "multicab_plate";

                List<Multicab> multicabList =  q.getMulticab_COMBOBOX();

                foreach (Multicab cabs in multicabList)
                {
                    
                    searchMulticab_ID.Items.Add(cabs);
                    searchMulticab_ID.ValueMember = "dataBaseId";
                    searchMulticab_ID.DisplayMember = "plateNumber_id";
                }

            }
            catch
            {
                MessageBox.Show("eguls");
            }
            searchMulticab_ID.Text = "";
        }

        private void AddMulticab_Load(object sender, EventArgs e)
        {
            getDataToComboBox_Multicab();
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e) //ADD TO QUEUE EXISTING
        {
            //Multicab multicabAddToQueue = new Multicab(this.driver_plate_existing, this.driver_name_existing, DateTime.Now, this.driver_seats_existing, this.earnings);
            //multicabAddToQueue.dataBaseId_(this.dataBaseId);
            // MessageBox.Show(multicabAddToQueue.ToString());
            try
            {
                if (searchMulticab_ID.SelectedIndex > -1)
                {
                    Query q = new Query();
                    q.editMulticab_isIn(this.driver_plate_existing);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

    }
}

