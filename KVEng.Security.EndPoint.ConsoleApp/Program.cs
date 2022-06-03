using KVEng.Security.EndPoint.Library;

LoopConsole(cmd =>
{
    switch (cmd[0].ToLower())
    {
        case "otp":
        case "totp":
            Console.WriteLine("Module [OTP]");
            Totp();
            break;
        default:
            Console.WriteLine("Invalid or empty command");
            break;
    }
    return false;
});


static void Totp()
{
    KOtp? _otp = null;

    LoopConsole(cmd =>
    {
        switch (cmd[0].ToLower())
        {
            case "i":
            case "init":
                _otp = new KOtp(cmd[1]);
                Console.WriteLine("TOTP Initialised");
                break;

            case "c":
            case "calc":
                Console.WriteLine(
                    _otp == null
                    ? "OTP is not initialised."
                    : _otp.Calc());
                break;

            case "v":
            case "verify":
                Console.WriteLine(
                    _otp == null
                    ? "OTP is not initialised."
                    : _otp.Verify(cmd[1])
                        ? "Pass"
                        : "Failed");
                break;

            case "e":
            case "exit":
                Console.WriteLine("Exit module");
                return true;

            default:
                Console.WriteLine("Invalid or empty command");
                break;
        }
        return false;

    });
}

static void LoopConsole(Func<string[], bool> act)
{
    while (true)
    {
        Console.Write(">");
        var cmd = Console.ReadLine()!.Split(' ');
        if (cmd.Length == 0)
        {
            Console.WriteLine("Invalid or empty command");
            continue;
        }
        if (act(cmd)) break;
    }
}