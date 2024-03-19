namespace cat_search.Model
{
    public class Favorite
    {
        public int Id { get; set; }
        public string Image_id { get; set; }
        public string Sub_id { get; set; }
        public string? Name { get; set; }

        public Favorite(int id, string image_id, string sub_id)
        {
            Id = id;
            Image_id = image_id;
            Sub_id = sub_id;
        }

        public void SetName(string name) 
        { 
            Name = name; 
        }
    }
}
