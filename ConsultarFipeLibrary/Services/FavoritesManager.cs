using ConsultarFipeLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace ConsultarFipeLibrary.Services
{
    public static class FavoritesManager
    {
        public static List<VehicleFavorite> Favorites = new List<VehicleFavorite>();
        private static readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Favoritos", "favorites.json");
        static FavoritesManager()
        {
            string directoryPath = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            LoadFavoritesFromFile();
        }
        public static List<VehicleFavorite> GetFavorites()
        {
            return Favorites;
        }

        public static void Add(VehicleFavorite vehicle)
        {
            bool exists = Favorites.Any(v => v.Marca == vehicle.Marca && v.Modelo == vehicle.Modelo && v.Ano == vehicle.Ano);

            if (!exists)
            {
                Favorites.Add(vehicle);
                SaveVehicleToFile();
            }
        }

        public static void SaveVehicleToFile()
        {
            string json = JsonSerializer.Serialize(Favorites, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        private static void LoadFavoritesFromFile()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                List<VehicleFavorite> loadedFavorites = JsonSerializer.Deserialize<List<VehicleFavorite>>(json);

                if (loadedFavorites != null)
                {
                    Favorites.AddRange(loadedFavorites);
                }
            }
        }
    }
}
