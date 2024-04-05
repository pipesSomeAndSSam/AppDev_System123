using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDev_System.UserControls
{
    public partial class UserControl1_Dash : UserControl
    {

        public UserControl1_Dash()
        {
            InitializeComponent();

            Query query = new Query();


            gunaLabel8.Text = query.get_total_numOfRoutes();
            label.Text = query.get_total_numOfUsers();

        }

    }
}
