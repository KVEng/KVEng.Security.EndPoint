using KVEng.Security.EndPoint.Library;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KVEng.Security.EndPoint.WpfClient
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private IVerifiable v;

        private void BtnGenOtp_Click(object sender, EventArgs e)
        {
            var bytes = Generator.GenerateRandomKey(20);
            v = new KOtp(bytes);
            QRCodeForm qr = new QRCodeForm(bytes.Base32ToString());
            qr.ShowDialog();
            qr.Dispose();
        }

        private void BtnRunLocker_Click(object sender, EventArgs e)
        {
            if (v == null)
                return;
            LoginForm l = new LoginForm(v);
            l.ShowDialog();
        }
    }
}
