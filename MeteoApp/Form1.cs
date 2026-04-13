using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeteoApp.Models;
using MeteoApp.Services;

namespace MeteoApp
{
    public partial class Form1 : Form
    {
        private WeatherApiService _weatherService;
        private FavoriteService _favoriteService;

        private List<City> _favorites = new List<City>();
        private WeatherData _currentWeather;

        public Form1()
        {
            InitializeComponent();
            _weatherService = new WeatherApiService();
            _favoriteService = new FavoriteService();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadFavoritesAsync();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await SearchWeatherAsync();
        }

        private async void txtCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                await SearchWeatherAsync();
            }
        }

        private async Task SearchWeatherAsync()
        {
            string cityName = txtCity.Text.Trim();
            if (string.IsNullOrEmpty(cityName))
            {
                MessageBox.Show("Veuillez saisir le nom d'une ville.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SetUiEnabled(false);
            lblStatus.Text = "Recherche en cours...";
            ClearWeatherDisplay();

            try
            {
                _currentWeather = await _weatherService.GetWeatherAsync(cityName);
                DisplayWeather(_currentWeather);
                lblStatus.Text = "Données chargées avec succès.";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Erreur.";
                MessageBox.Show("Impossible de récupérer les données météo :\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetUiEnabled(true);
            }
        }

        private void DisplayWeather(WeatherData data)
        {
            string country = data.Sys?.Country ?? "";
            if (string.IsNullOrEmpty(country))
                lblCityName.Text = data.CityName;
            else
                lblCityName.Text = data.CityName + ", " + country;

            lblTemperature.Text = data.Main?.Temp.ToString("F1") + " °C";
            lblFeelsLike.Text = "Ressenti : " + data.Main?.FeelsLike.ToString("F1") + " °C";
            lblHumidity.Text = "Humidité : " + data.Main?.Humidity + " %";
            lblWindSpeed.Text = "Vent : " + data.Wind?.Speed.ToString("F1") + " m/s";
            lblClouds.Text = "Nuages : " + data.Clouds?.All + " %";

            if (data.Weather != null && data.Weather.Count > 0)
            {
                string desc = data.Weather[0].Description;
                if (!string.IsNullOrEmpty(desc))
                    lblDescription.Text = char.ToUpper(desc[0]) + desc.Substring(1);
            }

            LoadWeatherIconAsync(data.Weather?[0]?.Icon);
        }

        private void ClearWeatherDisplay()
        {
            lblCityName.Text = "";
            lblTemperature.Text = "";
            lblFeelsLike.Text = "";
            lblHumidity.Text = "";
            lblWindSpeed.Text = "";
            lblClouds.Text = "";
            lblDescription.Text = "";
            pbWeatherIcon.Image = null;
            _currentWeather = null;
        }

        private async void LoadWeatherIconAsync(string iconCode)
        {
            if (string.IsNullOrEmpty(iconCode)) return;

            try
            {
                string url = "https://openweathermap.org/img/wn/" + iconCode + "@2x.png";
                var client = new HttpClient();
                byte[] bytes = await client.GetByteArrayAsync(url);
                using (var ms = new System.IO.MemoryStream(bytes))
                {
                    pbWeatherIcon.Image = Image.FromStream(ms);
                }
            }
            catch
            {
                pbWeatherIcon.Image = null;
            }
        }

        private async void btnAddFavorite_Click(object sender, EventArgs e)
        {
            if (_currentWeather == null)
            {
                MessageBox.Show("Recherchez d'abord une ville.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            City city = new City(_currentWeather.CityName, _currentWeather.Sys?.Country ?? "");

            try
            {
                await _favoriteService.AddFavoriteAsync(city);
                await LoadFavoritesAsync();
                lblStatus.Text = city.ToString() + " ajouté aux favoris.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible d'ajouter le favori :\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnRemoveFavorite_Click(object sender, EventArgs e)
        {
            if (lstFavorites.SelectedItem is City selected)
            {
                try
                {
                    await _favoriteService.RemoveFavoriteAsync(selected.Name);
                    await LoadFavoritesAsync();
                    lblStatus.Text = selected.ToString() + " supprimé des favoris.";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Impossible de supprimer le favori :\n" + ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez une ville dans la liste des favoris.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void lstFavorites_DoubleClick(object sender, EventArgs e)
        {
            if (lstFavorites.SelectedItem is City selected)
            {
                txtCity.Text = selected.Name;
                await SearchWeatherAsync();
            }
        }

        private async Task LoadFavoritesAsync()
        {
            _favorites = await _favoriteService.LoadFavoritesAsync();
            lstFavorites.Items.Clear();
            foreach (City city in _favorites)
                lstFavorites.Items.Add(city);
        }

        private void SetUiEnabled(bool enabled)
        {
            txtCity.Enabled = enabled;
            btnSearch.Enabled = enabled;
            btnAddFavorite.Enabled = enabled;
            btnRemoveFavorite.Enabled = enabled;
            lstFavorites.Enabled = enabled;
        }
    }
}
