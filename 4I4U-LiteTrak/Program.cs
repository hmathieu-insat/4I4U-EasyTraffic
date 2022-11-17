using _4I4U_LiteTrak;
using _4I4U_LiteTrak.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// Add the Db Context
var db = new FeuDbContext();
builder.Services
    .AddDbContext<FeuDbContext>()
    .AddTransient<DataSeeder>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.Run();
