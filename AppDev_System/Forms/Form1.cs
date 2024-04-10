using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AppDev_System
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }
        bool IsValidEmail(string eMail)
        {
            bool Result = false;

            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(eMail);

                Result = (eMail.LastIndexOf(".") > eMail.LastIndexOf("@"));
            }
            catch
            {
                Result = false;
            };

            return Result;
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
            this.ActiveControl = null;
            gunaUsernameTextBox.Text = "Email";
            gunaUsernameTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            gunaPasswordTextBox.Text = "Password";
            gunaPasswordTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            gunaPasswordTextBox.UseSystemPasswordChar = false;
            gunaCheckBox1.Checked = false;
            gunaPasswordTextBox2.BorderColor = Color.LightGray;

            //this is gunaLOGINButton2_Click lmao
            gunaLOGINPanel.Show();
            gunaREGISTERPanel.Hide();
        }

        private void gunaCreateAccountAdvenceButton_Click(object sender, EventArgs e)
        {
            if (gunaCheckBox2.Checked == true)
            {
                gunaCheckBox2.Checked = false;
               INPUT_PASSS_AGAIN.UseSystemPasswordChar = false;
                gunaPasswordTextBox2.UseSystemPasswordChar = false;
            }

            gunaUsernameTextBox2.Text = "Email";
            gunaUsernameTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            gunaPasswordTextBox2.Text = "Set Password";
            gunaPasswordTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            INPUT_PASSS_AGAIN.Text = "Input Password Again";
            INPUT_PASSS_AGAIN.ForeColor = Color.FromArgb(64, 64, 64);
            gunaTextBox2.Text = "Username";
            gunaTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            gunaTextBox1.Text = "Number";
            gunaTextBox1.ForeColor = Color.FromArgb(64, 64, 64);

            gunaREGISTERPanel.Show();
            gunaLOGINPanel.Hide();
        }

        private void gunaRegisterAdvenceButton2_Click(object sender, EventArgs e) //REGISTER INPUT SA DATA TO DATABASE
        {
            if(gunaPasswordTextBox2.Text == INPUT_PASSS_AGAIN.Text)
            {
                if (IsValidEmail(gunaUsernameTextBox2.Text))
                {
                    User user = new User(gunaTextBox2.Text, gunaUsernameTextBox2.Text, gunaPasswordTextBox2.Text, gunaTextBox1.Text);
                    bool res = user.createUser();

                    if (res == true)
                    {
                        gunaLOGINPanel.Show();
                        gunaREGISTERPanel.Hide();
                    }
                }
                else
                {
                    this.ActiveControl = null;
                    gunaUsernameTextBox2.Text = "Please Input a Valid Email";
                    gunaUsernameTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
                    gunaUsernameTextBox2.BorderColor = Color.Red;
                }
            }
            else
            {
                this.ActiveControl = null;
                INPUT_PASSS_AGAIN.Text = "Input Password Again";
                INPUT_PASSS_AGAIN.ForeColor = Color.FromArgb(64, 64, 64);
                gunaPasswordTextBox2.Text = "Please Set Password Again";
                gunaPasswordTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
                gunaPasswordTextBox2.BorderColor = Color.Red;
            }
        }

        private void gunaUsernameTextBox2_Enter(object sender, EventArgs e)
        {
            gunaUsernameTextBox2.BorderColor = Color.LightGray;
            if (gunaUsernameTextBox2.Text == "Email" || gunaUsernameTextBox2.Text == "Please Input a Valid Email")
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
            gunaPasswordTextBox2.BorderColor = Color.LightGray;
            if ((gunaPasswordTextBox2.Text == "Set Password" || gunaPasswordTextBox2.Text == "Please Set Password Again") && gunaCheckBox2.Checked == false)
            {
                gunaPasswordTextBox2.Text = "";
                gunaPasswordTextBox2.UseSystemPasswordChar = true;
                gunaPasswordTextBox2.ForeColor = Color.Black;
            }
            else if ((gunaPasswordTextBox2.Text == "Set Password" || gunaPasswordTextBox2.Text == "Please Set Password Again") && gunaCheckBox2.Checked == true)
            {
                gunaPasswordTextBox2.Text = "";
                gunaPasswordTextBox2.UseSystemPasswordChar = false;
                gunaPasswordTextBox2.ForeColor = Color.Black;
            }
            
        }

        private void gunaPasswordTextBox2_Leave(object sender, EventArgs e)
        {
            if (gunaPasswordTextBox2.Text == "")
            {
                gunaPasswordTextBox2.Text = "Set Password";
                gunaPasswordTextBox2.UseSystemPasswordChar = false;
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

        private void INPUT_PASSS_AGAIN_Leave(object sender, EventArgs e)
        {
            if (INPUT_PASSS_AGAIN.Text == "")
            {
                INPUT_PASSS_AGAIN.Text = "Input Password Again";
                INPUT_PASSS_AGAIN.UseSystemPasswordChar = false;
                INPUT_PASSS_AGAIN.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void INPUT_PASSS_AGAIN_Enter(object sender, EventArgs e)
        {
            if ((INPUT_PASSS_AGAIN.Text == "Input Password Again") && gunaCheckBox2.Checked == false)
            {
                INPUT_PASSS_AGAIN.Text = "";
                INPUT_PASSS_AGAIN.UseSystemPasswordChar = true;
                INPUT_PASSS_AGAIN.ForeColor = Color.Black;
            }
            else if ((INPUT_PASSS_AGAIN.Text == "Input Password Again") && gunaCheckBox2.Checked == true)
            {
                INPUT_PASSS_AGAIN.Text = "";
                INPUT_PASSS_AGAIN.UseSystemPasswordChar = false;
                INPUT_PASSS_AGAIN.ForeColor = Color.Black;
            }
        }

        private void gunaCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if ((gunaCheckBox2.Checked == false && gunaPasswordTextBox2.Text != "Set Password") && INPUT_PASSS_AGAIN.Text == "Input Password Again")
            {
                gunaPasswordTextBox2.UseSystemPasswordChar = true;
            }
            else if ((gunaCheckBox2.Checked == false && gunaPasswordTextBox2.Text != "Set Password") && INPUT_PASSS_AGAIN.Text != "Input Password Again")
            {
                gunaPasswordTextBox2.UseSystemPasswordChar = true;
                INPUT_PASSS_AGAIN.UseSystemPasswordChar = true;
            }
            else if ((gunaCheckBox2.Checked == false && gunaPasswordTextBox2.Text == "Set Password") && INPUT_PASSS_AGAIN.Text != "Input Password Again")
            {
                gunaPasswordTextBox2.UseSystemPasswordChar = false;
                INPUT_PASSS_AGAIN.UseSystemPasswordChar = true;
            }
            else if (gunaCheckBox2.Checked == true || gunaPasswordTextBox2.Text == "Set Password")
            {
                gunaPasswordTextBox2.UseSystemPasswordChar = false;
                INPUT_PASSS_AGAIN.UseSystemPasswordChar = false;
            }
        }
    }
}
