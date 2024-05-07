using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppDev_System.UserControls
{
    public partial class UserControl_editAcc : UserControl
    {
        public string email {  get; set; }
        User user = null;
        Query q = new Query();

        public UserControl_editAcc()
        {
            InitializeComponent();
            user = q.get_userDetails(email);
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

        private void esc_button_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void editPic_button_Click(object sender, EventArgs e)
        {

        }

        private void name_textBox_Enter(object sender, EventArgs e)
        {
            if (name_textBox.Text == "Edit Name")
            {
                name_textBox.Text = "";
                name_textBox.ForeColor = Color.Black;
            }
        }

        private void name_textBox_Leave(object sender, EventArgs e)
        {
            if (name_textBox.Text == "")
            {
                name_textBox.Text = "Edit Name";
                name_textBox.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void email_textBox_Enter(object sender, EventArgs e)
        {
            email_textBox.BorderColor = Color.LightGray;
            if (email_textBox.Text == "Edit Email" || email_textBox.Text == "Please Input a Valid Email")
            {
                email_textBox.Text = "";
                email_textBox.ForeColor = Color.Black;
            }
        }

        private void email_textBox_Leave(object sender, EventArgs e)
        {
            if (email_textBox.Text == "")
            {
                email_textBox.Text = "Edit Email";
                email_textBox.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void password_textBox_Enter(object sender, EventArgs e)
        {
            password_textBox.BorderColor = Color.LightGray;
            if ((password_textBox.Text == "Edit Password" || password_textBox.Text == "Please Set Password Again") && password_CheckBox.Checked == false)
            {
                password_textBox.Text = "";
                password_textBox.UseSystemPasswordChar = true;
                password_textBox.ForeColor = Color.Black;
            }
            else if ((password_textBox.Text == "Edit Password" || password_textBox.Text == "Please Set Password Again") && password_CheckBox.Checked == true)
            {
                password_textBox.Text = "";
                password_textBox.UseSystemPasswordChar = false;
                password_textBox.ForeColor = Color.Black;
            }
        }

        private void password_textBox_Leave(object sender, EventArgs e)
        {
            if (password_textBox.Text == "")
            {
                password_textBox.Text = "Edit Password";
                password_textBox.UseSystemPasswordChar = false;
                password_textBox.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void gunaTextBox1_Enter(object sender, EventArgs e)
        {
            if ((gunaTextBox1.Text == "Re-Enter Password") && password_CheckBox.Checked == false)
            {
                gunaTextBox1.Text = "";
                gunaTextBox1.UseSystemPasswordChar = true;
                gunaTextBox1.ForeColor = Color.Black;
            }
            else if ((gunaTextBox1.Text == "Re-Enter Password") && password_CheckBox.Checked == true)
            {
                gunaTextBox1.Text = "";
                gunaTextBox1.UseSystemPasswordChar = false;
                gunaTextBox1.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox1_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "")
            {
                gunaTextBox1.Text = "Re-Enter Password";
                gunaTextBox1.UseSystemPasswordChar = false;
                gunaTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void password_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((password_CheckBox.Checked == false && password_textBox.Text != "Edit Password") && (password_CheckBox.Checked == false && password_textBox.Text != "Please Set Password Again")) && gunaTextBox1.Text == "Re-Enter Password")
            {

                password_textBox.UseSystemPasswordChar = true;
                //MessageBox.Show("1");
            }
            else if (((password_CheckBox.Checked == false && password_textBox.Text == "Please Set Password Again") && (password_CheckBox.Checked == false && password_textBox.Text == "Edit Password")) && gunaTextBox1.Text == "Re-Enter Password")
            {

                password_textBox.UseSystemPasswordChar = false;
                //MessageBox.Show("2");
            }
            else if ((password_CheckBox.Checked == false && password_textBox.Text != "Edit Password") && gunaTextBox1.Text != "Re-Enter Password")
            {

                password_textBox.UseSystemPasswordChar = true;
                gunaTextBox1.UseSystemPasswordChar = true;
                //MessageBox.Show("3");
            }
            else if ((password_CheckBox.Checked == false && password_textBox.Text == "Edit Password") && gunaTextBox1.Text != "Re-Enter Password")
            {

                password_textBox.UseSystemPasswordChar = false;
                gunaTextBox1.UseSystemPasswordChar = true;
                //MessageBox.Show("4");
            }
            else if (password_CheckBox.Checked == true || password_textBox.Text == "Edit Password")
            {

                password_textBox.UseSystemPasswordChar = false;
                gunaTextBox1.UseSystemPasswordChar = false;
                //MessageBox.Show("5");
            }
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            if (password_textBox.Text == gunaTextBox1.Text)
            {
                if (IsValidEmail(email_textBox.Text)) 
                {
                   // User user = new User(name_textBox.Text, email_textBox.Text, password_textBox.Text, gunaTextBox1.Text);
                    


                }
                else
                {
                    this.ActiveControl = null;
                    email_textBox.Text = "Please Input a Valid Email";
                    email_textBox.ForeColor = Color.FromArgb(64, 64, 64);
                    email_textBox.BorderColor = Color.Red;
                }
            }
            else
            {
                this.ActiveControl = null;
                gunaTextBox1.Text = "Re-Enter Password";
                gunaTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
                password_textBox.Text = "Please Set Password Again";
                password_textBox.ForeColor = Color.FromArgb(64, 64, 64);
                password_textBox.BorderColor = Color.Red;
                password_textBox.UseSystemPasswordChar = false;
                gunaTextBox1.UseSystemPasswordChar = false;
            }
        }
    }
}
