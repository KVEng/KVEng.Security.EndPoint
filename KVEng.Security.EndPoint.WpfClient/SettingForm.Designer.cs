namespace KVEng.Security.EndPoint.WpfClient
{
    partial class SettingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.BtnGenOtp = new System.Windows.Forms.Button();
            this.BtnRunLocker = new System.Windows.Forms.Button();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.BtnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGenOtp
            // 
            this.BtnGenOtp.Location = new System.Drawing.Point(12, 24);
            this.BtnGenOtp.Name = "BtnGenOtp";
            this.BtnGenOtp.Size = new System.Drawing.Size(225, 100);
            this.BtnGenOtp.TabIndex = 0;
            this.BtnGenOtp.Text = "Generate OTP";
            this.BtnGenOtp.UseVisualStyleBackColor = true;
            this.BtnGenOtp.Click += new System.EventHandler(this.BtnGenOtp_Click);
            // 
            // BtnRunLocker
            // 
            this.BtnRunLocker.Location = new System.Drawing.Point(263, 24);
            this.BtnRunLocker.Name = "BtnRunLocker";
            this.BtnRunLocker.Size = new System.Drawing.Size(178, 106);
            this.BtnRunLocker.TabIndex = 1;
            this.BtnRunLocker.Text = "Run Locker";
            this.BtnRunLocker.UseVisualStyleBackColor = true;
            this.BtnRunLocker.Click += new System.EventHandler(this.BtnRunLocker_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "KSE - Working";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(463, 24);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(145, 106);
            this.BtnQuit.TabIndex = 2;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 846);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnRunLocker);
            this.Controls.Add(this.BtnGenOtp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.SettingForm_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGenOtp;
        private System.Windows.Forms.Button BtnRunLocker;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.Button BtnQuit;
    }
}