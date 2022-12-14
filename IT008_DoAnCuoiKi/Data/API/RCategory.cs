using IT008_DoAnCuoiKi.Data.API.Auth;
using IT008_DoAnCuoiKi.Data.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace IT008_DoAnCuoiKi.Data.API
{
    public static class RCategory
    {
        public static SpotifyResult AllCategories()
        {
            var client = new RestClient("https://api.spotify.com/v1/browse/categories");
            client.AddDefaultHeader("Authorization", $"Bearer {TokenString.AccessToken}");
            var request = new RestRequest($"?country=VN&limit=50", Method.Get);
            try
            {
                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    using (StreamWriter sw = new StreamWriter("Category.txt"))
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
