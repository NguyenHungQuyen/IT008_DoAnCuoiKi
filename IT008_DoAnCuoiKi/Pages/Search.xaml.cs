using IT008_DoAnCuoiKi.Data.API.Auth;
using IT008_DoAnCuoiKi.Data.API;
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
using static IT008_DoAnCuoiKi.Data.Models.MSearch;
using IT008_DoAnCuoiKi.Data.Models;

namespace IT008_DoAnCuoiKi.Pages
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Page
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, RoutedEventArgs e)
        {
            if (search_tb.Text == string.Empty)
            {
                MessageBox.Show("Please type something!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                SearchResult.ItemsSource = null;
                return;
            }
            ComboBoxItem dropdown_item = dropdown.SelectedItem as ComboBoxItem;
            string type = dropdown_item.Content.ToString().ToLower();
            if (type.CompareTo("choose type") == 0)
            {
                MessageBox.Show("Please choose type!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                SearchResult.ItemsSource = null;
                return;
            }
            SpotifyResult res = RSearch.SearchByType(search_tb.Text, type);
            if (res != null)
            {
                switch (type)
                {
                    case "artist":
                        var listArtist = new List<ArtistItem>();
                        foreach (var item in res?.artists.items)
                            listArtist.Add(item);
                        SearchResult.ItemsSource = listArtist;
                        break;
                    case "track":
                        var listTrack = new List<TracksItem>();
                        foreach (var item in res?.tracks.items)
                            listTrack.Add(item);
                        SearchResult.ItemsSource = listTrack;
                        break;
                    case "album":
                        var listAlbum = new List<AlbumsItem>();
                        foreach (var item in res?.albums.items)
                            listAlbum.Add(item);
                        SearchResult.ItemsSource = listAlbum;
                        break;
                    case "playlist":
                        var listPlaylist = new List<PlaylistsItem>();
                        foreach (var item in res?.playlists.items)
                            listPlaylist.Add(item);
                        SearchResult.ItemsSource = listPlaylist;
                        break;
                    default:
                        return; 
                }
            }
        }
    }
}
