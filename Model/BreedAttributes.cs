namespace cat_search.Model
{
    public class BreedAttributes : Breed
    {
        public string Temperament { get; set; }
        public string Origin { get; set; }
        public string Description { get; set; }

        public BreedAttributes(string temperament, string origin, string description, string id, string name, string reference_Image_Id) 
            : base(id, name, reference_Image_Id)
        {
            Temperament = temperament;
            Origin = origin;
            Description = description;
        }
    }
}
