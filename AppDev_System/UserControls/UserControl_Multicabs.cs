using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDev_System.Classes;
using AppDev_System.Forms;
using Google.Protobuf.Compiler;
using Guna.UI.WinForms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppDev_System.UserControls
{
    public partial class UserControl_Multicabs : UserControl
    {
        private bool gjh2 = false;
        private Query q = new Query();
        MySqlConnection con = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem");

        // Queue<Multicab> multicab_queue = new Queue<Multicab>();
        // List<Multicab> multicab_list_get = new List<Multicab>();
        // List<Multicab> multicab_list_show = new List<Multicab>();


       // Queue_Implementation <Multicab> multicab_queue = new Queue_Implementation <Multicab>();

        public UserControl_Multicabs()
        {
            InitializeComponent();
            customizeGridView();
        }
        private void showGrid()
        {
            //DateTime theDate1 = dateTimePickerMult.Value;

            // this.multicab_list_get.Clear();
            // this.multicab_queue.Clear();
            // this.multicab_list_show.Clear();

            // MulticabGridView.DataSource = q.getMulticab_withDATE(DateTime.Now.ToString("yyyy-MM-dd"));

            /*
            foreach (Multicab cab in this.multicab_list_get)
            {
                
                this.multicab_queue.Enqueue(cab);
            }

            foreach (Multicab cab in this.multicab_queue)
            {
                
                this.multicab_list_show.Add(cab);
                
            }

            MulticabGridView.DataSource = this.multicab_list_show;
            */
            
            /*
            int multicab_id = 0;
            string name_of_driver = "";
            string dateTime_of_arrival = "";
            string date_day = "";
            string multicab_plate = "";

            try
            {
                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();

                string sql_users = "SELECT * FROM managementsystem.multicabs_table WHERE date_day ='" + DateTime.Now.ToString("yyyy-MM-dd") + "';";

                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);
                MySqlDataReader reader_mult = cmd_users.ExecuteReader();

                while (reader_mult.Read())
                {
                    multicab_id = reader_mult.GetInt32(reader_mult.GetOrdinal("multicab_id"));
                    name_of_driver = (string)reader_mult["name_of_driver"];

                    DateTime d = reader_mult.GetDateTime(2);
                    dateTime_of_arrival = d.ToString("yyyy-MM-dd HH:mm:ss tt");

                    DateTime d2 = reader_mult.GetDateTime(3);
                    date_day = d2.ToString("yyyy-MM-dd");

                    multicab_plate = (string)reader_mult["multicab_plate"];


                    //ADD TO LIST
                    Multicab multicab = new Multicab(multicab_plate, name_of_driver, dateTime_of_arrival);

                    multicab.dataBaseId_(multicab_id);
                    multicab.setDay_Date(date_day);

                    if(multicab.isIn == true)
                        this.multicab_queue.Enqueue(multicab);
                }

                /*
                MessageBox.Show("multicab_plate = " + multicab_id +
                                "\nname_of_driver = " + name_of_driver +
                                "\ndateTime_of_arrival = " + dateTime_of_arrival +
                                "\ndate_day = " + date_day +
                                "\nmulticab_plate =" + multicab_plate);
                */


                //conConn.Close();
                
            try
            { 
                MulticabGridView.DataSource = q.getMulticab_isIn();
                numOfMulticabs.Text = q.get_total_multicabsInQueue();
            }
            catch
            {
                MessageBox.Show("There was an Error REIPOH");
            }
        }

        
        private void customizeGridView()
        {


            showGrid();



            /*
            con.Open();
            string query = "SELECT * FROM multicabs_table";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, con);
            DataTable dt_users = new DataTable();
            dataAdapter.Fill(dt_users);
            MulticabGridView.DataSource = dt_users;*/

            MulticabGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            MulticabGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            MulticabGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            MulticabGridView.EnableHeadersVisualStyles = false;
            MulticabGridView.ColumnHeadersVisible = true;
            MulticabGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            MulticabGridView.DefaultCellStyle.ForeColor = Color.DimGray;
            MulticabGridView.DefaultCellStyle.BackColor = Color.White;
            MulticabGridView.RowsDefaultCellStyle = MulticabGridView.DefaultCellStyle;
            MulticabGridView.AllowUserToResizeRows = false;
            MulticabGridView.AllowUserToResizeColumns = false;
            MulticabGridView.AllowUserToAddRows = false;
            MulticabGridView.ColumnHeadersHeight = 50;
            MulticabGridView.RowTemplate.Height = 30;
            MulticabGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            MulticabGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            MulticabGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            MulticabGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            MulticabGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            MulticabGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(38, 38, 38);
            MulticabGridView.DefaultCellStyle.ForeColor = Color.FromArgb(38, 38, 38);
            MulticabGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;

            /*
            MulticabGridView.Columns["date_day"].Visible = false;
            MulticabGridView.Columns[1].HeaderText = "Name of Driver";
            MulticabGridView.Columns[1].ReadOnly = true;
            MulticabGridView.Columns[2].HeaderText = "Arrival Time";
            MulticabGridView.Columns[2].ReadOnly = true;
            MulticabGridView.Columns[4].HeaderText = "Multicab ID";
            MulticabGridView.Columns[4].ReadOnly = true;*/

            MulticabGridView.Columns[0].Visible = false; //database ID
            MulticabGridView.Columns[2].Visible = false; //arrived Time
            MulticabGridView.Columns[3].Visible = false; //departure
            MulticabGridView.Columns[4].Visible = false; //seatsTotal
            MulticabGridView.Columns[5].Visible = false; //seatsAverage
            MulticabGridView.Columns[6].Visible = false; //earnings
            MulticabGridView.Columns[7].Visible = false; //date_day with time
            MulticabGridView.Columns[9].Visible = false; //time_date

            MulticabGridView.Columns[10].Visible = false; //DATE TIME TODAY (IMPORTANT)
            MulticabGridView.Columns[11].Visible = false; //DATE added to dataBase
            MulticabGridView.Columns[12].Visible = false; //datetime_queue
            MulticabGridView.Columns[14].Visible = false; //isIn
            MulticabGridView.Columns[15].Visible = false; //added_to_database

            MulticabGridView.Columns[1].HeaderText = "Name of Driver";
            MulticabGridView.Columns[1].ReadOnly = true;
            MulticabGridView.Columns[13].HeaderText = "Date and Time added to Queue";
            MulticabGridView.Columns[13].ReadOnly = true;
            MulticabGridView.Columns[8].HeaderText = "Multicab ID";
            MulticabGridView.Columns[8].ReadOnly = true;

            MulticabGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            MulticabGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            MulticabGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            MulticabGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(38, 38, 38);
            MulticabGridView.DefaultCellStyle.ForeColor = Color.FromArgb(38, 38, 38);
            MulticabGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;

            //BookingsGridView.Columns.Add("Destination_Column", "Destination");

            //MulticabGridView.Columns["multicab_id"].Visible = false;




            DataGridViewButtonColumn dataGridViewButtonColumn_delete = new DataGridViewButtonColumn();
            dataGridViewButtonColumn_delete.Name = "Action_Button";
            dataGridViewButtonColumn_delete.HeaderText = "Select Row";

            dataGridViewButtonColumn_delete.FlatStyle = FlatStyle.Popup;
            dataGridViewButtonColumn_delete.Text = "    DEQUEUE";

            dataGridViewButtonColumn_delete.UseColumnTextForButtonValue = true;

            MulticabGridView.Columns.Add(dataGridViewButtonColumn_delete);

            dataGridViewButtonColumn_delete.Width = 130;

            numOfMulticabs.Text = q.get_total_multicabsToday();

            //con.Close();

            //DateTime theDate = dateTimePickerMult.Value;
            numOfMulticabs.Text = q.get_total_multicabsToday(DateTime.Now.ToString("yyyy-MM-dd"));
            showGrid();

            /*
            string sqlstm = "SELECT * FROM multicabs_table WHERE date_day = '" + theDate.ToString("yyyy-MM-dd") + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(sqlstm, con);
            DataSet DS = new System.Data.DataSet();
            SDA.Fill(DS, "multicabs_table");
            MulticabGridView.DataSource = DS.Tables[0];*/
        }

        private void addMulticab_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "AddMulticab")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                AddMulticab addmult = new AddMulticab();
                addmult.Show();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            showGrid();
            /*
            string sqlstm = "SELECT * FROM multicabs_table WHERE date_day = '" + theDate.ToString("yyyy-MM-dd") + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(sqlstm, con);
            DataSet DS = new System.Data.DataSet();
            SDA.Fill(DS, "multicabs_table");
            MulticabGridView.DataSource = DS.Tables[0];*/
        }

        private void searchDriverName_Enter(object sender, EventArgs e)
        {
            if (searchDriverName.Text == "Input Driver Name")
            {
                searchDriverName.Text = "";
                searchDriverName.ForeColor = Color.Black;
            }
        }

        private void searchDriverName_Leave(object sender, EventArgs e)
        {
            if (searchDriverName.Text == "")
            {

                searchDriverName.Text = "Input Driver Name";
                searchDriverName.ForeColor = Color.Silver;

                /*
                string sqlstm = "SELECT * FROM multicabs_table";
                MySqlDataAdapter SDA = new MySqlDataAdapter(sqlstm, con);
                DataSet DS = new System.Data.DataSet();
                SDA.Fill(DS, "multicabs_table");
                MulticabGridView.DataSource = DS.Tables[0];*/

                showGrid();
            }
        }
        /*
        private void showGridDataBasedOnDateTime_Multicab()
        {
            DateTime theDate = dateTimePickerMult.Value;



            MulticabGridView.DataSource = q.getMulticab_withDATE_ifCabIsIn(theDate.ToString("yyyy-MM-dd"));
            
            string sqlstm = "SELECT * FROM multicabs_table WHERE date_day = '" + theDate.ToString("yyyy-MM-dd") + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(sqlstm, con);
            DataSet DS = new System.Data.DataSet();
            SDA.Fill(DS, "multicabs_table");
            MulticabGridView.DataSource = DS.Tables[0];
        }
        */

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchDriverName.Text != "Input Driver Name")
            {
               // DateTime theDate = dateTimePickerMult.Value;

                /*
                MySqlDataAdapter da;
                DataTable dt;
                con.Open();
                da = new MySqlDataAdapter("SELECT * FROM multicabs_table WHERE name_of_driver = '" + searchDriverName.Text + "' and date_day = '" + theDate.ToString("yyyy-MM-dd") + "'", con);
                dt = new DataTable();
                da.Fill(dt);
                MulticabGridView.DataSource = dt;
                con.Close();
                */

                MulticabGridView.DataSource = q.getMulticab_withDriverName(searchDriverName.Text);


                gjh2 = true;
            }
        }


        private void BookingsGridView_CellClick(object sender, DataGridViewCellEventArgs e) //MULTICAB DATA GRID VIEW
        {
            try
            {
                if (e.ColumnIndex == MulticabGridView.Columns["Action_Button"].Index) //ACTION
                {
                    DataGridViewRow row_to_edit = MulticabGridView.Rows[e.RowIndex];

                    string id = row_to_edit.Cells[1].Value.ToString(); //MAO NI ID
                    string date_time = row_to_edit.Cells[3].Value.ToString();
                    // string earnings = row_to_edit.Cells[7].Value.ToString(); //MAO NI EARNINGS NAME

                    bool isOpen = false;
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Text == "MulticabAction")
                        {
                            isOpen = true;
                            f.BringToFront();
                            break;
                        }
                    }
                    if (isOpen == false)
                    {
                        MulticabAction actmult = new MulticabAction();
                        //actmult.multicab_earnings = float.Parse(earnings);
                        actmult.setRowID(Int32.Parse(id), date_time);

                        actmult.rowNum = e.RowIndex + 1;
                        actmult.Show();
                    }
                }
            }
            catch
            {
            }
        }

        private void clearButton_Click(object sender, EventArgs e) //CLEAR BUTTON
        {          
            if (MessageBox.Show("Do you want to Clear all cabs in Queue?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    con.Open();

                    MySqlCommand comToCheck = new MySqlCommand("SELECT * FROM multicabs_table", con);

                    MySqlDataAdapter sd = new MySqlDataAdapter(comToCheck);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        string updt = "UPDATE multicabs_table SET isInQueue = '" + 0 + "'";

                        MySqlCommand command_update = new MySqlCommand(updt, con);

                        command_update.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("IT DOES NOT EXIST EXISTS");
                    }
                }
                catch
                {
                    MessageBox.Show("mali kay duy");
                }
            }
        }
    }
}
