using IT008_DoAnCuoiKi.Data.API;
using IT008_DoAnCuoiKi.Data.API.Auth;
using IT008_DoAnCuoiKi.Data.Models;
using IT008_DoAnCuoiKi.Pages;
using IT008_DoAnCuoiKi.Pages.LikedSongsPage;
using IT008_DoAnCuoiKi.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public System.Windows.Media.Brush color => nav_home.Background;
        public string Source { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            nav_home.IsSelected = true;
        }

        private void sidebar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = sidebar.SelectedItem as ListBoxItem;
            if (selected == null)
                return;
            selected.Background = color;
            string uri = selected.Name;
            switch (uri)
            {
                case "nav_home":
                    navframe.Navigate(new Home());
                    break;
                case "nav_search":
                    navframe.Navigate(new Search());
                    break;
                case "nav_library":
                    navframe.Navigate(new YourLibrary());
                    break;
                case "nav_create_playlist":
                    navframe.Navigate(new CreatePlaylist());
                    break;
                case "nav_liked_songs":
                    navframe.Navigate(new LikedSongs());
                    break;
                default:
                    break;
            }
        }

        private void queue_Click(object sender, RoutedEventArgs e)
        {
            sidebar.SelectedItem = null;
            navframe.Navigate(new Queue());
        }
    }
}
