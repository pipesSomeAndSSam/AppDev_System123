using AppDev_System.Forms;
using Guna.UI.WinForms;
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

namespace AppDev_System.UserControls
{
    public partial class UserControl_MultData : UserControl
    {
        Query q = new Query();
        MySqlConnection con = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem");
        public UserControl_MultData()
        {
            InitializeComponent();
            customizeGridView();
        }

        private void showGrid()
        {
            try
            {
                MulticabGridView.DataSource = q.getMulticabList();
                numOfMulticabs.Text = q.get_total_numOfMulticabs();
            }
            catch
            {
                MessageBox.Show("There was an Error REIPOH");
            }
        }

        private void customizeGridView()
        {
            showGrid();

            //BookingsGridView.ColumnHeadersHeight.DisableResizing
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
            MulticabGridView.ColumnHeadersHeight = 40;
            MulticabGridView.RowTemplate.Height = 30;
            MulticabGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            MulticabGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            MulticabGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            MulticabGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            MulticabGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            MulticabGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(38, 38, 38);
            MulticabGridView.DefaultCellStyle.ForeColor = Color.FromArgb(38, 38, 38);
            MulticabGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;

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
            MulticabGridView.Columns[13].Visible = false; //date_queued_string

            MulticabGridView.Columns[1].HeaderText = "Name of Driver";
            MulticabGridView.Columns[1].ReadOnly = true;
            MulticabGridView.Columns[15].HeaderText = "Date Added";
            MulticabGridView.Columns[15].ReadOnly = true;
            MulticabGridView.Columns[8].HeaderText = "Multicab ID";
            MulticabGridView.Columns[8].ReadOnly = true;

            MulticabGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            MulticabGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            MulticabGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            MulticabGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(38, 38, 38);
            MulticabGridView.DefaultCellStyle.ForeColor = Color.FromArgb(38, 38, 38);
            MulticabGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;


            MulticabGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            MulticabGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            MulticabGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            MulticabGridView.DefaultCellStyle.SelectionForeColor = Color.FromArgb(38, 38, 38);
            MulticabGridView.DefaultCellStyle.ForeColor = Color.FromArgb(38, 38, 38);
            MulticabGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;

            //BookingsGridView.Columns.Add("Destination_Column", "Destination");

            DataGridViewButtonColumn dataGridViewButtonColumn_edit = new DataGridViewButtonColumn();
            DataGridViewButtonColumn dataGridViewButtonColumn_delete = new DataGridViewButtonColumn();
            dataGridViewButtonColumn_delete.Name = "Del_button1";
            dataGridViewButtonColumn_delete.HeaderText = "Action";
            dataGridViewButtonColumn_edit.Name = "Edit_button";
            dataGridViewButtonColumn_edit.HeaderText = "";

            dataGridViewButtonColumn_delete.FlatStyle = FlatStyle.Popup;
            dataGridViewButtonColumn_edit.FlatStyle = FlatStyle.Popup;
            dataGridViewButtonColumn_delete.Text = "    DELETE";
            dataGridViewButtonColumn_edit.Text = "   EDIT";

            dataGridViewButtonColumn_delete.UseColumnTextForButtonValue = true;
            dataGridViewButtonColumn_edit.UseColumnTextForButtonValue = true;

            MulticabGridView.Columns.Add(dataGridViewButtonColumn_delete);
            MulticabGridView.Columns.Add(dataGridViewButtonColumn_edit);

            MulticabGridView.Columns[16].Width = 80;
            MulticabGridView.Columns[17].Width = 80;

            numOfMulticabs.Text = q.get_total_numOfMulticabs();

            showGrid();
        }

        private void input_Name_Enter(object sender, EventArgs e)
        {
            if (input_Name.Text == "Input Driver Name")
            {
                input_Name.Text = "";
                input_Name.ForeColor = Color.Black;
            }
        }

        private void input_Name_Leave(object sender, EventArgs e)
        {
            if (input_Name.Text == "")
            {

                input_Name.Text = "Input Driver Name";
                input_Name.ForeColor = Color.Silver;

                MulticabGridView.DataSource = q.getMulticabList();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (input_Name.Text != "Input Driver Name")
            {
                MulticabGridView.DataSource = q.showGridDataBasedOnDriverName(input_Name.Text);
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            MulticabGridView.DataSource = q.getMulticabList();
            numOfMulticabs.Text = q.get_total_numOfMulticabs();
        }

        private void addMulticab_Click(object sender, EventArgs e)
        {          
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "AddMulticab_2")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                AddMulticab_2 new_form = new AddMulticab_2();
                new_form.Show();
            }
        }


        private void MulticabGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == MulticabGridView.Columns["Del_button1"].Index) //DELETE
                {
                    DataGridViewRow row_to_DELETE = MulticabGridView.Rows[e.RowIndex];
                    if (MessageBox.Show(string.Format("Do you want to delete Multicab ID: " + (MulticabGridView[10, e.RowIndex].Value).ToString() + " ?", row_to_DELETE.Cells["plateNumber_id"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        using (MySqlConnection con1 = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem"))
                        {
                            using (MySqlCommand cmd1 = new MySqlCommand("DELETE from multicabs_table WHERE multicab_plate=@multicab_plate", con1))
                            {
                                cmd1.Parameters.AddWithValue("multicab_plate", row_to_DELETE.Cells["plateNumber_id"].Value);
                                con1.Open();
                                cmd1.ExecuteNonQuery();
                                con1.Close();
                            }
                        }

                    }
                }
                else if (e.ColumnIndex == MulticabGridView.Columns["Edit_button"].Index) //EDIT
                {
                    DataGridViewRow row_to_edit = MulticabGridView.Rows[e.RowIndex];
                    string id = row_to_edit.Cells[2].Value.ToString(); //MAO NI ID
                    string date_time = row_to_edit.Cells[3].Value.ToString();

                    bool isOpen = false;
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Text == "EditMulticab")
                        {
                            isOpen = true;
                            f.BringToFront();
                            break;
                        }
                    }
                    if (isOpen == false)
                    {
                        EditMulticab actmult = new EditMulticab();
                        //actmult.multicab_earnings = float.Parse(earnings);
                        actmult.setRowID(Int32.Parse(id), date_time);

                        actmult.rowNum = e.RowIndex + 1;
                        actmult.timestamp = date_time;
                        actmult.Show();
                    }
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }
    }
}
