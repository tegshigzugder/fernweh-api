using FernwehApi.Models;

namespace FernwehApi.Repositories;

public interface IPlacesRepository
{
	Task OnGetFindPlace(string fields, string input);
	Task<ListPlaces> OnGetSearchText(string fields, string input);
}
