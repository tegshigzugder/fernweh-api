using FernwehApi.Models;

namespace FernwehApi.Repositories;

public interface IPlacesDbRepository
{
	Task Save(List<Place> listPlaces);
}
