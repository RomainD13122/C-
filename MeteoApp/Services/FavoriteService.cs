using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using MeteoApp.Models;

namespace MeteoApp.Services
{
    public class FavoriteService
    {
        private string _filePath;

        public FavoriteService()
        {
            string folder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "MeteoApp"
            );

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            _filePath = Path.Combine(folder, "favorites.json");
        }

        public async Task<List<City>> LoadFavoritesAsync()
        {
            if (!File.Exists(_filePath))
                return new List<City>();

            try
            {
                string json = await File.ReadAllTextAsync(_filePath);
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var result = JsonSerializer.Deserialize<List<City>>(json, options);
                return result ?? new List<City>();
            }
            catch (Exception)
            {
                return new List<City>();
            }
        }

        public async Task SaveFavoritesAsync(List<City> cities)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(cities, options);
            await File.WriteAllTextAsync(_filePath, json);
        }

        public async Task AddFavoriteAsync(City city)
        {
            List<City> favorites = await LoadFavoritesAsync();

            bool alreadyExists = favorites.Any(c => c.Name.ToLower() == city.Name.ToLower());

            if (!alreadyExists)
            {
                favorites.Add(city);
                await SaveFavoritesAsync(favorites);
            }
        }

        public async Task RemoveFavoriteAsync(string cityName)
        {
            List<City> favorites = await LoadFavoritesAsync();
            favorites.RemoveAll(c => c.Name.ToLower() == cityName.ToLower());
            await SaveFavoritesAsync(favorites);
        }
    }
}
