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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void setPasswordButton_Click(object sender, EventArgs e)
        {
            if (oldPasswordTextbox.Text != WebsiteBlocker.Properties.Settings.Default.password)
            {
                MessageBox.Show("Old Password does not match records");
                return;
            }

                if (oldPasswordTextbox.Text == WebsiteBlocker.Properties.Settings.Default.password)
            {
                WebsiteBlocker.Properties.Settings.Default.password = newPasswordTextbox.Text;
            }

            DialogResult result;
            result =  MessageBox.Show("Saved New Password!", "Saved!", MessageBoxButtons.OK);
           if(result == DialogResult.OK)
            {
                this.Close();
            }
            
        }
    }
}
