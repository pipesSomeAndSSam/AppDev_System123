using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDev_System.Forms;
using AppDev_System.UserControls;
using Guna.UI.WinForms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Asn1.X509;
using static System.Net.Mime.MediaTypeNames;
using System.Collections;



namespace AppDev_System 
{
    public partial class Dashboard : Form
    {
        public string forms1Email;
        Query q = new Query();
        private int formsId;

        MySqlConnection con = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem");
        private string cccooonnn = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";

        //Controls.Dashboard uc_dashboard = new Controls.Dashboard();

        public Dashboard()
        {
            InitializeComponent();
            userControl1_Dash1.BringToFront();
            setUpDashBoard_Text();
        }
        public void setformsID(int x)
        {
            this.formsId = x;
        }

        /*
        public void SetImageFromByteArray(GunaCirclePictureBox Image_cont, byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
            {
                // Handle the case of empty or null byte array (optional: set default image)
                MessageBox.Show("NULL!!!");
                return;
            }

            try
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                    Image_cont.Image = image;
                }
            }
            catch (ArgumentException ex)
            {
                // Handle the case of invalid image format
               MessageBox.Show("Error setting image: Invalid image format - " + ex.Message);
            }
        }*/

        private string get_onlineEarnings()
        {
            string y = "";
            try
            {
                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();

                string sql_users = "SELECT * FROM managementsystem.users WHERE loggedIn ='" + 1 + "';";

                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);
                MySqlDataReader reader_mult = cmd_users.ExecuteReader();

                while (reader_mult.Read())
                {
                    if (!reader_mult.IsDBNull(5))
                    {
                        y = reader_mult.GetFloat(reader_mult.GetOrdinal("earnings_while_loggedIn")).ToString();
                    }
                    else
                    {
                        y = "0";
                    }
                }
                conConn.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return y;
        }

        private void setUpDashBoard_Text()
        {
            totalBookingsNum.Text = q.get_total_numOfTickets_forToday();
            gunaLabel4.Text = q.get_total_multicabsInQueue();
            gunaLabel5.Text = q.get_total_numOfRoutes();
            gunaLabel7.Text = q.get_total_numOfUsers();
            gunaLabel8.Text = "₱ ";
            gunaLabel8.Text += q.get_total_numOfEarnings_forToday();
            total_num_multicabs.Text = q.get_total_numOfMulticabs();
            monthlyEarnigs.Text = "₱ ";
            monthlyEarnigs.Text += q.getMonthlyEarnings();
            monthlyTicket.Text += q.getMonthlytickets();

           
                monthlyTicket.Text = "Ticketed Passengers this Month: ";
                monthlyTicket.Text += q.getMonthlytickets();
           


           
                onlineEarnings.Text = "Monthly Earnings while online: ₱ ";
                onlineEarnings.Text += get_onlineEarnings();
            

            monthlyTicket.BringToFront();
            totalBookingsNum.BringToFront();
            gunaLabel4.BringToFront();
            gunaLabel5.BringToFront();
            //gunaLabel6.BringToFront();
            gunaLabel7.BringToFront();
            gunaLabel8.BringToFront();
            total_num_multicabs.BringToFront();
            monthlyEarnigs.BringToFront();
            onlineEarnings.BringToFront();
            edit.BringToFront();
        }


        public void setforms1Email(string x)
        {
            this.forms1Email = x;
        }

        public string getForms1Email()
        {
            return forms1Email;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //GET TOTAL NUMBER OF CHU2

            

            //GET USERNAME AND EMAIL IN USERS DATABASEL

            try
            {

                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();

                string sql_users = "SELECT * FROM managementsystem.users WHERE email='"+ forms1Email + "';";

                
                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);

                
                MySqlDataReader reader_users = cmd_users.ExecuteReader();


                string emailEx = "";
                string usernameEx = "";
                //string no_of_routes = "";

                while (reader_users.Read())
                {
                     emailEx = (string)reader_users["email"];
                     usernameEx = (string)reader_users["user_name"];

                }


                userName.Text = usernameEx;
                gunaLabel2.Text = emailEx;
                conConn.Close();

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void LOGOUTButt_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in System.Windows.Forms.Application.OpenForms)
            {
                openForms.Add(f);
            }

            foreach (Form f in openForms)
            {
                if (f.Name != "Dashboard")
                    f.Close();
            }
            if (gunaLabel2?.Text != null)
            {
                // The label is not null and its Text property can be accessed safely
                q.editUser_logout(gunaLabel2.Text);
            }
            
