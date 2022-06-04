using QRCoder;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KVEng.Security.EndPoint.WpfClient;

public partial class QRCodeForm : Form
{
    public QRCodeForm(string content)
    {
        InitializeComponent();
        var qrGenerator = new QRCodeGenerator();
        var qrCodeData = qrGenerator.CreateQrCode(GenerateOtpUrl(content),  QRCodeGenerator.ECCLevel.Q);
        var qrCode = new QRCode(qrCodeData);
        var qrImg = qrCode.GetGraphic(20)!;
        PicQR.Image = qrImg;
        TxtContent.Text = content;
    }

    private void QRCodeForm_Load(object sender, EventArgs e)
    {

    }

    private void BtnOK_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private string GenerateOtpUrl(string secret)
    {
        var username = Environment.UserName;
        var pcname = Environment.MachineName;
        return $"otpauth://totp/KSE:{username}@{pcname}?secret={secret}&issuer=KSE";
    }
}
