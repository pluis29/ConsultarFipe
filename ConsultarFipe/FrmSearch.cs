using ConsultarFipeLibrary.Models;
using ConsultarFipeLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ConsultarFipe
{
    public partial class frmSearch : Form
    {
        private readonly FipeApiService fipeApi;
        private readonly Vehicle vehicle;
        private List<Brand> brands;
        private List<Model> models;
        private List<Year> years;

        public frmSearch()
        {
            InitializeComponent();
            fipeApi = new FipeApiService();
            vehicle = new Vehicle();

            rdoCar.Click += Rdo_Click;
            rdoMotorcycle.Click += Rdo_Click;
            rdoTruck.Click += Rdo_Click;
            rdoCar.Tag = 0;
            rdoMotorcycle.Tag = 1;
            rdoTruck.Tag = 2;
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void lblLinkApi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lblLinkApi.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/deividfortuna/fipe");
        }

        private void btnFavorites_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            FrmFavorites frmFavorites = new FrmFavorites();
            frmFavorites.ShowDialog();
            this.Show();
        }

        private async void Rdo_Click(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked
                && !radioButton.Tag.Equals(vehicle.Type.Index))
            {
                SetVehicleType();
                ClearComboBoxes(cmbBrand, cmbModel, cmbYear);
                brands = await fipeApi.GetBrandsAsync(vehicle.Type.Name);
                PopulateComboBox(cmbBrand, brands, b => b.Nome);
            }
        }

        private void SetVehicleType()
        {
            vehicle.Type = rdoCar.Checked ? ("carros", 0) :
                    rdoMotorcycle.Checked ? ("motos", 1) :
                    rdoTruck.Checked ? ("caminhoes", 2) :
                    vehicle.Type;
        }

        private void PopulateComboBox<T>(ComboBox comboBox, IEnumerable<T> items, Func<T, string> selector)
        {
            foreach (var item in items)
            {
                comboBox.Items.Add(selector(item));
            }
        }
        private void ClearComboBoxes(params ComboBox[] comboBoxes)
        {
            foreach (var comboBox in comboBoxes)
            {
                comboBox.Text = string.Empty;
                comboBox.Items.Clear();
            }
        }

        private async void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBrand.SelectedItem is string brandName)
            {
                var selectedBrand = brands.FirstOrDefault(b => b.Nome == brandName);
                if (selectedBrand != null)
                {
                    vehicle.Brand = (selectedBrand.Nome, selectedBrand.Codigo);
                    ClearComboBoxes(cmbModel, cmbYear);
                    models = await fipeApi.GetModelsAsync(vehicle.Type.Name, vehicle.Brand.Code);
                    PopulateComboBox(cmbModel, models, m => m.Nome);
                }
            }
        }

        private async void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModel.SelectedItem is string modelName)
            {
                var selectedModel = models.FirstOrDefault(m => m.Nome == modelName);
                if (selectedModel != null)
                {
                    vehicle.Model = (selectedModel.Nome, Convert.ToString(selectedModel.Codigo));
                    ClearComboBoxes(cmbYear);
                    years = await fipeApi.GetYearsAsync(vehicle.Type.Name, vehicle.Brand.Code, vehicle.Model.Code);
                    PopulateComboBox(cmbYear, years, y => y.Nome);
                }
            }
        }
    }
}
