using IT008_DoAnCuoiKi.ViewModel;
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

namespace IT008_DoAnCuoiKi.Pages.LikedSongsPage
{
    /// <summary>
    /// Interaction logic for LikedSongs.xaml
    /// </summary>
    public partial class LikedSongs : Page
    {
        public LikedSongs()
        {
            InitializeComponent();
            this.DataContext = new ControlPageViewModel();
        }

        private void find_songs_btn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Search());
        }
    }
}
