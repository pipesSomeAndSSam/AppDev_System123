using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace AppDev_System.Forms
{
    public partial class EditAccountForm : Form
    {
        private const string PhilippineMobilePattern = @"^(09|\+639)\d{9}$";
        MySqlConnection con = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem");
        public string email {  get; set; }
        Query q = new Query();
        public EditAccountForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Size = new System.Drawing.Size(642- 161, 505 - 120);
        }
        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public void setEmail(string email)
        {    
            this.email = email;
            User user = q.get_userDetails(email);
            if (user != null)
            {
                name_textBox.Text = user.user_name;
                email_textBox.Text = user.email;
            }
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
                if (IsValidEmail(email_textBox.Text) )
                {
                    string input = Edit_Num.Text.Trim();
                    bool isValid = Regex.IsMatch(input, PhilippineMobilePattern);

                    if (isValid)
                    {
                        // User user = new User(name_textBox.Text, email_textBox.Text, password_textBox.Text, gunaTextBox1.Text);
                        User user = new User(name_textBox.Text, email_textBox.Text, password_textBox.Text, Edit_Num.Text);
                        user.editIUser(this.email);
                        /*
                        try
                        {
                            con.Open();
                            MySqlCommand command = new MySqlCommand("", con);
                            command.CommandText = "UPDATE users SET user_image = '@user_image' WHERE email = '" + email_textBox.Text + "';";
                            byte[] data = ImageToByteArray(picture.Image);
                            MySqlParameter blob = new MySqlParameter("@user_image", MySqlDbType.LongBlob, data.Length);
                            blob.Value = data;

                            command.Parameters.Add(blob);

                            command.ExecuteNonQuery();
                            con.Close();
                            //MessageBox.Show("Nice!");

                            this.Size = new Size(642 - 161, 530 - 75);
                        }
                        catch
                        {
                            MessageBox.Show("No!");
                        }
                        */
                        this.Size = new Size(642 - 161, 505 - 75);
                    }
                    else
                    {
                        this.ActiveControl = null;
                        Edit_Num.Text = "Need Valid Number";
                        Edit_Num.ForeColor = Color.FromArgb(64, 64, 64);
                        Edit_Num.BorderColor = Color.Red;
                    }
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
        /*
        private void editPic_button_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picture.Image = new Bitmap(openFileDialog.FileName);
                }
            }
            catch 
            {
                MessageBox.Show("please select appropriate file");
            }
        }
        */

        private void Edit_Num_Enter(object sender, EventArgs e)
        {
            Edit_Num.BorderColor = Color.LightGray;
            if (Edit_Num.Text == "Enter Num" || Edit_Num.Text == "Need Valid Number")
            {
                Edit_Num.Text = "";
                Edit_Num.ForeColor = Color.Black;
            }
        }

        private void Edit_Num_Leave(object sender, EventArgs e)
        {
            if (Edit_Num.Text == "")
            {
                Edit_Num.Text = "Enter Num";
                Edit_Num.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }
        
    }
}
