using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace KVEng.Security.EndPoint.WpfClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            if (HaveSameNameProcess())
            {
                MessageBox.Show("You have started one KSE, exiting...");
                Quit();
                return;
            }

            base.OnStartup(e);
            var form = new SettingForm();
            form.Show();
        }

        private static bool HaveSameNameProcess()
        {
            var cur = Process.GetCurrentProcess();
            var procs = Process.GetProcessesByName(cur.ProcessName);
            foreach (var p in procs)
            {
                if (p.Id != cur.Id)
                    return true;
            }
            return false;
        }

        public static void Quit()
        {
            Unkillable.MakeProcessKillable();
            Application.Current.Shutdown();
        }
    }
}
