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
using IT008_DoAnCuoiKi.PlayListThing;

namespace IT008_DoAnCuoiKi.Pages
{
    /// <summary>
    /// Interaction logic for YourLibrary.xaml
    /// </summary>
    public partial class YourLibrary : Page
    {
        public YourLibrary()
        {
            InitializeComponent();
            nav_playlists.IsSelected = true;
        }
        private void Change_Page(object sender, SelectionChangedEventArgs e)
        {
            var selected = sidebar.SelectedItem as ListBoxItem;
            if (selected == null)
                return;
            //selected.Background = color;
            string uri = selected.Name;
            switch (uri)
            {
                case "nav_playlists":
                    PlayList_Page.Navigate(new PlayListPage());
                    break;           
                case "nav_artists":
                    PlayList_Page.Navigate(new ViewArtists());
                    break;
                case "nav_albums":
                    PlayList_Page.Navigate(new ViewAlbum());
                    break;            
                default:
                    break;
            }
            /* var selected = sidebar.SelectedItem as NavButton;
             if (selected == null)
                 return;
             PlayList_Page.Navigate(selected.Navlink);*/
        }
    }
}
