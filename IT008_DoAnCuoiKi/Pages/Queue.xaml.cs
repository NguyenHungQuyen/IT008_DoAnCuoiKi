using IT008_DoAnCuoiKi.Data.Models;
using Newtonsoft.Json;
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
using System.IO;

namespace IT008_DoAnCuoiKi.Pages
{
    /// <summary>
    /// Interaction logic for Queue.xaml
    /// </summary>
    public partial class Queue : Page
    {
        public Queue()
        {
            InitializeComponent();
            string s = "";
            if (!File.Exists("Data1.txt")) return;
            s = File.ReadAllText("Data1.txt");
            grid_track.Visibility = Visibility.Visible;
            grid_icon.Visibility = Visibility.Hidden;
            var result = JsonConvert.DeserializeObject<TracksItem>(s);
            List<TracksItem> listTracks = new List<TracksItem> { result };
            queue_tracks_result.ItemsSource = listTracks;
        }

        private void find_st_to_play_Click(object sender, RoutedEventArgs e)
        {
            
            this.NavigationService.Navigate(new Search());
        }
        private void queue_tracks_selected(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
