using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WebsiteBlocker
{
    public partial class TimerForm : Form
    {

        public static int Time { get; set; }

        public TimerForm()
        {
            InitializeComponent();
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            int time;
            int.TryParse(timeComboBox.Text, out time);
            Time = time;
            MessageBox.Show("Timer Started!");
            this.Close();
            
        }

    }
}
