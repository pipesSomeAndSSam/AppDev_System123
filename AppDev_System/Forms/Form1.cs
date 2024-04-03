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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AppDev_System
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void gunaLOGINAdvenceButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem");
            MySqlDataAdapter adapter;
            DataTable table = new DataTable();

            adapter = new MySqlDataAdapter("Select * From users where email = '" + gunaUsernameTextBox.Text + "' and password = '" + gunaPasswordTextBox.Text + "'", con);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.setforms1Email(gunaUsernameTextBox.Text);
                dashboard.Show();
                Visible = false;
            }
            else
                MessageBox.Show("email or password wrong");
            
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            
            //this is gunaLOGINButton2_Click lmao
            gunaLOGINPanel.Show();
            gunaREGISTERPanel.Hide();
        }

        private void gunaCreateAccountAdvenceButton_Click(object sender, EventArgs e)
        {
            gunaREGISTERPanel.Show();
            gunaLOGINPanel.Hide();
        }

        private void gunaRegisterAdvenceButton2_Click(object sender, EventArgs e) //REGISTER INPUT SA DATA TO DATABASE
        {
            User user = new User(gunaTextBox2.Text, gunaUsernameTextBox2.Text, gunaPasswordTextBox2.Text, gunaTextBox1.Text);
            bool res = user.createUser();

            if (res == true)
            {
                gunaLOGINPanel.Show();
                gunaREGISTERPanel.Hide();
            }
            //}
        }

        private void gunaUsernameTextBox2_Enter(object sender, EventArgs e)
        {
            if(gunaUsernameTextBox2.Text == "Email")
            {
                gunaUsernameTextBox2.Text = "";
                gunaUsernameTextBox2.ForeColor = Color.Black;
            }
        }

        private void gunaUsernameTextBox2_Leave(object sender, EventArgs e)
        {
            if (gunaUsernameTextBox2.Text == "")
            {
                gunaUsernameTextBox2.Text = "Email";
                gunaUsernameTextBox2.ForeColor = Color.FromArgb(64,64,64);
            }
        }

        private void gunaPasswordTextBox2_Enter(object sender, EventArgs e)
        {
            if (gunaPasswordTextBox2.Text == "Set Password")
            {
                gunaPasswordTextBox2.Text = "";
                gunaPasswordTextBox2.ForeColor = Color.Black;
            }
        }

        private void gunaPasswordTextBox2_Leave(object sender, EventArgs e)
        {
            if (gunaPasswordTextBox2.Text == "")
            {
                gunaPasswordTextBox2.Text = "Set Password";
                gunaPasswordTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void gunaTextBox2_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox2.Text == "Username")
            {
                gunaTextBox2.Text = "";
                gunaTextBox2.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox2_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox2.Text == "")
            {
                gunaTextBox2.Text = "Username";
                gunaTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void gunaTextBox1_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "Number")
            {
                gunaTextBox1.Text = "";
                gunaTextBox1.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox1_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "")
            {
                gunaTextBox1.Text = "Number";
                gunaTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void gunaUsernameTextBox_Enter(object sender, EventArgs e)
        {

            if (gunaUsernameTextBox.Text == "Email")
            {
                gunaUsernameTextBox.Text = "";
                gunaUsernameTextBox.ForeColor = Color.Black;
            }
        }

        private void gunaUsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (gunaUsernameTextBox.Text == "")
            {
                gunaUsernameTextBox.Text = "Email";
                gunaUsernameTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void gunaPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (gunaPasswordTextBox.Text == "Password" && gunaCheckBox1.Checked == false)
            {
                gunaPasswordTextBox.Text = "";
                gunaPasswordTextBox.UseSystemPasswordChar = true;
                gunaPasswordTextBox.ForeColor = Color.Black;
            }
            else if (gunaPasswordTextBox.Text == "Password" && gunaCheckBox1.Checked == true)
            {
                gunaPasswordTextBox.Text = "";
                gunaPasswordTextBox.UseSystemPasswordChar = false;
                gunaPasswordTextBox.ForeColor = Color.Black;
            }
        }

        private void gunaPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (gunaPasswordTextBox.Text == "")
            {
                gunaPasswordTextBox.Text = "Password";
                gunaPasswordTextBox.UseSystemPasswordChar = false;
                gunaPasswordTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(gunaCheckBox1.Checked == false && gunaPasswordTextBox.Text != "Password")
            {
                gunaPasswordTextBox.UseSystemPasswordChar = true;
            }
            else if(gunaCheckBox1.Checked == true || gunaPasswordTextBox.Text == "Password")
            {
                gunaPasswordTextBox.UseSystemPasswordChar = false;
            }
        }
    }
}
