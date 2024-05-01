using AppDev_System.Classes;
using Google.Protobuf.WellKnownTypes;
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
        private string datetime_qyeye = "";
        public string timestamp { get; set;}
        public MulticabAction()
        {
            InitializeComponent();
           // editPanel.BringToFront();
           // this.Size = new Size(639 - 157, 668 - 124);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void setRowID(int rowId, string x)
        {
            this.rowId = rowId;
            this.timestamp = x;
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
                string dateAddedToDataBase = "";
                string dateTimeArrived = "";
                string date_time_added = "";
                

                while (reader_users.Read())
                {
                    drivername = (string)reader_users["name_of_driver"];
                    multicabid = (string)reader_users["multicab_plate"];

                    DateTime d2 = reader_users.GetDateTime(5);
                    dateAddedToDataBase = d2.ToString("yyyy-MM-dd");

                    DateTime d3 = reader_users.GetDateTime(2);

                    DateTime d6 = reader_users.GetDateTime(7);
                    this.datetime_qyeye = d6.ToString("yyyy-MM-dd H:m:s");

                    int hour = d3.Hour;
                    int minute = d3.Minute;
                    int second = d3.Second;

                    if (hour < 10 && minute < 10)
                    {
                        dateTimeArrived = d2.ToString("yyyy-MM-dd 0" + hour + ":0" + minute + ":" + second + "0 tt");
                    }
                    else if (hour < 10 && minute > 10)
                    {
                        dateTimeArrived = d2.ToString("yyyy-MM-dd 0" + hour + ":" + minute + ":" + second + "0 tt");
                    }
                    else if (hour > 10 && minute > 10)
                    {
                        dateTimeArrived = d2.ToString("yyyy-MM-dd " + hour + ":" + minute + ":" + second + "0 tt");
                    }
                    else if (hour > 10 && minute < 10)
                    {
                        dateTimeArrived = d2.ToString("yyyy-MM-dd " + hour + ":0" + minute + ":" + second + "0 tt");
                    }
                }

               // DRIVER_NAME_LABEL.Text = 
                DRIVER_NAME_LABEL_DEQUEUE.Text = drivername;
               // MULTICAB_ID_LABEL.Text = 
                MULTICAB_ID_LABEL_DEQUEUE.Text = multicabid;
                DATE_TIME_ADDED.Text = datetime_qyeye;
              //  dateAddedMulticab.Text = dateAddedToDataBase;
                DATE_TIME_DEQUEUED.Text = DateTime.Now.ToString("yyyy-MM-dd H:m:s");

              //  DATE_TIME_SET.Text = this.datetime_qyeye;

                conConn.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
/*
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

        
        private void gunaAdvenceButton6_Click(object sender, EventArgs e) //SUBMIT
        {
            try
            {
                if ((Edit_Name.Text == "Input Name" || string.IsNullOrWhiteSpace(Edit_Name.Text)) &&
                    (Edit_ID.Text == "Input ID" || string.IsNullOrWhiteSpace(Edit_ID.Text)))
                {
                    MessageBox.Show("Input Required");
                }
                else
                {
                    Multicab multicab = new Multicab(Edit_ID.Text, Edit_Name.Text, DATE_TIME_SET.Text, 0, this.multicab_earnings);
                    multicab.dataBaseId = this.rowId;
                    multicab.date_queued = DateTime.Now;
                    multicab.date_queued_string = DateTime.Now.ToString("yyyy-MM-dd H:m:s");
                    multicab.editMulticab();
                }

                (comment start here)

                DateTime date_t = DateTime.Now;
                DateTime date = DateTime.Now;
                float amount = float.Parse(gunaLabel82.Text);
                string destination = routeComboBox1.Text;

                Booking b = new Booking(x, amount, destination, date_t, date);
                b.editTicket(this.rowId);
                this.Close();

                (comment end here)

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
            //this.Size = new Size(639 - 157, 668 - 124);
        }

        private void EDIT_CAB_Click(object sender, EventArgs e)
        {
            editPanel.BringToFront();
            //this.Size = new Size(639 - 157, 668 - 124);
        }

        private void REMOVE_QUEUE_Click(object sender, EventArgs e)
        {
            // this.Size = new Size(1232 - 157, 668 - 124);
            dequeuePanel.BringToFront();
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
            this.Close();
        }

        private void changeTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(changeTimeCheckBox.Checked)
            {
                DATE_TIME_SET.Text = DateTime.Now.ToString("yyyy-MM-dd H:m:s");
            }
            else 
            {
                DATE_TIME_SET.Text = this.datetime_qyeye;
            }
        }*/

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            Query q = new Query();
            q.editMulticab_dequeue(rowId);
            this.Close();
        }
    }
}
