using cat_search.Forms;

namespace cat_search
{
    public partial class FirstWindow : Form
    {
        public FirstWindow()
        {
            InitializeComponent();
        }

        private void buscarRaçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search searchForm = new();
            searchForm.ShowDialog();
        }

        private void meusFavoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Favorites favoritesForm = new();
            favoritesForm.ShowDialog();
        }
    }
}