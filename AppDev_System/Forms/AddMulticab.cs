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
using AppDev_System.Classes;
using Guna.UI.WinForms;
using MySql.Data.MySqlClient;

namespace AppDev_System.Forms
{
    public partial class AddMulticab : Form
    {
        public string driver_plate_existing { get; set; }
        public string driver_name_existing { get; set; }
        public int driver_seats_existing { get; set; }
        public string timestamp {  get; set; }

        private int where = 0;
        MySqlConnection con = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem");
        public AddMulticab()
        {
            InitializeComponent();

            gunaPanel1.BringToFront();
            gunaPanel12.BringToFront();

            SetDateArrival_existing.Text = setDateLabel.Text = gunaLabel17.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
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

        private void gunaTextBox2_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox2.Text == "Input ID")
            {
                gunaTextBox2.Text = "";
                gunaTextBox2.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox2_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox2.Text == "")
            {
                gunaTextBox2.Text = "Input ID";
                gunaTextBox2.ForeColor = Color.Silver;
            }
        }

        private void gunaTextBox3_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox3.Text == "Input Total Seats")
            {
                gunaTextBox3.Text = "";
                gunaTextBox3.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox3_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox3.Text == "")
            {
                gunaTextBox3.Text = "Input Total Seats";
                gunaTextBox3.ForeColor = Color.Silver;
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e) //NEXT BUTTON IN ADD NEW ACTION
        {
            this.where = 1;
            if((gunaTextBox3.Text == "" || gunaTextBox3.Text == "Input Total Seats") ||
                (gunaTextBox2.Text == "Input ID" || gunaTextBox2.Text == "") ||
                (gunaTextBox1.Text == "" || gunaTextBox1.Text == "Input Name"))
            {
                MessageBox.Show("Input Required");
            }
            else
            {
                NAME_LABEL.Text = gunaTextBox1.Text;
                ID_LABEL.Text = gunaTextBox2.Text;
                SeatsNum.Text = gunaTextBox3.Text;

                gunaPanel5.BringToFront();

                gunaPanel8.Visible = true;
                gunaPanel4.Visible = false;
                gunaLabel1.ForeColor = Color.Black;
                gunaLabel1.Font = new Font("Segoe UI", 15, FontStyle.Regular);
                gunaLabel2.ForeColor = Color.FromArgb(0, 102, 204);
                gunaLabel2.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            }
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e) //BACK BUTTON IN ADD NEW ACTION
        {
            this.where = 0;

            gunaPanel1.BringToFront();
            gunaPanel12.BringToFront();

            gunaPanel8.Visible = false;
            gunaPanel4.Visible = true;
            gunaLabel2.ForeColor = Color.Black;
            gunaLabel2.Font = new Font("Segoe UI", 15, FontStyle.Regular);
            gunaLabel1.ForeColor = Color.FromArgb(0, 102, 204);
            gunaLabel1.Font = new Font("Segoe UI", 14, FontStyle.Bold);
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e) //SUBMIT BUTTON IN ADD NEW ACTION
        {
            try
            {
                Multicab multicab = new Multicab(ID_LABEL.Text, NAME_LABEL.Text, DateTime.Now, Int32.Parse(SeatsNum.Text), 0);
                multicab.createMulticab();

                gunaPanel1.BringToFront();
                gunaPanel12.BringToFront();

                this.ActiveControl = null;

                gunaPanel8.Visible = false;
                gunaPanel4.Visible = true;
                gunaLabel1.ForeColor = Color.FromArgb(0, 102, 204);
                gunaLabel1.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                gunaLabel2.ForeColor = Color.Black;
                gunaLabel2.Font = new Font("Segoe UI", 15, FontStyle.Regular);

                gunaTextBox1.Text = "Input Name";
                gunaTextBox1.ForeColor = Color.Silver;
                gunaTextBox2.Text = "Input ID";
                gunaTextBox2.ForeColor = Color.Silver;
                gunaTextBox3.Text = "Input Total Seats";
                gunaTextBox3.ForeColor = Color.Silver;

                this.where = 0;
            }
            catch 
            {
                MessageBox.Show("Wrong Input");
            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e) //ADD NEW ACTION
        {
            gunaPanel1.BringToFront();
            if (where == 0)
            {
                gunaPanel12.BringToFront();
            }
            else if(where == 1) 
            {
                gunaPanel5.BringToFront();
            }
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e) //ADD EXISTING ACTION
        {
            gunaPanel9.BringToFront();
        }

        private void searchMulticab_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.driver_plate_existing = searchMulticab_ID.GetItemText(searchMulticab_ID.SelectedItem);

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
                    this.driver_seats_existing = reader_users.GetInt32(reader_users.GetOrdinal("seats_available"));
                }
                Driver_name_comboBox.Text = this.driver_name_existing;
                seatsAvailable.Text = this.driver_seats_existing.ToString();

                conConn.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void getDataToComboBox_Multicab()
        {
            searchMulticab_ID.DropDownStyle = ComboBoxStyle.DropDownList;
            try
            {
                MySqlDataAdapter adapter;
                DataTable dt;
                con.Open();
                adapter = new MySqlDataAdapter("SELECT * FROM multicabs_table", con);
                dt = new DataTable();
                adapter.Fill(dt);
                searchMulticab_ID.ValueMember = "multicab_id";
                searchMulticab_ID.DisplayMember = "multicab_plate";
                searchMulticab_ID.DataSource = dt;

                con.Close();
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

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            //this.driver_plate_existing;
        }
    }
}

