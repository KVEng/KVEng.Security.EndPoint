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
            this.MenuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TsmKseName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsmStartLocker = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.MenuNotify.SuspendLayout();
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
            this.NotifyIcon.ContextMenuStrip = this.MenuNotify;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "KSE - Working";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // MenuNotify
            // 
            this.MenuNotify.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.MenuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmKseName,
            this.toolStripSeparator1,
            this.TsmStartLocker,
            this.TsmQuit});
            this.MenuNotify.Name = "MenuNotify";
            this.MenuNotify.Size = new System.Drawing.Size(195, 118);
            // 
            // TsmKseName
            // 
            this.TsmKseName.Enabled = false;
            this.TsmKseName.Name = "TsmKseName";
            this.TsmKseName.Size = new System.Drawing.Size(194, 36);
            this.TsmKseName.Text = "KSE";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // TsmStartLocker
            // 
            this.TsmStartLocker.Name = "TsmStartLocker";
            this.TsmStartLocker.Size = new System.Drawing.Size(194, 36);
            this.TsmStartLocker.Text = "Start Locker";
            this.TsmStartLocker.Click += new System.EventHandler(this.TsmStartLocker_Click);
            // 
            // TsmQuit
            // 
            this.TsmQuit.Name = "TsmQuit";
            this.TsmQuit.Size = new System.Drawing.Size(194, 36);
            this.TsmQuit.Text = "Quit";
            this.TsmQuit.Click += new System.EventHandler(this.TsmQuit_Click);
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
            this.Text = "KSE Setting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.SettingForm_SizeChanged);
            this.MenuNotify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGenOtp;
        private System.Windows.Forms.Button BtnRunLocker;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.ContextMenuStrip MenuNotify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TsmQuit;
        private System.Windows.Forms.ToolStripMenuItem TsmKseName;
        private System.Windows.Forms.ToolStripMenuItem TsmStartLocker;
    }
}