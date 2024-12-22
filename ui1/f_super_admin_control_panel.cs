using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ui1
{
    public partial class f_super_admin_control_panel : Form
    {
        public f_super_admin_control_panel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f_menu_master menu = new f_menu_master();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f_user_menu_mapped umm = new f_user_menu_mapped();
            umm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f_user_event_mapped eventmapped = new f_user_event_mapped();
            eventmapped.Show();
        }

        private void b_user_event_master_Click(object sender, EventArgs e)
        {
            f_event_master eventmaster = new f_event_master();
            eventmaster.Show();
            
        }
    }
}
