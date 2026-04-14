# MeteoApp

Application météo en WinForms qui utilise l'API OpenWeatherMap pour afficher la météo d'une ville.

## Fonctionnalités

- Recherche d'une ville et affichage de la météo (température, humidité, vent...)
- Système de favoris pour sauvegarder des villes

## Configuration

Il faut créer un fichier `MeteoApp/appsettings.json` en copiant `appsettings.example.json` et en mettant sa clé API OpenWeatherMap dedans :

```json
{
  "OpenWeatherMap": {
    "ApiKey": "votre_clé_ici"
  }
}
```

La clé est gratuite sur https://openweathermap.org/api

## Lancer le projet

Ouvrir `Projet1.sln` dans Visual Studio et appuyer sur F5.

> Le fichier appsettings.json n'est pas versionné pour ne pas exposer la clé API.
