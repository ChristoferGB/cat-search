using cat_search.Extensions;
using cat_search.Model;
using cat_search.Services;
using System.Net;

namespace cat_search.Forms
{
    public partial class Favorites : Form
    {
        private readonly ApiService apiService;
        private readonly List<Favourite> favourites;

        public Favorites()
        {
            InitializeComponent();

            apiService = new ApiService();

            try
            {
                favourites = apiService.GetFavourites();

                var favouritesNames = favourites.Select(f => f.Name).ToArray();

                lboxFavorites.Items.AddRange(favouritesNames);

                if (lboxFavorites.Items.Count == 0)
                    btnDeleteFavorite.Enabled = false;
            }
            catch (Exception ex)
            {
                ex.ShowApplicationErrorMessageBox();
            }
        }

        private void btnDeleteFavourite_Click(object sender, EventArgs e)
        {
            if (lboxFavorites.SelectedItem is not string favouriteName)
            {
                MessageBox.Show("You must choose a breed to remove from the favorites list!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                int favouriteId = favourites.Where(x => x.Name == favouriteName)
                        .Select(x => x.Id)
                        .FirstOrDefault();

                var response = apiService.DeleteFavourite(favouriteId);

                if (response.StatusCode == HttpStatusCode.OK)
                    lboxFavorites.Items.Remove(favouriteName);

                response.ShowMessageBox($"Breed {favouriteName} deleted from the favorites list successfully!");

                if (lboxFavorites.Items.Count == 0)
                    btnDeleteFavorite.Enabled = false;
            }
            catch (Exception ex)
            {
                ex.ShowApplicationErrorMessageBox();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();

            Search searchForm = new();

            searchForm.Closed += (s, args) => Close();

            searchForm.Show();
        }
    }
}
