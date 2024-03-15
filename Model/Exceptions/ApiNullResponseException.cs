namespace cat_search.Model.Exceptions
{
    public class ApiNullResponseException : Exception
    {
        public ApiNullResponseException() 
            : base("The response returned by the API was null. Try again in a few moments.")
        {
        }
    }
}
