namespace cat_search.Model
{
    public class BreedAttributes
    {
        public string Temperament { get; set; }
        public string Origin { get; set; }
        public string Description { get; set; }

        public BreedAttributes(string temperament, string origin, string description)
        {
            Temperament = temperament;
            Origin = origin;
            Description = description;
        }
    }
}
