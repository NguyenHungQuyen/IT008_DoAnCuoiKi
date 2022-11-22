using IT008_DoAnCuoiKi.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Wpf.Ui.Mvvm.Contracts;

namespace IT008_DoAnCuoiKi.ViewModel
{
    public class ControlPageViewModel : BaseViewModel
    {
        private ICommand _navigateCommand;
        private readonly INavigationService _navigationService;
        private string _PageSource;
        public string PageSource { get { return _PageSource;  } set { _PageSource = value; OnPropertyChanged(); } }
        public ICommand NavigatePageCommand { get; set; }

        public ControlPageViewModel()
        {
            NavigatePageCommand = new RelayCommand<string>((p) => p != string.Empty, p => OnNavigate(p));
            _PageSource = "/Pages/Home.xaml";
            //MessageBox.Show(PageSource);
        }

        public ControlPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        void OnNavigate(string parameter)
        {
            if (parameter != string.Empty)
            {
                switch (parameter)
                {
                    case "nav_home":
                        //MessageBox.Show("Hello");
                        PageSource = "/Pages/Home.xaml";
                        break;
                    case "nav_search":
                        PageSource = "/Pages/Search.xaml";
                        break;
                    case "nav_library":
                        PageSource = "/Pages/YourLibrary.xaml";
                        break;
                    case "nav_create_playlist":
                        PageSource = "/PlayListThing/PlayListPage.xaml";
                        break;
                    case "nav_liked_songs":
                        PageSource = "/Pages/LikedSongs.xaml";
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
