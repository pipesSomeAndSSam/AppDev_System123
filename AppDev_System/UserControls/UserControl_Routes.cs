﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using MySql.Data.MySqlClient;

namespace AppDev_System.UserControls
{
    public partial class UserControl_Routes : UserControl
    {
        MySqlConnection con = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem");
        private bool addRoute_isOpen = false;

        public UserControl_Routes()
        {
            InitializeComponent();



            con.Open();

            string query = "SELECT * FROM routes";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, con);
            DataTable dt_users = new DataTable();
            dataAdapter.Fill(dt_users);
            gunaDataGridView2.DataSource = dt_users;

            gunaDataGridView2.ColumnHeadersVisible = true;
            gunaDataGridView2.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            gunaDataGridView2.DefaultCellStyle.ForeColor = Color.Black;

            gunaDataGridView2.RowsDefaultCellStyle = gunaDataGridView2.DefaultCellStyle;

            gunaDataGridView2.AllowUserToResizeRows = false;
            gunaDataGridView2.AllowUserToResizeColumns = false;
            gunaDataGridView2.AllowUserToAddRows = false;
            
            gunaDataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gunaDataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            //gunaDataGridView2.AllowUserToDeleteRows = false;

            gunaDataGridView2.ColumnHeadersHeight = 40;
            gunaDataGridView2.RowTemplate.Height = 30;

            gunaDataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gunaDataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            gunaDataGridView2.Columns["id"].Visible = false;
            gunaDataGridView2.Columns["regular_fare_old"].Visible = false;
            gunaDataGridView2.Columns["special_fare_old"].Visible = false;
            gunaDataGridView2.Columns["date_fare_changed"].Visible = false;

            gunaDataGridView2.Columns[1].HeaderText = "Barangay";
            gunaDataGridView2.Columns[1].ReadOnly = true;
            gunaDataGridView2.Columns[2].HeaderText = "Distance";
            gunaDataGridView2.Columns[2].ReadOnly = true;
            gunaDataGridView2.Columns[3].HeaderText = "Regular Fare";
            gunaDataGridView2.Columns[3].ReadOnly = true;
            gunaDataGridView2.Columns[4].HeaderText = "Discounted Fare";
            gunaDataGridView2.Columns[4].ReadOnly = true;

            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.Items.AddRange("Update", "View", "Delete");
            comboBoxColumn.Name = "Action";
            comboBoxColumn.HeaderText = "Action";
            comboBoxColumn.ValueType = typeof(String);
            gunaDataGridView2.Columns.Add(comboBoxColumn);





            /*
                        // Reset Table
                          if (gunaDataGridView2.Columns.Contains("Action"))
                          {
                              dormerTableView.Columns["Action"].Visible = false;
                              dormerTableView.Columns.Remove("Action");
                          }

                        //   gunaDataGridView2.DataSource = null;
                        //   List<User> u2 = null;
                        //   if (n == 60)
                        //      u2 = users.GetRange(0, users.Count);
                        //  else
                        //      u2 = users.GetRange(0, n);

                        //users -> ToList of users
                        //u2 = copied users depending sa range
                        // Set up Table Style
                        //   dormerTableView.DataSource = u2;
                        gunaDataGridView2.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
                        gunaDataGridView2.DefaultCellStyle.ForeColor = Color.Black;
                        gunaDataGridView2.AllowUserToResizeRows = false;
                        gunaDataGridView2.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
                        gunaDataGridView2.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(40, 167, 69);
                        gunaDataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
                        gunaDataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        gunaDataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        gunaDataGridView2.RowTemplate.Height = 40;
                     //   gunaDataGridView2.Columns["Barangay Name"].Visible = false;
                      //  gunaDataGridView2.Columns["Distance"].Visible = false;
                      //  gunaDataGridView2.Columns["Regular Fare"].Visible = false;
                     //   gunaDataGridView2.Columns["Special Fare"].Visible = false;
                      //  gunaDataGridView2.Columns["Date Last Changed"].Visible = false;
                        gunaDataGridView2.Columns[0].Width = 30;

                            // Add Action Column
                        DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
                        comboBoxColumn.Items.AddRange("Update", "View", "Delete");
                        comboBoxColumn.Name = "Action";
                        comboBoxColumn.HeaderText = "Action";
                        comboBoxColumn.ValueType = typeof(String);
                        gunaDataGridView2.Columns.Add(comboBoxColumn);
                      //     gunaDataGridView2.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(gunaDataGridView2_EditingControlShowing);


                        // Set up Column Header
                     /*   gunaDataGridView2.Columns["BarangayName"].HeaderText = "Barangay Name";
                        gunaDataGridView2.Columns["Distance"].HeaderText = "Distance";
                        gunaDataGridView2.Columns["RegularFare"].HeaderText = "Regular Fare";
                        gunaDataGridView2.Columns["SpecialFare"].HeaderText = "Special Fare";
                        gunaDataGridView2.Columns["Email"].HeaderText = "Email";
                        gunaDataGridView2.Columns["DateLastChanged"].HeaderText = "Date Last Changed";
                     */
            con.Close();


        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            if (addRoute_isOpen == false)
            {
                AddRouteForm addroutefrm = new AddRouteForm();
                addroutefrm.Show();
            }
            addRoute_isOpen = true;
        }

        
    }
}
