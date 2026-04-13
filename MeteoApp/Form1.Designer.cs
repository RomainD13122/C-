namespace MeteoApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // Contrôles
            this.pnlSearch        = new System.Windows.Forms.Panel();
            this.txtCity          = new System.Windows.Forms.TextBox();
            this.btnSearch        = new System.Windows.Forms.Button();

            this.pnlWeather       = new System.Windows.Forms.Panel();
            this.pbWeatherIcon    = new System.Windows.Forms.PictureBox();
            this.lblCityName      = new System.Windows.Forms.Label();
            this.lblDescription   = new System.Windows.Forms.Label();
            this.lblTemperature   = new System.Windows.Forms.Label();
            this.lblFeelsLike     = new System.Windows.Forms.Label();
            this.lblHumidity      = new System.Windows.Forms.Label();
            this.lblWindSpeed     = new System.Windows.Forms.Label();
            this.lblClouds        = new System.Windows.Forms.Label();

            this.pnlFavorites     = new System.Windows.Forms.Panel();
            this.lblFavTitle      = new System.Windows.Forms.Label();
            this.lstFavorites     = new System.Windows.Forms.ListBox();
            this.btnAddFavorite   = new System.Windows.Forms.Button();
            this.btnRemoveFavorite= new System.Windows.Forms.Button();

            this.lblStatus        = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherIcon)).BeginInit();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(900, 550);
            this.MinimumSize         = new System.Drawing.Size(900, 590);
            this.Text                = "MeteoApp — Météo en temps réel";
            this.BackColor           = System.Drawing.Color.FromArgb(30, 30, 45);
            this.ForeColor           = System.Drawing.Color.White;
            this.Font                = new System.Drawing.Font("Segoe UI", 9F);
            this.Load               += new System.EventHandler(this.Form1_Load);

            // Panel Recherche
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(40, 40, 60);
            this.pnlSearch.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Height    = 60;
            this.pnlSearch.Padding   = new System.Windows.Forms.Padding(10);

            this.txtCity.Location    = new System.Drawing.Point(10, 15);
            this.txtCity.Size        = new System.Drawing.Size(300, 25);
            this.txtCity.Font        = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCity.PlaceholderText = "Entrez une ville...";
            this.txtCity.BackColor   = System.Drawing.Color.FromArgb(55, 55, 75);
            this.txtCity.ForeColor   = System.Drawing.Color.White;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.KeyDown    += new System.Windows.Forms.KeyEventHandler(this.txtCity_KeyDown);

            this.btnSearch.Location  = new System.Drawing.Point(320, 13);
            this.btnSearch.Size      = new System.Drawing.Size(120, 30);
            this.btnSearch.Text      = "Rechercher";
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Click    += new System.EventHandler(this.btnSearch_Click);

            this.pnlSearch.Controls.Add(this.txtCity);
            this.pnlSearch.Controls.Add(this.btnSearch);

            // Panel Météo
            this.pnlWeather.BackColor = System.Drawing.Color.FromArgb(35, 35, 55);
            this.pnlWeather.Location  = new System.Drawing.Point(0, 60);
            this.pnlWeather.Size      = new System.Drawing.Size(570, 460);
            this.pnlWeather.Padding   = new System.Windows.Forms.Padding(20);

            this.pbWeatherIcon.Location  = new System.Drawing.Point(20, 20);
            this.pbWeatherIcon.Size      = new System.Drawing.Size(80, 80);
            this.pbWeatherIcon.SizeMode  = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWeatherIcon.BackColor = System.Drawing.Color.Transparent;

            this.lblCityName.Location  = new System.Drawing.Point(115, 25);
            this.lblCityName.Size      = new System.Drawing.Size(420, 35);
            this.lblCityName.Font      = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCityName.ForeColor = System.Drawing.Color.White;

            this.lblDescription.Location = new System.Drawing.Point(115, 62);
            this.lblDescription.Size     = new System.Drawing.Size(420, 22);
            this.lblDescription.Font     = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblDescription.ForeColor= System.Drawing.Color.LightSkyBlue;

            int yStart = 120;
            int yStep  = 45;

            this.lblTemperature.Location = new System.Drawing.Point(20, yStart);
            this.lblTemperature.Size     = new System.Drawing.Size(500, 35);
            this.lblTemperature.Font     = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTemperature.ForeColor= System.Drawing.Color.Gold;

            this.lblFeelsLike.Location   = new System.Drawing.Point(20, yStart + yStep + 10);
            this.lblFeelsLike.Size       = new System.Drawing.Size(500, 25);
            this.lblFeelsLike.Font       = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFeelsLike.ForeColor  = System.Drawing.Color.LightGray;

            this.lblHumidity.Location    = new System.Drawing.Point(20, yStart + (yStep * 2) + 10);
            this.lblHumidity.Size        = new System.Drawing.Size(500, 25);
            this.lblHumidity.Font        = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHumidity.ForeColor   = System.Drawing.Color.LightBlue;

            this.lblWindSpeed.Location   = new System.Drawing.Point(20, yStart + (yStep * 3) + 10);
            this.lblWindSpeed.Size       = new System.Drawing.Size(500, 25);
            this.lblWindSpeed.Font       = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWindSpeed.ForeColor  = System.Drawing.Color.LightGreen;

            this.lblClouds.Location      = new System.Drawing.Point(20, yStart + (yStep * 4) + 10);
            this.lblClouds.Size          = new System.Drawing.Size(500, 25);
            this.lblClouds.Font          = new System.Drawing.Font("Segoe UI", 10F);
            this.lblClouds.ForeColor     = System.Drawing.Color.Plum;

            this.pnlWeather.Controls.Add(this.pbWeatherIcon);
            this.pnlWeather.Controls.Add(this.lblCityName);
            this.pnlWeather.Controls.Add(this.lblDescription);
            this.pnlWeather.Controls.Add(this.lblTemperature);
            this.pnlWeather.Controls.Add(this.lblFeelsLike);
            this.pnlWeather.Controls.Add(this.lblHumidity);
            this.pnlWeather.Controls.Add(this.lblWindSpeed);
            this.pnlWeather.Controls.Add(this.lblClouds);

            // Panel Favoris
            this.pnlFavorites.BackColor = System.Drawing.Color.FromArgb(25, 25, 40);
            this.pnlFavorites.Location  = new System.Drawing.Point(570, 60);
            this.pnlFavorites.Size      = new System.Drawing.Size(330, 460);
            this.pnlFavorites.Padding   = new System.Windows.Forms.Padding(10);

            this.lblFavTitle.Location   = new System.Drawing.Point(10, 10);
            this.lblFavTitle.Size       = new System.Drawing.Size(310, 25);
            this.lblFavTitle.Text       = "Villes favorites";
            this.lblFavTitle.Font       = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFavTitle.ForeColor  = System.Drawing.Color.White;

            this.lstFavorites.Location  = new System.Drawing.Point(10, 42);
            this.lstFavorites.Size      = new System.Drawing.Size(310, 310);
            this.lstFavorites.BackColor = System.Drawing.Color.FromArgb(40, 40, 60);
            this.lstFavorites.ForeColor = System.Drawing.Color.White;
            this.lstFavorites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFavorites.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lstFavorites.DoubleClick += new System.EventHandler(this.lstFavorites_DoubleClick);

            this.btnAddFavorite.Location  = new System.Drawing.Point(10, 365);
            this.btnAddFavorite.Size      = new System.Drawing.Size(310, 35);
            this.btnAddFavorite.Text      = "+ Ajouter aux favoris";
            this.btnAddFavorite.BackColor = System.Drawing.Color.FromArgb(60, 160, 80);
            this.btnAddFavorite.ForeColor = System.Drawing.Color.White;
            this.btnAddFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFavorite.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnAddFavorite.Click    += new System.EventHandler(this.btnAddFavorite_Click);

            this.btnRemoveFavorite.Location  = new System.Drawing.Point(10, 410);
            this.btnRemoveFavorite.Size      = new System.Drawing.Size(310, 35);
            this.btnRemoveFavorite.Text      = "− Supprimer le favori";
            this.btnRemoveFavorite.BackColor = System.Drawing.Color.FromArgb(180, 60, 60);
            this.btnRemoveFavorite.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFavorite.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveFavorite.Click    += new System.EventHandler(this.btnRemoveFavorite_Click);

            this.pnlFavorites.Controls.Add(this.lblFavTitle);
            this.pnlFavorites.Controls.Add(this.lstFavorites);
            this.pnlFavorites.Controls.Add(this.btnAddFavorite);
            this.pnlFavorites.Controls.Add(this.btnRemoveFavorite);

            // Barre de statut
            this.lblStatus.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Height    = 28;
            this.lblStatus.Padding   = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(20, 20, 35);
            this.lblStatus.ForeColor = System.Drawing.Color.LightGray;
            this.lblStatus.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblStatus.Text      = "Prêt.";

            // Ajout au Form
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlWeather);
            this.Controls.Add(this.pnlFavorites);
            this.Controls.Add(this.lblStatus);

            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherIcon)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // Déclarations des contrôles
        private System.Windows.Forms.Panel       pnlSearch;
        private System.Windows.Forms.TextBox     txtCity;
        private System.Windows.Forms.Button      btnSearch;

        private System.Windows.Forms.Panel       pnlWeather;
        private System.Windows.Forms.PictureBox  pbWeatherIcon;
        private System.Windows.Forms.Label       lblCityName;
        private System.Windows.Forms.Label       lblDescription;
        private System.Windows.Forms.Label       lblTemperature;
        private System.Windows.Forms.Label       lblFeelsLike;
        private System.Windows.Forms.Label       lblHumidity;
        private System.Windows.Forms.Label       lblWindSpeed;
        private System.Windows.Forms.Label       lblClouds;

        private System.Windows.Forms.Panel       pnlFavorites;
        private System.Windows.Forms.Label       lblFavTitle;
        private System.Windows.Forms.ListBox     lstFavorites;
        private System.Windows.Forms.Button      btnAddFavorite;
        private System.Windows.Forms.Button      btnRemoveFavorite;

        private System.Windows.Forms.Label       lblStatus;
    }
}
