using KVEng.Security.EndPoint.Library;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using WindowsDesktop;

namespace KVEng.Security.EndPoint.WpfClient
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        #region Initialiser
        public LoginForm() : this(new KOtp("LJVEK52ZGJHGYTL2NN2E6R2RGVNFGMBQLJCFS6KMK5FGSWKUKF2FSV2VGVHVOUJTJZ5ES52NPJETI==="))
        { }

        public LoginForm(IVerifiable v)
        {
            this._verify = v;
            InitializeComponent();
            LblStatus.Content = GetAssemblyStatus();
#if DEBUG
            this.Topmost = false;
#endif
#if RELEASE
            Unkillable.MakeProcessUnkillable();
#endif            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PinIt();
            StartDisableTaskView();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
        }

        private void Window_StateChanged(object sender, EventArgs e)
        {
            this.WindowState = WindowState.Maximized;
        }

        #endregion

        #region Exiting
        bool isExit = false;
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            ExitThis(true);
        }

        private void ExitThis(bool isSafe)
        {
            isExit = true;
            if (isSafe)
                Unkillable.MakeProcessKillable();
            StopDisableTaskView();
            this.Close();

            // Application.Current.Shutdown();
        }

        private void BtnUnsafeExit_Click(object sender, RoutedEventArgs e)
        {
            ExitThis(false);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!isExit) e.Cancel = true;
        }
        #endregion

        #region Window Event
        private void Window_Deactivated(object sender, EventArgs e)
        {
            Window window = (Window)sender;
            window.Topmost = true;
            this.Activate();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.System && e.SystemKey == Key.F4)
            {
                e.Handled = true;
            }
        }
        #endregion

        private void PinIt()
        {
            VirtualDesktop.CurrentChanged += (_, args) =>
            {
                this.Dispatcher.Invoke(() =>
                {
                    if (!this.IsCurrentVirtualDesktop())
                        this.MoveToDesktop(VirtualDesktop.Current);
#if RELEASE
                    if (!this.IsPinned())
                        this.Pin();
#endif
                });
            };
#if RELEASE
            this.Pin();
#endif
        }

        private readonly IVerifiable _verify;
        private void BtnOtpVerify_Click(object sender, RoutedEventArgs e)
        {
            var txt = TxtOtp.Text;

            if (_verify.Verify(txt)
#if DEBUG
                || txt == "114514"
#endif
                ) ExitThis(true);
            else MessageBox.Show("Wrong Password!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private string GetAssemblyStatus()
        {
            var s = $"{Environment.UserName}@{Environment.MachineName} {Environment.OSVersion} {System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription}";
#if DEBUG
            s += " DEBUG";
#endif
#if RELEASE
            s += " RELEASE";
#endif
            return s;
        }

        TaskViewDisabler _taskViewDisabler;
        private void StartDisableTaskView()
        {
            _taskViewDisabler = new TaskViewDisabler(100, this.GetHandle());
            _taskViewDisabler.Start();
        }

        private void StopDisableTaskView()
        {
            if (_taskViewDisabler != null)
                _taskViewDisabler.Stop();
        }
    }
}
