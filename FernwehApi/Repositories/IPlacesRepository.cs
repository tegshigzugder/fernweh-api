namespace FernwehApi.Repositories;

public interface IPlacesRepository
{
	Task OnGetFindPlace(string fields, string input);
	Task OnGetSearchText(string fields, string input);
}
