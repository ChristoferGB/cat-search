namespace cat_search.Model.Responses
{
    public class FavouritesResponse
    {
        public int Id { get; set; }
        public string Image_id { get; set; }
        public string Sub_id { get; set; }

        public FavouritesResponse(int id, string image_id, string sub_id)
        {
            Id = id;
            Image_id = image_id;
            Sub_id = sub_id;
        }
    }
}
