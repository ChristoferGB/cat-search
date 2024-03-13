using cat_search.Model;
using cat_search.Services;

namespace cat_search.Forms
{
    public partial class Favorites : Form
    {
        private readonly ApiService apiService;

        public Favorites()
        {
            InitializeComponent();

            apiService = new ApiService();

            List<Favourite> favourites = apiService.GetFavourites();

            var favouritesNames = favourites.Select(f => f.Name).ToArray();

            lboxFavourites.Items.AddRange(favouritesNames);
        }
    }
}
