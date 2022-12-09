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
using System.ComponentModel;
using System.Collections;
//using Newtonsoft.Json;
using System.Text.Json;
using RestSharp.Serializers.Json;
using System.IO;
using System.Net;
using Microsoft.Win32;

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
            songs_visibility.Visibility = Visibility.Hidden;
        }


        public enum Type
        {
            [Description("Artists")]
            Artists,
            [Description("Tracks")]
            Tracks,
            [Description("Albums")]
            Albums,
            [Description("Playlists")]
            Playlists
        }



        private void btn_search_Click(object sender, RoutedEventArgs e)
        {
            if (search_tb.Text == string.Empty)
            {
                MessageBox.Show("Please type something!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                songs_visibility.Visibility = Visibility.Visible;
                artists_title.Text = Type.Artists.ToString();
                tracks_title.Text = Type.Tracks.ToString();
                albums_title.Text = Type.Albums.ToString();
                playlists_title.Text = Type.Playlists.ToString();
                List<ArtistItem> listArtists = RSearch.SearchByType(search_tb.Text, "artist").artists.items;
                List<TracksItem> listTracks = RSearch.SearchByType(search_tb.Text, "track").tracks.items;
                List<AlbumsItem> listAlbums = RSearch.SearchByType(search_tb.Text, "album").albums.items;
                List<PlaylistsItem> listPlaylists = RSearch.SearchByType(search_tb.Text, "playlist").playlists.items;
                foreach (var item in listTracks)
                {
                    int o = (int)item.duration_ms / 60000;
                    double t = Convert.ToDouble(item.duration_ms) / 60000.0;
                    double r = t - o;
                    int s = (int)(r * 60);
                    item.duration_string = o.ToString() + ":" + (s < 10 ? "0" : "") + s.ToString();
                }
                ArtistResult.ItemsSource = listArtists;
                TrackResult.ItemsSource = listTracks;
                AlbumResult.ItemsSource = listAlbums;
                PlaylistResult.ItemsSource = listPlaylists;
                List<TracksItem> trackItem = new List<TracksItem>
                {
                    listTracks[0]
                };
                top_result.ItemsSource = trackItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //if (res != null)
            //{
            //    switch (type)
            //    {
            //        case "artist":
            //            var listArtist = new List<ArtistItem>();
            //            foreach (var item in res?.artists.items)
            //                listArtist.Add(item);
            //            ArtistResult.ItemsSource = listArtist;
            //            break;
            //        case "track":
            //            var listTrack = new List<TracksItem>();
            //            foreach (var item in res?.tracks.items)
            //                listTrack.Add(item);
            //            TrackResult.ItemsSource = listTrack;
            //            break;
            //        case "album":
            //            var listAlbum = new List<AlbumsItem>();
            //            foreach (var item in res?.albums.items)
            //                listAlbum.Add(item);
            //            AlbumResult.ItemsSource = listAlbum;
            //            break;
            //        case "playlist":
            //            var listPlaylist = new List<PlaylistsItem>();
            //            foreach (var item in res?.playlists.items)
            //                listPlaylist.Add(item);
            //            PlaylistResult.ItemsSource = listPlaylist;
            //            break;
            //        default:
            //            return;
            //    }
            //}
        }

        private void card_MouseEnter(object sender, MouseEventArgs e)
        {
            ((Wpf.Ui.Controls.Card)sender).Background = Brushes.Gray;
        }

        private void card_MouseLeave(object sender, MouseEventArgs e)
        {
            ((Wpf.Ui.Controls.Card)sender).Background = Brushes.Black;
        }

        private void search_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                this.btn_search_Click(sender, e);
        }

        private void top_result_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                TracksItem tracksItem;
                tracksItem = top_result.SelectedItem as TracksItem;
                string s = "";
                s = tracksItem.preview_url;
                MessageBox.Show(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tracks_selected(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                TracksItem tracksItem;
                tracksItem = tracks_result.SelectedItem as TracksItem;

                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = "";
                jsonString = JsonSerializer.Serialize(tracksItem, options);

                using (StreamWriter sw = new StreamWriter("Data1.txt"))
                {
                    sw.WriteLine(jsonString);
                    sw.Close();
                }
                WebClient webClient = new WebClient();
                string s = "";

                s = tracksItem.preview_url;
                webClient.DownloadFile(s, "anc.mp3");
                App.MediaPlayer.Open(new Uri(System.IO.Path.Combine(Environment.CurrentDirectory, "anc.mp3")));
                App.MediaPlayer.Play();

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }

    
}
