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

namespace AppDev_System
{
    public partial class EditRouteForm : Form
    {
        public int rowNumber {get; set;}
        public EditRouteForm()
        {
            InitializeComponent();
        }

        public void setrowNumber(int ev_passed)
        {
            this.rowNumber = ev_passed + 1;
            this.Row_Num.Text = (this.rowNumber).ToString();
        }

        private void Edit_brgy_textBox_Enter(object sender, EventArgs e)
        {
            if (Edit_brgy_textBox.Text == "Input Brgy.")
            {
                Edit_brgy_textBox.Text = "";
                Edit_brgy_textBox.ForeColor = Color.Black;
            }
        }

        private void Edit_brgy_textBox_Leave(object sender, EventArgs e)
        {
            if (Edit_brgy_textBox.Text == "")
            {
                Edit_brgy_textBox.Text = "Input Brgy.";
                Edit_brgy_textBox.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void Edit_Dist_textBox_Enter(object sender, EventArgs e)
        {
            if (Edit_Dist_textBox.Text == "Input Distance")
            {
                Edit_Dist_textBox.Text = "";
                Edit_Dist_textBox.ForeColor = Color.Black;
            }
        }

        private void Edit_Dist_textBox_Leave(object sender, EventArgs e)
        {
            if (Edit_Dist_textBox.Text == "")
            {
                Edit_Dist_textBox.Text = "Input Distance";
                Edit_Dist_textBox.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void Edit_RegularFee_textBox_Enter(object sender, EventArgs e)
        {
            if (Edit_RegularFee_textBox.Text == "Input in Pesos")
            {
                Edit_RegularFee_textBox.Text = "";
                Edit_RegularFee_textBox.ForeColor = Color.Black;
            }
        }

        private void Edit_RegularFee_textBox_Leave(object sender, EventArgs e)
        {
            if (Edit_RegularFee_textBox.Text == "")
            {
                Edit_RegularFee_textBox.Text = "Input in Pesos";
                Edit_RegularFee_textBox.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void Edit_SpecialFee_textBox_Enter(object sender, EventArgs e)
        {
            if (Edit_SpecialFee_textBox.Text == "Input in Pesos")
            {
                Edit_SpecialFee_textBox.Text = "";
                Edit_SpecialFee_textBox.ForeColor = Color.Black;
            }
        }

        private void Edit_SpecialFee_textBox_Leave(object sender, EventArgs e)
        {
            if (Edit_SpecialFee_textBox.Text == "")
            {
                Edit_SpecialFee_textBox.Text = "Input in Pesos";
                Edit_SpecialFee_textBox.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }
    }
}
