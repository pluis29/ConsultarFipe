using System.Windows.Forms;

namespace ConsultarFipe
{
    public partial class FrmFavorites : Form
    {
        public FrmFavorites()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
