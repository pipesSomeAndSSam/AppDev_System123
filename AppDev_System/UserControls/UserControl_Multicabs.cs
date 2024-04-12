using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDev_System.Forms;
using Guna.UI.WinForms;
using MySql.Data.MySqlClient;

namespace AppDev_System.UserControls
{
    public partial class UserControl_Multicabs : UserControl
    {
        private bool gjh2 = false;
        private Query q = new Query();
        MySqlConnection con = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem");

        public List<Multicab> multicabs = new List<Multicab>();

        public UserControl_Multicabs()
        {
            InitializeComponent();
            customizeGridView();
        }

        private void customizeGridView()
        {
            con.Open();
            string query = "SELECT * FROM multicabs_table";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, con);
            DataTable dt_users = new DataTable();
            dataAdapter.Fill(dt_users);
            BookingsGridView.DataSource = dt_users;

            BookingsGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            BookingsGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            BookingsGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            BookingsGridView.EnableHeadersVisualStyles = false;
            BookingsGridView.ColumnHeadersVisible = true;
            BookingsGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            BookingsGridView.DefaultCellStyle.ForeColor = Color.DimGray;
            BookingsGridView.DefaultCellStyle.BackColor = Color.White;
            BookingsGridView.RowsDefaultCellStyle = BookingsGridView.DefaultCellStyle;
            BookingsGridView.AllowUserToResizeRows = false;
            BookingsGridView.AllowUserToResizeColumns = false;
            BookingsGridView.AllowUserToAddRows = false;
            BookingsGridView.ColumnHeadersHeight = 50;
            BookingsGridView.RowTemplate.Height = 30;
            BookingsGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            BookingsGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            BookingsGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            BookingsGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            BookingsGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            BookingsGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(38, 38, 38);
            BookingsGridView.DefaultCellStyle.ForeColor = Color.FromArgb(38, 38, 38);
            BookingsGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;

            BookingsGridView.Columns["multicab_id"].Visible = false;
            BookingsGridView.Columns["date_day"].Visible = false;
            BookingsGridView.Columns[1].HeaderText = "Name of Driver";
            BookingsGridView.Columns[1].ReadOnly = true;
            BookingsGridView.Columns[2].HeaderText = "Arrival Time";
            BookingsGridView.Columns[2].ReadOnly = true;
            BookingsGridView.Columns[2].Width = 70;
            BookingsGridView.Columns[3].HeaderText = "Departure Time";
            BookingsGridView.Columns[3].ReadOnly = true;
            BookingsGridView.Columns[3].Width = 70;
            BookingsGridView.Columns[4].HeaderText = "Number of Seats";
            BookingsGridView.Columns[4].ReadOnly = true;
            BookingsGridView.Columns[4].Width = 70;
            BookingsGridView.Columns[5].HeaderText = "Available Seats";
            BookingsGridView.Columns[5].ReadOnly = true;
            BookingsGridView.Columns[5].Width = 70;
            BookingsGridView.Columns[6].HeaderText = "Earnings Today in ₱";
            BookingsGridView.Columns[6].ReadOnly = true;
            BookingsGridView.Columns[6].Width = 70;
            BookingsGridView.Columns[8].HeaderText = "Multicab ID";
            BookingsGridView.Columns[8].ReadOnly = true;
            BookingsGridView.Columns[8].Width = 190;

            BookingsGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            BookingsGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            BookingsGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            BookingsGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(38, 38, 38);
            BookingsGridView.DefaultCellStyle.ForeColor = Color.FromArgb(38, 38, 38);
            BookingsGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;

            //BookingsGridView.Columns.Add("Destination_Column", "Destination");

            DataGridViewButtonColumn dataGridViewButtonColumn_delete = new DataGridViewButtonColumn();
            dataGridViewButtonColumn_delete.Name = "Action_Button";
            dataGridViewButtonColumn_delete.HeaderText = "Select Row";

            dataGridViewButtonColumn_delete.FlatStyle = FlatStyle.Popup;
            dataGridViewButtonColumn_delete.Text = "      ACTION";

            dataGridViewButtonColumn_delete.UseColumnTextForButtonValue = true;

            BookingsGridView.Columns.Add(dataGridViewButtonColumn_delete);

            BookingsGridView.Columns[9].Width = 130;

            numOfMulticabs.Text = q.get_total_multicabsToday();

            con.Close();
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
            DateTime theDate = dateTimePickerMult.Value;
            numOfMulticabs.Text = q.get_total_multicabsToday(theDate.ToString("yyyy-MM-dd"));

            string sqlstm = "SELECT * FROM multicabs_table WHERE date_day = '" + theDate.ToString("yyyy-MM-dd") + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(sqlstm, con);
            DataSet DS = new System.Data.DataSet();
            SDA.Fill(DS, "multicabs_table");
            BookingsGridView.DataSource = DS.Tables[0];
        }

        private void dateTimePickerMult_ValueChanged(object sender, EventArgs e)
        {
            showGridDataBasedOnDateTime_Multicab();
            this.ActiveControl = null;
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

                string sqlstm = "SELECT * FROM multicabs_table";
                MySqlDataAdapter SDA = new MySqlDataAdapter(sqlstm, con);
                DataSet DS = new System.Data.DataSet();
                SDA.Fill(DS, "multicabs_table");
                BookingsGridView.DataSource = DS.Tables[0];

                showGridDataBasedOnDateTime_Multicab();
            }
        }

        private void showGridDataBasedOnDateTime_Multicab()
        {
            DateTime theDate = dateTimePickerMult.Value;
            numOfMulticabs.Text = q.get_total_multicabsToday(theDate.ToString("yyyy-MM-dd"));

            string sqlstm = "SELECT * FROM multicabs_table WHERE date_day = '" + theDate.ToString("yyyy-MM-dd") + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(sqlstm, con);
            DataSet DS = new System.Data.DataSet();
            SDA.Fill(DS, "multicabs_table");
            BookingsGridView.DataSource = DS.Tables[0];
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (dateTimePickerMult.Text != "Input Driver Name")
            {
                DateTime theDate = dateTimePickerMult.Value;

                MySqlDataAdapter da;
                DataTable dt;
                con.Open();
                da = new MySqlDataAdapter("SELECT * FROM multicabs_table WHERE name_of_driver = '" + searchDriverName.Text + "' and date_day = '" + theDate.ToString("yyyy-MM-dd") + "'", con);
                dt = new DataTable();
                da.Fill(dt);
                BookingsGridView.DataSource = dt;
                con.Close();

                gjh2 = true;
            }
        }

        private void BookingsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch
            {

            }
        }
    }
}
