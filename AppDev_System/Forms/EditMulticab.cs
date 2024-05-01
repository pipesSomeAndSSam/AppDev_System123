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

namespace AppDev_System.Forms
{
    public partial class EditMulticab : Form
    {
        private string datetime_qyeye = "";
        public int rowNum {  get; set; }
        public int rowId {  get; set; }
        public float multicab_earnings { get; set; }
        public string timestamp { get; set; }
        public EditMulticab()
        {
            InitializeComponent();
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
                string dateTime_arrived = "";

                while (reader_users.Read())
                {
                    drivername = (string)reader_users["name_of_driver"];
                    multicabid = (string)reader_users["multicab_plate"];

                    DateTime d2 = reader_users.GetDateTime(5);
                    dateAddedToDataBase = d2.ToString("yyyy-MM-dd");

                    DateTime d3 = reader_users.GetDateTime(2);
                    DateTime d5 = reader_users.GetDateTime(2);
                    dateTime_arrived = d5.ToString("yyyy-MM-dd H:m:s");

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
                //DATE_TIME_SET.Text = this.datetime_qyeye;
                DATE_TIME_SET.Text = this.datetime_qyeye = dateTime_arrived;

                conConn.Close();
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
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
            }
            catch
            {
                MessageBox.Show("Incorrect Input");
            }
        }

        private void changeTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (changeTimeCheckBox.Checked)
            {
                DATE_TIME_SET.Text = DateTime.Now.ToString("yyyy-MM-dd H:m:s");
            }
            else
            {
                DATE_TIME_SET.Text = this.datetime_qyeye;
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
    }
}
