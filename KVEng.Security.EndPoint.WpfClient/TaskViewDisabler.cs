using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KVEng.Security.EndPoint.WpfClient;
class TaskViewDisabler
{
    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    static extern bool SetForegroundWindow(IntPtr hWnd);

    [DllImport("user32.dll")]
    private static extern IntPtr GetForegroundWindow();

    [DllImport("user32.dll", SetLastError = true)]
    private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
    private static void KeyboardHelp(int key, int oper)
    {
        keybd_event((byte)key, 0, oper, 0);
    }

    private static void PressKey(int key)
    {
        KeyboardHelp(key, KEYEVENTF_KEYDOWN);
        KeyboardHelp(key, KEYEVENTF_KEYUP);
    }

    public const int KEYEVENTF_KEYDOWN = 0x0000;
    public const int KEYEVENTF_KEYUP = 0x0002;
    public const int VK_ESCAPE = 0x1B;              // ESC

    public static void DisableTaskView(IntPtr handle)
    {
        SetForegroundWindow(handle);
    }

    Timer _timer;

    public TaskViewDisabler(int time, IntPtr handle)
    {
        _timer = new Timer();
        _timer.Interval = time;
        _timer.Tick += (o, e) =>
        {
            if (GetForegroundWindow() != handle)
                PressKey(VK_ESCAPE);
            SetForegroundWindow(handle);
        };
    }

    public void Start()
    {
        _timer.Start();
    }

    public void Stop()
    {
        _timer.Stop();
    }
}
