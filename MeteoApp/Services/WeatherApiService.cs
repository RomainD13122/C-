using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using MeteoApp.Models;

namespace MeteoApp.Services
{
    public class WeatherApiService
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private string _apiKey;

        public WeatherApiService()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
                string json = File.ReadAllText(path);
                using var doc = JsonDocument.Parse(json);
                _apiKey = doc.RootElement
                             .GetProperty("OpenWeatherMap")
                             .GetProperty("ApiKey")
                             .GetString();
            }
            catch (Exception ex)
            {
                throw new Exception("Clé API introuvable : " + ex.Message);
            }
        }

        public async Task<WeatherData> GetWeatherAsync(string cityName)
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q="
                + Uri.EscapeDataString(cityName)
                + "&appid=" + _apiKey
                + "&units=metric&lang=fr";

            try
            {
                string json = await _httpClient.GetStringAsync(url);
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                WeatherData data = JsonSerializer.Deserialize<WeatherData>(json, options);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de la récupération des données : " + ex.Message);
            }
        }
    }
}
