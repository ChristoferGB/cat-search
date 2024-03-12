namespace cat_search.Model
{
    public class Breed
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Reference_Image_Id { get; set; }

        public Breed(string id, string name, string reference_Image_Id)
        {
            Id = id;
            Name = name;
            Reference_Image_Id = reference_Image_Id;
        }
    }
}
