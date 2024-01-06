using System.Collections.Generic;
using FernwehApi.Repositories;

namespace FernwehApi.Services
{
	public class PlacesService : IPlacesService
	{
		private readonly IPlacesRepository _placesRepository;
		private readonly IPlacesDbRepository _placesDbRepository;

		public PlacesService(IPlacesRepository placesRepository,
		IPlacesDbRepository placesDbRepository)
		{
			_placesRepository = placesRepository;
			_placesDbRepository = placesDbRepository;
		}

		public async void OnGetFindPlace()
		{
			var fieldsList = new List<string>{
			"formatted_address",
			"name",
			"rating",
			"opening_hours",
			"geometry"
			};

			var fields = string.Join(",", fieldsList);
			var input = Uri.EscapeDataString("Cafes In Leipzig");

			await _placesRepository.OnGetFindPlace(fields, input);
		}

		public async void OnGetSearchText()
		{
			var fieldsList = new List<string>{
				"places.rating",
				"places.userRatingCount",
				"places.formattedAddress",
				"places.displayName"
			};

			var fields = string.Join(",", fieldsList);
			var input = Uri.EscapeDataString("Cafes In Leipzig");

			var results = await _placesRepository.OnGetSearchText(fields, input);

			await _placesDbRepository.Save(results.Places);
		}
	}
}
