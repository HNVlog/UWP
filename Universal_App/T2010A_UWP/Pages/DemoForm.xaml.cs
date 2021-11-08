using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2010A_UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DemoForm : Page
    {
        public DemoForm()
        {
            this.InitializeComponent();
        }

        private void Submit(object sender, RoutedEventArgs e)
        {
            var fullName = inputFullname.Text;// lấy nội dung người dùng nhập trong input
            var email = inputEmail.Text;
            var phone = inputPhone.Text;

            txtFullname.Text = fullName;
            txtEmail.Text = email;
            txtPhone.Text = phone;
        }
    }
}