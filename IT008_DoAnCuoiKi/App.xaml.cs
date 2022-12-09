using IT008_DoAnCuoiKi.Data.API;
using IT008_DoAnCuoiKi.Data.API.Auth;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace IT008_DoAnCuoiKi
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Task.Run(async () => await Auth.GetToken());
            MediaPlayer = new MediaPlayer();
        }
        public static MediaPlayer MediaPlayer;
    }
}
