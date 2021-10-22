
namespace WebsiteBlocker
{
    partial class ChangePasswordForm
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
            this.setPasswordButton = new System.Windows.Forms.Button();
            this.newPasswordTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oldPasswordTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // setPasswordButton
            // 
            this.setPasswordButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.setPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setPasswordButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPasswordButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.setPasswordButton.Location = new System.Drawing.Point(86, 167);
            this.setPasswordButton.Name = "setPasswordButton";
            this.setPasswordButton.Size = new System.Drawing.Size(121, 27);
            this.setPasswordButton.TabIndex = 3;
            this.setPasswordButton.Text = "Set Password";
            this.setPasswordButton.UseVisualStyleBackColor = false;
            this.setPasswordButton.Click += new System.EventHandler(this.setPasswordButton_Click);
            // 
            // newPasswordTextbox
            // 
            this.newPasswordTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordTextbox.Location = new System.Drawing.Point(54, 116);
            this.newPasswordTextbox.Name = "newPasswordTextbox";
            this.newPasswordTextbox.PasswordChar = '*';
            this.newPasswordTextbox.Size = new System.Drawing.Size(187, 27);
            this.newPasswordTextbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Old Password";
            // 
            // oldPasswordTextbox
            // 
            this.oldPasswordTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPasswordTextbox.Location = new System.Drawing.Point(54, 52);
            this.oldPasswordTextbox.Name = "oldPasswordTextbox";
            this.oldPasswordTextbox.PasswordChar = '*';
            this.oldPasswordTextbox.Size = new System.Drawing.Size(187, 27);
            this.oldPasswordTextbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter New Password";
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(293, 227);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldPasswordTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setPasswordButton);
            this.Controls.Add(this.newPasswordTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setPasswordButton;
        private System.Windows.Forms.TextBox newPasswordTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oldPasswordTextbox;
        private System.Windows.Forms.Label label2;
    }
}