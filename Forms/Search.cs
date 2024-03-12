using cat_search.Model;
using cat_search.Services;
using System.Data;

namespace cat_search.Forms
{
    public partial class Search : Form
    {
        private readonly ApiService apiService;
        private readonly List<Breed> breeds;

        public Search()
        {
            InitializeComponent();
            apiService = new ApiService();
            breeds = apiService.GetListOfBreeds();

            var names = breeds.Select(x => x.Name).ToArray();

            cbListBreeds.Items.AddRange(names);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string breedName = cbListBreeds.SelectedItem.ToString();

            var breedId = breeds.Where(x => x.Name == breedName)
                .Select(y => y.Id)
                .First();

            var attributes = apiService.GetBreedAttributes(breedId);

            lbTemperament.Text = attributes.Temperament;
            lbOrigin.Text = attributes.Origin;
            lbDescription.Text = attributes.Description;
        }
    }
}
