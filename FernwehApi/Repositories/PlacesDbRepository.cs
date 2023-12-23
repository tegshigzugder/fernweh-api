using FernwehApi.Models;

namespace FernwehApi.Repositories
{

	public class PlacesDbRepository : IPlacesDbRepository
	{
		private readonly PlacesDbContext _dbContext;

		public PlacesDbRepository(PlacesDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task Save(List<Place> listPlaces)
		{
			await _dbContext.Places.AddRangeAsync(listPlaces);
			await _dbContext.SaveChangesAsync();
		}
	}
}
