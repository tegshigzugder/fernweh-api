using System.Text;

namespace FernwehApi.Repositories
{
	public class PlacesRepository : IPlacesRepository
	{
		private readonly IConfiguration _config;
		private readonly string _googleKey;
		private readonly string _places_old = "https://maps.googleapis.com/maps/api/place/findplacefromtext/";
		private readonly string _places_new = "https://places.googleapis.com/v1/places:searchText";

		public PlacesRepository(IConfiguration config)
		{
			_config = config;
			_googleKey = _config["Google:PlacesApiKey"];
		}

		public async Task OnGetFindPlace(string fields, string input)
		{
			var apiUrl = _places_old +
						$"json" +
						$"?fields={fields}" +
						$"&input={input}" +
						$"&inputtype=textquery" +
						$"&key={_googleKey}";

			using HttpClient client = new HttpClient();
			try
			{
				HttpResponseMessage response = await client.GetAsync(apiUrl);
				if (response.IsSuccessStatusCode)
				{
					string result = await response.Content.ReadAsStringAsync();
					Console.WriteLine(result);
					// returning single candidate but working
					WriteToFile(result);
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

		private static void WriteToFile(string result)
		{
			var dt = String.Format("{0:s}", DateTime.Now);
			var fileName = dt + ".json";
			// Exception: Could not find a part of the path '/Users/tegshig/Documents/beProjects/fernweh-api/FernwehApi/12/17/2023 14:45:08result.json'.
			File.WriteAllText(fileName, result);
		}

		public async Task OnGetSearchText(string fields, string input)
		{
			using var client = new HttpClient();
			string requestBody = @"{
                ""textQuery"": ""Cafes in Leipzig, Germany""
            }";
			// Set up headers using HttpRequestMessage
			var request = new HttpRequestMessage(HttpMethod.Post, _places_new);
			request.Headers.Add("X-Goog-Api-Key", _googleKey);
			request.Headers.Add("X-Goog-FieldMask", fields);
			request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");


			var response = await client.SendAsync(request);


			// Check if the request was successful (status code 200)
			if (response.IsSuccessStatusCode)
			{
				// Read and display the response content
				string result = await response.Content.ReadAsStringAsync();
				Console.WriteLine(result);
				WriteToFile(result);
			}
			else
			{
				// Display error message if the request was not successful
				Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
			}
		}
	}
}
