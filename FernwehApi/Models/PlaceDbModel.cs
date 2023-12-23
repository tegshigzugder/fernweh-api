namespace FernwehApi.Models
{
	public class ListPlaces
	{
		public List<Place> Places { get; set; }
	}

	public class Place
	{
		public int PlaceId { get; set; }
		public string FormattedAddress { get; set; }
		public double Rating { get; set; }
		public int UserRatingCount { get; set; }
		public DisplayName DisplayName { get; set; }
	}

	public class DisplayName
	{
		public string DisplayNameId { get; set; }
		public string Text { get; set; }
		public string LanguageCode { get; set; }
	}
}
