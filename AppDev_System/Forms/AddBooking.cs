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
using MySql.Data.MySqlClient;
using Guna.UI.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using AppDev_System.Classes;
using System.Globalization;

namespace AppDev_System.Forms
{
    public partial class AddBooking : Form
    {
        private string traveler_name;
        private string barangay_name;
        private float fare_in_pesos_regular_fare_new;
        private float fare_in_pesos_special_fare_new;

        MySqlConnection con = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem");
        public AddBooking()
        {
            InitializeComponent();
            gunaPanel12.BringToFront();
        }

        private void getDataToComboBox_Route()
        {
            /*
            string comnd_query = "SELECT barangay_name, distance FROM routes";
            MySqlCommand cmd = new MySqlCommand(comnd_query, con);
            MySqlDataReader mySqlDataReader;
            try
            {
                con.Open();

                mySqlDataReader = cmd.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    string brgy = mySqlDataReader.GetString("barangay_name");
                    string dstnc = mySqlDataReader.GetString("distance");
                    routeComboBox.Items.Add(brgy);
                    routeComboBox.Items.Add(dstnc);
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            

            routeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt;
                con.Open();
                adapter = new MySqlDataAdapter("SELECT * FROM routes", con);
                dt = new DataTable();
                adapter.Fill(dt);
                routeComboBox.ValueMember  = "id";
                routeComboBox.DisplayMember = "barangay_name";
                routeComboBox.DataSource = dt;


                con.Close();
            }
            catch
            {
                MessageBox.Show("eguls");
            }
            routeComboBox.Text = "";
        }

        private void AddBooking_Load(object sender, EventArgs e)
        {
            getDataToComboBox_Route();
            setDateLabel.Text = gunaLabel11.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");


            /*
            try
            {
                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();
                string sql_users = "SELECT * FROM managementsystem.routes WHERE barangay_name ='" + this.barangay_name + "';";
                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);
                MySqlDataReader reader_users = cmd_users.ExecuteReader();
                while (reader_users.Read())
                {
                    this.fare_in_pesos_regular_fare_new = (string)reader_users["regular_fare_new"];
                    this.fare_in_pesos_special_fare_new = (string)reader_users["special_fare_new"];

                }
                this.gunaLabel8.Text  = fare_in_pesos_regular_fare_new;
                //MessageBox.Show(routeComboBox.GetItemText(routeComboBox.SelectedItem));

                conConn.Close();

            }
            catch
            {
                MessageBox.Show("Error");
            }*/
        }

        private void gunaTextBox1_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "Input Name")
            {
                gunaTextBox1.Text = "";
                gunaTextBox1.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox1_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "")
            {
                gunaTextBox1.Text = "Input Name";
                gunaTextBox1.ForeColor = Color.Silver;
            }
        }

        private void routeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.barangay_name =  routeComboBox.GetItemText(routeComboBox.SelectedItem);
            DESTINATION_LABEL.Text = this.barangay_name;

            try
            {
                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();
                string sql_users = "SELECT * FROM managementsystem.routes WHERE barangay_name ='" + this.barangay_name + "';";
                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);
                MySqlDataReader reader_users = cmd_users.ExecuteReader();
                while (reader_users.Read())
                {
                    this.fare_in_pesos_regular_fare_new = reader_users.GetFloat(reader_users.GetOrdinal("regular_fare_new"));
                    this.fare_in_pesos_special_fare_new = reader_users.GetFloat(reader_users.GetOrdinal("special_fare_new"));
                }
                if (gunaCheckBox1.Checked)
                {
                    FARE_LABEL.Text = gunaLabel8.Text = Convert.ToString(this.fare_in_pesos_special_fare_new);
                }
                else
                {
                    FARE_LABEL.Text = gunaLabel8.Text = Convert.ToString(this.fare_in_pesos_regular_fare_new);
                }

                conConn.Close();

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "" || gunaTextBox1.Text == "Input Name" || string.IsNullOrWhiteSpace(gunaTextBox1.Text))
            {

                NAME_LABEL.Text = gunaTextBox1.Text = "NULL";

                gunaPanel7.BringToFront();
                gunaPanel8.Visible = true;
                gunaPanel4.Visible = false;
                gunaLabel1.ForeColor = Color.Black;
                gunaLabel1.Font = new Font("Segoe UI", 15, FontStyle.Regular);
                gunaLabel2.ForeColor = Color.FromArgb(0, 102, 204);
                gunaLabel2.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                /*
                if (gunaTextBox1.Text != "" && gunaTextBox1.Text != "Input Name")
                {
                    this.traveler_name = gunaTextBox1.Text;
                    NAME_LABEL.Text = this.traveler_name;
                }*/
            }
            else
            {
                gunaPanel7.BringToFront();

                gunaPanel8.Visible = true;
                gunaPanel4.Visible = false;
                gunaLabel1.ForeColor = Color.Black;
                gunaLabel1.Font = new Font("Segoe UI", 15, FontStyle.Regular);
                gunaLabel2.ForeColor = Color.FromArgb(0, 102, 204);
                gunaLabel2.Font = new Font("Segoe UI", 14, FontStyle.Bold);

                NAME_LABEL.Text = gunaTextBox1.Text;
                /*
                if (gunaTextBox1.Text != "" && gunaTextBox1.Text != "Input Name")
                {
                    this.traveler_name = gunaTextBox1.Text;
                    NAME_LABEL.Text = this.traveler_name;
                }*/
            }
        }
           // this.FARE_LABEL.Text = fare_in_pesos_regular_fare_new;

            
        

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaCheckBox1.Checked)
            {
                FARE_LABEL.Text = gunaLabel8.Text = Convert.ToString(this.fare_in_pesos_special_fare_new);
            }
            else
            {
                FARE_LABEL.Text = gunaLabel8.Text = Convert.ToString(this.fare_in_pesos_regular_fare_new);
            }
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "NULL")
            {
                gunaTextBox1.Text = "Input Name";
                gunaTextBox1.ForeColor = Color.Silver;
            }
            this.ActiveControl = null;

            gunaPanel12.BringToFront();

            gunaPanel8.Visible = false;
            gunaPanel4.Visible = true;
            gunaLabel1.ForeColor = Color.FromArgb(0, 102, 204);
            gunaLabel1.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            gunaLabel2.ForeColor = Color.Black;
            gunaLabel2.Font =  new Font("Segoe UI", 15, FontStyle.Regular);
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {/*
            Booking booking = new Booking(gunaTextBox1.Text, route_distance, route_regular_fare, route_special_fare);
            routes.createRoute();*/

            float fare = float.Parse(FARE_LABEL.Text, CultureInfo.InvariantCulture.NumberFormat);
            string des;

            if (DESTINATION_LABEL.Text != "DESTINATION_LABEL")
                des = DESTINATION_LABEL.Text;
            else
                des = "NULL";

            Booking booking = new Booking(NAME_LABEL.Text, fare, des);
            booking.createBooking();

            gunaPanel12.BringToFront();

            if (gunaTextBox1.Text == "NULL")
            {
                gunaTextBox1.Text = "Input Name";
                gunaTextBox1.ForeColor = Color.Silver;
            }
            this.ActiveControl = null;

            gunaPanel8.Visible = false;
            gunaPanel4.Visible = true;
            gunaLabel1.ForeColor = Color.FromArgb(0, 102, 204);
            gunaLabel1.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            gunaLabel2.ForeColor = Color.Black;
            gunaLabel2.Font = new Font("Segoe UI", 15, FontStyle.Regular);
        }
    }
}
