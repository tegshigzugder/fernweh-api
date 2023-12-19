using FernwehApi.Repositories;

namespace FernwehApi.Services
{
	public class PlacesService : IPlacesService
	{
		// place type
		// city
		private readonly IPlacesRepository _placesRepository;

		public PlacesService(IPlacesRepository placesRepository)
		{
			_placesRepository = placesRepository;
		}

		public async void OnGet()
		{

			var fieldsList = new List<string>
		{
			"formatted_address",
			"name",
			"rating",
			"opening_hours",
			"geometry"
		};

			var fieldsList2 = new List<string>{
				"places.rating",
				"places.userRatingCount",
				"places.formattedAddress",
				"places.displayName"
			};

			var fields = string.Join(",", fieldsList);
			var fields2 = string.Join(",", fieldsList2);
			var input = Uri.EscapeDataString("Cafes In Leipzig");

			// await _placesRepository.OnGetFindPlace(fields, input);
			await _placesRepository.OnGetSearchText(fields2, input);
		}
	}
}
