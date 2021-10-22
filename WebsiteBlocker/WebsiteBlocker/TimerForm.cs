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

        public System.Timers.Timer timer { get; set; } = new System.Timers.Timer();
        public static DateTime StartTime { get; set; }
        public static bool TimerOn { get; set; } = false;


        public TimerForm()
        {
            InitializeComponent();
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            TimerOn = true;
            int time;
            int.TryParse(timeComboBox.Text, out time);
            timer.Interval = time * 1000;
            timer.Elapsed += new ElapsedEventHandler(OnTimeEvent);
            timer.Enabled = true;
            timer.Start();
            StartTime = DateTime.Now;
            MessageBox.Show("Timer Started!");
            this.Close();
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            MessageBox.Show("Timer Ended");
            timer.Stop();
            TimerOn = false;
        }
    }
}
