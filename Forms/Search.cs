using cat_search.Extensions;
using cat_search.Model;
using cat_search.Services;
using System.Data;

namespace cat_search.Forms
{
    public partial class Search : Form
    {
        private readonly ApiService apiService;
        private readonly List<Breed> breeds;
        private Breed? selectedBreed;

        public Search()
        {
            InitializeComponent();

            apiService = new ApiService();

            try
            {
                breeds = apiService.GetListOfBreeds();

                var names = breeds.Select(x => x.Name).ToArray();

                cbListBreeds.Items.AddRange(names);

                if (cbListBreeds.SelectedItem == null)
                {
                    btnSearch.Enabled = false;
                    btnFavorite.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                ex.ShowApplicationErrorMessageBox();
            }
        }

        private void cbListBreeds_SelectedValueChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = true;
            btnFavorite.Enabled = true;

            string? breedName = cbListBreeds.SelectedItem.ToString();

            selectedBreed = breeds.Where(x => x.Name == breedName).First();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (selectedBreed == null)
            {
                MessageBox.Show("You must choose a breed before retrieving its informations!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                var attributes = apiService.GetBreedAttributes(selectedBreed.Id);

                lbTemperament.Text = attributes.Temperament;
                lbOrigin.Text = attributes.Origin;
                lbDescription.Text = attributes.Description;
            }
            catch (Exception ex)
            {
                ex.ShowApplicationErrorMessageBox();
            }
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            if (selectedBreed == null)
            {
                MessageBox.Show("You must choose a breed before favorite it!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                var response = apiService.PostFavoriteBreed(selectedBreed.Reference_Image_Id, selectedBreed.Id);

                response.ShowMessageBox($"Breed {selectedBreed.Name} favorited successfully!");
            }
            catch (Exception ex)
            {
                ex.ShowApplicationErrorMessageBox();
            }
        }

        private void btnMyFavorites_Click(object sender, EventArgs e)
        {
            Hide();

            Favorites favoritesForm = new();

            favoritesForm.Closed += (s, args) => Close();

            favoritesForm.Show();
        }
    }
}
