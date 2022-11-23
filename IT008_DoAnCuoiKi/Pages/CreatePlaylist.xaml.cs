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

namespace IT008_DoAnCuoiKi.Pages
{
    /// <summary>
    /// Interaction logic for CreatePlaylist.xaml
    /// </summary>
    public partial class CreatePlaylist : Page
    {
        public CreatePlaylist()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.searchbar.Visibility = Visibility.Hidden;
            this.Xbutton.Visibility = Visibility.Hidden;
            this.Findmore.Visibility = Visibility.Visible;
        }

        private void Findmore_Click(object sender, RoutedEventArgs e)
        {
            this.searchbar.Visibility = Visibility.Visible;
            this.Xbutton.Visibility = Visibility.Visible;
            this.Findmore.Visibility = Visibility.Hidden;
        }
    }
}
