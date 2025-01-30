using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class screen_home : Form
    {
        public screen_home()
        {
            InitializeComponent();
        }

        private void screen_home_Load(object sender, EventArgs e)
        {
            lb_username.Text = user_info.Username;
        }
    }
}
