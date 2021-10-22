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
    public partial class TimerRunningForm : Form
    {

        public bool AdminPasswordEntered { get; set; } = false;

        public TimerRunningForm()
        {
            InitializeComponent();

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = TimerForm.Time * 60000;
            timer.Tick += new EventHandler(OnTimeEvent);
            timer.Enabled = true;
            timer.Start();

        }

        private void OnTimeEvent(object sender, EventArgs e)
        {
            if(AdminPasswordEntered == false)
            {
                MessageBox.Show("Timer Ended");
            }
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(adminPasswordTextbox.Text == WebsiteBlocker.Properties.Settings.Default.password)
            {
                AdminPasswordEntered = true;
                this.Close();
            }
            else if(adminPasswordTextbox.Text == WebsiteBlocker.Properties.Settings.Default.password)
            {
                MessageBox.Show("Incorrect Password");
                return;
            }
        }

        private void TimerRunningForm_Load(object sender, EventArgs e)
        {
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
