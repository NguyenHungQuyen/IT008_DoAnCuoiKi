using IT008_DoAnCuoiKi.Data.API;
using IT008_DoAnCuoiKi.Data.API.Auth;
using IT008_DoAnCuoiKi.Data.Models;
using IT008_DoAnCuoiKi.Pages;
using System;
using System.Collections.Generic;
using System.Drawing;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static IT008_DoAnCuoiKi.Data.Models.MSearch;

namespace IT008_DoAnCuoiKi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            nav_home.IsSelected = true;
        }


        private void wa_close_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void wa_maxmin_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            switch (WindowState)
            {
                case (WindowState.Maximized):
                    WindowStartupLocation = WindowStartupLocation.CenterOwner;
                    ResizeMode = ResizeMode.NoResize;
                    WindowState = WindowState.Normal;
                    break;
                case (WindowState.Normal):
                    ResizeMode = ResizeMode.NoResize;
                    WindowState = WindowState.Maximized;
                    break;
            }
        }

        private void wa_hide_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }


        private void sidebar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = sidebar.SelectedItem as NavButton;
            if (selected == null)
                return;
            navframe.Navigate(selected.Navlink);
        }

        private void queue_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            sidebar.SelectedItem = null;
            navframe.Navigate(queue.Navlink);
        }

       

    }
}
