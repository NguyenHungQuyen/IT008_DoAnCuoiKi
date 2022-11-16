using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace IT008_DoAnCuoiKi.Data.API.Auth
{
    public class Token
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string expires_in { get; set; }


    }

    public static class TokenString 
    {
        public static string AccessToken { get; set; }
        public static string TokenType { get; set;}
        public static string ExpiresIn { get; set; }
    }
    public static class Client
    {
        public static string client_id { get; set; }
        public static string client_secret { get; }

        static Client()
        {
            #region
            client_id = "aad3e4e2077b47fbb21b6e921d83b800";
            client_secret = "4cce6dd85ff248ac984968f30e194586";
            #endregion
        }
    }

    public static class Auth
    {
        public static Token token { get; set; }
        public static async Task GetToken()
        {

            string auth = Convert.ToBase64String(Encoding.UTF8.GetBytes(Client.client_id + ":" + Client.client_secret));
            
            List<KeyValuePair<string, string>> args = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials")
            };

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Basic {auth}");
            HttpContent content = new FormUrlEncodedContent(args);

            HttpResponseMessage resp = await client.PostAsync("https://accounts.spotify.com/api/token", content);
            string msg = await resp.Content.ReadAsStringAsync();

            token =  JsonConvert.DeserializeObject<Token>(msg);
            TokenString.AccessToken = token.access_token;
            TokenString.TokenType = token.access_token;
            TokenString.ExpiresIn = token.expires_in;
            //MessageBox.Show(TokenString.AccessToken);
        }
    }
}
