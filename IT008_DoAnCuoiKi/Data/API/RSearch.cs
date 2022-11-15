using IT008_DoAnCuoiKi.Data.API.Auth;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using static IT008_DoAnCuoiKi.Data.Models.MSearch;

namespace IT008_DoAnCuoiKi.Data.API
{
    public static class RSearch
    {
        public static SpotifyResult SearchByType(string search_word, string type)
        {
            var client = new RestClient("https://api.spotify.com/v1/search");
            client.AddDefaultHeader("Authorization", $"Bearer {TokenString.AccessToken}");
            var request = new RestRequest($"?q={search_word}&type={type}", Method.Get);
            try
            {
                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    using (StreamWriter sw = new StreamWriter("Data.txt"))
                    {
                        sw.WriteLine(response.Content);
                        sw.Close();
                    }
                    var result = JsonConvert.DeserializeObject<SpotifyResult>(response.Content);
                    return result;
                }
                else
                {
                    MessageBox.Show(response?.StatusDescription);
                    return null; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
