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
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        private void search_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void search_tb_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (search_tb.Text == "What do you want to listen to?")
                search_tb.Text = "";
        }

        private void sidebar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = sidebar.SelectedItem as NavButton;
            navframe.Navigate(selected.Navlink);
        }

        private void search_tb_MouseLeave(object sender, MouseEventArgs e)
        {
            if (search_tb.Text == "")
                search_tb.Text = "What do you want to listen to?";
        }

    }
}
