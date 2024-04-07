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

namespace AppDev_System.UserControls
{
    public partial class UserControl_Booking : UserControl
    {
        MySqlConnection con = new MySqlConnection("server= localhost ;uid=root;pwd=PeCoMaRuSuiSoAmKro123123;database=managementsystem");
        public UserControl_Booking()
        {
            InitializeComponent();
            customizeGridView();
        }

        private void customizeGridView()
        {

        }
    }
}
