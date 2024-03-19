using cat_search.Extensions;
using cat_search.Model;
using cat_search.Services;
using System.Net;

namespace cat_search.Forms
{
    public partial class Favorites : Form
    {
        private readonly ApiService apiService;
        private readonly List<Favourite> favorites;

        public Favorites()
        {
            InitializeComponent();

            apiService = new ApiService();

            try
            {
                favorites = apiService.GetFavorites();

                var favoritesNames = favorites.Select(f => f.Name).ToArray();

                lboxFavorites.Items.AddRange(favoritesNames);

                if (lboxFavorites.Items.Count == 0)
                    btnDeleteFavorite.Enabled = false;
            }
            catch (Exception ex)
            {
                ex.ShowApplicationErrorMessageBox();
            }
        }

        private void btnDeleteFavorite_Click(object sender, EventArgs e)
        {
            string? favoriteName = ValidateSelectedFavorite();

            if (string.IsNullOrEmpty(favoriteName))
                return;

            try
            {
                int favouriteId = favorites.Where(x => x.Name == favoriteName)
                        .Select(x => x.Id)
                        .FirstOrDefault();

                var response = apiService.DeleteFavorite(favouriteId);

                if (response.StatusCode == HttpStatusCode.OK)
                    lboxFavorites.Items.Remove(favoriteName);

                response.ShowMessageBox($"Breed {favoriteName} deleted from the favorites list successfully!");

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

        private string? ValidateSelectedFavorite()
        {
            if (lboxFavorites.SelectedItem is not string favouriteName)
            {
                MessageBox.Show("You must choose a breed to remove from the favorites list!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return null;
            }

            return favouriteName;
        }
    }
}
