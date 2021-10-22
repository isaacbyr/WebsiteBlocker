using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebsiteBlocker
{
    public partial class TimerRunningForm : Form
    {
        public TimerRunningForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(adminPasswordTextbox.Text == WebsiteBlocker.Properties.Settings.Default.password)
            {
                this.Close();
            }
            else if(adminPasswordTextbox.Text == WebsiteBlocker.Properties.Settings.Default.password)
            {
                MessageBox.Show("Incorrect Password");
                return;
            }
        }
    }
}
