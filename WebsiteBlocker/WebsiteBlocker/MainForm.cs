using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebsiteBlocker
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            WebsiteBlocker.Properties.Settings.Default.password = "";

            string hostPath = Application.StartupPath + @"\Files\Websites.txt";

            using(StreamReader r = new StreamReader(hostPath))
            {
                string line;
                while((line = r.ReadLine()) != null)
                {
                    websitesListBox.Items.Add(line);
                }
                r.Close();
            }
        }

        private void blockButton_Click(object sender, EventArgs e)
        {
            websitesListBox.Items.Add(websiteTextbox.Text);
            websiteTextbox.ResetText();
        }

        private void unblockButon_Click(object sender, EventArgs e)
        {
            if (websitesListBox.SelectedItem != null)
            {
                websitesListBox.Items.Remove(websitesListBox.SelectedItem);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult response;
            response = MessageBox.Show("Are you sure you don't want to set a timer?","Proceed Without Timer" ,MessageBoxButtons.YesNo);

            if(response == DialogResult.Yes)
            {
                // this method stores the blocked wesbites in a local file
                addLocally();

                // this method adds the blocked wesbites to the /drivers/etc/host file
                addToHost();
            }
            else
            {
                return;
            }
           
        }

        private void addToHost()
        {
            try
            {
                // Run as admin to get acces to file;
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.Verb = "runas";
                startInfo.FileName = Application.ExecutablePath;
                Process.Start(startInfo);

                // get host file dir
                string hostPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts");

                // have locally saved blank host file to overwrite current host file and erase pre-existing blocked websites;
                string localHostPath = Application.StartupPath + @"\Files\hosts.txt";

                using (FileStream stream = File.OpenRead(localHostPath)) 
                using (FileStream writeStream = File.OpenWrite(hostPath))
                {
                    BinaryReader reader = new BinaryReader(stream);
                    BinaryWriter writer = new BinaryWriter(writeStream);

                    // create a buffer to hold the bytes;
                    byte[] buffer = new byte[1024];
                    int bytesRead;

                    // while the read method returns bytes keep writing them to output stream
                    while((bytesRead = stream.Read(buffer, 0, 1024)) > 0)
                    {
                        writeStream.Write(buffer, 0, bytesRead);
                    }
                    stream.Close();
                    writeStream.Close();

                    foreach (var item in websitesListBox.Items)
                    {
                        using (StreamWriter sw = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts")))
                        {
                            sw.WriteLine("127.0.0.1 " + item.ToString());
                        }
                       
                    }

                    MessageBox.Show("Successfully blocked websites!", "Success");
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erorr");
            }
        }

        private void addLocally()
        {
            try
            {
                string hostPath = Application.StartupPath + @"\Files\Websites.txt";

                StreamWriter sw = new StreamWriter(hostPath);

                foreach (var item in websitesListBox.Items)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.Close();
                MessageBox.Show("Saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timerButton_Click(object sender, EventArgs e)
        {
            var timerForm = new TimerForm();
            timerForm.ShowDialog();
            timerButton.Text = "Timer On!";
            timerButton.BackColor = System.Drawing.Color.LightCoral;
        }

        private void setAdminPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var setPasswordForm = new SetPasswordForm();
            setPasswordForm.ShowDialog();
            setAdminPasswordMenuItem.Text = "Change Password";
        }
    }
}
