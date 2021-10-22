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
    public partial class SetPasswordForm : Form
    {
        public SetPasswordForm()
        {
            InitializeComponent();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var infoForm = new InfoForm();
            infoForm.ShowDialog();
        }

        private void setPasswordButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(passwordTextbox.Text))
                {
                    MessageBox.Show("Enter Valid Password");
                }
                else
                {
                    WebsiteBlocker.Properties.Settings.Default.password = passwordTextbox.Text;
                    MessageBox.Show("Successfully added password", "Added Admin Password");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
