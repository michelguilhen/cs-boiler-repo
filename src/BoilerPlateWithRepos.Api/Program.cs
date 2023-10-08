using BoilerPlateWithRepos.Api.Data;
using BoilerPlateWithRepos.Api.Data.Repositories;
using BoilerPlateWithRepos.Api.Data.Repositories.Common;
using BoilerPlateWithRepos.Api.Data.Repositories.Interfaces;
using BoilerPlateWithRepos.Api.Endpoints;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// db
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// repos
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IGamesRepository, GamesRepository>();
builder.Services.AddScoped<IPublishersRepository, PublishersRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

GamesEndpoints.Map(app);

app.Run();