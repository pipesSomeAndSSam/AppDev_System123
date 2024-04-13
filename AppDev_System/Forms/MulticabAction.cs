using AppDev_System.Classes;
using Guna.UI.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AppDev_System.Forms
{
    public partial class MulticabAction : Form
    {
        MySqlConnection con = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem");
        public int rowNum {  get; set; }
        public float multicab_earnings {get; set;}
        private int rowId { get; set;}
        public DateTime timestamp { get; set;}
        public MulticabAction()
        {
            InitializeComponent();
            editPanel.BringToFront();
            this.Size = new Size(639 - 157, 668 - 124);
        }
        public void setRowID(int rowId)
        {
            this.rowId = rowId;
            setDetails();
        }
        private void setDetails()
        {
            try
            {
                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();
                string sql_users = "SELECT * FROM managementsystem.multicabs_table WHERE multicab_id ='" + this.rowId + "';";

                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);
                MySqlDataReader reader_users = cmd_users.ExecuteReader();

                string drivername = "";
                string multicabid = "";

                while (reader_users.Read())
                {
                    drivername = (string)reader_users["name_of_driver"];
                    multicabid = (string)reader_users["multicab_plate"];

                }
                DRIVER_NAME_LABEL.Text = drivername;
                MULTICAB_ID_LABEL.Text = multicabid;
                conConn.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Edit_Name_Enter(object sender, EventArgs e)
        {
            if (Edit_Name.Text == "Input Name")
            {
                Edit_Name.Text = "";
                Edit_Name.ForeColor = Color.Black;
            }
        }

        private void Edit_Name_Leave(object sender, EventArgs e)
        {
            if (Edit_Name.Text == "")
            {
                Edit_Name.Text = "Input Name";
                Edit_Name.ForeColor = Color.Silver;
            }
        }

        private void Edit_ID_Enter(object sender, EventArgs e)
        {
            if (Edit_ID.Text == "Input ID")
            {
                Edit_ID.Text = "";
                Edit_ID.ForeColor = Color.Black;
            }
        }

        private void Edit_ID_Leave(object sender, EventArgs e)
        {
            if (Edit_ID.Text == "")
            {
                Edit_ID.Text = "Input ID";
                Edit_ID.ForeColor = Color.Silver;
            }
        }

        private void Edit_seatsNum_Enter(object sender, EventArgs e)
        {
            if (Edit_seatsNum.Text == "Input Total Seats")
            {
                Edit_seatsNum.Text = "";
                Edit_seatsNum.ForeColor = Color.Black;
            }
        }

        private void Edit_seatsNum_Leave(object sender, EventArgs e)
        {
            if (Edit_seatsNum.Text == "")
            {
                Edit_seatsNum.Text = "Input Total Seats";
                Edit_seatsNum.ForeColor = Color.Silver;
            }
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e) //SUBMIT
        {
            try
            {
                if ((Edit_Name.Text == "Input Name" || string.IsNullOrWhiteSpace(Edit_Name.Text)) &&
                    (Edit_ID.Text == "Input ID" || string.IsNullOrWhiteSpace(Edit_ID.Text)) &&
                    (Edit_seatsNum.Text == "Input Total Seats" || string.IsNullOrWhiteSpace(Edit_seatsNum.Text)))
                {
                    MessageBox.Show("Input Required");
                }
                else
                {
                    Multicab multicab = new Multicab(Edit_ID.Text, Edit_Name.Text, DateTime.Now, Int32.Parse(Edit_seatsNum.Text), this.multicab_earnings);
                    multicab.dataBaseId = this.rowId;
                    multicab.editMulticab();
                }
                /*
                DateTime date_t = DateTime.Now;
                DateTime date = DateTime.Now;
                float amount = float.Parse(gunaLabel82.Text);
                string destination = routeComboBox1.Text;

                Booking b = new Booking(x, amount, destination, date_t, date);
                b.editTicket(this.rowId);
                this.Close();*/
            }
            catch
            {
                MessageBox.Show("Incorrect Input");
            }
        }

        private void DELETE_CAB_Click(object sender, EventArgs e)
        {
            deletePanel.BringToFront();
            //this.Size = new Size(1232 - 157, 668 - 124);
            this.Size = new Size(639 - 157, 668 - 124);
        }

        private void EDIT_CAB_Click(object sender, EventArgs e)
        {
            editPanel.BringToFront();
            this.Size = new Size(639 - 157, 668 - 124);
        }

        private void REMOVE_QUEUE_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1232 - 157, 668 - 124);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM multicabs_table WHERE multicab_id ='" + this.rowId + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deletion Successful");
            }
            catch
            {
                MessageBox.Show("mali bro");
            }
        }
    }
}
