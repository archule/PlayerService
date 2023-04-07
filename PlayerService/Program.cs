using Microsoft.EntityFrameworkCore;
using PlayerService.Data;
using PlayerService.SyncDataServices.Http;
Console.WriteLine("ARARARARRAARR!@!@#");
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

Console.WriteLine("ZZDCZCZDCZDC");
builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("InMem"));

builder.Services.AddScoped<IPlayerRepo, PlayerRepo>();
builder.Services.AddHttpClient<IPlayerDataClient, HttpPlayerDataClient>();
Console.WriteLine("ERROREROROREE!@!@#");
//builder.Services.AddStackExchangeRedisCache(options => {
//    options.Configuration = ConfigurationBinder.GetConnectionString("Redis");
//    options.InstanceName = "RedisDemo_";
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

PrepDb.PrepPopulation(app);
app.Run();
