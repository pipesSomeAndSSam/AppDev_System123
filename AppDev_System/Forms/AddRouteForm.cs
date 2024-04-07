using AppDev_System.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDev_System
{
    public partial class AddRouteForm : Form
    {
        public AddRouteForm()
        {
            InitializeComponent();
        }

        private void gunaTextBox1_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "Choose Brgy.")
            {
                gunaTextBox1.Text = "";
                gunaTextBox1.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox1_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "")
            {
                gunaTextBox1.Text = "Choose Brgy.";
                gunaTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void gunaTextBox2_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox2.Text == "Input Distance")
            {
                gunaTextBox2.Text = "";
                gunaTextBox2.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox2_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox2.Text == "")
            {
                gunaTextBox2.Text = "Input Distance";
                gunaTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void gunaTextBox3_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox3.Text == "In Pesos")
            {
                gunaTextBox3.Text = "";
                gunaTextBox3.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox3_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox3.Text == "")
            {
                gunaTextBox3.Text = "In Pesos";
                gunaTextBox3.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void gunaTextBox4_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox4.Text == "In Pesos")
            {
                gunaTextBox4.Text = "";
                gunaTextBox4.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox4_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox4.Text == "")
            {
                gunaTextBox4.Text = "In Pesos";
                gunaTextBox4.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }
        private void SubmitButtonRoute_Click(object sender, EventArgs e)
        {
            try
            {
                if ((gunaTextBox1.Text != "Choose Brgy." && gunaTextBox1.Text != "")
                    && (gunaTextBox2.Text != "Input Distance" && gunaTextBox2.Text != "") 
                    && (gunaTextBox3.Text != "In Pesos" && gunaTextBox3.Text != "") 
                    && (gunaTextBox4.Text != "In Pesos" && gunaTextBox4.Text != ""))
                {
                    float route_distance = float.Parse(gunaTextBox2.Text);
                    float route_regular_fare = float.Parse(gunaTextBox3.Text);
                    float route_special_fare = float.Parse(gunaTextBox4.Text);

                    Routes routes = new Routes(gunaTextBox1.Text, route_distance, route_regular_fare, route_special_fare);
                    routes.createRoute();
                }
            }
            catch
            {
                MessageBox.Show("Incorrect Input");
            }
        }
    }
}
