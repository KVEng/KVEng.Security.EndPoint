using OtpNet;

namespace KVEng.Security.EndPoint.Library;
public static class Generator
{
    public static byte[] GenerateRandomKey(int length)
    {
        return KeyGeneration.GenerateRandomKey(length);
    }

    public static string Base32ToString(this byte[] b32)
    {
        return Base32Encoding.ToString(b32);
    }

    public static byte[] StringToBase32(this string s)
    {
        return Base32Encoding.ToBytes(s);
    }
}
