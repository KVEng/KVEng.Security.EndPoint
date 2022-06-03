using OtpNet;

namespace KVEng.Security.EndPoint.Library;

public class KOtp
{
    private Totp _otp;

    public KOtp(byte[] secretKey)
    {
        _otp = new Totp(secretKey);
    }

    public KOtp(string secretKey)
    {
        _otp = new Totp(Base32Encoding.ToBytes(secretKey));
    }

    public string Calc()
    {
        return _otp.ComputeTotp();
    }

    public bool Verify(string otp)
    {
        return _otp.VerifyTotp(otp, out long timeWindowUsed);
    }


}
