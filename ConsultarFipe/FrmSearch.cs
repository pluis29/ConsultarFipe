using ConsultarFipeLibrary.Models;
using ConsultarFipeLibrary.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
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

        private string lastBrand = "";
        private string lastModel = "";
        private string lastYear = "";

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

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYear.SelectedItem is string yearName)
            {
                var selectedYear = years.FirstOrDefault(y => y.Nome == yearName);
                if (selectedYear != null)
                {
                    vehicle.Year = (selectedYear.Nome, selectedYear.Codigo);
                }
            }
        }



        private void FillTable(Value v)
        {
            lblTlpReferenceInfo.Text = v.MesReferencia;
            lblTlpFipeCodeInfo.Text = v.CodigoFipe;
            lblTlpBrandInfo.Text = v.Marca;
            lblTlpModelInfo.Text = v.Modelo;
            lblTlpGasInfo.Text = v.Combustivel;
            lblTlpYearInfo.Text = Convert.ToString(v.AnoModelo);
            lblTlpPriceInfo.Text = v.Valor;
        }

        private bool IsNewSearch()
        {
            string currentBrand = cmbBrand.SelectedItem.ToString();
            string currentModel = cmbModel.SelectedItem.ToString();
            string currentYear = cmbYear.SelectedItem.ToString();

            if (currentBrand == lastBrand && currentModel == lastModel && currentYear == lastYear)
            {
                return false;
            }
            lastBrand = currentBrand;
            lastModel = currentModel;
            lastYear = currentYear;
            return true;
        }

        private bool ValidateSearchForm()
        {
            if (cmbBrand.SelectedIndex == -1 || cmbModel.SelectedIndex == -1 || cmbYear.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void btnFavoritesList_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmFavorites frmFavorites = new FrmFavorites();
            frmFavorites.ShowDialog();
            this.Show();
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            if (IsTableFilled() && !IsVehicleInFavorites())
            {
                AddVehicleInList();
                btnFavorite.ForeColor = Color.Green;
                Task.Delay(1300).ContinueWith(_ =>
                {
                    btnFavorite.Invoke((Action)(() => btnFavorite.ForeColor = SystemColors.ControlText));
                });
                return;
            }
            else if (IsVehicleInFavorites())
            {
                btnFavorite.ForeColor = Color.Red;
                Task.Delay(1300).ContinueWith(_ =>
                {
                    btnFavorite.Invoke((Action)(() => btnFavorite.ForeColor = SystemColors.ControlText));
                });
                MessageBox.Show("Este veículo já foi adicionado aos favoritos.");
            }
        }

        private void AddVehicleInList()
        {
            VehicleFavorite vehicle = new VehicleFavorite
            {
                Marca = lblTlpBrandInfo.Text,
                Modelo = lblTlpModelInfo.Text,
                Ano = lblTlpYearInfo.Text,
                Combustivel = lblTlpGasInfo.Text,
                PrecoMedio = lblTlpPriceInfo.Text,
                CodigoFipe = lblTlpFipeCodeInfo.Text,
                MesReferencia = lblTlpReferenceInfo.Text
            };
            FavoritesManager.Add(vehicle);
        }

        private bool IsVehicleInFavorites()
        {
            return FavoritesManager.Favorites.Any(v =>
            v.Marca == lblTlpBrandInfo.Text &&
            v.Modelo == lblTlpModelInfo.Text &&
            v.Ano == lblTlpYearInfo.Text);
        }

        private bool IsTableFilled()
        {
            return !string.IsNullOrWhiteSpace(lblTlpReferenceInfo.Text) &&
                !string.IsNullOrWhiteSpace(lblTlpFipeCodeInfo.Text) &&
                !string.IsNullOrWhiteSpace(lblTlpBrandInfo.Text) &&
                !string.IsNullOrWhiteSpace(lblTlpModelInfo.Text) &&
                !string.IsNullOrWhiteSpace(lblTlpGasInfo.Text) &&
                !string.IsNullOrWhiteSpace(lblTlpYearInfo.Text) &&
                !string.IsNullOrWhiteSpace(lblTlpPriceInfo.Text);
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (ValidateSearchForm() && IsNewSearch())
            {
                var value = await fipeApi.GetValueAsync(vehicle.Type.Name, vehicle.Brand.Code, vehicle.Model.Code, vehicle.Year.Code);
                FillTable(value);
            }
        }
    }
}
