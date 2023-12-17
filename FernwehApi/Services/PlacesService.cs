namespace FernwehApi.Services
{
    public class PlacesService : IPlacesService
    {
        // place type
        // city
        private readonly IConfiguration _config;

        public PlacesService(IConfiguration config)
        {
            _config = config;
        }

        public async void OnGet()
        {
            var googleKey = _config["Google:PlacesApiKey"];

            var fieldsList = new List<string>
        {
            "formatted_address",
            "name",
            "rating",
            "opening_hours",
            "geometry"
        };
            var fields = string.Join(",", fieldsList);
            var input = "Cafes In Leipzig";
            var inputEscaped = Uri.EscapeDataString(input);
            var apiUrl = $"https://maps.googleapis.com/maps/api/place/findplacefromtext/json" +
                            $"?fields={fields}" +
                            $"&input={inputEscaped}" +
                            $"&inputtype=textquery" +
                            $"&key={googleKey}";

            var apiUrl2 = "https://maps.googleapis.com/maps/api/place/findplacefromtext/json?fields=formatted_address%2Cname%2Crating%2Copening_hours%2Cgeometry&input=Museum%20of%20Contemporary%20Art%20Australia&inputtype=textquery&key=" + googleKey;

            await NewMethod(apiUrl);
        }
    }
}
