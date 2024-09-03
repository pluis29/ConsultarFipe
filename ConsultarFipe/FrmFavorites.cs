using ConsultarFipeLibrary.Models;
using ConsultarFipeLibrary.Services;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConsultarFipe
{
    public partial class FrmFavorites : Form
    {

        public FrmFavorites()
        {
            InitializeComponent();
            ConfigureListView();
            PopulateListView();
        }

        private void PopulateListView()
        {
            List<VehicleFavorite> favorites = FavoritesManager.GetFavorites();

            lvwFavorites.Items.Clear();

            foreach (var vehicle in favorites)
            {
                var item = new ListViewItem(vehicle.Marca);
                item.SubItems.Add(vehicle.Modelo);
                item.SubItems.Add(vehicle.Ano);
                item.SubItems.Add(vehicle.Combustivel);
                item.SubItems.Add(vehicle.PrecoMedio);
                item.SubItems.Add(vehicle.CodigoFipe);
                item.SubItems.Add(vehicle.MesReferencia);
                lvwFavorites.Items.Add(item);
            }
        }

        private void ConfigureListView()
        {
            lvwFavorites.Columns.Add("Marca", -2, HorizontalAlignment.Left);
            lvwFavorites.Columns.Add("Modelo", -2, HorizontalAlignment.Left);
            lvwFavorites.Columns.Add("Ano", -2, HorizontalAlignment.Left);
            lvwFavorites.Columns.Add("Combustível", -2, HorizontalAlignment.Left);
            lvwFavorites.Columns.Add("Preço Médio", -2, HorizontalAlignment.Left);
            lvwFavorites.Columns.Add("Código Fipe", -2, HorizontalAlignment.Left);
            lvwFavorites.Columns.Add("Mês de Referência", -2, HorizontalAlignment.Left);
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveFavorite_Click(object sender, System.EventArgs e)
        {
            if (lvwFavorites.SelectedItems.Count > 0)
            {
                List<int> indicesToRemove = new List<int>();
                foreach (ListViewItem selectedItem in lvwFavorites.SelectedItems)
                {
                    indicesToRemove.Add(selectedItem.Index);
                }
                indicesToRemove.Sort((a, b) => b.CompareTo(a));
                foreach (int index in indicesToRemove)
                {
                    RemoveFavoriteByIndex(index);
                }
                foreach (ListViewItem item in lvwFavorites.SelectedItems)
                {
                    lvwFavorites.Items.Remove(item);
                }
                FavoritesManager.SaveVehicleToFile();
            }
        }
        private void RemoveFavoriteByIndex(int index)
        {
            if (index >= 0 && index < FavoritesManager.Favorites.Count)
            {
                FavoritesManager.Favorites.RemoveAt(index);
            }
        }
    }
}
