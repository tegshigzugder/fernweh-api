using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MySqlConnector;

namespace Controllers;
[ApiController]
[Route("[controller]")]
public class FakeController : ControllerBase
{
	private readonly ILogger<FakeController> _logger;
	public FakeController(ILogger<FakeController> logger)
	{
		_logger = logger;
	}

	[HttpGet(Name = "GetDB")]
	public void Get()
	{
		try
		{
			using (var connection = new MySqlConnection("connectionString"))
			{
				connection.Open();

				Console.WriteLine("=========================================\n");

				connection.Close();
			}
		}
		catch (SqlException e)
		{
			Console.WriteLine(e.ToString());
		}
	}
}
