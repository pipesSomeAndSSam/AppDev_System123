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
    public partial class greyPanel : UserControl
    {
        public greyPanel()
        {
            InitializeComponent();
            base.CreateParams.ExStyle |= 0x20;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            BackColor = Color.FromArgb(0x80, 0xFF, 0xCC, 0x33);
        }
    }
}
