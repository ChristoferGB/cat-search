namespace cat_search.Model
{
    public class Breed
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Breed(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
