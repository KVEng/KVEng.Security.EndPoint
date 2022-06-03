using KVEng.Security.EndPoint.Library;

using Microsoft.Win32;

using System;
using System.Windows.Forms;

namespace KVEng.Security.EndPoint.WpfClient
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
            AddSystemEventTriger();
        }

        private IVerifiable v;

        private void BtnGenOtp_Click(object sender, EventArgs e)
        {
            var bytes = Generator.GenerateRandomKey(20);
            v = new KOtp(bytes);
            var qr = new QRCodeForm(bytes.Base32ToString());
            qr.ShowDialog();
            qr.Dispose();
            _login = new LoginForm(v);

        }

        LoginForm _login;
        private void BtnRunLocker_Click(object sender, EventArgs e)
        {
            if (_login == null)
                return;
            _login.ShowDialog();
        }

        private void SettingForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.ShowInTaskbar = false;
                NotifyIcon.Visible = true;
            }
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // this.Show();
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            NotifyIcon.Visible = false;
        }

        private void Quit()
        {
            this.Close();

            App.Quit();
        }

        private void AddSystemEventTriger()
        {
            SystemEvents.PowerModeChanged += (object s, PowerModeChangedEventArgs e) =>
            {
                switch (e.Mode)
                {
                    case PowerModes.Resume:
                        break;
                    case PowerModes.Suspend:
                        break;
                }
            };

            SystemEvents.SessionSwitch += (object sender, Microsoft.Win32.SessionSwitchEventArgs e) =>
            {
                if (e.Reason == SessionSwitchReason.SessionLock)
                {
                    // Lock
                    if (_login != null)
                        _login.ShowDialog();
                        
                }
                else if (e.Reason == SessionSwitchReason.SessionUnlock)
                {
                    //Unlock
                }
            };

        }
    }
}
