using System.Windows.Forms;

namespace ConsultarFipe
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            frmSearch frmSearch = new frmSearch();
            frmSearch.ShowDialog();
            this.Show();
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
