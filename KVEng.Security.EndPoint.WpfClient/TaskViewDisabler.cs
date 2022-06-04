using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KVEng.Security.EndPoint.WpfClient;
class TaskViewDisabler
{
    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    static extern bool SetForegroundWindow(IntPtr hWnd);

    public static void DisableTaskView(IntPtr handle)
    {
        SetForegroundWindow(handle);
    }

    Timer _timer;

    public  TaskViewDisabler (int time, IntPtr handle)
    {
        _timer = new Timer();
        _timer.Interval = time;
        _timer.Tick += (o, e) =>
        {
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
