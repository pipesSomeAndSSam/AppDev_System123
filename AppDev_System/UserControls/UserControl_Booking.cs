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
   
    public partial class UserControl_Booking : UserControl
    {
        private Query q = new Query();
        private bool gjh1 = false;
        MySqlConnection con = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem");
        public UserControl_Booking()
        {
            InitializeComponent();
            customizeGridView();
        }

        private void customizeGridView()
        {
            con.Open();
            string query = "SELECT * FROM bookings";
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
            BookingsGridView.ColumnHeadersHeight = 40;
            BookingsGridView.RowTemplate.Height = 30;
            BookingsGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            BookingsGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            BookingsGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            BookingsGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            BookingsGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            BookingsGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(38, 38, 38);
            BookingsGridView.DefaultCellStyle.ForeColor = Color.FromArgb(38, 38, 38);
            BookingsGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;

            BookingsGridView.Columns["id"].Visible = false;
            BookingsGridView.Columns[1].HeaderText = "Passenger";
            BookingsGridView.Columns[1].ReadOnly = true;
            BookingsGridView.Columns[2].HeaderText = "Book Date";
            BookingsGridView.Columns[2].ReadOnly = true;
            BookingsGridView.Columns[3].HeaderText = "Destination";
            BookingsGridView.Columns[3].ReadOnly = true;
            BookingsGridView.Columns[4].HeaderText = "Amount in ₱";
            BookingsGridView.Columns[4].ReadOnly = true;

            BookingsGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            BookingsGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            BookingsGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            BookingsGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(38, 38, 38);
            BookingsGridView.DefaultCellStyle.ForeColor = Color.FromArgb(38, 38, 38);
            BookingsGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;

            //BookingsGridView.Columns.Add("Destination_Column", "Destination");

            DataGridViewButtonColumn dataGridViewButtonColumn_edit = new DataGridViewButtonColumn();
            DataGridViewButtonColumn dataGridViewButtonColumn_delete = new DataGridViewButtonColumn();
            dataGridViewButtonColumn_delete.Name = "Del_button";
            dataGridViewButtonColumn_delete.HeaderText = "Action";
            dataGridViewButtonColumn_edit.Name = "Edit_button";
            dataGridViewButtonColumn_edit.HeaderText = "";

            dataGridViewButtonColumn_delete.FlatStyle = FlatStyle.Popup;
            dataGridViewButtonColumn_edit.FlatStyle = FlatStyle.Popup;
            dataGridViewButtonColumn_delete.Text = "  DELETE";
            dataGridViewButtonColumn_edit.Text = "    EDIT";

            dataGridViewButtonColumn_delete.UseColumnTextForButtonValue = true;
            dataGridViewButtonColumn_edit.UseColumnTextForButtonValue = true;

            BookingsGridView.Columns.Add(dataGridViewButtonColumn_delete);
            BookingsGridView.Columns.Add(dataGridViewButtonColumn_edit);

            BookingsGridView.Columns[5].Width = 80;
            BookingsGridView.Columns[6].Width = 80;

            numOfRts.Text = q.get_total_numOfTickets_forToday();

            con.Close();
        }

        private void addBookings_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "AddBooking")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                AddBooking addbookn = new AddBooking();
                addbookn.Show();
            }
        }

        private void gunaLineTextBox1_Enter(object sender, EventArgs e)
        {
            if (gunaLineTextBox1.Text == "Input Destination")
            {
                gunaLineTextBox1.Text = "";
                gunaLineTextBox1.ForeColor = Color.Black;
            }
        }

        private void gunaLineTextBox1_Leave(object sender, EventArgs e)
        {
            if (gunaLineTextBox1.Text == "")
            {
                gunaLineTextBox1.Text = "Input Destination";
                gunaLineTextBox1.ForeColor = Color.Silver;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (gunaLineTextBox1.Text != "Input Destination")
            {
                MySqlDataAdapter da;
                DataTable dt;
                con.Open();
                da = new MySqlDataAdapter("SELECT * FROM bookings WHERE route_id = '" + gunaLineTextBox1.Text + "'", con);
                dt = new DataTable();
                da.Fill(dt);
                BookingsGridView.DataSource = dt;
                con.Close();

                gjh1 = true;
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            string sqlstm = "SELECT * FROM bookings";
            MySqlDataAdapter SDA = new MySqlDataAdapter(sqlstm, con);
            DataSet DS = new System.Data.DataSet();
            SDA.Fill(DS, "bookings");
            BookingsGridView.DataSource = DS.Tables[0];

            numOfRts.Text = q.get_total_numOfRoutes();
        }
    }
}