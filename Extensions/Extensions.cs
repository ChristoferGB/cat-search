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
                MessageBox.Show("Ação realizada com sucesso!\n" + 
                    message,
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Erro na execução da ação!\n" +
                    $"Erro: {response.StatusDescription} -  {response.Content}",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
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
