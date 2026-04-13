using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MeteoApp.Models
{
    public class WeatherData
    {
        [JsonPropertyName("name")]
        public string CityName { get; set; }

        [JsonPropertyName("main")]
        public MainData Main { get; set; }

        [JsonPropertyName("weather")]
        public List<WeatherDescription> Weather { get; set; }

        [JsonPropertyName("wind")]
        public WindData Wind { get; set; }

        [JsonPropertyName("clouds")]
        public CloudsData Clouds { get; set; }

        [JsonPropertyName("sys")]
        public SysData Sys { get; set; }
    }

    public class MainData
    {
        [JsonPropertyName("temp")]
        public double Temp { get; set; }

        [JsonPropertyName("feels_like")]
        public double FeelsLike { get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }

        [JsonPropertyName("pressure")]
        public int Pressure { get; set; }
    }

    public class WeatherDescription
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("main")]
        public string Main { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }

    public class WindData
    {
        [JsonPropertyName("speed")]
        public double Speed { get; set; }

        [JsonPropertyName("deg")]
        public int Deg { get; set; }
    }

    public class CloudsData
    {
        [JsonPropertyName("all")]
        public int All { get; set; }
    }

    public class SysData
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }
    }
}
