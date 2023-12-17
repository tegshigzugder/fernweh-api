namespace FernwehApi.Repositories
{
    public class PlacesRepository : IPlacesRepository
    {
        public async void OnGet(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(result);
                        // returning single candidate but working
                        var dt = String.Format("{0:s}", DateTime.Now);
                        var fileName = dt + "result.json";
                        // Exception: Could not find a part of the path '/Users/tegshig/Documents/beProjects/fernweh-api/FernwehApi/12/17/2023 14:45:08result.json'.
                        File.WriteAllText(fileName, result);
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }
        }

    }
}
