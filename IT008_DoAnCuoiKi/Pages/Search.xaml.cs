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
                SearchResult = null;
                return;
            }
            ComboBoxItem dropdown_item = dropdown.SelectedItem as ComboBoxItem;
            string type = dropdown_item.Content.ToString().ToLower();
            SpotifyResult res = RSearch.SearchByType(search_tb.Text, type);
            if (res != null)
            {
                switch (type)
                {
                    case "artist":
                        var listArtist = new List<RArtist>();
                        foreach (var item in res.artists.items)
                        {
                            listArtist.Add(new RArtist()
                            {
                                ID = item.id,
                                Name = item.name,
                                ArtistImage = item.images.Any() ? item.images[0].url : "https://user-images.githubusercontent.com/24848110/33519396-7e56363c-d79d-11e7-969b-09782f5ccbab.png",
                                Popularity = item.popularity,
                                Followers = item.followers.total,
                                Genres = item.genres,
                                Type = item.type,
                                Href = item.href,
                                External_Url = item.external_urls.spotify
                            });
                        }
                        SearchResult.ItemsSource = listArtist;
                        break;
                    case "track":
                        break;
                }
            }
        }
    }
}
