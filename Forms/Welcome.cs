using cat_search.Forms;

namespace cat_search
{
    public partial class FirstWindow : Form
    {
        public FirstWindow()
        {
            InitializeComponent();
        }

        private void searchBreedsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();

            Search searchForm = new();

            searchForm.Closed += (s, args) => Close();

            searchForm.Show();
        }

        private void myFavoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();

            Favorites favoritesForm = new();

            favoritesForm.Closed += (s, args) => Close();

            favoritesForm.Show();
        }
    }
}