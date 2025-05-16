using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http;


namespace App_Seller
{
    public class LoginRequest
    {
        public async Task<string> LoginR(string Name,string Password,int Cdg)
        {
            var login = new { name = Name, password = Password, cdg = Cdg };
            var json = JsonSerializer.Serialize(login);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();
            var url = "http://127.0.0.1:5000/login";
            var response = await httpClient.PostAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                string res = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<bool>(res);
                return result.ToString();
            }
            else
            {
                return "Erro";
            }
        }
    }
}
