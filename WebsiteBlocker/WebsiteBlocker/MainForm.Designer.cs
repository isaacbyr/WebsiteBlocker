
namespace WebsiteBlocker
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.timerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.unblockButon = new System.Windows.Forms.Button();
            this.blockButton = new System.Windows.Forms.Button();
            this.websiteTextbox = new System.Windows.Forms.TextBox();
            this.websitesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // timerButton
            // 
            this.timerButton.BackColor = System.Drawing.Color.Orange;
            this.timerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timerButton.ForeColor = System.Drawing.SystemColors.Window;
            this.timerButton.Location = new System.Drawing.Point(402, 324);
            this.timerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timerButton.Name = "timerButton";
            this.timerButton.Size = new System.Drawing.Size(95, 33);
            this.timerButton.TabIndex = 15;
            this.timerButton.Text = "Set Timer";
            this.timerButton.UseVisualStyleBackColor = false;
            this.timerButton.Click += new System.EventHandler(this.timerButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Blocked Websites";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.ForeColor = System.Drawing.SystemColors.Window;
            this.saveButton.Location = new System.Drawing.Point(402, 367);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(95, 33);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter Website";
            // 
            // unblockButon
            // 
            this.unblockButon.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.unblockButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.unblockButon.ForeColor = System.Drawing.SystemColors.Window;
            this.unblockButon.Location = new System.Drawing.Point(402, 156);
            this.unblockButon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unblockButon.Name = "unblockButon";
            this.unblockButon.Size = new System.Drawing.Size(95, 33);
            this.unblockButon.TabIndex = 11;
            this.unblockButon.Text = "Unblock";
            this.unblockButon.UseVisualStyleBackColor = false;
            this.unblockButon.Click += new System.EventHandler(this.unblockButon_Click);
            // 
            // blockButton
            // 
            this.blockButton.BackColor = System.Drawing.Color.LightCoral;
            this.blockButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.blockButton.ForeColor = System.Drawing.SystemColors.Window;
            this.blockButton.Location = new System.Drawing.Point(402, 63);
            this.blockButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blockButton.Name = "blockButton";
            this.blockButton.Size = new System.Drawing.Size(95, 33);
            this.blockButton.TabIndex = 10;
            this.blockButton.Text = "Block";
            this.blockButton.UseVisualStyleBackColor = false;
            this.blockButton.Click += new System.EventHandler(this.blockButton_Click);
            // 
            // websiteTextbox
            // 
            this.websiteTextbox.Location = new System.Drawing.Point(59, 63);
            this.websiteTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.websiteTextbox.Name = "websiteTextbox";
            this.websiteTextbox.Size = new System.Drawing.Size(292, 27);
            this.websiteTextbox.TabIndex = 9;
            // 
            // websitesListBox
            // 
            this.websitesListBox.FormattingEnabled = true;
            this.websitesListBox.ItemHeight = 20;
            this.websitesListBox.Location = new System.Drawing.Point(59, 156);
            this.websitesListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.websitesListBox.MultiColumn = true;
            this.websitesListBox.Name = "websitesListBox";
            this.websitesListBox.Size = new System.Drawing.Size(292, 244);
            this.websitesListBox.TabIndex = 8;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(556, 440);
            this.Controls.Add(this.timerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unblockButon);
            this.Controls.Add(this.blockButton);
            this.Controls.Add(this.websiteTextbox);
            this.Controls.Add(this.websitesListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mainForm";
            this.Text = "Website Blocker";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button timerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button unblockButon;
        private System.Windows.Forms.Button blockButton;
        private System.Windows.Forms.TextBox websiteTextbox;
        public System.Windows.Forms.ListBox websitesListBox;
    }
}

