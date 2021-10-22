
namespace WebsiteBlocker
{
    partial class TimerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.setButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Time (mins)";
            // 
            // timeComboBox
            // 
            this.timeComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Items.AddRange(new object[] {
            "5",
            "15",
            "30",
            "60"});
            this.timeComboBox.Location = new System.Drawing.Point(85, 113);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(121, 31);
            this.timeComboBox.TabIndex = 4;
            // 
            // setButton
            // 
            this.setButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.setButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.setButton.Location = new System.Drawing.Point(224, 112);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(78, 32);
            this.setButton.TabIndex = 3;
            this.setButton.Text = "Set Timer";
            this.setButton.UseVisualStyleBackColor = false;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(379, 223);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeComboBox);
            this.Controls.Add(this.setButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimerForm";
            this.Text = "Set Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.Button setButton;
    }
}