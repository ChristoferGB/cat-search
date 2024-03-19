using RestSharp;
using System.Net;

namespace cat_search.Extensions
{
    public static class Extensions
    {
        public static void ShowMessageBox(this RestResponse response, string? message = null)
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Task completed successfully!\n" + 
                    message,
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Error on task execution!\n" +
                    $"Error: {response.StatusDescription} -  {response.Content}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void ShowApplicationErrorMessageBox(this Exception exception)
        {
            MessageBox.Show("Application error:" +
                    $"{exception.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
    }
}
