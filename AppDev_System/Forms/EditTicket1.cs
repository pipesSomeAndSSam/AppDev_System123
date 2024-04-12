using AppDev_System.Classes;
using Guna.UI.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppDev_System.Forms
{
    public partial class EditTicket1 : Form
    {
        MySqlConnection con = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem");
        public int rowId { get; set; }
        public string name { get; set; }
        public string destination { get; set; }

        private string barangay_name;
        private float fare_in_pesos_regular_fare_new;
        private float fare_in_pesos_special_fare_new;
        public EditTicket1()
        {
            InitializeComponent();
        }

        private void getDataToComboBox_Route()
        {
            routeComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt;
                con.Open();
                adapter = new MySqlDataAdapter("SELECT * FROM routes", con);
                dt = new DataTable();
                adapter.Fill(dt);
                routeComboBox1.ValueMember = "id";
                routeComboBox1.DisplayMember = "barangay_name";
                routeComboBox1.DataSource = dt;


                con.Close();
            }
            catch
            {
                MessageBox.Show("eguls");
            }
            routeComboBox1.Text = "";
        }

        private void EditTicket1_Load(object sender, EventArgs e)
        {
            getDataToComboBox_Route();
            setDateLabel.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
        }

        private void gunaTextBox1_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "Edit Name" || gunaTextBox1.Text == this.name)
            {
                gunaTextBox1.Text = "";
                gunaTextBox1.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox1_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "")
            {
                gunaTextBox1.Text = "Edit Name";
                gunaTextBox1.ForeColor = Color.Silver;
            }
        }

        private void routeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.barangay_name = routeComboBox1.GetItemText(routeComboBox1.SelectedItem);
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
                    gunaLabel82.Text = Convert.ToString(this.fare_in_pesos_special_fare_new);
                }
                else
                {
                    gunaLabel82.Text = Convert.ToString(this.fare_in_pesos_regular_fare_new);
                }
                conConn.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this.barangay_name + ", " + this.fare_in_pesos_regular_fare_new + " " + this.fare_in_pesos_special_fare_new);
            if (gunaCheckBox1.Checked)
            {
                gunaLabel82.Text = Convert.ToString(this.fare_in_pesos_special_fare_new);
            }
            else
            {
                gunaLabel82.Text = Convert.ToString(this.fare_in_pesos_regular_fare_new);
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string x = "";
                if(gunaTextBox1.Text == "" || string.IsNullOrWhiteSpace(gunaTextBox1.Text))
                {
                    x = "NULL";
                }
                else
                {
                    x = gunaTextBox1.Text;
                }

                DateTime date_t = DateTime.Now;
                DateTime date = DateTime.Now;
                float amount = float.Parse(gunaLabel82.Text);
                string destination = routeComboBox1.Text;

                Booking b = new Booking(x, amount, destination, date_t, date);
                b.editTicket(this.rowId);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Incorrect Input");
            }
        }
    }
}
