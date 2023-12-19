using FernwehApi.Repositories;
using FernwehApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddSingleton<IPlacesService, PlacesService>();
builder.Services.AddSingleton<IPlacesRepository, PlacesRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();
IConfiguration configuration = new ConfigurationBuilder()
		.SetBasePath(Directory.GetCurrentDirectory())
		.AddJsonFile("connectionstrings.json")
	.Build();

// var result = configuration.GetConnectionString("Database");

// define DbContext

// builder.Services.AddDbContext<DbContext>(options =>
// {
// 	options.UseSqlServer(builder.Configuration.GetConnectionString("Database"));

// });



app.Run();
