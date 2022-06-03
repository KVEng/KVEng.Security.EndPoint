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
        public LoginForm()
        {
            InitializeComponent();
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
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            ExitThis(true);
        }



        private void ExitThis(bool isSafe)
        {
            if (isSafe)
                Unkillable.MakeProcessKillable();
            Application.Current.Shutdown();
        }
        private void BtnUnsafeExit_Click(object sender, RoutedEventArgs e)
        {
            ExitThis(false);
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            Window window = (Window)sender;
            window.Topmost = true;
            this.Activate();
        }

        private void PinIt()
        {
            VirtualDesktop.CurrentChanged += (_, args) =>
            {
                this.Dispatcher.Invoke(() =>
                {
#if DEBUG
                    MessageBox.Show("CurrentChanged!");
#endif
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

        private void BtnOtpVerify_Click(object sender, RoutedEventArgs e)
        {
            if (TxtOtp.Text == "114514")
                ExitThis(true);
            MessageBox.Show("Wrong Password!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
