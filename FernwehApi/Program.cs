using FernwehApi.Models;
using FernwehApi.Repositories;
using FernwehApi.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("connectionstrings.json");
builder.Configuration.AddJsonFile("secrets.json");
builder.Services.AddDbContext<PlacesDbContext>(options =>
{
	var connectionString = builder.Configuration.GetConnectionString("Database");
	Console.WriteLine(connectionString);
	options.UseSqlServer(connectionString);
});

builder.Services.AddCors(options =>
{
	options.AddDefaultPolicy(
		builder =>
		{
			builder.AllowAnyOrigin()
								.AllowAnyHeader()
								.AllowAnyMethod();
		});
});

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddScoped<IPlacesService, PlacesService>();
builder.Services.AddScoped<IPlacesRepository, PlacesRepository>();
builder.Services.AddScoped<IPlacesDbRepository, PlacesDbRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.UseCors();

app.Run();
