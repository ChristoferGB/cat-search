namespace cat_search.Model.Requests
{
    public class FavouriteRequest
    {
        public string image_id { get; set; }
        public string sub_id { get; set; }

        public FavouriteRequest(string image_id, string sub_id)
        {
            this.image_id = image_id;
            this.sub_id = sub_id;
        }
    }
}
