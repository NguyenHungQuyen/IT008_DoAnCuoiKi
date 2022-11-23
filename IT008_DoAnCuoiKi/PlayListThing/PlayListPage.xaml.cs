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

namespace IT008_DoAnCuoiKi.PlayListThing
{
    /// <summary>
    /// Interaction logic for PlayListPage.xaml
    /// </summary>
    public partial class PlayListPage : Page
    {
        public PlayListPage()
        {
            InitializeComponent();
            //PlayListCheck = GetInformation(); // Tắt cmt đoạn này để coi hiển thị các playlists 
            if (PlayListCheck.Count == 0)
            {
                IfEmpty.Visibility = Visibility.Visible;
            }
            else
            {
                ScrollViewLists.Visibility = Visibility.Visible;
                TagPlayList.Visibility = Visibility.Visible;
                var playlist = PlayListCheck;
                if (playlist.Count > 0)
                {
                    PlayListControl.ItemsSource = playlist;
                }
            }
        }
        private List<PlayListInformation> PlayListCheck = new List<PlayListInformation>();
        // Trường hợp đã có các playList rồi for test
        private List<PlayListInformation> GetInformation()
        {
            return new List<PlayListInformation>()
            {
                new PlayListInformation("/PlayListThing/spotify.png","FirstList","By huy"),
                new PlayListInformation("/PlayListThing/spotify.png","SecondList","By huy"),
                new PlayListInformation("/PlayListThing/spotify.png","ThirdList","By huy"),
                new PlayListInformation("/PlayListThing/spotify.png","FourthList","By huy"),
                new PlayListInformation("/PlayListThing/spotify.png","FifthList","By huy"),
                new PlayListInformation("/PlayListThing/spotify.png","SixthList","By huy"),
                new PlayListInformation("/PlayListThing/spotify.png","SeventhList","By huy"),
                new PlayListInformation("/PlayListThing/spotify.png","EightthList","By huy"),
                new PlayListInformation("/PlayListThing/spotify.png","NinethList","By huy"),
                new PlayListInformation("/PlayListThing/spotify.png","TenthList","By huy"),
                new PlayListInformation("/PlayListThing/spotify.png","EleventhList","By huy"),
                new PlayListInformation("/PlayListThing/spotify.png","TwelvethList","By huy"),
                new PlayListInformation("/PlayListThing/spotify.png","ThirdteenthList","By huy"),
                new PlayListInformation("/PlayListThing/spotify.png","FourthList","By huy")
            };
        }

     
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PlayListCheck.Add(new PlayListInformation("/PlayListThing/spotify.png", "FirstList", "By huy"));
            IfEmpty.Visibility = Visibility.Hidden;
            ScrollViewLists.Visibility = Visibility.Visible;
            TagPlayList.Visibility = Visibility.Visible;
            var playlist = PlayListCheck;
            if (playlist.Count > 0)
            {
                PlayListControl.ItemsSource = playlist;
            }
        }
    }
}
