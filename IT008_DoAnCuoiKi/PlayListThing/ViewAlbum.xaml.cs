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
    /// Interaction logic for ViewAlbum.xaml
    /// </summary>
    public partial class ViewAlbum : Page
    {
        public ViewAlbum()
        {
            InitializeComponent();
            //this.DataContext = new ViewModel.ControlPageViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Pages.Search());
        }
    }
}
