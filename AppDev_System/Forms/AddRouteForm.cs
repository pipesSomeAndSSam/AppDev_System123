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

        private void SubmitButtonRoute_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
