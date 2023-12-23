using Microsoft.EntityFrameworkCore;

namespace FernwehApi.Models
{
	public class PlacesDbContext : DbContext
	{
		public DbSet<Place> Places { get; set; }

		public PlacesDbContext(DbContextOptions<PlacesDbContext> options) : base(options)
		{
		}
	}
}