            Form1 frm1 = new Form1();
            frm1.Show();

            this.Visible = false;
        }

        private void MulticabsButton_Click(object sender, EventArgs e)                  //MUTICAB BUTTON
        {
            userControl_Multicabs1.BringToFront();
        }

        private void RoutesButton_Click(object sender, EventArgs e)                  //ROUTES BUTTON
        {
            userControl_Routes.BringToFront();
          //  userControl1_Dash1.Hide();
        }

        private void DashboardButton_Click(object sender, EventArgs e)                  //DASHBOARD BUTTON
        {
            userControl1_Dash1.BringToFront();

            setUpDashBoard_Text();

            // userControl_Routes1.Hide();
        }

        private void BookingsButton_Click(object sender, EventArgs e)                  //TICKETING BUTTON
        {
            userControl_Booking1.BringToFront();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                if (gunaLabel2?.Text != null)
                {
                    // The label is not null and its Text property can be accessed safely
                    q.editUser_logout(gunaLabel2.Text);
                }
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                if (gunaLabel2?.Text != null)
                {
                    // The label is not null and its Text property can be accessed safely
                    q.editUser_logout(gunaLabel2.Text);
                }
                System.Environment.Exit(1);
            }
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {

                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();

                string sql_users = "SELECT * FROM managementsystem.users WHERE id='" + this.formsId + "';";


                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);


                MySqlDataReader reader_users = cmd_users.ExecuteReader();


                string emailEx = "";
                string usernameEx = "";
                byte[] imageData = null;
                //string no_of_routes = "";

                while (reader_users.Read())
                {
                    emailEx = (string)reader_users["email"];
                    usernameEx = (string)reader_users["user_name"];

                    

                    
                    //gunaCirclePictureBox1.Image = 

                }
                /*string query = "SELECT user_image FROM users WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@id", imageId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            if (!reader.IsDBNull(8)) // Check for null image data
                            {
                                byte[] imageData = (byte[])reader[8];
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    gunaCirclePictureBox1.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No image data found for ID: " + imageId);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No record found for ID: " + imageId);
                        }
                    }
                }*/

                userName.Text = usernameEx;

                gunaLabel2.Text = emailEx;
                conConn.Close();
                MessageBox.Show("wa");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void gunaAdvenceButton1_Click_1(object sender, EventArgs e)
        {
            userControl_MultData1.BringToFront();
        }



        private void edit_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in System.Windows.Forms.Application.OpenForms)
            {
                if (f.Text == "EditAccountForm")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                EditAccountForm editAcc = new EditAccountForm();
                editAcc.setEmail(gunaLabel2.Text);
                editAcc.Show();
            }
        }

        private void gunaAdvenceButton2_Click_1(object sender, EventArgs e)
        {
            try
            {

                string conne = "server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem";
                MySqlConnection conConn = new MySqlConnection(conne);
                conConn.Open();

                string sql_users = "SELECT * FROM managementsystem.users WHERE id='" + this.formsId + "';";


                MySqlCommand cmd_users = new MySqlCommand(sql_users, conConn);


                MySqlDataReader reader_users = cmd_users.ExecuteReader();


                string emailEx = "";
                string usernameEx = "";
                byte[] imageData = null;
                //string no_of_routes = "";

                while (reader_users.Read())
                {
                    emailEx = (string)reader_users["email"];
                    usernameEx = (string)reader_users["user_name"];



                    if (!reader_users.IsDBNull(8))
                    {
                        imageData = (byte[])reader_users[8];

                        /*
                     using (var ms = new MemoryStream(imageBytes))
                     {
                         gunaCirclePictureBox1.Image = System.Drawing.Image.FromStream(ms);
                     }*/
                    }
                    //gunaCirclePictureBox1.Image = 

                }
                /*string query = "SELECT user_image FROM users WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@id", imageId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            if (!reader.IsDBNull(8)) // Check for null image data
                            {
                                byte[] imageData = (byte[])reader[8];
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    gunaCirclePictureBox1.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No image data found for ID: " + imageId);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No record found for ID: " + imageId);
                        }
                    }
                }*/

                userName.Text = usernameEx;

                gunaLabel2.Text = emailEx;
                conConn.Close();
                //  MessageBox.Show("wa");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
