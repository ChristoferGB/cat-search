using cat_search.Model;
using cat_search.Services;
using System.Data;
using System.Net;

namespace cat_search.Forms
{
    public partial class Search : Form
    {
        private readonly ApiService apiService;
        private readonly List<Breed> breeds;
        private Breed selectedBreed;

        public Search()
        {
            InitializeComponent();
            apiService = new ApiService();
            breeds = apiService.GetListOfBreeds();

            var names = breeds.Select(x => x.Name).ToArray();

            cbListBreeds.Items.AddRange(names);
        }

        private void cbListBreeds_SelectedValueChanged(object sender, EventArgs e)
        {
            string breedName = cbListBreeds.SelectedItem.ToString();

            selectedBreed = breeds.Where(x => x.Name == breedName).First();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var attributes = apiService.GetBreedAttributes(selectedBreed.Id);

            lbTemperament.Text = attributes.Temperament;
            lbOrigin.Text = attributes.Origin;
            lbDescription.Text = attributes.Description;
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            var response = apiService.PostFavoriteBreed(selectedBreed.Reference_Image_Id, selectedBreed.Id);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show($"Raça {selectedBreed.Name} favoritada com sucesso!", 
                    "Sucesso", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Erro ao favoritar raça!\n" +
                    $"Erro: {response.StatusDescription} -  {response.Content}",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
