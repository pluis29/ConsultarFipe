using System.Windows.Forms;

namespace ConsultarFipe
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
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
    }
}
