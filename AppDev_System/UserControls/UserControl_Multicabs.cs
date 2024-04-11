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

namespace AppDev_System.UserControls
{
    public partial class UserControl_Multicabs : UserControl
    {
        private Query q = new Query();
        MySqlConnection con = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem");
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

            BookingsGridView.Columns["multicab_id"].Visible = false;
            BookingsGridView.Columns["date_day"].Visible = false;
            BookingsGridView.Columns[1].HeaderText = "Name of Driver";
            BookingsGridView.Columns[1].ReadOnly = true;
            BookingsGridView.Columns[2].HeaderText = "Arrival Time";
            BookingsGridView.Columns[2].ReadOnly = true;
            BookingsGridView.Columns[3].HeaderText = "Departure Time";
            BookingsGridView.Columns[3].ReadOnly = true;
            BookingsGridView.Columns[4].HeaderText = "Number of Seats";
            BookingsGridView.Columns[4].ReadOnly = true;
            BookingsGridView.Columns[5].HeaderText = "Available Seats";
            BookingsGridView.Columns[5].ReadOnly = true;
            BookingsGridView.Columns[6].HeaderText = "Earnings Today";
            BookingsGridView.Columns[6].ReadOnly = true;

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

            BookingsGridView.Columns[8].Width = 80;
            BookingsGridView.Columns[9].Width = 80;

            numOfMulticabs.Text = q.get_total_multicabsToday();

            con.Close();
        }
    }
}
