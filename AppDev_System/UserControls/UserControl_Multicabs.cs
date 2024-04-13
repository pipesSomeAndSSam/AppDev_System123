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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppDev_System.UserControls
{
    public partial class UserControl_Multicabs : UserControl
    {
        private bool gjh2 = false;
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
            MulticabGridView.DataSource = dt_users;

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

            MulticabGridView.Columns["multicab_id"].Visible = false;
            MulticabGridView.Columns["date_day"].Visible = false;
            MulticabGridView.Columns[1].HeaderText = "Name of Driver";
            MulticabGridView.Columns[1].ReadOnly = true;
            MulticabGridView.Columns[2].HeaderText = "Arrival Time";
            MulticabGridView.Columns[2].ReadOnly = true;
            MulticabGridView.Columns[2].Width = 70;
            MulticabGridView.Columns[3].HeaderText = "Departure Time";
            MulticabGridView.Columns[3].ReadOnly = true;
            MulticabGridView.Columns[3].Width = 70;
            MulticabGridView.Columns[4].HeaderText = "Number of Seats";
            MulticabGridView.Columns[4].ReadOnly = true;
            MulticabGridView.Columns[4].Width = 70;
            MulticabGridView.Columns[5].HeaderText = "Available Seats";
            MulticabGridView.Columns[5].ReadOnly = true;
            MulticabGridView.Columns[5].Width = 70;
            MulticabGridView.Columns[6].HeaderText = "Earnings Today in ₱";
            MulticabGridView.Columns[6].ReadOnly = true;
            MulticabGridView.Columns[6].Width = 70;
            MulticabGridView.Columns[8].HeaderText = "Multicab ID";
            MulticabGridView.Columns[8].ReadOnly = true;
            MulticabGridView.Columns[8].Width = 190;

            MulticabGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            MulticabGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            MulticabGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            MulticabGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(38, 38, 38);
            MulticabGridView.DefaultCellStyle.ForeColor = Color.FromArgb(38, 38, 38);
            MulticabGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;

            //BookingsGridView.Columns.Add("Destination_Column", "Destination");

            DataGridViewButtonColumn dataGridViewButtonColumn_delete = new DataGridViewButtonColumn();
            dataGridViewButtonColumn_delete.Name = "Action_Button";
            dataGridViewButtonColumn_delete.HeaderText = "Select Row";

            dataGridViewButtonColumn_delete.FlatStyle = FlatStyle.Popup;
            dataGridViewButtonColumn_delete.Text = "      ACTION";

            dataGridViewButtonColumn_delete.UseColumnTextForButtonValue = true;

            MulticabGridView.Columns.Add(dataGridViewButtonColumn_delete);

            MulticabGridView.Columns[9].Width = 130;

            numOfMulticabs.Text = q.get_total_multicabsToday();

            con.Close();

            DateTime theDate = dateTimePickerMult.Value;
            numOfMulticabs.Text = q.get_total_multicabsToday(theDate.ToString("yyyy-MM-dd"));

            string sqlstm = "SELECT * FROM multicabs_table WHERE date_day = '" + theDate.ToString("yyyy-MM-dd") + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(sqlstm, con);
            DataSet DS = new System.Data.DataSet();
            SDA.Fill(DS, "multicabs_table");
            MulticabGridView.DataSource = DS.Tables[0];
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
            MulticabGridView.DataSource = DS.Tables[0];
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
                MulticabGridView.DataSource = DS.Tables[0];

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
            MulticabGridView.DataSource = DS.Tables[0];
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
                MulticabGridView.DataSource = dt;
                con.Close();

                gjh2 = true;
            }
        }

        private void BookingsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == MulticabGridView.Columns["Action_Button"].Index) //ACTION
                {
                    DataGridViewRow row_to_edit = MulticabGridView.Rows[e.RowIndex];

                    string id = row_to_edit.Cells[1].Value.ToString(); //MAO NI ID
                    string earnings = row_to_edit.Cells[7].Value.ToString(); //MAO NI EARNINGS NAME

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
                        actmult.multicab_earnings = float.Parse(earnings);
                        actmult.setRowID(Int32.Parse(id));
                        actmult.rowNum = e.RowIndex + 1;
                        actmult.Show();
                    }
                    /*
                    DataGridViewRow row_to_DELETE = BookingsGridView.Rows[e.RowIndex];
                    if (MessageBox.Show(string.Format("Do you want to Delete row " + (e.RowIndex + 1) + " ?", row_to_DELETE.Cells["id"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        using (MySqlConnection con1 = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem"))
                        {
                            using (MySqlCommand cmd1 = new MySqlCommand("DELETE from bookings WHERE id=@id", con1))
                            {
                                cmd1.Parameters.AddWithValue("id", row_to_DELETE.Cells["id"].Value);
                                con1.Open();
                                cmd1.ExecuteNonQuery();
                                con1.Close();
                            }
                        }

                    }*/
                }
            }
            catch
            {
            }
        }
    }
}
