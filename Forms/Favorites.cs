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

            favourites = apiService.GetFavourites();

            var favouritesNames = favourites.Select(f => f.Name).ToArray();

            lboxFavourites.Items.AddRange(favouritesNames);
        }

        private void btnDeleteFavourite_Click(object sender, EventArgs e)
        {
            var favouriteName = lboxFavourites.SelectedItem as string; //qual a diferença para toString?

            int favouriteId = favourites.Where(x => x.Name == favouriteName)
                .Select(x => x.Id)
                .FirstOrDefault();

            var response = apiService.DeleteFavourite(favouriteId);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                lboxFavourites.Items.Remove(favouriteName);

                MessageBox.Show($"Favorito da raça {favouriteName} excluída com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Erro ao excluir favorito!\n" +
                    $"Erro: {response.StatusDescription} -  {response.Content}",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
