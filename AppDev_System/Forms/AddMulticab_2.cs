using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDev_System.Forms
{
    public partial class AddMulticab_2 : Form
    {
        private int where = 0;
        public AddMulticab_2()
        {
            InitializeComponent();
            gunaPanel12.BringToFront();
            setDateLabel.Text = gunaLabel17.Text = DateTime.Now.ToString("yyyy-MM-dd H:m:s");
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void next_Click(object sender, EventArgs e)
        {
            this.where = 1;
            if ((gunaTextBox2.Text == "Input ID" || gunaTextBox2.Text == "") ||
                (gunaTextBox1.Text == "" || gunaTextBox1.Text == "Input Name"))
            {
                MessageBox.Show("Input Required");
            }
            else
            {
                NAME_LABEL.Text = gunaTextBox1.Text;
                ID_LABEL.Text = gunaTextBox2.Text;

                gunaPanel5.BringToFront();

                gunaPanel8.Visible = true;
                gunaPanel4.Visible = false;
                gunaLabel1.ForeColor = Color.Black;
                gunaLabel1.Font = new Font("Segoe UI", 15, FontStyle.Regular);
                gunaLabel2.ForeColor = Color.FromArgb(0, 102, 204);
                gunaLabel2.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            }
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            this.where = 0;

            gunaPanel1.BringToFront();
            gunaPanel12.BringToFront();

            gunaPanel8.Visible = false;
            gunaPanel4.Visible = true;
            gunaLabel2.ForeColor = Color.Black;
            gunaLabel2.Font = new Font("Segoe UI", 15, FontStyle.Regular);
            gunaLabel1.ForeColor = Color.FromArgb(0, 102, 204);
            gunaLabel1.Font = new Font("Segoe UI", 14, FontStyle.Bold);
        }

        private void SUBMIT_BUTTON_Click(object sender, EventArgs e)
        {
            try
            {
                Multicab multicab = new Multicab(ID_LABEL.Text, NAME_LABEL.Text, gunaLabel17.Text, 0, 0);
                multicab.createMulticab();

                gunaPanel1.BringToFront();
                gunaPanel12.BringToFront();

                this.ActiveControl = null;

                gunaPanel8.Visible = false;
                gunaPanel4.Visible = true;
                gunaLabel1.ForeColor = Color.FromArgb(0, 102, 204);
                gunaLabel1.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                gunaLabel2.ForeColor = Color.Black;
                gunaLabel2.Font = new Font("Segoe UI", 15, FontStyle.Regular);

                gunaTextBox1.Text = "Input Name";
                gunaTextBox1.ForeColor = Color.Silver;
                gunaTextBox2.Text = "Input ID";
                gunaTextBox2.ForeColor = Color.Silver;

                this.where = 0;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Wrong Input");
            }
        }

        private void gunaTextBox1_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "Input Name")
            {
                gunaTextBox1.Text = "";
                gunaTextBox1.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox1_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "")
            {
                gunaTextBox1.Text = "Input Name";
                gunaTextBox1.ForeColor = Color.Silver;
            }
        }

        private void gunaTextBox2_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox2.Text == "Input ID")
            {
                gunaTextBox2.Text = "";
                gunaTextBox2.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox2_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox2.Text == "")
            {
                gunaTextBox2.Text = "Input ID";
                gunaTextBox2.ForeColor = Color.Silver;
            }
        }
    }
}
