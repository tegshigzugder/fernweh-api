

using FernwehApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
[assembly: CLSCompliant(true)]
namespace Controllers;
[ApiController]
[Route("[controller]")]
public class MockController : ControllerBase
{
	private readonly ILogger<MockController> _logger;
	public MockController(ILogger<MockController> logger)
	{
		_logger = logger;
	}

	[HttpGet(Name = "GetDb")]
	public ListPlaces GetDb()
	{
		var result = @"
{
  ""places"": [
    {
      ""formattedAddress"": ""Thomaskirchhof 11, 04109 Leipzig, Germany"",
      ""rating"": 4.2,
      ""userRatingCount"": 826,
      ""displayName"": {
        ""text"": ""Café Kandler"",
        ""languageCode"": ""de""
      }
    },
    {
      ""formattedAddress"": ""Reichsstraße 2, 04109 Leipzig, Germany"",
      ""rating"": 4.4,
      ""userRatingCount"": 1790,
      ""displayName"": {
        ""text"": ""Café Central"",
        ""languageCode"": ""de""
      }
    },
    {
      ""formattedAddress"": ""Karl-Liebknecht-Straße 62, 04275 Leipzig, Germany"",
      ""rating"": 4.4,
      ""userRatingCount"": 1653,
      ""displayName"": {
        ""text"": ""Café Maître and Pâtisserie"",
        ""languageCode"": ""en""
      }
    },
    {
      ""formattedAddress"": ""Bosestraße 4, 04109 Leipzig, Germany"",
      ""rating"": 4.2,
      ""userRatingCount"": 2230,
      ""displayName"": {
        ""text"": ""Café Luise"",
        ""languageCode"": ""de""
      }
    },
    {
      ""formattedAddress"": ""Richard-Wagner-Platz 1, 04109 Leipzig, Germany"",
      ""rating"": 3.7,
      ""userRatingCount"": 466,
      ""displayName"": {
        ""text"": ""Café Wagner"",
        ""languageCode"": ""de""
      }
    },
    {
      ""formattedAddress"": ""Burgstraße 1-5, 04109 Leipzig, Germany"",
      ""rating"": 4.5,
      ""userRatingCount"": 708,
      ""displayName"": {
        ""text"": ""Café Bigoti"",
        ""languageCode"": ""en""
      }
    },
    {
      ""formattedAddress"": ""Schuhmachergäßchen 1, 04109 Leipzig, Germany"",
      ""rating"": 4.1,
      ""userRatingCount"": 2416,
      ""displayName"": {
        ""text"": ""Kaffeehaus Riquet Café"",
        ""languageCode"": ""de""
      }
    },
    {
      ""formattedAddress"": ""Katharinenstraße 2, 04109 Leipzig, Germany"",
      ""rating"": 3.7,
      ""userRatingCount"": 823,
      ""displayName"": {
        ""text"": ""Stein Café"",
        ""languageCode"": ""de""
      }
    },
    {
      ""formattedAddress"": ""Karl-Liebknecht-Straße 74, 04275 Leipzig, Germany"",
      ""rating"": 4.3,
      ""userRatingCount"": 2161,
      ""displayName"": {
        ""text"": ""Café Puschkin"",
        ""languageCode"": ""en""
      }
    },
    {
      ""formattedAddress"": ""Nikolaistraße 3-5, 04109 Leipzig, Germany"",
      ""rating"": 4.3,
      ""userRatingCount"": 686,
      ""displayName"": {
        ""text"": ""Café Kandler"",
        ""languageCode"": ""de""
      }
    },
    {
      ""formattedAddress"": ""Café im Bach-Museum, Thomaskirchhof 15, 04109 Leipzig, Germany"",
      ""rating"": 4.1,
      ""userRatingCount"": 247,
      ""displayName"": {
        ""text"": ""Café Gloria - Kaffee, Kuchen, Frühstück und Bistro"",
        ""languageCode"": ""de""
      }
    },
    {
      ""formattedAddress"": ""Nikolaistraße 55, 04109 Leipzig, Germany"",
      ""rating"": 4.2,
      ""userRatingCount"": 883,
      ""displayName"": {
        ""text"": ""Coffee Fellows - Kaffee, Bagels, Frühstück"",
        ""languageCode"": ""de""
      }
    },
    {
      ""formattedAddress"": ""Petersstraße 12, 04109 Leipzig, Germany"",
      ""rating"": 4.4,
      ""userRatingCount"": 101,
      ""displayName"": {
        ""text"": ""Cafe im Hugendubel"",
        ""languageCode"": ""de""
      }
    },
    {
      ""formattedAddress"": ""Riemannstraße 44, 04107 Leipzig, Germany"",
      ""rating"": 4.6,
      ""userRatingCount"": 263,
      ""displayName"": {
        ""text"": ""Uptown Coffee Bar"",
        ""languageCode"": ""en""
      }
    },
    {
      ""formattedAddress"": ""August-Bebel-Straße 2, 04275 Leipzig, Germany"",
      ""rating"": 4.2,
      ""userRatingCount"": 1180,
      ""displayName"": {
        ""text"": ""Café Grundmann"",
        ""languageCode"": ""en""
      }
    },
    {
      ""formattedAddress"": ""Universitätsstraße 14, 04109 Leipzig, Germany"",
      ""rating"": 4.3,
      ""userRatingCount"": 127,
      ""displayName"": {
        ""text"": ""XOXO Café & Bar"",
        ""languageCode"": ""de""
      }
    },
    {
      ""formattedAddress"": ""Rudolph-Sack-Straße 2, 04229 Leipzig, Germany"",
      ""rating"": 4.4,
      ""userRatingCount"": 548,
      ""displayName"": {
        ""text"": ""Café Kater"",
        ""languageCode"": ""en""
      }
    },
    {
      ""formattedAddress"": ""Brüderstraße 6, 04103 Leipzig, Germany"",
      ""rating"": 4.6,
      ""userRatingCount"": 447,
      ""displayName"": {
        ""text"": ""Café Corso"",
        ""languageCode"": ""de""
      }
    },
    {
      ""formattedAddress"": ""Thomasgasse 2, 04109 Leipzig, Germany"",
      ""rating"": 4,
      ""userRatingCount"": 1106,
      ""displayName"": {
        ""text"": ""Pascucci Restaurant & Café"",
        ""languageCode"": ""de""
      }
    },
    {
      ""formattedAddress"": ""Fichtestraße 15, 04275 Leipzig, Germany"",
      ""rating"": 4.6,
      ""userRatingCount"": 403,
      ""displayName"": {
        ""text"": ""Mein Liebes Frollein"",
        ""languageCode"": ""en""
      }
    }
  ]
}";

		var listPlaces = JsonConvert.DeserializeObject<ListPlaces>(result);
		return listPlaces;

	}

}
